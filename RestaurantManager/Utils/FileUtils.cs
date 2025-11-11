using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestaurantManager.Utils
{
    public static class FileUtils
    {
        public static bool isFileExist(string path)
        {
            return File.Exists(path);
        }
        public static void SaveToJson <T> (string path, T data)
        {
            //if (!isFileExist(path))
            //{
            //    File.Create(path).Close();
            //}
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public static T LoadFromJson<T>(string path)
        {
            // 1. File missing or empty → return default
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
            {
                return default(T);
            }

            try
            {
                // 2. Read the JSON content
                string json = File.ReadAllText(path);

                // 3. Attempt to deserialize
                T data = JsonSerializer.Deserialize<T>(json);

                // 4. If deserialization fails, return default
                if (data == null)
                    return default(T);

                return data;
            }
            catch (Exception ex)
            {
                // Optional: log or show error message
                MessageBox.Show($"Failed to load {path}: {ex.Message}. Maybe the file content was corrupted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }


    }
}
