Public Class DAL

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MsgBox("Item Added")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MsgBox("Item Added")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Item Added")
    End Sub

    Private Sub DAL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Product.Show()
    End Sub
End Class