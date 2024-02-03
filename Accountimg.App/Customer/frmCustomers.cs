using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using(UnitOfWork db= new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                
                dgCustomers.DataSource = db.CustomerRepository.GetAllRows();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.DataSource= db.CustomerRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null) 
            {
                string name = dgCustomers.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure to delete {name}?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.CustomerRepository.DeleteCusomer(customerId);
                        db.Save();
                    }
                    BindGrid();
                }

            }
            else
            {
                MessageBox.Show("Please Select a Row!");
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {

            frmAddOrEditCustomer frm = new frmAddOrEditCustomer();
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                BindGrid();
            }
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditCustomer frm = new frmAddOrEditCustomer();
                frm.customerId = customerId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
                
            }
        }
    }
}
