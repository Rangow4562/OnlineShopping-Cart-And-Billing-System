Public Class Form1

    Dim i As Integer

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
      
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            CUSTOMER_AND_USER.Show()
        Else
            ProgressBar1.PerformStep()
            Label1.Text = ProgressBar1.Value & ("%")

        End If
        

    End Sub

  

    
    

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()

    End Sub

   
    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    
End Class
