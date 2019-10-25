Public Class SettingsMenu
    Public IsSimpleChecked As Boolean
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, PictureBox1.Click, Label1.Click
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        My.Settings.GenSimpleMode = True
    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click, PictureBox2.Click, Label2.Click
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        My.Settings.GenSimpleMode = False
    End Sub
End Class
