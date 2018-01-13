<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInstructions
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
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.lblHallOfFame = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(210, 474)
        Me.btnMulti.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(161, 32)
        Me.btnMulti.TabIndex = 1
        Me.btnMulti.Text = "Multiplayer"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnSingle
        '
        Me.btnSingle.Location = New System.Drawing.Point(28, 474)
        Me.btnSingle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(161, 32)
        Me.btnSingle.TabIndex = 0
        Me.btnSingle.Text = "Single Player"
        Me.btnSingle.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(28, 78)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(344, 38)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "Single Player"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInstructions
        '
        Me.txtInstructions.BackColor = System.Drawing.Color.Green
        Me.txtInstructions.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructions.ForeColor = System.Drawing.SystemColors.Info
        Me.txtInstructions.Location = New System.Drawing.Point(28, 127)
        Me.txtInstructions.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(344, 331)
        Me.txtInstructions.TabIndex = 2
        '
        'lblHallOfFame
        '
        Me.lblHallOfFame.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHallOfFame.Location = New System.Drawing.Point(28, 24)
        Me.lblHallOfFame.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHallOfFame.Name = "lblHallOfFame"
        Me.lblHallOfFame.Size = New System.Drawing.Size(344, 54)
        Me.lblHallOfFame.TabIndex = 3
        Me.lblHallOfFame.Text = "Instructions on how to play"
        Me.lblHallOfFame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 531)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSingle)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.lblHallOfFame)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formInstructions"
        Me.Text = "How to Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnSingle As System.Windows.Forms.Button
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents lblHallOfFame As System.Windows.Forms.Label
End Class
