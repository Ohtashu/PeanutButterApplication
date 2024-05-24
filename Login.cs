using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Dashboard dashBoard = new Dashboard();
           Login loginUser = new Login();
           string username = txtUsername.Text;
           string password= txtPassword.Text;

            if (username == "Admin" &&  password == "PeanutButter")
            {
                MessageBox.Show("Login Successfull");
                dashBoard.Show();
                loginUser.Close();
                

            }
            else
            {
                MessageBox.Show("Wrong Username/Password!."); 
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        [Category("Password")]
        public bool PasswordChar
        {
            get 
            { 
                return txtPassword.UseSystemPasswordChar; 
            }
            set
            {  
                txtPassword.UseSystemPasswordChar = value;
            }
        }
    }
}
