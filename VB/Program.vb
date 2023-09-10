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
Imports System.Windows.Forms

Namespace WindowsApplication1

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
