Public Class Form3

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        If ComboBox1.Text = My.Settings.question And TextBox1.Text = My.Settings.answer Then
            MsgBox("set password")
            Form4.Show()
        Else
            MsgBox("incorrect answer")
            Form4.Close()

        End If
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load






    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

        If Label1.Visible = True Then
            Label1.Visible = False
        Else
            Label1.Visible = True

        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

        If Label2.Visible = True Then
            Label2.Visible = False
        Else
            Label2.Visible = True

        End If
    End Sub
End Class