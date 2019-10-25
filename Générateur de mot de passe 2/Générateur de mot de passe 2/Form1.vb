Imports System.Net

Public Class Form1
    Dim UsableChar() As String
    Dim RandomClass As New Random()
    Dim CharList = ("A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,/,é,&,ç,à")
    Dim FinalPassword As String = ""
    Dim Number As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.GenSimpleMode = True Then
            UsableChar = Split(CharList, ",")
            FinalPassword = ""
            Number = 0
            If TextBox2.Text > 0 Then
                For i As Integer = 1 To TextBox2.Text
                    Number = RandomClass.Next(0, 60)
                    FinalPassword = FinalPassword + UsableChar(Number)
                Next
                TextBox1.Text = FinalPassword
            Else
                MsgBox("Impossible de générer le mot de passe.")
            End If
        Else
            UsableChar = Split(CharList, ",")
            FinalPassword = ""
            Number = 0
            If TextBox2.Text > 0 Then
                For i As Integer = 1 To TextBox2.Text
                    Number = RandomClass.Next(0, 65)
                    FinalPassword = FinalPassword + UsableChar(Number)
                Next
                TextBox1.Text = FinalPassword
            Else
                MsgBox("Impossible de générer le mot de passe.")
            End If
        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CheckUpdate()
    End Sub
    Sub CheckUpdate()
        'LABS Custom Update System for VB
        'By Leo Corporation
        '(c) 2020
        Dim MAJ As New WebClient
        Dim Four As New WebClient
        Dim versionActuelle As String = "2.4.0.1910"
        Dim derniereVersion As String = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/yoy7s7ej25i03um/Version.txt")
        Dim FourMaj As String = Four.DownloadString("https://dl.dropboxusercontent.com/s/hwh2sldew5nhr07/fournisseur%20de%20la%20mise%20%C3%A0%20jour.txt")
        If versionActuelle = derniereVersion Then
            MAJ_UN.Show()
        Else
            MAJ_AV.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.BackColor = Color.FromArgb(50, 50, 62)
            TextBox1.BackColor = Color.FromArgb(50, 50, 62)
            TextBox2.BackColor = Color.FromArgb(50, 50, 62)
            Button1.BackgroundImage = My.Resources.roudnbuttonblack
            Button1.BackColor = Color.FromArgb(50, 50, 62)
            Panel1.BackColor = Color.FromArgb(50, 50, 62)
            SettingsMenu1.BackColor = Color.FromArgb(50, 50, 62)
            My.Settings.Thème = "1"
        Else
            Me.BackColor = Color.White
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            Button1.BackColor = Color.White
            Panel1.BackColor = Color.White
            SettingsMenu1.BackColor = Color.White
            Button1.BackgroundImage = My.Resources.roundbuttonwhite
            My.Settings.Thème = "0"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Thème = "1" Then
            Me.BackColor = Color.FromArgb(50, 50, 62)
            TextBox1.BackColor = Color.FromArgb(50, 50, 62)
            TextBox2.BackColor = Color.FromArgb(50, 50, 62)
            Button1.BackgroundImage = My.Resources.roudnbuttonblack
            Panel1.BackColor = Color.FromArgb(50, 50, 62)
            SettingsMenu1.BackColor = Color.FromArgb(50, 50, 62)
            CheckBox1.Checked = True
        Else
            Me.BackColor = Color.White
            TextBox1.BackColor = Color.White
            Button1.BackgroundImage = My.Resources.roundbuttonwhite
            Panel1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            SettingsMenu1.BackColor = Color.White
            CheckBox1.Checked = False
        End If
        If My.Settings.GenSimpleMode = True Then
            SettingsMenu1.PictureBox3.Visible = True
            SettingsMenu1.PictureBox4.Visible = False
        Else
            SettingsMenu1.PictureBox3.Visible = False
            SettingsMenu1.PictureBox4.Visible = True
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Preset.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If SettingsMenu1.Visible = True Then
            SettingsMenu1.Visible = False
        Else
            SettingsMenu1.Visible = True
        End If
    End Sub
End Class
