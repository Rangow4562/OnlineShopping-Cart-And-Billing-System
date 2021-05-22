Public Class Customer

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

   

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Product.Show()
        Me.Close()

    End Sub

    Private Sub Customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Hide()
        CUSTOMER_AND_USER.Show()

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Product.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        CUSTOMER_AND_USER.Show()


    End Sub

    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class