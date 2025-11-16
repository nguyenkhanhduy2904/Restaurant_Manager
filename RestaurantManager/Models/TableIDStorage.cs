using RestaurantManager.Utils;
using System;
using System.IO;

namespace RestaurantManager.Models
{
    public class IDStorageData
    {
        public int NextTableID { get; set; } = 1;
        public int NextOrderID { get; set; } = 1;
        // add more later if needed
    }

    public static class IDStorage
    {
        private static readonly string filePath = Constant.TABLE_NEXT_ID_FILE;
        private static IDStorageData data = new IDStorageData();

        public static void Load()
        {
            if (File.Exists(filePath))
            {
                data = FileUtils.LoadFromJson<IDStorageData>(filePath) ?? new IDStorageData();
            }
            else
            {
                data = new IDStorageData();
                Save();
            }
        }

        public static void Save()
        {
            FileUtils.SaveToJson(filePath, data);
        }

        public static int GetNextTableID()
        {
            int id = data.NextTableID++;
            Save();
            return id;
        }

        public static int GetNextOrderID()
        {
            int id = data.NextOrderID++;
            Save();
            return id;
        }
    }
}
