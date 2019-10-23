Imports System.Net
Public Class Preset
    Dim UsableChar() As String
    Dim RandomClass As New Random()
    Dim CharList = ("A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,/,é,&,ç,à")
    Dim FinalPassword As String = ""
    Dim Number As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox4.Click, Label3.Click
        Form1.TextBox2.Text = "10"
        UsableChar = Split(CharList, ",")
        FinalPassword = ""
        Number = 0
        If Form1.TextBox2.Text > 0 Then
            For i As Integer = 1 To Form1.TextBox2.Text
                Number = RandomClass.Next(0, 60)
                FinalPassword = FinalPassword + UsableChar(Number)
            Next
            Form1.TextBox1.Text = FinalPassword
        Else
            MsgBox("Impossible de générer le mot de passe.")
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox5.Click, Label4.Click
        Form1.TextBox2.Text = "25"
        UsableChar = Split(CharList, ",")
        FinalPassword = ""
        Number = 0
        If Form1.TextBox2.Text > 0 Then
            For i As Integer = 1 To Form1.TextBox2.Text
                Number = RandomClass.Next(0, 65)
                FinalPassword = FinalPassword + UsableChar(Number)
            Next
            Form1.TextBox1.Text = FinalPassword
        Else
            MsgBox("Impossible de générer le mot de passe.")
        End If
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Preset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Thème = "1" Then
            Me.BackColor = Color.FromArgb(50, 50, 62)
            PictureBox1.Image = My.Resources.roundrblack
            PictureBox2.Image = My.Resources.roundrblack
            PictureBox3.Image = My.Resources.roundrblack
        Else
            Me.BackColor = Color.White
            PictureBox1.Image = My.Resources.roundwhite
            PictureBox2.Image = My.Resources.roundwhite
            PictureBox3.Image = My.Resources.roundwhite
        End If
    End Sub
End Class