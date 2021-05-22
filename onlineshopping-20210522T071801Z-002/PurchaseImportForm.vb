Imports System.Data.SqlClient
Public Class PurchaseImportForm
    Dim pkVar, BillNoVar As Long
    Dim rowNo As Long
    Dim totAmt, taxVar As Decimal
    Dim DS2 As New DataSet
    Dim Tab1 As DataTable
    Dim I As Long

    Private Sub PurchaseForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        disRecords()

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select suppCode from SuppTab order by Suppcode", Conn)
        Dim D2 As SqlDataReader = Cmd0.ExecuteReader()
        While D2.Read
            ComboBox1.Items.Add(D2(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select ItemCode from ItemTab order by ItemCode", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox2.Items.Add(D1(0).ToString)
        End While



        DG2Init()
    End Sub
    Sub DG2Init()
        rowNo = 0
        totAmt = 0

        DS2 = New DataSet
        Tab1 = New DataTable
        Tab1 = DS2.Tables.Add("t1Tab")
        Tab1.Columns.Add("ItemCode", GetType(String))
        Tab1.Columns.Add("iRate", GetType(Long))
        Tab1.Columns.Add("iQty", GetType(Long))
        Tab1.Columns.Add("TaxAmt", GetType(Long))
        Tab1.Columns.Add("TotAmt", GetType(Long))
        DG2.DataSource = DS2.Tables(0)
    End Sub



    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False
        butPrint.Enabled = True
    End Sub
    Sub SaveRecord()
        Dim cmd3 As New SqlCommand
        'If TextBox1.Text = "" Then
        '    MsgBox("Please enter the necessary details")
        '    Exit Sub
        'End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select max(Billno) from SaMainTab", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            BillNoVar = Val(D1(0).ToString) + 1
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End If
        'TextBox1.Text = BillNoVar
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1var = "insert into SaMainTab("
        q2var = " values("
        q1var = q1var & "billNo" & ","
        q2var = q2var & "" & BillNoVar & ","
        q1var = q1var & "BDate" & ","
        q2var = q2var & "'" & Format(bDate.Value, "dd/MMM/yyyy") & "',"
        q1var = q1var & "PartyCode" & ","
        q2var = q2var & "'" & ComboBox1.Text & "',"
        q1var = q1var & "RefNo" & ","
        q2var = q2var & "'" & TextBox1.Text & "',"
        q1var = q1var & "Btype" & ","
        q2var = q2var & "2,"
        q1var = q1var & "tAmt" & ","
        q2var = q2var & "" & Val(TxtT1.Text) & ","
        q1var = q1var & "Add1" & ","
        q2var = q2var & "" & Val(TxtT2.Text) & ","
        q1var = q1var & "gtAmt" & ","
        q2var = q2var & "" & Val(TxtT3.Text) & ","
        q1var = q1var & "Rem1" & ")"
        q2var = q2var & "'" & txtRem.Text & "')"

        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1var & q2var, Conn)
        cmd1.ExecuteNonQuery()

        For Each r As DataGridViewRow In DG2.Rows
            If Conn.State = ConnectionState.Open Then Conn.Close()
            If Not r.Cells(0).Value = "" Then
                q1var = "insert into SaDetTab("
                q2var = " values("
                q1var = q1var & "billNo" & ","
                q2var = q2var & "" & BillNoVar & ","
                q1var = q1var & "slNo" & ","
                q2var = q2var & "" & I & ","
                q1var = q1var & "ItemCode" & ","
                q2var = q2var & "'" & r.Cells(0).Value & "',"
                q1var = q1var & "iRate" & ","
                q2var = q2var & "" & Val(r.Cells(1).Value) & ","
                q1var = q1var & "iQty" & ","
                q2var = q2var & "" & Val(r.Cells(2).Value) & ","
                q1var = q1var & "TaxAmt" & ","
                q2var = q2var & "" & Val(r.Cells(3).Value) & ","
                q1var = q1var & "totAmt" & ","
                q2var = q2var & "" & Val(r.Cells(4).Value) & ","
                q1var = q1var & "Rem1" & ")"
                q2var = q2var & "'')"
                Conn.Open()
                cmd3.Connection = Conn
                cmd3.CommandText = (q1var & q2var)
                cmd3.ExecuteNonQuery()
            End If
        Next


        disRecords()

    End Sub
    Sub disRecords()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select Billno,PartyCode From SaMainTab where btype =2 order by Billno", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub



    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub

    Private Sub butModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butModify.Click
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from SaMainTab where billNo=" & pkVar & "", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd2 As New SqlCommand("Delete from SaDetTab where billNo=" & pkVar & "", Conn)
        cmd2.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from SaMainTab where billNo=" & pkVar & "", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub butNew_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles butNew.Click
        DG2Init()
        'ClearTxtControls(Me, 1)
        TextBox1.Focus()

    End Sub

    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        disRecords()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
    End Sub

    Private Sub butAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAdd.Click

        Dim dRow As DataRow = Tab1.NewRow
        dRow(0) = ComboBox2.Text
        dRow(1) = CLng(TxtRate.Text)
        dRow(2) = CLng(TxtQty.Text)
        dRow(3) = CLng(TxtTax.Text)
        dRow(4) = CLng(TxtTot.Text)
        Tab1.Rows.Add(dRow)
        DG2.DataSource = DS2.Tables(0)

        rowNo = rowNo + 1
        totAmt = totAmt + Val(TxtTot.Text)
        TxtT1.Text = totAmt
        TxtT3.Text = totAmt + Val(TxtT2.Text)
        ComboBox2.Text = ""
        TxtRate.Text = ""
        TxtQty.Text = ""
        TxtTax.Text = ""
        TxtTot.Text = ""
        ComboBox2.Focus()
    End Sub

    Private Sub ComboBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Leave
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select pPrice,TaxPer from ItemTab where ItemCode='" & ComboBox2.Text & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TxtRate.Text = D1(0).ToString
            taxVar = D1(1).ToString
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub


    Private Sub TxtRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRate.TextChanged
        TxtTax.Text = (Val(TxtQty.Text) * Val(TxtRate.Text) * Val(taxVar) * 0.01).ToString
        TxtTot.Text = (Val(TxtQty.Text) * Val(TxtRate.Text)) + Val(TxtTax.Text)
    End Sub

    Private Sub TxtQty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQty.TextChanged
        TxtTax.Text = (Val(TxtQty.Text) * Val(TxtRate.Text) * Val(taxVar) * 0.01).ToString
        TxtTot.Text = (Val(TxtQty.Text) * Val(TxtRate.Text)) + Val(TxtTax.Text)
    End Sub

    Private Sub TxtT2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtT2.TextChanged
        TxtT3.Text = Val(TxtT1.Text) + Val(TxtT2.Text)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long

        YPos += 50
        XPos = 10
        Dim MyFont As New Font("Arial", 20)
        e.Graphics.DrawString("Organic Food And Co", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 14)
        XPos = 10
        e.Graphics.DrawString("Purchase Bill", MyFont, Brushes.Black, XPos, YPos)
        XPos = 200
        e.Graphics.DrawString("Date : ", MyFont, Brushes.Black, XPos, YPos)
        XPos = 300
        e.Graphics.DrawString(bDate.Value, MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 200
        e.Graphics.DrawString("BillNo : ", MyFont, Brushes.Black, XPos, YPos)
        XPos = 300
        e.Graphics.DrawString(TextBox1.Text, MyFont, Brushes.Black, XPos, YPos)

        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 12)
        e.Graphics.DrawString("From", MyFont, Brushes.Black, XPos, YPos)
        YPos += 25
        XPos = 10
        e.Graphics.DrawString(ComboBox1.Text, MyFont, Brushes.Black, XPos, YPos)
        YPos += 20
        XPos = 10
        e.Graphics.DrawString("______________________________________________________________________________________________", MyFont, Brushes.Black, XPos, YPos)
        YPos += 30
        XPos = 10
        e.Graphics.DrawString("Product Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 200
        e.Graphics.DrawString("Qty", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Rate", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Tax Amt", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Total Amt", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150

        YPos += 10
        XPos = 10
        e.Graphics.DrawString("______________________________________________________________________________________________", MyFont, Brushes.Black, XPos, YPos)



        YPos += 25
        For Each r As DataGridViewRow In DG2.Rows
            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 200
            e.Graphics.DrawString(r.Cells(1).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(3).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(4).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150

            YPos += 25
        Next

        XPos = 10
        e.Graphics.DrawString("______________________________________________________________________________________________", MyFont, Brushes.Black, XPos, YPos)

    End Sub
    Private Sub PP1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles PP1.Disposed
        PP1.Close()
        PrintDocument1.Dispose()
    End Sub
    Private Sub butPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butPrint.Click
        PP1.ShowDialog()
    End Sub


    Private Sub DG2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG2.CellContentClick

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.KeyChar = CheckNum(e.KeyChar)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.KeyChar = CheckNum(e.KeyChar)
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DG1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        DG2Init()
        '(Me, 1)
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from SaMainTab where billNo=" & pkVar & "", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            'TextBox1.Text = D1("BillNo").ToString
            TextBox1.Text = D1("RefNo").ToString
            bDate.Value = D1("bDate")
            ComboBox1.Text = D1("PartyCode").ToString
            TxtT1.Text = D1("tAmt").ToString
            TxtT2.Text = D1("add1").ToString
            TxtT3.Text = D1("gtAmt").ToString

            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = True
            ButDelete.Enabled = True
            butPrint.Enabled = True
        Else
            TextBox1.Text = ""
            ComboBox1.Text = ""
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = False
            ButDelete.Enabled = False
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd4 As New SqlCommand("select * from SaDetTab where billNo=" & pkVar & "", Conn)
        Dim D2 As SqlDataReader = Cmd4.ExecuteReader()
        rowNo = 1
        totAmt = 0

        While D2.Read
            Dim dRow As DataRow = Tab1.NewRow
            dRow(0) = D2(2)
            dRow(1) = CLng(D2(3))
            dRow(2) = CLng(D2(4))
            dRow(3) = CLng(D2(5))
            dRow(4) = CLng(D2(6))
            Tab1.Rows.Add(dRow)

            'Grid1.set_TextMatrix(rowNo, 0, D2(2).ToString)
            'Grid1.set_TextMatrix(rowNo, 1, D2(3).ToString)
            'Grid1.set_TextMatrix(rowNo, 2, D2(4).ToString)
            'Grid1.set_TextMatrix(rowNo, 3, D2(5).ToString)
            'Grid1.set_TextMatrix(rowNo, 4, D2(6).ToString)
            totAmt = totAmt + D2(6)
            rowNo = rowNo + 1
        End While
        DG2.DataSource = DS2.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()

    End Sub

  
End Class
