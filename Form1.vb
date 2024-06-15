Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Sub New()
        Me.Text = "Popup Message App"
        ' Show a message box with the specified content in the constructor
        MessageBox.Show("Rajdeep Das, this is my Slidely AI task", "Slidely AI Task")
        AddHandler Me.Load, AddressOf Me.Form1_Load
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ' Display a detailed popup message when the form loads
        Dim message As String = "Welcome to the Popup Message App!" & vbCrLf & vbCrLf &
                                "This application demonstrates how to display a message box in Visual Basic." & vbCrLf &
                                "You can customize the content, title, buttons, and icon of the message box." & vbCrLf &
                                "Click 'OK' to continue or 'Cancel' to exit."

        Dim title As String = "Detailed Popup Message"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel
        Dim icon As MessageBoxIcon = MessageBoxIcon.Information

        Dim result As DialogResult = MessageBox.Show(message, title, buttons, icon)

        If result = DialogResult.Cancel Then
            ' Close the application if the user clicks 'Cancel'
            Me.Close()
        End If
    End Sub

    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Class
