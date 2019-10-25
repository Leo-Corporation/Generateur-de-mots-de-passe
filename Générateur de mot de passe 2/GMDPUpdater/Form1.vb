Imports System.IO
Imports System.Net
Public Class Form1
    Dim NewPoint As New Point
    Dim X, Y As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = GetLastVersion()
        InstallUpdate()
        Application.Exit()
    End Sub
    Function GetLastVersion()
        Dim Web As New WebClient
        Dim Version = Web.DownloadString("https://dl.dropboxusercontent.com/s/yoy7s7ej25i03um/Version.txt")
        Dim LabelVersion = "Version " + Version
        Return LabelVersion
    End Function
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (Y)
            NewPoint.X -= (X)
            Me.Location = NewPoint
        End If
    End Sub

    Sub InstallUpdate()
        Dim start As String = Application.StartupPath & "\Générateur de mot de passe 2.exe"
        Dim down As New WebClient
        Dim link = down.DownloadString("https://dl.dropboxusercontent.com/s/hohhgvia46slryl/LienDown.txt")
        File.Delete(start)
        My.Computer.Network.DownloadFile(link, start)
        Label5.Text = "La mise à jour a été installée"
    End Sub
End Class
