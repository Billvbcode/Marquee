<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColor
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
        Me.HSRed = New System.Windows.Forms.HScrollBar()
        Me.HSGreen = New System.Windows.Forms.HScrollBar()
        Me.HSBlue = New System.Windows.Forms.HScrollBar()
        Me.LblRed = New System.Windows.Forms.Label()
        Me.LblGreen = New System.Windows.Forms.Label()
        Me.LblBlue = New System.Windows.Forms.Label()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.BtnSignR = New System.Windows.Forms.Button()
        Me.BtnSignL = New System.Windows.Forms.Button()
        Me.LblMarquee = New System.Windows.Forms.Label()
        Me.TimSign = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'HSRed
        '
        Me.HSRed.Location = New System.Drawing.Point(39, 36)
        Me.HSRed.Maximum = 264
        Me.HSRed.Name = "HSRed"
        Me.HSRed.Size = New System.Drawing.Size(307, 45)
        Me.HSRed.TabIndex = 1
        '
        'HSGreen
        '
        Me.HSGreen.Location = New System.Drawing.Point(39, 111)
        Me.HSGreen.Maximum = 264
        Me.HSGreen.Name = "HSGreen"
        Me.HSGreen.Size = New System.Drawing.Size(307, 45)
        Me.HSGreen.TabIndex = 2
        '
        'HSBlue
        '
        Me.HSBlue.Location = New System.Drawing.Point(39, 184)
        Me.HSBlue.Maximum = 264
        Me.HSBlue.Name = "HSBlue"
        Me.HSBlue.Size = New System.Drawing.Size(307, 45)
        Me.HSBlue.TabIndex = 3
        '
        'LblRed
        '
        Me.LblRed.AutoSize = True
        Me.LblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRed.Location = New System.Drawing.Point(408, 48)
        Me.LblRed.Name = "LblRed"
        Me.LblRed.Size = New System.Drawing.Size(66, 20)
        Me.LblRed.TabIndex = 4
        Me.LblRed.Text = "LblRed"
        '
        'LblGreen
        '
        Me.LblGreen.AutoSize = True
        Me.LblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGreen.Location = New System.Drawing.Point(408, 130)
        Me.LblGreen.Name = "LblGreen"
        Me.LblGreen.Size = New System.Drawing.Size(83, 20)
        Me.LblGreen.TabIndex = 5
        Me.LblGreen.Text = "LblGreen"
        '
        'LblBlue
        '
        Me.LblBlue.AutoSize = True
        Me.LblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlue.Location = New System.Drawing.Point(408, 197)
        Me.LblBlue.Name = "LblBlue"
        Me.LblBlue.Size = New System.Drawing.Size(69, 20)
        Me.LblBlue.TabIndex = 6
        Me.LblBlue.Text = "LblBlue"
        '
        'LblColor
        '
        Me.LblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColor.Location = New System.Drawing.Point(590, 77)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(129, 133)
        Me.LblColor.TabIndex = 7
        Me.LblColor.Text = "Color"
        '
        'BtnSignR
        '
        Me.BtnSignR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignR.Location = New System.Drawing.Point(74, 281)
        Me.BtnSignR.Name = "BtnSignR"
        Me.BtnSignR.Size = New System.Drawing.Size(75, 34)
        Me.BtnSignR.TabIndex = 8
        Me.BtnSignR.Text = "SignR"
        Me.BtnSignR.UseVisualStyleBackColor = True
        '
        'BtnSignL
        '
        Me.BtnSignL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignL.Location = New System.Drawing.Point(412, 281)
        Me.BtnSignL.Name = "BtnSignL"
        Me.BtnSignL.Size = New System.Drawing.Size(75, 34)
        Me.BtnSignL.TabIndex = 9
        Me.BtnSignL.Text = "SignL"
        Me.BtnSignL.UseVisualStyleBackColor = True
        '
        'LblMarquee
        '
        Me.LblMarquee.AutoSize = True
        Me.LblMarquee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarquee.Location = New System.Drawing.Point(172, 355)
        Me.LblMarquee.Name = "LblMarquee"
        Me.LblMarquee.Size = New System.Drawing.Size(235, 20)
        Me.LblMarquee.TabIndex = 10
        Me.LblMarquee.Text = "Hope you have a great day…."
        '
        'TimSign
        '
        Me.TimSign.Interval = 200
        '
        'FrmColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblMarquee)
        Me.Controls.Add(Me.BtnSignL)
        Me.Controls.Add(Me.BtnSignR)
        Me.Controls.Add(Me.LblColor)
        Me.Controls.Add(Me.LblBlue)
        Me.Controls.Add(Me.LblGreen)
        Me.Controls.Add(Me.LblRed)
        Me.Controls.Add(Me.HSBlue)
        Me.Controls.Add(Me.HSGreen)
        Me.Controls.Add(Me.HSRed)
        Me.Name = "FrmColor"
        Me.Text = "Color"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HSRed As HScrollBar
    Friend WithEvents HSGreen As HScrollBar
    Friend WithEvents HSBlue As HScrollBar
    Friend WithEvents LblRed As Label
    Friend WithEvents LblGreen As Label
    Friend WithEvents LblBlue As Label
    Friend WithEvents LblColor As Label
    Friend WithEvents BtnSignR As Button
    Friend WithEvents BtnSignL As Button
    Friend WithEvents LblMarquee As Label
    Friend WithEvents TimSign As Timer
End Class
