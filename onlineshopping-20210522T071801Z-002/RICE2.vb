Public Class RICE2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        RICE.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MsgBox("Item Added")

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        MsgBox("Item Added")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MsgBox("Item Added")
    End Sub

    Private Sub RICE2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Product.Show()
    End Sub
End Class