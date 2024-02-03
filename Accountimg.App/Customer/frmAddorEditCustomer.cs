using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accountimg.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

             string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);

                   string path = Application.StartupPath + "/Images/";

                   if (!Directory.Exists(path))
                   {
                       Directory.CreateDirectory(path);
                   }
                   pcCustomer.Image.Save(path + imageName);

                Customers customer = new Customers() {
                    FullName = txtName.Text,
                    Address = txtAddress.Text,
                    Mobile = txtMobile.Text,
                    Email=txtEmail.Text,
                    CustomerImage=imageName
                };
                if (customerId == 0)
                {
                    db.CustomerRepository.InsertCustomer(customer);
                }
                else
                {
                    customer.CustomerID = customerId;
                    db.CustomerRepository.UpdateCustomer(customer);
                }
                
                db.Save();
                DialogResult = DialogResult.OK;
            }

        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "Edit Customer";
                btnSubmit.Text = "Edit Customer";
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                txtName.Text= customer.FullName;
                txtAddress.Text= customer.Address;
                txtMobile.Text=customer.Mobile;
                txtEmail.Text=customer.Email;
                if (customer.CustomerImage!= "default_photo.jpg")
                {
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
                else
                {
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/default_photo.jpg";
                }
                
                
            }

        }
    }
}
