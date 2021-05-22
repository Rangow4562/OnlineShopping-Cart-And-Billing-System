Imports System.Data.SqlClient
Public Class SalesReport

    Private Sub salesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select RefNo,bDate,PartyCode,tamt From saMainTab where btype=4 order by refNo,bDate", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long
        YPos = 50
        Dim MyFont As New Font("Arial", 18)
        XPos = 10
        e.Graphics.DrawString("Organic Food And Co", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("No 233, II Floor, UB City, Bangalore", MyFont, Brushes.Black, XPos, YPos)
        YPos += 100
        XPos = 10
        e.Graphics.DrawString("Purchase Detail Report", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("RefNo", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 50
        e.Graphics.DrawString("Bill Date", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Party Code", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Total Amount", MyFont, Brushes.Black, XPos, YPos)



        YPos += 25
        For Each r As DataGridViewRow In DG1.Rows
            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 50
            e.Graphics.DrawString(Format(r.Cells(1).Value, "dd MM yy"), MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(3).Value, MyFont, Brushes.Black, XPos, YPos)

            YPos += 25
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PP1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class