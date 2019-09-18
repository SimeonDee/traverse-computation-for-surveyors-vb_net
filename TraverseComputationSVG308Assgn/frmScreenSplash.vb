Public Class frmScreenSplash

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMain.Show()
        FrmProgram.Show(FrmMain)
        Me.Hide()
    End Sub

    Private Sub frmScreenSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 200
        Me.Left = 350
    End Sub
End Class