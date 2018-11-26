Imports BrightIdeasSoftware
Public Class Product_type_list
    Private Sub ObjectListView_Product_type_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Product_type_list_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim db As New SQLiteDatabase
        Dim tb As New DataTable
        Dim strSQL As String
        strSQL = "SELECT * FROM Product_Type"
        tb = db.GetDataTable(strSQL)
        DataListView1.DataSource = tb

    End Sub

    Private Sub DataListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListView1.SelectedIndexChanged

    End Sub
End Class