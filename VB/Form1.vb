' Developer Express Code Central Example:
' How to bind the ImageComboBoxEdit to a datasource
' 
' This example demonstrates how the GridLookUpEdit can be customized to look like
' the ImageComboBoxEdit. This approach allows you to implement the data-bound
' ImageComboBox editor.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2200
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Private Function CreateTable() As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Value", GetType(Integer))
            tbl.Columns.Add("Description", GetType(String))
            tbl.Columns.Add("Image", GetType(Image))
            For i As Integer = 0 To imageList1.Images.Count - 1
                tbl.Rows.Add(New Object() {i, String.Format("Description{0}", i), imageList1.Images(i)})
            Next

            Return tbl
        End Function

        Public Sub New()
            InitializeComponent()
            gridLookUpEdit1.Properties.DataSource = CreateTable()
            gridLookUpEdit1.Properties.DisplayMember = "Description"
            gridLookUpEdit1.Properties.ValueMember = "Value"
            AddHandler gridLookUpEdit1.EditValueChanged, New EventHandler(AddressOf gridLookUpEdit1_EditValueChanged)
            SyncButtonImage()
        End Sub

        Private Function GetSelectedImage() As Image
            Dim row As DataRowView = TryCast(gridLookUpEdit1.Properties.GetRowByKeyValue(gridLookUpEdit1.EditValue), DataRowView)
            If row Is Nothing Then Return Nothing
            Return TryCast(row("Image"), Image)
        End Function

        Private Sub SetButtonImage(ByVal selectedImage As Image, ByVal buttonIndex As Integer)
            Dim button As EditorButton = gridLookUpEdit1.Properties.Buttons(buttonIndex)
            button.Visible = Not selectedImage Is Nothing
            button.Image = selectedImage
        End Sub

        Private Sub SyncButtonImage()
            SetButtonImage(GetSelectedImage(), 1)
        End Sub

        Private Sub gridLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            BeginInvoke(New Action(AddressOf SyncButtonImage))
        End Sub
    End Class
End Namespace
