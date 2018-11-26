Imports BrightIdeasSoftware
Public Class Product_type_list
    Private Sub ObjectListView_Product_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ObjectListView_Product_type.SelectedIndexChanged

    End Sub

    Private Sub Product_type_list_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim db As New SQLiteDatabase
        Dim tb As New DataTable
        Dim strSQL As String
        strSQL = "SELECT * FROM Product_Type"
        tb = db.GetDataTable(strSQL)
        For Each row As DataRow In tb.Rows
            Dim NewCol As New OLVColumn
            Try
                NewCol.AspectName = row("Product_Type_Decscription").ToString
                ObjectListView_Product_type.Columns.Add(NewCol)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
    End Sub
End Class