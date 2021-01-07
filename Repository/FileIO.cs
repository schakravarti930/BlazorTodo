using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace BlazorTodo.Repository
{
    public class FileIO
    {
        public static string FilePath = $@"{Directory.GetCurrentDirectory()}\SavedTodo.json";
        public void SaveListToFile(List<TodoItem> list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(FilePath,json);  
        }
        public List<TodoItem> LoadListFromFile()
        {
            string content = File.ReadAllText(FilePath);
            if(string.IsNullOrEmpty(content))
            {
                return new List<TodoItem>();
            }
            return JsonConvert.DeserializeObject<List<TodoItem>>(content);
        }
    }
}
