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
        Me.ObjectListView_Product_type = New BrightIdeasSoftware.ObjectListView()
        CType(Me.ObjectListView_Product_type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObjectListView_Product_type
        '
        Me.ObjectListView_Product_type.CellEditUseWholeCell = False
        Me.ObjectListView_Product_type.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectListView_Product_type.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectListView_Product_type.Location = New System.Drawing.Point(0, 0)
        Me.ObjectListView_Product_type.Name = "ObjectListView_Product_type"
        Me.ObjectListView_Product_type.Size = New System.Drawing.Size(800, 450)
        Me.ObjectListView_Product_type.TabIndex = 0
        Me.ObjectListView_Product_type.UseCompatibleStateImageBehavior = False
        Me.ObjectListView_Product_type.View = System.Windows.Forms.View.Details
        '
        'Product_type_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ObjectListView_Product_type)
        Me.Name = "Product_type_list"
        Me.Text = "Nhóm sản phẩm"
        CType(Me.ObjectListView_Product_type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ObjectListView_Product_type As BrightIdeasSoftware.ObjectListView
End Class
