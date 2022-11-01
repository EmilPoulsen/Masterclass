using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Masterclass.Revit.Utilities
{
    public static class DialogUtils
    {
        public static string SelectFile()
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = "*.xlsx",
                Multiselect = false
            };
            var dialogRes = dialog.ShowDialog();
            if (dialogRes == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                return fileName;
            }
            else
            {
                return null;
            }
        }
    }
}
