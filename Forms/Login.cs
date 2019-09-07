using ManageIT.LMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageIT.LMS.Forms
{
    public partial class Login : Form
    {
        int testPass = 12345;
        public Login()
        {
            InitializeComponent();
        }

        /////////////////////// Custome Methoods ////////////////////////////
        private void LoginTo()
        {
            if (txtUserName.Text == "Admin")
            {
                if (Int32.Parse(txtPassword.Text) == testPass)
                {
                    var adminLogin = new AdminMain();
                    adminLogin.Show();
                    this.Hide();
                }
            }
        }
        /////////////////////// Custome Methoods Ends ////////////////////////////

        /////////////////////// Action Events ////////////////////////////

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Home HomePage = new Home();
            HomePage.Show();
            this.Hide();
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            Color color = Color.DarkSlateGray;
            FormsUtility.HoverEffect(btnLogin, color);
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            Color color = Color.Transparent;
            FormsUtility.HoverEffect(btnLogin, color);
        }

        private void BtnResister_Click(object sender, EventArgs e)
        {
            Register registerPage = new Register();
            registerPage.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginTo();
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormsUtility.FocusOn(e, txtPassword);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)Keys.Enter))
            {
                LoginTo();
            }
        }
    }
}
