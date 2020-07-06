using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework8.Model;

namespace Homework8
{
    public partial class frmTaxi : Form
    {
        Database database;


        public frmTaxi()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaxi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddTaxi frmAddTaxi = new frmAddTaxi();
            frmAddTaxi.ShowDialog();
            if (frmAddTaxi.DialogResult == DialogResult.OK)
            {
                database.Add(frmAddTaxi.Taxi);
            }

        }
    }
}
