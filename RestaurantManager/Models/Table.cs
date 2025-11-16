using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Utils;

namespace RestaurantManager.Models
{
    public class Table
    {
        private int tableID;
        private string tableName;
        private TableType tableType;
        private bool isOccupied;
        private string? currentOrderID;

        public Table(int tableID, string? tableName, TableType tableType, bool isOccupied, string? currentOrderID)
        {
            this.tableID = tableID;
            TableName = string.IsNullOrWhiteSpace(tableName)
                        ? tableID.ToString()  // <-- Default name assigned here
                        : tableName;
            this.tableType = tableType;
            this.isOccupied = isOccupied;
            this.currentOrderID = currentOrderID;
        }

        public int TableID { get => tableID; set => tableID = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public TableType TableType { get => tableType; set => tableType = value; }
        public bool IsOccupied { get => isOccupied; set => isOccupied = value; }
        public string? CurrentOrderID { get => currentOrderID; set => currentOrderID = value; }

    }

    public static class TableList
    {
        public static List<Table> Tables = new List<Table>();

       

        public static Table CreateNextTable(TableType? tableType)
        {
            int nextID = IDStorage.GetNextTableID();
            if (tableType == null)
            {
                return new Table(nextID, null, TableTypeList.TableTypes[0], false, null);
            }
           
            return new Table(nextID, null , tableType, false, null);
        }

        public static List<Table> InitDefaultTableList()
        {
            var defaultList = new List<Table> { CreateNextTable(null) };
            FileUtils.SaveToJson(Constant.TABLE_DATA_FILE, defaultList);
            return defaultList;
        }


        public static bool InitTableListData()
        {
            try
            {
                if (!File.Exists(Constant.TABLE_DATA_FILE))
                {
                    Tables = InitDefaultTableList();
                    return false;
                }
                Tables = FileUtils.LoadFromJson<List<Table>>(Constant.TABLE_DATA_FILE);
                if (Tables == null || Tables.Count == 0)
                {
                    Tables = InitDefaultTableList();
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"There an error loading Table list. \nA default list will be create.\n {e.Message}", "Error", MessageBoxButtons.OK);
                Tables = InitDefaultTableList();
                return false;
            }
        }

        public static Table GetTableByID(int id)
        {
            foreach (var table in Tables)
            {
                if (table.TableID == id)
                {
                    return table;
                }
            }
            return null;
        }


        public static bool AddTable(Table table)
        {
            try 
            {
               
                Tables.Add(table);
                FileUtils.SaveToJson(Constant.TABLE_DATA_FILE, Tables);
                return true;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error adding table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DeleteTable(Table table)
        {
            try 
            {
                Tables.Remove(table);
                FileUtils.SaveToJson(Constant.TABLE_DATA_FILE, Tables);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateTable(Table table)
        {
            try
            {
                var existingTable = GetTableByID(table.TableID);
                if (existingTable != null)
                {
                    existingTable.TableName = table.TableName;
                    existingTable.TableType = table.TableType;
                    existingTable.IsOccupied = table.IsOccupied;
                    existingTable.CurrentOrderID = table.CurrentOrderID;
                    FileUtils.SaveToJson(Constant.TABLE_DATA_FILE, Tables);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }




    }

}
