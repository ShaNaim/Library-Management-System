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


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            tblSortElement.Visible = true;
            if (cbSearchBy.SelectedIndex == 1)
            {
                tblSortAuthor.Visible = false;
                tblSortGener.Visible = true;
                tblSortReleasDate.Visible = true;
            }
            else if(cbSearchBy.SelectedIndex == 2)
            {
                tblSortGener.Visible = false;
                tblSortAuthor.Visible = true;
                tblSortReleasDate.Visible = true;
            }
        }

        /////////////////////////// Custom Methods Ends ///////////////////////////

        /////////////////////////// Action Event ///////////////////////////

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
