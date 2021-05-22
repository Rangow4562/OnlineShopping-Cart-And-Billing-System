<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportBillingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportBillingForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.butNew = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.butModify = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.butList = New System.Windows.Forms.Button()
        Me.butClose = New System.Windows.Forms.Button()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.TxtTax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.TxtT1 = New System.Windows.Forms.TextBox()
        Me.TxtT2 = New System.Windows.Forms.TextBox()
        Me.TxtT3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DG2 = New System.Windows.Forms.DataGridView()
        Me.PP1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.butPrint = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BillNo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 29)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Code"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(508, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 26)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 570)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(921, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'butNew
        '
        Me.butNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butNew.Location = New System.Drawing.Point(14, 579)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(95, 30)
        Me.butNew.TabIndex = 0
        Me.butNew.Text = "New"
        Me.butNew.UseVisualStyleBackColor = False
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butSave.Location = New System.Drawing.Point(115, 579)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(95, 30)
        Me.butSave.TabIndex = 16
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'DG1
        '
        Me.DG1.BackgroundColor = System.Drawing.Color.White
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(965, 12)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(480, 548)
        Me.DG1.TabIndex = 19
        '
        'butModify
        '
        Me.butModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butModify.Location = New System.Drawing.Point(216, 579)
        Me.butModify.Name = "butModify"
        Me.butModify.Size = New System.Drawing.Size(95, 30)
        Me.butModify.TabIndex = 17
        Me.butModify.Text = "Modify"
        Me.butModify.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ButDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(317, 579)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(95, 30)
        Me.ButDelete.TabIndex = 18
        Me.ButDelete.Text = "Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'butList
        '
        Me.butList.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butList.Location = New System.Drawing.Point(646, 579)
        Me.butList.Name = "butList"
        Me.butList.Size = New System.Drawing.Size(95, 30)
        Me.butList.TabIndex = 20
        Me.butList.Text = "List"
        Me.butList.UseVisualStyleBackColor = False
        '
        'butClose
        '
        Me.butClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butClose.Location = New System.Drawing.Point(808, 579)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(95, 30)
        Me.butClose.TabIndex = 21
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = False
        '
        'TxtRate
        '
        Me.TxtRate.Location = New System.Drawing.Point(216, 150)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(61, 26)
        Me.TxtRate.TabIndex = 6
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(282, 150)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(67, 26)
        Me.TxtQty.TabIndex = 7
        '
        'TxtTax
        '
        Me.TxtTax.Location = New System.Drawing.Point(354, 150)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.Size = New System.Drawing.Size(67, 26)
        Me.TxtTax.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(212, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ItemCode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(428, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Bill Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(428, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "RefNo"
        Me.Label6.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(145, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 26)
        Me.ComboBox1.TabIndex = 3
        '
        'bDate
        '
        Me.bDate.CustomFormat = "dd-MMM-yyyy"
        Me.bDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bDate.Location = New System.Drawing.Point(508, 30)
        Me.bDate.Name = "bDate"
        Me.bDate.Size = New System.Drawing.Size(110, 26)
        Me.bDate.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(14, 149)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(189, 26)
        Me.ComboBox2.TabIndex = 5
        '
        'TxtTot
        '
        Me.TxtTot.Location = New System.Drawing.Point(426, 149)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(77, 26)
        Me.TxtTot.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(278, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(351, 126)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Tax Amt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(428, 126)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Total"
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(508, 149)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(53, 28)
        Me.butAdd.TabIndex = 10
        Me.butAdd.Text = "Add"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'TxtT1
        '
        Me.TxtT1.Location = New System.Drawing.Point(426, 427)
        Me.TxtT1.Name = "TxtT1"
        Me.TxtT1.Size = New System.Drawing.Size(77, 26)
        Me.TxtT1.TabIndex = 12
        '
        'TxtT2
        '
        Me.TxtT2.Location = New System.Drawing.Point(426, 456)
        Me.TxtT2.Name = "TxtT2"
        Me.TxtT2.Size = New System.Drawing.Size(77, 26)
        Me.TxtT2.TabIndex = 13
        '
        'TxtT3
        '
        Me.TxtT3.Location = New System.Drawing.Point(426, 485)
        Me.TxtT3.Name = "TxtT3"
        Me.TxtT3.Size = New System.Drawing.Size(77, 26)
        Me.TxtT3.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(304, 430)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 18)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(302, 463)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Other Charges"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(302, 489)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 18)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Grand Total"
        '
        'txtRem
        '
        Me.txtRem.Location = New System.Drawing.Point(14, 489)
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(262, 26)
        Me.txtRem.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(12, 470)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Remark"
        '
        'DG2
        '
        Me.DG2.BackgroundColor = System.Drawing.Color.White
        Me.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG2.Location = New System.Drawing.Point(14, 188)
        Me.DG2.Name = "DG2"
        Me.DG2.Size = New System.Drawing.Size(488, 222)
        Me.DG2.TabIndex = 39
        '
        'PP1
        '
        Me.PP1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PP1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PP1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PP1.Document = Me.PrintDocument1
        Me.PP1.Enabled = True
        Me.PP1.Icon = CType(resources.GetObject("PP1.Icon"), System.Drawing.Icon)
        Me.PP1.Name = "PP"
        Me.PP1.Visible = False
        '
        'PrintDocument1
        '
        '
        'butPrint
        '
        Me.butPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butPrint.Location = New System.Drawing.Point(418, 579)
        Me.butPrint.Name = "butPrint"
        Me.butPrint.Size = New System.Drawing.Size(95, 30)
        Me.butPrint.TabIndex = 40
        Me.butPrint.Text = "Print"
        Me.butPrint.UseVisualStyleBackColor = False
        '
        'ExportBillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1576, 746)
        Me.Controls.Add(Me.butPrint)
        Me.Controls.Add(Me.DG2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRem)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtT3)
        Me.Controls.Add(Me.TxtT2)
        Me.Controls.Add(Me.TxtT1)
        Me.Controls.Add(Me.butAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.bDate)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTax)
        Me.Controls.Add(Me.TxtQty)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butList)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.butModify)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ExportBillingForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents butNew As System.Windows.Forms.Button
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents butModify As System.Windows.Forms.Button
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents butList As System.Windows.Forms.Button
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtTax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTot As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents butAdd As System.Windows.Forms.Button
    Friend WithEvents TxtT1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtT2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtT3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DG2 As System.Windows.Forms.DataGridView
    Friend WithEvents PP1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents butPrint As System.Windows.Forms.Button

End Class
