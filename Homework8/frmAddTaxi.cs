using Homework8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class frmAddTaxi : Form
    {
        public Taxi Taxi { get; private set; } = new Taxi();
        public frmAddTaxi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Taxi.Name = txtParkNew.Text;
            Taxi.Adress = txtAdressNew.Text;
            Taxi.Phone = txtPhoneNew.Text;
            Taxi.Email = txtMailNew.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
