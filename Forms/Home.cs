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
    public partial class Home : Form
    {
        public Home()
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
        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            
            Color color = Color.Transparent;
            btnClose.BackColor = color;
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            HoverEffect(this.btnClose);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            HoverEffect(this.btnClose);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login LoginPage = new Login();
            LoginPage.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
