using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Customers;
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
            using(UnitOfWork db= new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    FullName = "Select Customer",
                    CustomerID = 0
                });
                list.AddRange(db.CustomerRepository.GetCustomersByName());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                
                List <Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();

                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a=> a.TypeID==typeId && a.CustomerID==customerId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == typeId));
                }

                DateTime? startDate;
                DateTime? endDate;

                if (txtFromDate.Text != "  .  .") 
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    result=result.Where(c=>c.DateTime>=startDate).ToList();
                }
                if (txtToDate.Text != "  .  .")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    result=result.Where(c => c.DateTime <= endDate).ToList();
                }

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
                if(frm.ShowDialog()==DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void btnPrintTransaction_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");

            foreach (DataGridViewRow item in dgvReport.Rows)
            {
                dtPrint.Rows.Add(
                        item.Cells[1].Value.ToString(),
                        item.Cells[2].Value.ToString(),
                        item.Cells[3].Value.ToString(),
                        item.Cells[4].Value.ToString()
                    ); 
            }

            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT",dtPrint);
            stiPrint.Show();
        }
    }
}
