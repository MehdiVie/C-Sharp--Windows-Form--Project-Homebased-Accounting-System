﻿using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accountimg.App
{
    public partial class frmNewTransaction : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int currentId=0;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            //var res= db.CustomerRepository.GetCustomersByName(); ;
            dgvCustomers.DataSource = db.CustomerRepository.GetCustomersByName();
            if (currentId != 0)
            {
                var currentTransaction=db.AccountingRepository.GetById(currentId);
                txtAmount.Value= currentTransaction.Amount;
                txtDescription.Text = currentTransaction.Description;
                if (currentTransaction.TypeID==1)
                {
                    rbIncome.Checked = true;
                }
                else
                {
                    rbExpense
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            //var res= db.CustomerRepository.GetCustomersByName(); ;
            dgvCustomers.DataSource = db.CustomerRepository.GetCustomersByName(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            { 
                if (rbIncome.Checked || rbExpense.Checked)
                {
                Accounting.DataLayer.Accounting transaction = new Accounting.DataLayer.Accounting()
                {
                    Amount = int.Parse(txtAmount.Value.ToString()),
                    CustomerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                    TypeID = (rbExpense.Checked) ? 2 : 1,
                    DateTime= DateTime.Now,
                    Description=txtDescription.Text
                };
                db.AccountingRepository.Insert(transaction);
                db.Save();
                DialogResult = DialogResult.OK;
                }
                else
                {
                MessageBox.Show("Please Select Transaction Type!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
