Public Class formSettings

    Private Sub formSettings_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        formTitle.Show()
        Me.Close()
    End Sub
End Class