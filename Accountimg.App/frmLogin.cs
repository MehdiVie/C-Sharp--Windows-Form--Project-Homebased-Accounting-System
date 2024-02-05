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
using ValidationComponents;


namespace Accountimg.App
{
    
    public partial class frmLogin : Form
    {
        public bool edit = false;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using(UnitOfWork db=new UnitOfWork())
                {
                    
                    if (edit)
                    {
                        
                        if (db.AuthRepository.Get(a => a.Username == txtUsername.Text && a.LoginID!=Form1.userId).Any())
                        {
                            MessageBox.Show("Username Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var login=db.AuthRepository.GetById(Form1.userId);
                            login.Username = txtUsername.Text;
                            login.Password = txtPassword.Text;
                            db.AuthRepository.Update(login);
                            db.Save();
                            Application.Restart();
                        }
                        
                    }
                    else
                    {
                        
                        if (db.AuthRepository.Get(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text).Any())
                        {
                            var auth = db.AuthRepository.Get(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text).First();
                            Form1.userId = auth.LoginID;
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Username or Password are false!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }  
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                this.Text = "Change Login Setting";
                btnLogin.Text = "Edit";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.AuthRepository.GetById(Form1.userId);
                    txtUsername.Text= login.Username;
                    txtPassword.Text= login.Password;
                }

            }
        }
    }
}
