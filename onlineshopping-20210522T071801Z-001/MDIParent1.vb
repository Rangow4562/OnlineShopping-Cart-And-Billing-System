Imports System.Windows.Forms

Public Class MDIParent1







    Private Sub CustomerEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerEntryToolStripMenuItem.Click
        CustForm.MdiParent = Me
        CustForm.Show()
    End Sub



    Private Sub SupplierEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierEntryToolStripMenuItem.Click
        SupplierForm.MdiParent = Me
        SupplierForm.Show()
    End Sub

    Private Sub CategoryEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CategoryEntryToolStripMenuItem.Click
        CategoryForm.MdiParent = Me
        CategoryForm.Show()
    End Sub

    Private Sub GroupEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GroupEntryToolStripMenuItem.Click
        GroupForm.MdiParent = Me
        GroupForm.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockReportToolStripMenuItem.Click
        StockReport.MdiParent = Me
        StockReport.Show()
    End Sub

  

    Private Sub ImportEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportEntryToolStripMenuItem.Click
        PurchaseImportForm.MdiParent = Me
        PurchaseImportForm.Show()
    End Sub

    Private Sub ProductEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductEntryToolStripMenuItem.Click
        ItemForm.MdiParent = Me
        ItemForm.Show()
    End Sub

    Private Sub ExportBillingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportBillingToolStripMenuItem.Click
        ExportBillingForm.MdiParent = Me
        ExportBillingForm.Show()
    End Sub

    
    Private Sub ImportReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImportReportsToolStripMenuItem.Click
        PurchaseReport.MdiParent = Me
        PurchaseReport.Show()
    End Sub

    Private Sub ExportReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportReportsToolStripMenuItem.Click
        SalesReport.MdiParent = Me
        SalesReport.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "yes,no") Then Exit Sub
        Me.Hide()
        CUSTOMER_AND_USER.Show()

    End Sub

    Private Sub SIGNUPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SIGNUPToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
