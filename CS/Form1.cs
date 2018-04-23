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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
             
        private DataTable CreateTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Value", typeof(int));
            tbl.Columns.Add("Description", typeof(string));
            tbl.Columns.Add("Image", typeof(Image));
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                tbl.Rows.Add(new object[]{i, String.Format("Description{0}", i), imageList1.Images[i]} );
            }
            return tbl;
        }
        

        public Form1()
        {
            InitializeComponent();
            gridLookUpEdit1.Properties.DataSource = CreateTable();
            gridLookUpEdit1.Properties.DisplayMember = "Description";
            gridLookUpEdit1.Properties.ValueMember = "Value";
            gridLookUpEdit1.EditValueChanged += new EventHandler(gridLookUpEdit1_EditValueChanged);
            SyncButtonImage();
        }

        Image GetSelectedImage()
        {
            DataRowView row = gridLookUpEdit1.Properties.GetRowByKeyValue(gridLookUpEdit1.EditValue) as DataRowView;
            if (row == null) return null;
            return row["Image"] as Image;
        }


        void SetButtonImage(Image selectedImage, int buttonIndex)
        {
            EditorButton button = gridLookUpEdit1.Properties.Buttons[buttonIndex];
            button.Visible = !(selectedImage == null);
            button.Image = selectedImage;
        }

        void SyncButtonImage()
        {
            SetButtonImage(GetSelectedImage(), 1);
        }

        void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            BeginInvoke(new Action(SyncButtonImage));
        }
    }
}