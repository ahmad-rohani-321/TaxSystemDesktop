using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxSystem.UI
{
    internal static class Defaults
    {
        internal static void SucccessMessageBox()
        {
            MessageBox("عمیله تکمیل سوه");
        }
        internal static void ErrorMessageBox()
        {
            MessageBox("عمیله تکمیل سوه");
        }
        internal static void MessageBox(string message)
        {
            XtraMessageBox.Show(UserLookAndFeel.Default, message, "خبرتیا");
        }
        internal static DialogResult YesNoMessageBox(string message)
        {
            return XtraMessageBox.Show(UserLookAndFeel.Default, message, "خبرتیا", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
