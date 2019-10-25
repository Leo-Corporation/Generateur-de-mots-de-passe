Public Class MAJ_UN
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MAJ_UN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Thème = "1" Then
            Me.BackColor = Color.FromArgb(50, 50, 62)
            Button1.BackgroundImage = My.Resources.roudnbuttonblack
        Else
            Me.BackColor = Color.White
            Button1.BackgroundImage = My.Resources.roundbuttonwhite
        End If
    End Sub
End Class