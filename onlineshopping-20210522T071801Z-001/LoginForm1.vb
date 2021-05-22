Imports System.Data.SqlClient

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        CUSTOMER_AND_USER.Show()

    End Sub






    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Form2.Show()

    End Sub




    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PasswordTextBox.UseSystemPasswordChar = True

    End Sub


    

  
    


    

  
    
 

    Private Sub UsernameLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub







    Private Sub UsernameTextBox_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If PasswordTextBox.UseSystemPasswordChar = True Then

            PasswordTextBox.UseSystemPasswordChar = False

        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Form3.Show()
    End Sub

    
    Private Sub OK_Click_1(sender As System.Object, e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = My.Settings.username And PasswordTextBox.Text = My.Settings.password Or UsernameTextBox.Text = My.Settings.newpassword And PasswordTextBox.Text = My.Settings.conformpassword Then
            MsgBox("welcome user")
            MDIParent1.Show()
        Else
            MsgBox("UserName Or Password Is Incorrect")
            MDIParent1.Close()


        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        CUSTOMER_AND_USER.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class




