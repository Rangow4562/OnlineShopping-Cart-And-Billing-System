<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Me.butClose = New System.Windows.Forms.Button()
        Me.butList = New System.Windows.Forms.Button()
        Me.butDelete = New System.Windows.Forms.Button()
        Me.butModify = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.butNew = New System.Windows.Forms.Button()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butClose
        '
        Me.butClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butClose.Location = New System.Drawing.Point(1409, 513)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(87, 33)
        Me.butClose.TabIndex = 26
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = False
        '
        'butList
        '
        Me.butList.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butList.Location = New System.Drawing.Point(1121, 513)
        Me.butList.Name = "butList"
        Me.butList.Size = New System.Drawing.Size(87, 33)
        Me.butList.TabIndex = 25
        Me.butList.Text = "List"
        Me.butList.UseVisualStyleBackColor = False
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butDelete.Location = New System.Drawing.Point(528, 513)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(87, 33)
        Me.butDelete.TabIndex = 24
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = False
        '
        'butModify
        '
        Me.butModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butModify.Location = New System.Drawing.Point(430, 513)
        Me.butModify.Name = "butModify"
        Me.butModify.Size = New System.Drawing.Size(92, 33)
        Me.butModify.TabIndex = 29
        Me.butModify.Text = "Modify"
        Me.butModify.UseVisualStyleBackColor = False
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butSave.Location = New System.Drawing.Point(325, 513)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(99, 33)
        Me.butSave.TabIndex = 28
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'butNew
        '
        Me.butNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butNew.Location = New System.Drawing.Point(222, 513)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(97, 33)
        Me.butNew.TabIndex = 27
        Me.butNew.Text = "New"
        Me.butNew.UseVisualStyleBackColor = False
        '
        'DG1
        '
        Me.DG1.BackgroundColor = System.Drawing.Color.White
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(1121, 81)
        Me.DG1.Name = "DG1"
        Me.DG1.RowTemplate.Height = 24
        Me.DG1.Size = New System.Drawing.Size(375, 359)
        Me.DG1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(219, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "eMail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(216, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Phone No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(220, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pincode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(219, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(213, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Supplier Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(213, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Supplier Code"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(366, 418)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(249, 22)
        Me.TextBox8.TabIndex = 11
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(366, 358)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(249, 22)
        Me.TextBox7.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(366, 309)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(249, 22)
        Me.TextBox6.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(366, 268)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(249, 22)
        Me.TextBox5.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(366, 222)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(249, 22)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(366, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(249, 22)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(366, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(249, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(366, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(249, 22)
        Me.TextBox1.TabIndex = 14
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1708, 626)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butList)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butModify)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butNew)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SupplierForm"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents butList As System.Windows.Forms.Button
    Friend WithEvents butDelete As System.Windows.Forms.Button
    Friend WithEvents butModify As System.Windows.Forms.Button
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents butNew As System.Windows.Forms.Button
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

    Private Sub butNew_Click(sender As System.Object, e As System.EventArgs) Handles butNew.Click

    End Sub
End Class
