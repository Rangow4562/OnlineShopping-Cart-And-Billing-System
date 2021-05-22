<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseImportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseImportForm))
        Me.butPrint = New System.Windows.Forms.Button()
        Me.DG2 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtT3 = New System.Windows.Forms.TextBox()
        Me.TxtT2 = New System.Windows.Forms.TextBox()
        Me.TxtT1 = New System.Windows.Forms.TextBox()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PP1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.bDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTax = New System.Windows.Forms.TextBox()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.butClose = New System.Windows.Forms.Button()
        Me.butList = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.butModify = New System.Windows.Forms.Button()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.butSave = New System.Windows.Forms.Button()
        Me.butNew = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butPrint
        '
        Me.butPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butPrint.Location = New System.Drawing.Point(520, 660)
        Me.butPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.butPrint.Name = "butPrint"
        Me.butPrint.Size = New System.Drawing.Size(119, 34)
        Me.butPrint.TabIndex = 77
        Me.butPrint.Text = "Print"
        Me.butPrint.UseVisualStyleBackColor = False
        '
        'DG2
        '
        Me.DG2.BackgroundColor = System.Drawing.Color.White
        Me.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG2.Location = New System.Drawing.Point(13, 221)
        Me.DG2.Margin = New System.Windows.Forms.Padding(4)
        Me.DG2.Name = "DG2"
        Me.DG2.Size = New System.Drawing.Size(610, 250)
        Me.DG2.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(13, 537)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 18)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Remark"
        '
        'txtRem
        '
        Me.txtRem.Location = New System.Drawing.Point(16, 558)
        Me.txtRem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(327, 24)
        Me.txtRem.TabIndex = 58
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(376, 558)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 18)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Grand Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(376, 529)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 18)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Other Charges"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(379, 492)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 18)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Total"
        '
        'TxtT3
        '
        Me.TxtT3.Location = New System.Drawing.Point(530, 554)
        Me.TxtT3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT3.Name = "TxtT3"
        Me.TxtT3.Size = New System.Drawing.Size(95, 24)
        Me.TxtT3.TabIndex = 57
        '
        'TxtT2
        '
        Me.TxtT2.Location = New System.Drawing.Point(530, 522)
        Me.TxtT2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT2.Name = "TxtT2"
        Me.TxtT2.Size = New System.Drawing.Size(95, 24)
        Me.TxtT2.TabIndex = 56
        '
        'TxtT1
        '
        Me.TxtT1.Location = New System.Drawing.Point(530, 489)
        Me.TxtT1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT1.Name = "TxtT1"
        Me.TxtT1.Size = New System.Drawing.Size(95, 24)
        Me.TxtT1.TabIndex = 55
        '
        'butAdd
        '
        Me.butAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butAdd.Location = New System.Drawing.Point(659, 176)
        Me.butAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(67, 31)
        Me.butAdd.TabIndex = 54
        Me.butAdd.Text = "Add"
        Me.butAdd.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(533, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 18)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(437, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Tax Amt"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(346, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 18)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Qty"
        '
        'TxtTot
        '
        Me.TxtTot.Location = New System.Drawing.Point(530, 177)
        Me.TxtTot.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(95, 24)
        Me.TxtTot.TabIndex = 53
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 176)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 26)
        Me.ComboBox2.TabIndex = 48
        '
        'bDate
        '
        Me.bDate.CustomFormat = "dd-MMM-yyyy"
        Me.bDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bDate.Location = New System.Drawing.Point(632, 42)
        Me.bDate.Margin = New System.Windows.Forms.Padding(4)
        Me.bDate.Name = "bDate"
        Me.bDate.Size = New System.Drawing.Size(137, 24)
        Me.bDate.TabIndex = 44
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(179, 94)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 26)
        Me.ComboBox1.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(533, 100)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "RefNo"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(533, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Bill Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(13, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "ItemCode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(263, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Rate"
        '
        'TxtTax
        '
        Me.TxtTax.Location = New System.Drawing.Point(441, 177)
        Me.TxtTax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.Size = New System.Drawing.Size(83, 24)
        Me.TxtTax.TabIndex = 52
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(350, 177)
        Me.TxtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(83, 24)
        Me.TxtQty.TabIndex = 51
        '
        'TxtRate
        '
        Me.TxtRate.Location = New System.Drawing.Point(268, 177)
        Me.TxtRate.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(75, 24)
        Me.TxtRate.TabIndex = 50
        '
        'butClose
        '
        Me.butClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butClose.Location = New System.Drawing.Point(1009, 660)
        Me.butClose.Margin = New System.Windows.Forms.Padding(4)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(119, 34)
        Me.butClose.TabIndex = 67
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = False
        '
        'butList
        '
        Me.butList.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butList.Location = New System.Drawing.Point(806, 660)
        Me.butList.Margin = New System.Windows.Forms.Padding(4)
        Me.butList.Name = "butList"
        Me.butList.Size = New System.Drawing.Size(119, 34)
        Me.butList.TabIndex = 64
        Me.butList.Text = "List"
        Me.butList.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ButDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButDelete.Location = New System.Drawing.Point(394, 660)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(119, 34)
        Me.ButDelete.TabIndex = 61
        Me.ButDelete.Text = "Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'butModify
        '
        Me.butModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butModify.Location = New System.Drawing.Point(268, 660)
        Me.butModify.Margin = New System.Windows.Forms.Padding(4)
        Me.butModify.Name = "butModify"
        Me.butModify.Size = New System.Drawing.Size(119, 34)
        Me.butModify.TabIndex = 60
        Me.butModify.Text = "Modify"
        Me.butModify.UseVisualStyleBackColor = False
        '
        'DG1
        '
        Me.DG1.BackgroundColor = System.Drawing.Color.White
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(1043, 13)
        Me.DG1.Margin = New System.Windows.Forms.Padding(4)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(479, 616)
        Me.DG1.TabIndex = 62
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butSave.Location = New System.Drawing.Point(142, 660)
        Me.butSave.Margin = New System.Windows.Forms.Padding(4)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(119, 34)
        Me.butSave.TabIndex = 59
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'butNew
        '
        Me.butNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.butNew.Location = New System.Drawing.Point(16, 660)
        Me.butNew.Margin = New System.Windows.Forms.Padding(4)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(119, 34)
        Me.butNew.TabIndex = 41
        Me.butNew.Text = "New"
        Me.butNew.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 649)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1151, 56)
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(632, 97)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 24)
        Me.TextBox2.TabIndex = 47
        Me.TextBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Supplier Code"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(179, 41)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 24)
        Me.TextBox1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "BillNo"
        '
        'PurchaseImportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1719, 826)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PurchaseImportForm"
        Me.Text = "PurchaseImportForm"
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butPrint As System.Windows.Forms.Button
    Friend WithEvents DG2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtT3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtT2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtT1 As System.Windows.Forms.TextBox
    Friend WithEvents butAdd As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PP1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTot As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents bDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTax As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents TxtRate As System.Windows.Forms.TextBox
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents butList As System.Windows.Forms.Button
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents butModify As System.Windows.Forms.Button
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents butNew As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
