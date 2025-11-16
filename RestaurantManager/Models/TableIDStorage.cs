using RestaurantManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public static class TableIDStorage
    {
        private static string filePath = Constant.TABLE_NEXT_ID_FILE;

        public static int NextTableID { get; private set; } = 1;

        // Load from file
        public static void Load()
        {
            if (File.Exists(filePath))
            {
                NextTableID = FileUtils.LoadFromJson<int>(filePath);
            }
            else
            {
                NextTableID = 1;
                Save(); // create file
            }
        }

        // Save current value
        public static void Save()
        {
            FileUtils.SaveToJson(filePath, NextTableID);
        }

        // Get next ID and increment
        public static int GetNextID()
        {
            int id = NextTableID;
            NextTableID++;
            Save();
            return id;
        }


    }
}
