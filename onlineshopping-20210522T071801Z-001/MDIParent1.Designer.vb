<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MasterEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportBillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIGNUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntriesToolStripMenuItem, Me.ProductEntryToolStripMenuItem, Me.ImportEntryToolStripMenuItem, Me.ExportBillingToolStripMenuItem, Me.StockReportToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SIGNUPToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1466, 49)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MasterEntriesToolStripMenuItem
        '
        Me.MasterEntriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerEntryToolStripMenuItem, Me.SupplierEntryToolStripMenuItem, Me.CategoryEntryToolStripMenuItem, Me.GroupEntryToolStripMenuItem})
        Me.MasterEntriesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterEntriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MasterEntriesToolStripMenuItem.Name = "MasterEntriesToolStripMenuItem"
        Me.MasterEntriesToolStripMenuItem.Size = New System.Drawing.Size(217, 45)
        Me.MasterEntriesToolStripMenuItem.Text = "Master Entries"
        '
        'CustomerEntryToolStripMenuItem
        '
        Me.CustomerEntryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CustomerEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CustomerEntryToolStripMenuItem.Name = "CustomerEntryToolStripMenuItem"
        Me.CustomerEntryToolStripMenuItem.Size = New System.Drawing.Size(300, 46)
        Me.CustomerEntryToolStripMenuItem.Text = "Customer Entry"
        '
        'SupplierEntryToolStripMenuItem
        '
        Me.SupplierEntryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SupplierEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SupplierEntryToolStripMenuItem.Name = "SupplierEntryToolStripMenuItem"
        Me.SupplierEntryToolStripMenuItem.Size = New System.Drawing.Size(300, 46)
        Me.SupplierEntryToolStripMenuItem.Text = "Supplier Entry"
        '
        'CategoryEntryToolStripMenuItem
        '
        Me.CategoryEntryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CategoryEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CategoryEntryToolStripMenuItem.Name = "CategoryEntryToolStripMenuItem"
        Me.CategoryEntryToolStripMenuItem.Size = New System.Drawing.Size(300, 46)
        Me.CategoryEntryToolStripMenuItem.Text = "Category Entry"
        '
        'GroupEntryToolStripMenuItem
        '
        Me.GroupEntryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GroupEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupEntryToolStripMenuItem.Name = "GroupEntryToolStripMenuItem"
        Me.GroupEntryToolStripMenuItem.Size = New System.Drawing.Size(300, 46)
        Me.GroupEntryToolStripMenuItem.Text = "Group Entry"
        '
        'ProductEntryToolStripMenuItem
        '
        Me.ProductEntryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductEntryToolStripMenuItem.Name = "ProductEntryToolStripMenuItem"
        Me.ProductEntryToolStripMenuItem.Size = New System.Drawing.Size(209, 45)
        Me.ProductEntryToolStripMenuItem.Text = "Product Entry"
        '
        'ImportEntryToolStripMenuItem
        '
        Me.ImportEntryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ImportEntryToolStripMenuItem.Name = "ImportEntryToolStripMenuItem"
        Me.ImportEntryToolStripMenuItem.Size = New System.Drawing.Size(195, 45)
        Me.ImportEntryToolStripMenuItem.Text = "Import Entry"
        '
        'ExportBillingToolStripMenuItem
        '
        Me.ExportBillingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBillingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExportBillingToolStripMenuItem.Name = "ExportBillingToolStripMenuItem"
        Me.ExportBillingToolStripMenuItem.Size = New System.Drawing.Size(203, 45)
        Me.ExportBillingToolStripMenuItem.Text = "Export Billing"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(199, 45)
        Me.StockReportToolStripMenuItem.Text = "Stock Report"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportReportsToolStripMenuItem, Me.ExportReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(132, 45)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ImportReportsToolStripMenuItem
        '
        Me.ImportReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ImportReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ImportReportsToolStripMenuItem.Name = "ImportReportsToolStripMenuItem"
        Me.ImportReportsToolStripMenuItem.Size = New System.Drawing.Size(296, 46)
        Me.ImportReportsToolStripMenuItem.Text = "Import Reports"
        '
        'ExportReportsToolStripMenuItem
        '
        Me.ExportReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ExportReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExportReportsToolStripMenuItem.Name = "ExportReportsToolStripMenuItem"
        Me.ExportReportsToolStripMenuItem.Size = New System.Drawing.Size(296, 46)
        Me.ExportReportsToolStripMenuItem.Text = "Export Reports"
        '
        'SIGNUPToolStripMenuItem
        '
        Me.SIGNUPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SIGNUPToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIGNUPToolStripMenuItem.Name = "SIGNUPToolStripMenuItem"
        Me.SIGNUPToolStripMenuItem.Size = New System.Drawing.Size(163, 45)
        Me.SIGNUPToolStripMenuItem.Text = "EMP SIGNUP"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(118, 45)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1466, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.project.My.Resources.Resources.Artboard_1_100__4_1
        Me.ClientSize = New System.Drawing.Size(1466, 558)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportBillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SIGNUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
