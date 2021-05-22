Imports System.Data.SqlClient

Module Module1
    Public Conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Login.mdf;Integrated Security=True;User Instance=True")
    Public q1var, q2var As String
    Dim I As Long

    Public Function CheckNum(ByRef KeyVar As String) As String
        If Asc(KeyVar) = 8 Then
            CheckNum = KeyVar : Exit Function
        End If
        If Asc(KeyVar) < 46 Or Asc(KeyVar) > 57 Then
            CheckNum = Nothing
            MsgBox("Please Enter Numbers Only")
        Else
            CheckNum = KeyVar
        End If
        If Asc(KeyVar) = 47 Then CheckNum = Nothing

    End Function
    Public Function CheckChar(ByRef KeyVar As String) As String
        If Asc(KeyVar) = 8 Then
            CheckChar = KeyVar : Exit Function
        End If
        If Asc(KeyVar) < 65 Or Asc(KeyVar) > 90 Then
            CheckChar = Nothing
            MsgBox("Please Enter Text Only")
        Else
            CheckChar = KeyVar
        End If
        If Asc(KeyVar) = 47 Then CheckChar = Nothing

    End Function


End Module



