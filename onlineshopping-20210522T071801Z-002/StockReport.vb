Imports System.Data.SqlClient
Public Class StockReport
    Dim rowNo, dNo As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rowNo = 0
        Dim IVar, OVar, bVar As Long
        Dim DS2 As New DataSet
        Dim Tab1 As DataTable
        DS2 = New DataSet
        Tab1 = New DataTable
        Tab1 = DS2.Tables.Add("t1Tab")
        Tab1.Columns.Add("ItemCode", GetType(String))
        Tab1.Columns.Add("In Qty", GetType(Long))
        Tab1.Columns.Add("Out Qty", GetType(Long))
        Tab1.Columns.Add("Balance", GetType(Long))
        Dim dRow As DataRow = Tab1.NewRow

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select sum(b.iqty) from saMainTab A,saDetTab B where A.billNo=b.BillNo and A.btype=2 and B.itemcode='" & ComboBox1.Text & "'", Conn)
        Dim D2 As SqlDataReader = Cmd0.ExecuteReader()
        D2.Read()
        IVar = IIf(IsDBNull(D2(0)), 0, D2(0))

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select sum(B.iqty) from saMainTab A,saDetTab B where A.billNo=b.BillNo and (A.btype=3 or A.btype=4)  and B.itemcode='" & ComboBox1.Text & "'", Conn)
        Dim D3 As SqlDataReader = Cmd1.ExecuteReader()
        D3.Read()
        OVar = IIf(IsDBNull(D3(0)), 0, D3(0))
        bVar = IVar - OVar

        dRow(0) = ComboBox1.Text
        dRow(1) = IVar
        dRow(2) = OVar
        dRow(3) = bVar
        Tab1.Rows.Add(dRow)

        DG1.DataSource = DS2.Tables(0)
    End Sub

    Private Sub StockRep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click


    End Sub

    Private Sub StockRep_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()

        Dim Cmd0 As New SqlCommand("select itemCode from itemTab order by itemCode", Conn)
        Dim D2 As SqlDataReader = Cmd0.ExecuteReader()
        While D2.Read
            ComboBox1.Items.Add(D2(0).ToString)
        End While
    End Sub

    
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class