using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Numismatist
{
    public class TxtReader
    {
        private string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public TxtReader(string p)
        {
            this.path = p;
            CheckFile();
        }

        //Methods

        public void CheckFile()
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path.Remove(Path.LastIndexOf("\\")));
                File.Create(Path).Close();
            }
        }

        public string[] CreateArr()//читает файл
        {
            CheckFile();
            return File.ReadAllLines(Path);
        }

        public void ChengeFile(string[] str)// меняет текст файла
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
                File.Create(Path).Close();
            }
            using (StreamWriter file = new StreamWriter(Path))
            {
                foreach (string x in str)
                {
                    file.WriteLine(x);
                }
            }
        }

        public void AddToFile(string[] str)// добавляет в конец файла
        {
            CheckFile();
            using (StreamWriter file = new StreamWriter(Path, true))
            {
                foreach (string x in str)
                {
                    file.WriteLine(x);
                }
            }
        }

        public virtual void Print()
        {
            string[] str = CreateArr();
            foreach (string x in str)
                Console.WriteLine(x);
        }
    } 
}
