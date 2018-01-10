<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTitle
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
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSingle
        '
        Me.btnSingle.Location = New System.Drawing.Point(195, 42)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(166, 96)
        Me.btnSingle.TabIndex = 0
        Me.btnSingle.Text = "Single Player"
        Me.btnSingle.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(12, 289)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(133, 59)
        Me.btnInstructions.TabIndex = 1
        Me.btnInstructions.Text = "How to play"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'btnHighScores
        '
        Me.btnHighScores.Location = New System.Drawing.Point(413, 289)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(133, 59)
        Me.btnHighScores.TabIndex = 2
        Me.btnHighScores.Text = "High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(195, 144)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(166, 96)
        Me.btnMulti.TabIndex = 3
        Me.btnMulti.Text = "Multiplayer"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'formTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 360)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnSingle)
        Me.KeyPreview = True
        Me.Name = "formTitle"
        Me.Text = "ICS2O Trivia!!!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSingle As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnHighScores As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
End Class
