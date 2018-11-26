
Imports System.Windows.Forms
Imports SaleManager.SQLiteDatabase
Public Class Form1
    Private Sub Form1_open(sender As Object, e As EventArgs) Handles MyBase.Load

        'MessageBox.Show(ProjPath)
        Dim db As New SQLiteDatabase
        Dim tb As New DataTable
        Dim strSQL As String
        strSQL = "SELECT * FROM Product_Type"
        tb = db.GetDataTable(strSQL)
        Product_type_list.Show()
    End Sub
End Class
