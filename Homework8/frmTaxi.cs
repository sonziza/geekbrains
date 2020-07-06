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
            database = new Database(UpdateInfo);
        }

        void UpdateInfo()
        {
            if (database.GetCurrent == null)
            {
                txtPark.Text = "";
                txtAdress.Text = "";
                txtPhone.Text = "";
                txtMail.Text = "";
                tsIndex.Text = database.Current.ToString();
            }
            else
            {
                tsIndex.Text = database.Current.ToString();
                txtPark.Text = database.GetCurrent.Name;
                txtAdress.Text = database.GetCurrent.Adress;
                txtPhone.Text = database.GetCurrent.Phone;
                txtMail.Text = database.GetCurrent.Email;
            }
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

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            database.Prev();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            database.Next();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            database.RemoveCurrent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database = new Database(UpdateInfo);
            UpdateInfo();
        }

        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.Count>0)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "XML files|*.xml|All files|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    database.Save(dialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Не создана база данных.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML files|*.xml|All files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Load(dialog.FileName);
            }

        }
    }
}
