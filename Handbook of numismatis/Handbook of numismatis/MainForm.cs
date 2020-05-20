using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Handbook_of_numismatis
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
        }


   

 

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Comment". При необходимости она может быть перемещена или удалена.
            this.commentTableAdapter.Fill(this.databaseDataSet.Comment);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.infCollector". При необходимости она может быть перемещена или удалена.
            this.infCollectorTableAdapter.Fill(this.databaseDataSet.infCollector);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.myCollection". При необходимости она может быть перемещена или удалена.
            this.myCollectionTableAdapter.Fill(this.databaseDataSet.myCollection);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Сollector". При необходимости она может быть перемещена или удалена.
            this.сollectorTableAdapter.Fill(this.databaseDataSet.Сollector);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Allcoin". При необходимости она может быть перемещена или удалена.
            this.allcoinTableAdapter.Fill(this.databaseDataSet.Allcoin);

        }
  



        private void SaveButton_Click(object sender, EventArgs e)
        {
            commentTableAdapter.Update(databaseDataSet);
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Click(object sender, EventArgs e)
        {

            
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }
    }
}

