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
    public partial class AdminMain : Form
    {
        public AdminMain() => InitializeComponent();

        /////////////////////// Custome Methoods ////////////////////////////
        private void LoadSearchPage()
        {
            SearchResult search = new SearchResult();
            search.TopLevel = false;
            search.AutoScroll = true;
            search.FormBorderStyle = FormBorderStyle.None;
            search.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(search);

            search.Show();
        }
        /////////////////////// Custome Methoods Ends ////////////////////////////

        /////////////////////// Action Events ////////////////////////////

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSearchPage();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
