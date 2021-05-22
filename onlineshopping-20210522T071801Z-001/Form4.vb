Public Class Form4

   
    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        My.Settings.username = TextBox1.Text
        My.Settings.password = TextBox2.Text
        My.Settings.Save()
        MsgBox("new password set")
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    
   

    Private Sub Label1_Click_1(sender As System.Object, e As System.EventArgs) Handles Label1.Click

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