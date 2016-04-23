<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cbDomain = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDistrict = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTown = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMedEstblName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMedEstblType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbDomain
        '
        Me.cbDomain.FormattingEnabled = True
        Me.cbDomain.Location = New System.Drawing.Point(159, 15)
        Me.cbDomain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDomain.Name = "cbDomain"
        Me.cbDomain.Size = New System.Drawing.Size(283, 24)
        Me.cbDomain.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Област:"
        '
        'cbDistrict
        '
        Me.cbDistrict.FormattingEnabled = True
        Me.cbDistrict.Location = New System.Drawing.Point(159, 65)
        Me.cbDistrict.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDistrict.Name = "cbDistrict"
        Me.cbDistrict.Size = New System.Drawing.Size(283, 24)
        Me.cbDistrict.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Община:"
        '
        'cbTown
        '
        Me.cbTown.FormattingEnabled = True
        Me.cbTown.Location = New System.Drawing.Point(159, 116)
        Me.cbTown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTown.Name = "cbTown"
        Me.cbTown.Size = New System.Drawing.Size(283, 24)
        Me.cbTown.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "населено място:"
        '
        'tbMedEstblName
        '
        Me.tbMedEstblName.Location = New System.Drawing.Point(159, 171)
        Me.tbMedEstblName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMedEstblName.Name = "tbMedEstblName"
        Me.tbMedEstblName.Size = New System.Drawing.Size(604, 22)
        Me.tbMedEstblName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "лечебно заведение:"
        '
        'cbMedEstblType
        '
        Me.cbMedEstblType.FormattingEnabled = True
        Me.cbMedEstblType.Location = New System.Drawing.Point(159, 223)
        Me.cbMedEstblType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMedEstblType.Name = "cbMedEstblType"
        Me.cbMedEstblType.Size = New System.Drawing.Size(160, 24)
        Me.cbMedEstblType.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "тип на ЛЗ:"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(159, 268)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(604, 22)
        Me.tbAddress.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 273)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "адрес:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.Location = New System.Drawing.Point(313, 322)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 41)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "ЗАПИС"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(13, 322)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(241, 41)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "ИЗТРИВАНЕ НА ПОЛЕТАТА"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(677, 322)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 41)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(772, 375)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.cbMedEstblType)
        Me.Controls.Add(Me.tbMedEstblName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDistrict)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDomain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Добавяне на ЛЗ в базата данни"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbDomain As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDistrict As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTown As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMedEstblName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbMedEstblType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
End Class
