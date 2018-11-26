<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_type_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataListView1 = New BrightIdeasSoftware.DataListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListView1
        '
        Me.DataListView1.AllColumns.Add(Me.OlvColumn1)
        Me.DataListView1.AllColumns.Add(Me.OlvColumn2)
        Me.DataListView1.AllColumns.Add(Me.OlvColumn3)
        Me.DataListView1.AllColumns.Add(Me.OlvColumn4)
        Me.DataListView1.AllColumns.Add(Me.OlvColumn5)
        Me.DataListView1.CellEditUseWholeCell = False
        Me.DataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5})
        Me.DataListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListView1.DataSource = Nothing
        Me.DataListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListView1.Location = New System.Drawing.Point(0, 0)
        Me.DataListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataListView1.Name = "DataListView1"
        Me.DataListView1.Size = New System.Drawing.Size(1067, 554)
        Me.DataListView1.TabIndex = 0
        Me.DataListView1.UseCompatibleStateImageBehavior = False
        Me.DataListView1.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Product_Type_ID"
        Me.OlvColumn1.Text = "ID"
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Product_Type_Decscription"
        Me.OlvColumn2.Text = "Nhóm Sản Phẩm"
        Me.OlvColumn2.Width = 94
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Product_Type_Parrent"
        Me.OlvColumn3.Text = "Nhóm cha"
        Me.OlvColumn3.Width = 99
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "Product_Type_Active"
        Me.OlvColumn4.Text = "Sử dụng"
        Me.OlvColumn4.Width = 116
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "Order"
        Me.OlvColumn5.Text = "Sắp xếp"
        Me.OlvColumn5.Width = 95
        '
        'Product_type_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.DataListView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Product_type_list"
        Me.Text = "Nhóm sản phẩm"
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataListView1 As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
End Class
