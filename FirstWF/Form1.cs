using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWF
{
    public partial class Form1 : Form
    {
        Udvoitel udvoitel;

        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            lblCurrent.Text = udvoitel.Current.ToString();
            lblFinish.Text = udvoitel.Finish.ToString();
            lblSteps.Text = udvoitel.Steps.ToString();
            lblCount.Text = udvoitel.Count.ToString();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (udvoitel == null) return;
            udvoitel.Plus();
            UpdateInfo();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            udvoitel.Multi();
            UpdateInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            udvoitel.Reset();
            UpdateInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            udvoitel.Back();
            UpdateInfo();
        }
    }
}
