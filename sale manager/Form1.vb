
Imports System.Windows.Forms
Imports SaleManager.SQLiteDatabase
Public Class Form1
    Private Sub Form1_open(sender As Object, e As EventArgs) Handles MyBase.Load

        'MessageBox.Show(strcnn)
        Dim db As New SQLiteDatabase
        Dim users As New DataTable
        Dim strSQL As String
        strSQL = "SELECT * FROM users"
        users = db.GetDataTable(strSQL)
        For Each r As DataRow In users.Rows
            MessageBox.Show(r("userName").ToString)
            MessageBox.Show(r("userEmail").ToString)
            MessageBox.Show(r("userDisplayName").ToString)
            MessageBox.Show(r("groupID").ToString)
        Next
    End Sub
End Class
