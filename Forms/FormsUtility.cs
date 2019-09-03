using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManageIT.LMS.Default.Forms
{
    public static class FormsUtility
    {
        public static Color btnHovColor = Color.CornflowerBlue ;
        public static Color btnExtColor = Color.Transparent ;
        public static void HoverEffect(Button btn, Color clr)
        {
            Color color = clr;
            btn.BackColor = color;
        }

        public static void FocusOn(KeyPressEventArgs userInput, TextBox nextTxt)
        {
            if (userInput.KeyChar.Equals((char)Keys.Enter))
            {
                nextTxt.Focus();
            }
        }
    }
}
