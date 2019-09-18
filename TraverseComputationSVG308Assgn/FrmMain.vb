Public Class FrmMain

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Thanks for using our App" & vbCrLf & "Do you really want to exit?", "EXIT REQUEST", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = Windows.Forms.DialogResult.Yes Then
            End
        End If

    End Sub
End Class