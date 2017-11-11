using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace ToDoList
{
    public class tdList
    {
        public bool Status { get; set; }
        public string Description { get; set; }
    }

    public class Data
    {
        private static string path = @"list.txt";
        public List<tdList> GetList => list;

        private static List<tdList> list = new List<tdList>(); // Объявление списка

        public void Add(string text) // Добавляем объект в список 
        {
            list.Add(new tdList() { Status = true, Description = text });
        }
        public void Save() // сохранение данных
        {
            string text = string.Empty;
            foreach (var i in list)
            {
               text += $"{i.Status}|{i.Description}" +"\r\n";
            }
            File.WriteAllText(path,text);
        }
        public static void Open() // Создание файла данных и загрузка данных в список List
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] Lines = line.Split(new char[] { '|' });

                    list.Add(new tdList()
                    {
                        Status = bool.Parse(Lines[0]),
                        Description = Lines[1]
                    });
                }
            } else File.Create(path); 
        }
    }
}
