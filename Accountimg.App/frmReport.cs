using Accounting.DataLayer;
using Accounting.DataLayer.Context;
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
    public partial class frmReport : Form
    {
        public int typeId = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.Text = (typeId == 1) ? "Incomes Report" : "Expenses Report";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                var result = db.AccountingRepository.Get(a => a.TypeID == typeId);
                string customerName = "";
                //dgvReport.AutoGenerateColumns = false;
                //dgvReport.DataSource = result;
                dgvReport.Rows.Clear();
                foreach (var row in result)
                {
                    customerName = db.CustomerRepository.GetCustomerNameById(row.CustomerID);
                    dgvReport.Rows.Add(row.ID, customerName, row.Amount, row.DateTime, row.Description);
                }
            }
            
        }

        private void btnRefreshTransaction_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int rowId = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("Are you sure to delete?", "Waning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) 
                    == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.Delete(rowId);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int currentId = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction frm = new frmNewTransaction();
                frm.currentId = currentId;
                frm.ShowDialog();
            }
        }
    }
}
