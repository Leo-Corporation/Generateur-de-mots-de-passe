Imports System.Net

Public Class MAJ_AV
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub MAJ_AV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Thème = "1" Then
            Me.BackColor = Color.FromArgb(50, 50, 62)
            Button1.BackgroundImage = My.Resources.roudnbuttonblack
            Button2.BackgroundImage = My.Resources.Settings_Button_Second_Black
            Button2.ForeColor = Color.White
        Else
            Me.BackColor = Color.White
            Button1.BackgroundImage = My.Resources.roundbuttonwhite
            Button2.BackgroundImage = My.Resources.Settings_Button_Second_White
            Button2.ForeColor = Color.Black
        End If
        Dim MAJ As New WebClient
        Dim Four As New WebClient
        Dim derniereVersion As String = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/yoy7s7ej25i03um/Version.txt") 'dernier version du logiciel
        Dim FourMaj As String = Four.DownloadString("https://dl.dropboxusercontent.com/s/hwh2sldew5nhr07/fournisseur%20de%20la%20mise%20%C3%A0%20jour.txt") ' fournisseur de la mise à jour
        Label2.Text = "Version : " + derniereVersion
        Label3.Text = "Fournisseur : " + FourMaj
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start = Application.StartupPath
        Process.Start(start & "\GMDPUpdater.exe")
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class