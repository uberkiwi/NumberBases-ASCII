<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseConvert
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
        Me.Base10 = New System.Windows.Forms.TextBox()
        Me.Base10Label = New System.Windows.Forms.Label()
        Me.Base2Label = New System.Windows.Forms.Label()
        Me.Base2 = New System.Windows.Forms.TextBox()
        Me.Base16Label = New System.Windows.Forms.Label()
        Me.Base16 = New System.Windows.Forms.TextBox()
        Me.RunBtn = New System.Windows.Forms.Button()
        Me.Base10Chk = New System.Windows.Forms.CheckBox()
        Me.Base2Chk = New System.Windows.Forms.CheckBox()
        Me.Base16Chk = New System.Windows.Forms.CheckBox()
        Me.ASCII = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ASCIIchk = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Base10
        '
        Me.Base10.Location = New System.Drawing.Point(69, 12)
        Me.Base10.Name = "Base10"
        Me.Base10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Base10.Size = New System.Drawing.Size(236, 20)
        Me.Base10.TabIndex = 0
        Me.Base10.Text = "0"
        Me.Base10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Base10Label
        '
        Me.Base10Label.AutoSize = True
        Me.Base10Label.Location = New System.Drawing.Point(15, 17)
        Me.Base10Label.Name = "Base10Label"
        Me.Base10Label.Size = New System.Drawing.Size(43, 13)
        Me.Base10Label.TabIndex = 1
        Me.Base10Label.Text = "Base10"
        '
        'Base2Label
        '
        Me.Base2Label.AutoSize = True
        Me.Base2Label.Location = New System.Drawing.Point(19, 43)
        Me.Base2Label.Name = "Base2Label"
        Me.Base2Label.Size = New System.Drawing.Size(37, 13)
        Me.Base2Label.TabIndex = 3
        Me.Base2Label.Text = "Base2"
        '
        'Base2
        '
        Me.Base2.Location = New System.Drawing.Point(69, 38)
        Me.Base2.Name = "Base2"
        Me.Base2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Base2.Size = New System.Drawing.Size(236, 20)
        Me.Base2.TabIndex = 2
        Me.Base2.Text = "0"
        Me.Base2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Base16Label
        '
        Me.Base16Label.AutoSize = True
        Me.Base16Label.Location = New System.Drawing.Point(15, 69)
        Me.Base16Label.Name = "Base16Label"
        Me.Base16Label.Size = New System.Drawing.Size(43, 13)
        Me.Base16Label.TabIndex = 5
        Me.Base16Label.Text = "Base16"
        '
        'Base16
        '
        Me.Base16.Location = New System.Drawing.Point(69, 64)
        Me.Base16.Name = "Base16"
        Me.Base16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Base16.Size = New System.Drawing.Size(236, 20)
        Me.Base16.TabIndex = 4
        Me.Base16.Text = "0"
        Me.Base16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RunBtn
        '
        Me.RunBtn.Location = New System.Drawing.Point(22, 117)
        Me.RunBtn.Name = "RunBtn"
        Me.RunBtn.Size = New System.Drawing.Size(289, 33)
        Me.RunBtn.TabIndex = 6
        Me.RunBtn.Text = "Run"
        Me.RunBtn.UseMnemonic = False
        Me.RunBtn.UseVisualStyleBackColor = True
        '
        'Base10Chk
        '
        Me.Base10Chk.AutoSize = True
        Me.Base10Chk.Location = New System.Drawing.Point(311, 16)
        Me.Base10Chk.Name = "Base10Chk"
        Me.Base10Chk.Size = New System.Drawing.Size(15, 14)
        Me.Base10Chk.TabIndex = 7
        Me.Base10Chk.UseVisualStyleBackColor = True
        '
        'Base2Chk
        '
        Me.Base2Chk.AutoSize = True
        Me.Base2Chk.Location = New System.Drawing.Point(311, 42)
        Me.Base2Chk.Name = "Base2Chk"
        Me.Base2Chk.Size = New System.Drawing.Size(15, 14)
        Me.Base2Chk.TabIndex = 8
        Me.Base2Chk.UseVisualStyleBackColor = True
        '
        'Base16Chk
        '
        Me.Base16Chk.AutoSize = True
        Me.Base16Chk.Location = New System.Drawing.Point(311, 68)
        Me.Base16Chk.Name = "Base16Chk"
        Me.Base16Chk.Size = New System.Drawing.Size(15, 14)
        Me.Base16Chk.TabIndex = 9
        Me.Base16Chk.UseVisualStyleBackColor = True
        '
        'ASCII
        '
        Me.ASCII.Location = New System.Drawing.Point(69, 90)
        Me.ASCII.Name = "ASCII"
        Me.ASCII.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ASCII.Size = New System.Drawing.Size(236, 20)
        Me.ASCII.TabIndex = 10
        Me.ASCII.Text = "0"
        Me.ASCII.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ASCII"
        '
        'ASCIIchk
        '
        Me.ASCIIchk.AutoSize = True
        Me.ASCIIchk.Location = New System.Drawing.Point(311, 93)
        Me.ASCIIchk.Name = "ASCIIchk"
        Me.ASCIIchk.Size = New System.Drawing.Size(15, 14)
        Me.ASCIIchk.TabIndex = 12
        Me.ASCIIchk.UseVisualStyleBackColor = True
        '
        'BaseConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 162)
        Me.Controls.Add(Me.ASCIIchk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ASCII)
        Me.Controls.Add(Me.Base16Chk)
        Me.Controls.Add(Me.Base2Chk)
        Me.Controls.Add(Me.Base10Chk)
        Me.Controls.Add(Me.RunBtn)
        Me.Controls.Add(Me.Base16Label)
        Me.Controls.Add(Me.Base16)
        Me.Controls.Add(Me.Base2Label)
        Me.Controls.Add(Me.Base2)
        Me.Controls.Add(Me.Base10Label)
        Me.Controls.Add(Me.Base10)
        Me.Name = "BaseConvert"
        Me.Text = "BaseConvert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Base10 As TextBox
    Friend WithEvents Base10Label As Label
    Friend WithEvents Base2Label As Label
    Friend WithEvents Base2 As TextBox
    Friend WithEvents Base16Label As Label
    Friend WithEvents Base16 As TextBox
    Friend WithEvents RunBtn As Button
    Friend WithEvents Base10Chk As CheckBox
    Friend WithEvents Base2Chk As CheckBox
    Friend WithEvents Base16Chk As CheckBox
    Friend WithEvents ASCII As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ASCIIchk As CheckBox
End Class
