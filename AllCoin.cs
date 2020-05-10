using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatist
{
    public partial class AllCoin : Form
    {
        public CoinList Clist;
        Info infobar;
        int currentid = -1;

        public AllCoin(CoinList cl)
        {
            Clist = cl;

            InitializeComponent();

            dataGridView1.DataSource = Clist;

            infobar = new Info(-1, cl, dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Info addbar = new Info(Clist, dataGridView1);

            addbar.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!infobar.IsDisposed && currentid == dataGridView1.CurrentRow.Index)
                return;
              
            infobar.Close();
            infobar = new Info(dataGridView1.CurrentRow.Index, Clist, dataGridView1);

            //infobar.Hide();
            
            infobar.Show();
            currentid = dataGridView1.CurrentRow.Index;
            infobar.NameBox = Clist[currentid].Name;
            infobar.YearBox = Clist[currentid].Year;
            infobar.CountryBox = Clist[currentid].Country;
            infobar.DescribeBox = Clist[currentid].Describe;
        }
    }
}
