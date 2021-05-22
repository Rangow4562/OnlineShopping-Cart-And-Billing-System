Imports System.Data.SqlClient

Public Class SupplierForm

    Dim pkVar As String
    Private Sub suppForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        disRecords()
    End Sub



    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        SaveRecord()


    End Sub
    Sub SaveRecord()
        If TextBox1.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select suppcode from supptab where suppcode='" & UCase(TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This record is allready present in the database")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1var = "insert into supptab("
        q2var = " values("
        q1var = q1var & "suppcode" & ","
        q2var = q2var & "'" & UCase(TextBox1.Text) & "',"
        q1var = q1var & "suppname" & ","
        q2var = q2var & "'" & TextBox2.Text & "',"
        q1var = q1var & "Add1" & ","
        q2var = q2var & "'" & TextBox3.Text & "',"
        q1var = q1var & "Add2" & ","
        q2var = q2var & "'" & TextBox4.Text & "',"
        q1var = q1var & "Add3" & ","
        q2var = q2var & "'" & TextBox5.Text & "',"
        q1var = q1var & "PinCode" & ","
        q2var = q2var & "'" & TextBox6.Text & "',"
        q1var = q1var & "PhoneNo" & ","
        q2var = q2var & "'" & TextBox7.Text & "',"
        q1var = q1var & "eMail" & ")"
        q2var = q2var & "'" & TextBox8.Text & "')"

        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()

    End Sub
    Sub disRecords()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select suppcode,suppname From supptab order by suppcode", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub


    Private Sub DG1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from supptab where suppcode='" & pkVar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            TextBox2.Text = D1(1).ToString
            TextBox3.Text = D1(2).ToString
            TextBox4.Text = D1(3).ToString
            TextBox5.Text = D1(4).ToString
            TextBox6.Text = D1(5).ToString
            TextBox7.Text = D1(6).ToString
            TextBox8.Text = D1(7).ToString

        Else
            TextBox1.Text = ""
            TextBox2.Text = ""


        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()

    End Sub

    Private Sub butClose_Click(sender As System.Object, e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub
    Private Sub butModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butModify.Click
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from supptab where suppcode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        SaveRecord()


    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butDelete.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from supptab where suppcode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()

    End Sub



    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        disRecords()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        e.KeyChar = CheckNum(e.KeyChar)
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        e.KeyChar = CheckNum(e.KeyChar)
    End Sub
    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
