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
    public partial class Info : Form
    {
        int currentid;
        CoinList Clist;
        DataGridView dgv;


        public Info(CoinList c, DataGridView dgv)
        {
            this.Clist = c;
            this.dgv = dgv;

            InitializeComponent();

            Namebox.ReadOnly = false;
            Yearbox.ReadOnly = false;
            Countrybox.ReadOnly = false;
            Describebox.ReadOnly = false;
            Editbutton.Text = "Add";
            Deletebutton.Visible = false;
            Editbutton.BackColor = Color.WhiteSmoke;
        }

        public Info(int currentid, CoinList c, DataGridView dgv)
        {
            this.currentid = currentid;
            this.Clist = c;
            this.dgv = dgv;

            InitializeComponent();
        }

        public string NameBox
        {
            get { return Namebox.Text; }
            set { Namebox.Text = value; }
        }
        public string YearBox
        {
            get { return Yearbox.Text; }
            set { Yearbox.Text = value; }
        }
        public string CountryBox
        {
            get { return Countrybox.Text; }
            set { Countrybox.Text = value; }
        }
        public string DescribeBox
        {
            get { return Describebox.Text; }
            set { Describebox.Text = value; }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            switch (Editbutton.Text)
            {
                case "Add":
                    Clist.CreateNewElem(Namebox.Text, Yearbox.Text, Countrybox.Text, Describebox.Text);
                    dgv.DataSource = null;
                    this.Close();
                    dgv.DataSource = Clist;

                    break;
                case "Save":
                    Clist.ChangeElem(currentid, Namebox.Text, Yearbox.Text, Countrybox.Text, Describebox.Text);

                    Namebox.ReadOnly = true;
                    Yearbox.ReadOnly = true;
                    Countrybox.ReadOnly = true;
                    Describebox.ReadOnly = true;
                    Editbutton.Text = "Edit";
                    Editbutton.BackColor = Color.WhiteSmoke;
                    dgv.Refresh();

                    break;
                default:
                    Namebox.ReadOnly = false;
                    Yearbox.ReadOnly = false;
                    Countrybox.ReadOnly = false;
                    Describebox.ReadOnly = false;
                    Editbutton.Text = "Save";
                    Editbutton.BackColor = Color.YellowGreen;

                    break;
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Coin?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                dgv.DataSource = null;
                Clist.DeleteItem(currentid);
                this.Close();              
                dgv.DataSource = Clist;
            }
        }
    }
}
