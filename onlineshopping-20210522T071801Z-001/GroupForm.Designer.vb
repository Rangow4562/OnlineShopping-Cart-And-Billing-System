<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroupForm
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
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butDelete = New System.Windows.Forms.Button()
        Me.butModify = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.butNew = New System.Windows.Forms.Button()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butClose
        '
        Me.butClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butClose.Location = New System.Drawing.Point(1338, 475)
        Me.butClose.Name = "butClose"
        Me.butClose.Size = New System.Drawing.Size(87, 33)
        Me.butClose.TabIndex = 51
        Me.butClose.Text = "Close"
        Me.butClose.UseVisualStyleBackColor = False
        '
        'butList
        '
        Me.butList.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butList.Location = New System.Drawing.Point(1050, 475)
        Me.butList.Name = "butList"
        Me.butList.Size = New System.Drawing.Size(87, 33)
        Me.butList.TabIndex = 50
        Me.butList.Text = "List"
        Me.butList.UseVisualStyleBackColor = False
        '
        'DG1
        '
        Me.DG1.BackgroundColor = System.Drawing.Color.White
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(1050, 43)
        Me.DG1.Name = "DG1"
        Me.DG1.RowTemplate.Height = 24
        Me.DG1.Size = New System.Drawing.Size(375, 359)
        Me.DG1.TabIndex = 49
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(314, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(266, 22)
        Me.TextBox2.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(314, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 22)
        Me.TextBox1.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(149, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Group Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(149, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Group Name"
        '
        'butDelete
        '
        Me.butDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butDelete.Location = New System.Drawing.Point(461, 459)
        Me.butDelete.Name = "butDelete"
        Me.butDelete.Size = New System.Drawing.Size(87, 33)
        Me.butDelete.TabIndex = 41
        Me.butDelete.Text = "Delete"
        Me.butDelete.UseVisualStyleBackColor = False
        '
        'butModify
        '
        Me.butModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butModify.Location = New System.Drawing.Point(363, 459)
        Me.butModify.Name = "butModify"
        Me.butModify.Size = New System.Drawing.Size(92, 33)
        Me.butModify.TabIndex = 44
        Me.butModify.Text = "Modify"
        Me.butModify.UseVisualStyleBackColor = False
        '
        'butSave
        '
        Me.butSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butSave.Location = New System.Drawing.Point(258, 459)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(99, 33)
        Me.butSave.TabIndex = 43
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = False
        '
        'butNew
        '
        Me.butNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.butNew.Location = New System.Drawing.Point(155, 459)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(97, 33)
        Me.butNew.TabIndex = 42
        Me.butNew.Text = "New"
        Me.butNew.UseVisualStyleBackColor = False
        '
        'GroupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1564, 551)
        Me.Controls.Add(Me.butClose)
        Me.Controls.Add(Me.butList)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butDelete)
        Me.Controls.Add(Me.butModify)
        Me.Controls.Add(Me.butSave)
        Me.Controls.Add(Me.butNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "GroupForm"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butClose As System.Windows.Forms.Button
    Friend WithEvents butList As System.Windows.Forms.Button
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butDelete As System.Windows.Forms.Button
    Friend WithEvents butModify As System.Windows.Forms.Button
    Friend WithEvents butSave As System.Windows.Forms.Button
    Friend WithEvents butNew As System.Windows.Forms.Button
End Class
