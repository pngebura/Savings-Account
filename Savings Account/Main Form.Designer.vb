<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.principalLabel = New System.Windows.Forms.Label()
        Me.principalTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.balanceListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'principalLabel
        '
        Me.principalLabel.AutoSize = True
        Me.principalLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.principalLabel.Location = New System.Drawing.Point(76, 25)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Size = New System.Drawing.Size(79, 23)
        Me.principalLabel.TabIndex = 0
        Me.principalLabel.Text = "&Principal:"
        Me.principalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'principalTextBox
        '
        Me.principalTextBox.Location = New System.Drawing.Point(156, 21)
        Me.principalTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Size = New System.Drawing.Size(79, 29)
        Me.principalTextBox.TabIndex = 1
        Me.principalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(25, 85)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 52)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(165, 85)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(120, 52)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'balanceListBox
        '
        Me.balanceListBox.FormattingEnabled = True
        Me.balanceListBox.ItemHeight = 21
        Me.balanceListBox.Location = New System.Drawing.Point(13, 169)
        Me.balanceListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.balanceListBox.Name = "balanceListBox"
        Me.balanceListBox.Size = New System.Drawing.Size(285, 340)
        Me.balanceListBox.TabIndex = 4
        Me.balanceListBox.TabStop = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 519)
        Me.Controls.Add(Me.balanceListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.principalTextBox)
        Me.Controls.Add(Me.principalLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents principalLabel As Label
    Friend WithEvents principalTextBox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents balanceListBox As ListBox
End Class
