using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatist
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CoinList Clist1 = new CoinList(Environment.CurrentDirectory + @"\Data\AllCoin.txt");

            //CoinList AllCoin = new CoinList(Environment.CurrentDirectory + @"\Data\AllCoin.txt");
            //AllCoin.CreateCollFromFile();
            //CoinList MyCoin = new CoinList(Environment.CurrentDirectory + @"\Data\MyCoin.txt");
            //MyCoin.CreateCollFromFile();
            //СollectorList Collectors = new СollectorList(Environment.CurrentDirectory + @"\Data\AllCollectors.txt");
            //Collectors.CreateCollFromFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AllCoin(Clist1));
        }
    }
}
