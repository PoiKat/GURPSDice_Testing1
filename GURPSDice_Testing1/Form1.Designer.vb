<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSkill = New System.Windows.Forms.TextBox()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.lblBonPen = New System.Windows.Forms.Label()
        Me.txtBonPen = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lblRolls = New System.Windows.Forms.Label()
        Me.txtQuantRolls = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(15, 261)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(248, 41)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSkill
        '
        Me.txtSkill.Location = New System.Drawing.Point(216, 12)
        Me.txtSkill.Name = "txtSkill"
        Me.txtSkill.Size = New System.Drawing.Size(47, 33)
        Me.txtSkill.TabIndex = 1
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.Location = New System.Drawing.Point(12, 15)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(158, 26)
        Me.lblSkill.TabIndex = 2
        Me.lblSkill.Text = "Enter Skill Level:"
        '
        'lblBonPen
        '
        Me.lblBonPen.AutoSize = True
        Me.lblBonPen.Location = New System.Drawing.Point(12, 61)
        Me.lblBonPen.Name = "lblBonPen"
        Me.lblBonPen.Size = New System.Drawing.Size(198, 26)
        Me.lblBonPen.TabIndex = 4
        Me.lblBonPen.Text = "Enter Bonus/Penalty:"
        '
        'txtBonPen
        '
        Me.txtBonPen.Location = New System.Drawing.Point(216, 58)
        Me.txtBonPen.Name = "txtBonPen"
        Me.txtBonPen.Size = New System.Drawing.Size(47, 33)
        Me.txtBonPen.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(15, 208)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(248, 41)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(15, 155)
        Me.btnRoll.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(248, 41)
        Me.btnRoll.TabIndex = 6
        Me.btnRoll.Text = "Roll the Dice!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 26
        Me.lstResults.Location = New System.Drawing.Point(272, 12)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(514, 290)
        Me.lstResults.TabIndex = 7
        '
        'lblRolls
        '
        Me.lblRolls.AutoSize = True
        Me.lblRolls.Location = New System.Drawing.Point(12, 107)
        Me.lblRolls.Name = "lblRolls"
        Me.lblRolls.Size = New System.Drawing.Size(157, 26)
        Me.lblRolls.TabIndex = 9
        Me.lblRolls.Text = "How many rolls?"
        '
        'txtQuantRolls
        '
        Me.txtQuantRolls.Location = New System.Drawing.Point(216, 104)
        Me.txtQuantRolls.Name = "txtQuantRolls"
        Me.txtQuantRolls.Size = New System.Drawing.Size(47, 33)
        Me.txtQuantRolls.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 314)
        Me.Controls.Add(Me.lblRolls)
        Me.Controls.Add(Me.txtQuantRolls)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblBonPen)
        Me.Controls.Add(Me.txtBonPen)
        Me.Controls.Add(Me.lblSkill)
        Me.Controls.Add(Me.txtSkill)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents txtSkill As TextBox
    Friend WithEvents lblSkill As Label
    Friend WithEvents lblBonPen As Label
    Friend WithEvents txtBonPen As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lblRolls As Label
    Friend WithEvents txtQuantRolls As TextBox
End Class
