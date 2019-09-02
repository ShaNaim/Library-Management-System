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
        public Login()
        {
            InitializeComponent();
        }

        /////////////////////// Custome Methoods ////////////////////////////

        private void HoverEffect(Button btn)
        {
            Color color = Color.DarkSlateGray;
            btn.BackColor = color;
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
            HoverEffect(btnLogin);
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            Color color = Color.Transparent;
            btnLogin.BackColor = color;
        }

        private void BtnResister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerPage = new Register();
            registerPage.Show();
            this.Hide();
        }
    }
}
