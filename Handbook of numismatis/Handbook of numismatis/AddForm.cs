using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handbook_of_numismatis
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet.Tables[4].NewRow();
                int rc = main.Comment.RowCount + 1;
                nRow[0] = rc;
                nRow[0] = tbName.Text;
                nRow[1] = tbComment.Text;
                main.databaseDataSet.Tables[4].Rows.Add(nRow);
                main.commentTableAdapter.Update(main.databaseDataSet.Comment);
                main.databaseDataSet.Tables[4].AcceptChanges();
                main.Comment.Refresh();
                tbName.Text = "";
                tbComment.Text = "";

            }
        }
    }
}
