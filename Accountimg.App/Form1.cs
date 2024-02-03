using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountimg.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction frm = new frmNewTransaction();
            frm.ShowDialog();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.typeId = 2;
            frmReport.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.typeId = 1;
            frmReport.ShowDialog();
        }
    }
}
