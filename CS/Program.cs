// Developer Express Code Central Example:
// How to bind the ImageComboBoxEdit to a datasource
// 
// This example demonstrates how the GridLookUpEdit can be customized to look like
// the ImageComboBoxEdit. This approach allows you to implement the data-bound
// ImageComboBox editor.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2200

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}