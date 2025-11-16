using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Utils;

namespace RestaurantManager.Models
{
    public class TableType
    {
        private string typeID;
        private string typeName;

        public TableType(string typeID, string typeName)
        {
            this.typeID = typeID;
            this.typeName = typeName;
        }

        public string TypeID { get => typeID; set => typeID = value; }
        public string TypeName { get => typeName; set => typeName = value; }
    }


    public static class TableTypeList
    {
        public static List<TableType> TableTypes { get; set; } = new List<TableType>();


        public static List<TableType> InitDefaultTableType()
        {
            var defaultList = new List<TableType> { CreateDefaultTableType()};
            FileUtils.SaveToJson(Constant.TABLE_TYPE_DATA_FILE, defaultList);
            return defaultList;
        }

        public static TableType CreateDefaultTableType()
        {
            return new TableType(Constant.TABLE_TYPE_DEFAULT_ID, Constant.TABLE_TYPE_DEFAULT_NAME);
        }

        


        public static bool InitTableTypeListData()
        {
            try
            {
                if (!File.Exists(Constant.TABLE_TYPE_DATA_FILE))
                {
                    TableTypes = InitDefaultTableType();
                    return false;
                }
                TableTypes = FileUtils.LoadFromJson<List<TableType>>(Constant.TABLE_TYPE_DATA_FILE);
                if (TableTypes == null || TableTypes.Count ==0)
                {
                    return false;

                }
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show($"There an error loading Table Type list. \nA default list will be create.\n {e.Message}", "Error", MessageBoxButtons.OK);
                TableTypes = InitDefaultTableType();
                return false;
            }
        }

        public static TableType GetTableTypeByID(string id)
        {
            foreach (var type in TableTypes)
            {
                if (type.TypeID == id)
                {
                    return type;
                }
            }
            return null;
        }

        public static bool AddTableType(TableType tbType)
        {
            try
            {
                if (GetTableTypeByID(tbType.TypeID)!=null)
                {
                    MessageBox.Show($"Table Type ID {tbType.TypeID} already exists.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                TableTypes.Add(tbType);
                FileUtils.SaveToJson(Constant.TABLE_TYPE_DATA_FILE, TableTypes);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"There an error adding Table Type. \n {e.Message}", "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool DeleteTableType(TableType tbType)
        {
            try
            {
                TableTypes.Remove(tbType);
                FileUtils.SaveToJson(Constant.TABLE_TYPE_DATA_FILE, TableTypes);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"There an error removing Table Type. \n {e.Message}", "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool UpdateTableType(TableType tbType)
        {
            try
            {
                var existingType = GetTableTypeByID(tbType.TypeID);
                if (existingType == null)
                {
                    MessageBox.Show($"Table Type ID {tbType.TypeID} does not exist.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                existingType.TypeName = tbType.TypeName;
                FileUtils.SaveToJson(Constant.TABLE_TYPE_DATA_FILE, TableTypes);
                return true;


            }
            catch (Exception e)
            {
                MessageBox.Show($"There an error updating Table Type. \n {e.Message}", "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        

    }
}
