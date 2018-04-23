' Developer Express Code Central Example:
' How to bind the ImageComboBoxEdit to a datasource
' 
' This example demonstrates how the GridLookUpEdit can be customized to look like
' the ImageComboBoxEdit. This approach allows you to implement the data-bound
' ImageComboBox editor.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2200


Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
			Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "undo_round_16.png")
			Me.imageList1.Images.SetKeyName(1, "zoom_in_16.png")
			Me.imageList1.Images.SetKeyName(2, "zoom_out_16.png")
			Me.imageList1.Images.SetKeyName(3, "delete_row_16.png")
			Me.imageList1.Images.SetKeyName(4, "disconnect_16.png")
			Me.imageList1.Images.SetKeyName(5, "document_close_16.png")
			' 
			' gridLookUpEdit1
			' 
			Me.gridLookUpEdit1.EditValue = "1"
			Me.gridLookUpEdit1.Location = New System.Drawing.Point(29, 12)
			Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
			Me.gridLookUpEdit1.Properties.AllowFocused = False
			Me.gridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
			Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.gridLookUpEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
			Me.gridLookUpEdit1.Properties.NullText = " "
			Me.gridLookUpEdit1.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1})
			Me.gridLookUpEdit1.Properties.ShowFooter = False
			Me.gridLookUpEdit1.Properties.View = Me.gridLookUpEdit1View
			Me.gridLookUpEdit1.Size = New System.Drawing.Size(202, 20)
			Me.gridLookUpEdit1.TabIndex = 0
			' 
			' gridLookUpEdit1View
			' 
			Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
			Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
			Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
			Me.gridLookUpEdit1View.OptionsBehavior.Editable = False
			Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridLookUpEdit1View.OptionsSelection.UseIndicatorForSelection = False
			Me.gridLookUpEdit1View.OptionsView.RowAutoHeight = True
			Me.gridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
			Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			Me.gridLookUpEdit1View.OptionsView.ShowHorzLines = False
			Me.gridLookUpEdit1View.OptionsView.ShowIndicator = False
			Me.gridLookUpEdit1View.OptionsView.ShowVertLines = False
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.gridColumn1.FieldName = "Image"
			Me.gridColumn1.MinWidth = 10
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 35
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "gridColumn2"
			Me.gridColumn2.FieldName = "Description"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 363
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 454)
			Me.Controls.Add(Me.gridLookUpEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private gridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
		Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

