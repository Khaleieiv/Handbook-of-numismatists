using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatist
{
    public class CoinList : List<Coin>
    {
        TxtReader txt;

        public CoinList()
        {
            txt = new TxtReader(Environment.CurrentDirectory + @"\Data\AllCoin.txt");
            CreateCollFromFile();
        }

        public CoinList(string g)
        {
            txt = new TxtReader(g);
            CreateCollFromFile();
        }

        public void CreateNewElem(string n, string y, string c, string d)//создает новый элемент
        {
            n = n.Replace(System.Environment.NewLine, "");
            y = y.Replace(System.Environment.NewLine, "");
            c = c.Replace(System.Environment.NewLine, "");
            d = d.Replace(System.Environment.NewLine, "");

            AddInColl(n, y, c, d);
            string[] str = { n, y, c, d };
            txt.AddToFile(str);
        }

        public void CreateCollFromFile()//создает колелекцию из файла
        {
            Clear();

            string[] str = txt.CreateArr();
            if (str.Length % 4 != 0) { return; }
            for (int i = 0; i < str.Length; i += 4)
            {
                AddInColl(str[i], str[i + 1], str[i + 2], str[i + 3]);
            }
        }

        public void ChangeElem(int coinindex, string n, string y, string c, string d)//меняет элемент коллекции
        {
            n = n.Replace(System.Environment.NewLine, "");
            y = y.Replace(System.Environment.NewLine, "");
            c = c.Replace(System.Environment.NewLine, "");
            d = d.Replace(System.Environment.NewLine, "");

            if (Count <= coinindex) { return; }
            Coin current = this[coinindex];
            //if ((n != "" && n != null && y != "" && y != null && c != "" && c != null && d != "" && d != null))
            //{
            //if (n != "" && n != null)
            current.Name = n;
            //if (y != "" && y != null)
            current.Year = y;
            //if (c != "" && c != null)
            current.Country = c;
            //if (d != "" && d != null)
            current.Describe = d;

            txt.ChengeFile(CreateFileFromColl());
            //}

        }

        public void DeleteItem(int coinindex)// удаляет элемент из коллекции
        {
            RemoveAt(coinindex);
            txt.ChengeFile(CreateFileFromColl());
        }

        public void Print()
        {
            int n = 0;
            foreach (Coin x in this)
            {
                Console.WriteLine(n + ":\t " + x.Name + ", " + x.Year + ", " + x.Country + ", " + x.Describe);
                n++;
            }
        }

        private string[] CreateFileFromColl()//создает массив из коллекции
        {
            string[] str = new string[Count * 4];
            int n = 0;
            foreach (Coin x in this)
            {
                str[n] = x.Name;
                str[n + 1] = x.Year;
                str[n + 2] = x.Country;
                str[n + 3] = x.Describe;
                n += 4;
            }
            return str;
        }

        private void AddInColl(string n, string y, string c, string d)//заносить элемент в коллекцию
        {
            Add(new Coin(n, y, c, d));
        }
    }
}
