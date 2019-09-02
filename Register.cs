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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        /////////////////////// Custom Methods ///////////////////////
        private void HoverEffect(Button btn,Color clr)
        {
            Color color = clr;
            btn.BackColor = color;
        }

        private void FocusOn(KeyPressEventArgs userInput , TextBox nextTxt)
        {
            if (userInput.KeyChar.Equals((char)Keys.Enter))
            {
                nextTxt.Focus();
            }
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            rtxtAddress.Text = "";
            txtOccupation.Text = "";
            txtNid.Text = "";
        }

        private bool CheckDateTime(DateTimePicker dtp)
        {
            DateTime userDob = dtp.Value;
            DateTime dt = DateTime.Now;
            TimeSpan diffResult = dt - userDob;

            if (userDob >= dt)
            {
                return false;
            }
            else if(diffResult.Days <= 800)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool InputCheck()
        {
            if(txtName.Text == "")
            {
                lblSyntexError.Text = "Name Must be Filled";
                lblSyntexError.Visible = true;
                return false;
            }
            else if(txtContact.Text == "")
            {
                lblSyntexError.Text = "Contact Must be Filled";
                lblSyntexError.Visible = true;
                return false;
            }
            else if (txtNid.Text == "")
            {
                lblSyntexError.Text = "NID Must be Filled";
                lblSyntexError.Visible = true;
                return false;
            }
            else if (cbGender.SelectedItem == null)
            {
                lblSyntexError.Text = "Gender Must be Selected";
                lblSyntexError.Visible = true;
                return false;
            }
            else if(!CheckDateTime(dtpDob))
            {
                lblSyntexError.Text = "Incorrect Date of Birth (DOB)";
                lblSyntexError.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        ///////////////////////// Custom Methods Ends /////////////////

        /////////////////////// Action Event /////////////////////

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != "")
            {
                if(txtPassword.Text.Length >= 8)
                {
                    lblUserError.Visible = false;
                }
            }
            else if(txtPassword.Text == "")
            {
                lblUserError.Visible = true;
            }
        }

        private void BtnConfirm_MouseHover(object sender, EventArgs e)
        {
            Color clr = Color.ForestGreen;
            HoverEffect(btnConfirm,clr);
        }

        private void BtnConfirm_MouseLeave(object sender, EventArgs e)
        {
            Color color = Color.LightGreen;
            btnConfirm.BackColor = color;
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Color clr = Color.Red;
            HoverEffect(btnCancel, clr);
        }

        private void BtnCancel_MouseLeave(object sender, EventArgs e)
        {
            _ = new Color();
            Color clr = Color.FromArgb(255, 128, 128);
            btnCancel.BackColor = clr;
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            if(txtContact.Text != "")
            {
                txtId.Text = txtContact.Text;
            }
            else if(txtContact.Text == "")
            {
                txtId.Text = "";
            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(InputCheck())
            {
                MessageBox.Show("Successfully Registered", "Success");
                ClearFields();
            }
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            FocusOn(e, txtPassword);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            FocusOn(e, txtName);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            FocusOn(e, txtContact);
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            FocusOn(e, txtNid);
        }
    }
}
