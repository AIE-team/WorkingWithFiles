using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkingWithFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogin.Visible = false;
        
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string surname, firstname, contact, user, pass, repass;
            surname = txtSurname.Text;
            firstname = txtName.Text;
            contact = txtCon.Text;
            user = txtUser.Text;
            pass = txtPass.Text;
            repass = txtRePass.Text;

            if (pass == repass)
            {
                Users person = new Users {Username= user, PassWord=pass, Name=firstname, LastName= surname, Contanct=contact };
                person.WriteContent();

                MessageBox.Show("Data entered");

                txtSurname.Text= null;
                txtName.Text = null;
                txtCon.Text = null;
                txtUser.Text = null;
                txtPass.Text = null;
                txtRePass.Text = null;

            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }


            
            
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtSurname.Text = null;
            txtName.Text = null;
            txtCon.Text = null;
            txtUser.Text = null;
            txtPass.Text = null;
            txtRePass.Text = null;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string pass, user;

            pass = txtPassword.Text;
            user = txtUserName.Text;

            String[] fileData = System.IO.File.ReadAllLines(@"C:\Users\Admin\Documents\AIE\SoftwareDevelopmentFundamentals\code\WorkingWithFiles\Users.txt");
            
            foreach (var data in fileData)
            {
                string fileUser = data.Substring(0, data.IndexOf('#'));

                string remaning = data.Remove(0, data.IndexOf('#')+1);

                string filePass = remaning.Substring(0, remaning.IndexOf('#'));


               // MessageBox.Show(fileUser +"    "+ filePass+"      "+ remaning);


                if (user == fileUser)
                {
                    if (pass == filePass)
                    {
                        MessageBox.Show("Login Successful");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
