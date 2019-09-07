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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        /////////////////////////// Custom Methods ///////////////////////////
        private void SearchnSort(int slectedIndex, bool dateSearch = false)
        {
            tblSortElement.Visible = true;
            if(dateSearch)
            {
                tblSortAuthor.Visible = true;
                tblSortGener.Visible = true;
                tblSortReleasDate.Visible = false;

            }
            else
            {
                if (txtSearch.Text != "")
                {
                    if (slectedIndex == 1)
                    {
                        // Search By Author

                        tblSortAuthor.Visible = false;
                        tblSortGener.Visible = true;
                        tblSortReleasDate.Visible = true;
                    }
                    else if (slectedIndex == 2)
                    {
                        // Search By Gener

                        tblSortAuthor.Visible = true;
                        tblSortGener.Visible = false;
                        tblSortReleasDate.Visible = true;
                    }
                    else if (slectedIndex == 0)
                    {
                        // Search By Title

                        tblSortAuthor.Visible = true;
                        tblSortGener.Visible = true;
                        tblSortReleasDate.Visible = false;
                    }
                    else if (slectedIndex == 3)
                    {
                        // Search By ISBN

                        tblSortAuthor.Visible = false;
                        tblSortGener.Visible = false;
                        tblSortReleasDate.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Search , Must Provide Some Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Search , Must Provide Some Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchByDate()
        {
            DateTime userDob = dtpSearch.Value;
            DateTime dt = DateTime.Now;
            int compairDate = DateTime.Compare(userDob.Date, dt.Date);

            if (compairDate >= 0)
            {
                if (compairDate > 0)
                {
                    MessageBox.Show("Incorrect Search Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tblSortElement.Visible = false;
            }
            else
            {
                if (ckbFixed.Checked)
                {
                    //Search By Date Selected
                    SearchnSort(0,true);
                }
                else
                {
                    //Search by Date Bettwen
                    SearchnSort(0,true);
                }
            }
        }
        /////////////////////////// Custom Methods Ends ///////////////////////////

        /////////////////////////// Action Event ///////////////////////////
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchBy.Text == "")
            {
                if (txtSearch.Text != "")
                {
                    SearchnSort(0);
                }
                else
                {
                    SearchByDate();
                }
            }
            else if (cbSearchBy.SelectedIndex == 4)
            {
                SearchByDate();
            }
            else
            {
                SearchnSort(cbSearchBy.SelectedIndex);
            }
        }
        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            FormsUtility.HoverEffect(btnSearch,FormsUtility.btnHovColor);
        }

        private void BtnSearch_MouseLeave(object sender, EventArgs e)
        {
            FormsUtility.HoverEffect(btnSearch, FormsUtility.btnExtColor);
        }

        private void BtnSort_MouseEnter(object sender, EventArgs e)
        {
            FormsUtility.HoverEffect(btnSort, FormsUtility.btnHovColor);
        }

        private void BtnSort_MouseLeave(object sender, EventArgs e)
        {
            FormsUtility.HoverEffect(btnSort, FormsUtility.btnExtColor);
        }
    }
}


//  191, 79, 48 || 62, 81, 148 || 
