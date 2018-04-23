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
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace