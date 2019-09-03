using ManageIT.LMS.Default.Forms;
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
        private void SearchnSort(bool dateSearch = false)
        {
            tblSortElement.Visible = true;
            if(dateSearch)
            {
                tblSortReleasDate.Visible = false;
                tblSortAuthor.Visible = true;
                tblSortGener.Visible = true;
                
            }
            else
            {
                if (cbSearchBy.SelectedIndex == 1)
                {
                    // Search By Author
                    
                    tblSortAuthor.Visible = false;
                    tblSortGener.Visible = true;
                    tblSortReleasDate.Visible = true;
                }
                else if (cbSearchBy.SelectedIndex == 2)
                {
                    // Search By Gener

                    tblSortGener.Visible = false;
                    tblSortAuthor.Visible = true;
                    tblSortReleasDate.Visible = true;
                }
            }
        }
        /////////////////////////// Custom Methods Ends ///////////////////////////

        /////////////////////////// Action Event ///////////////////////////
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchBy.Text == "")
            {
                DateTime userDob = dtpSearch.Value;
                DateTime dt = DateTime.Now;
                int compairDate = DateTime.Compare(userDob.Date, dt.Date);

                if (compairDate >= 0)
                {
                    //Search By Title

                    if(compairDate > 0)
                    {
                        lblError.Text = "Incorrect Date";
                        lblError.Visible = true;
                    }
                    tblSortElement.Visible = false;
                }
                else
                {
                    if(ckbFixed.Checked)
                    {
                        //Search By Date Selected
                        SearchnSort(true);
                    }
                    else
                    {
                        //Search by Date Bettwen
                        SearchnSort(true);
                    }
                } 
            }
            else if(cbSearchBy.SelectedIndex == 0)
            {
                // Search By Title
            }
            else if(cbSearchBy.SelectedIndex == 3)
            {
                // Search by ISBN
            }
            else
            {
                SearchnSort();
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
