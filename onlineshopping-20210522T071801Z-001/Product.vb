Public Class Product

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub QUITToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QUITToolStripMenuItem.Click
        Me.Hide()

        Customer.Show()

    End Sub

    Private Sub INGREDIANTSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CEREALSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CEREALSToolStripMenuItem.Click
        Me.Hide()
        RICE.Show()

    End Sub

    Private Sub DALSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DALSToolStripMenuItem.Click
        Me.Hide()
        DAL.Show()

    End Sub

    Private Sub MILLETSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MILLETSToolStripMenuItem.Click
        Me.Hide()
        MILLETS.Show()
    End Sub

    Private Sub SPICESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SPICESToolStripMenuItem.Click
        Me.Hide()
        SPICES.Show()
    End Sub

    Private Sub OILSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OILSToolStripMenuItem.Click
        Me.Hide()
        OILS.Show()
    End Sub

    Private Sub TEASToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TEASToolStripMenuItem.Click
        Me.Hide()
        TEAS.Show()
    End Sub

   
    Private Sub JUICESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JUICESToolStripMenuItem.Click
        Me.Hide()
        JUICES.Show()
    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABOUTUSToolStripMenuItem.Click
        Me.Hide()
        ABOUT_US.Show()

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Hide()
        Customer.Show()

    End Sub

    Private Sub Product_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Hide()
        Customer.Show()

    End Sub
End Class