Public Class Form2

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.username = TextBox1.Text
        My.Settings.password = TextBox2.Text
        My.Settings.Save()
        My.Settings.question = ComboBox1.Text
        My.Settings.answer = TextBox3.Text
        My.Settings.Save()
        MsgBox("new user id created")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

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

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        If Label3.Visible = True Then
            Label3.Visible = False
        Else
            Label3.Visible = True

        End If

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        If Label4.Visible = True Then
            Label4.Visible = False
        Else
            Label4.Visible = True

        End If

    End Sub
   


    
End Class