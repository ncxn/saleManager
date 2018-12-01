Imports BrightIdeasSoftware

Public Class Product_type_list

    Private Sub Product_type_list_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim db As New SQLiteDatabase
        Dim tb As New DataTable
        Dim strSQL As String
        strSQL = "SELECT * FROM Product_Type"
        tb = db.GetDataTable(strSQL)
        Dim mysqlstm As New VBMySQL
        mysqlstm.Connect_Server()
        Dim users As DataTable = mysqlstm.Retrieve_Table("SELECT * FROM `users`")
        Dim row As DataRow
        For Each row In users.Rows
            MessageBox.Show(row("uuid").ToString)
        Next

    End Sub

End Class