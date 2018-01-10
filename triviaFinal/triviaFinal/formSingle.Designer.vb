<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSingle
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.rbOption1 = New System.Windows.Forms.RadioButton()
        Me.rbOption2 = New System.Windows.Forms.RadioButton()
        Me.rbOption3 = New System.Windows.Forms.RadioButton()
        Me.rbOption0 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.groupOptions = New System.Windows.Forms.GroupBox()
        Me.timerAnswer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnNewRound = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.groupOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(15, 23)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(287, 133)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Question"
        '
        'rbOption1
        '
        Me.rbOption1.AutoSize = True
        Me.rbOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOption1.Location = New System.Drawing.Point(81, 85)
        Me.rbOption1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOption1.Name = "rbOption1"
        Me.rbOption1.Size = New System.Drawing.Size(93, 24)
        Me.rbOption1.TabIndex = 3
        Me.rbOption1.TabStop = True
        Me.rbOption1.Text = "Option 1"
        Me.rbOption1.UseVisualStyleBackColor = True
        '
        'rbOption2
        '
        Me.rbOption2.AutoSize = True
        Me.rbOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOption2.Location = New System.Drawing.Point(81, 118)
        Me.rbOption2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOption2.Name = "rbOption2"
        Me.rbOption2.Size = New System.Drawing.Size(93, 24)
        Me.rbOption2.TabIndex = 4
        Me.rbOption2.TabStop = True
        Me.rbOption2.Text = "Option 2"
        Me.rbOption2.UseVisualStyleBackColor = True
        '
        'rbOption3
        '
        Me.rbOption3.AutoSize = True
        Me.rbOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOption3.Location = New System.Drawing.Point(81, 151)
        Me.rbOption3.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOption3.Name = "rbOption3"
        Me.rbOption3.Size = New System.Drawing.Size(93, 24)
        Me.rbOption3.TabIndex = 5
        Me.rbOption3.TabStop = True
        Me.rbOption3.Text = "Option 3"
        Me.rbOption3.UseVisualStyleBackColor = True
        '
        'rbOption0
        '
        Me.rbOption0.AutoSize = True
        Me.rbOption0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOption0.Location = New System.Drawing.Point(81, 52)
        Me.rbOption0.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOption0.Name = "rbOption0"
        Me.rbOption0.Size = New System.Drawing.Size(93, 24)
        Me.rbOption0.TabIndex = 6
        Me.rbOption0.TabStop = True
        Me.rbOption0.Text = "Option 0"
        Me.rbOption0.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(231, 410)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(133, 46)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit!"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'groupOptions
        '
        Me.groupOptions.Controls.Add(Me.rbOption0)
        Me.groupOptions.Controls.Add(Me.rbOption1)
        Me.groupOptions.Controls.Add(Me.rbOption2)
        Me.groupOptions.Controls.Add(Me.rbOption3)
        Me.groupOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupOptions.Location = New System.Drawing.Point(20, 160)
        Me.groupOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.groupOptions.Name = "groupOptions"
        Me.groupOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.groupOptions.Size = New System.Drawing.Size(373, 219)
        Me.groupOptions.TabIndex = 8
        Me.groupOptions.TabStop = False
        Me.groupOptions.Text = "Options"
        '
        'timerAnswer
        '
        Me.timerAnswer.Interval = 25
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(327, 23)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 20)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time"
        '
        'btnNewRound
        '
        Me.btnNewRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRound.Location = New System.Drawing.Point(55, 410)
        Me.btnNewRound.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewRound.Name = "btnNewRound"
        Me.btnNewRound.Size = New System.Drawing.Size(133, 46)
        Me.btnNewRound.TabIndex = 10
        Me.btnNewRound.Text = "New round"
        Me.btnNewRound.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(16, 473)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(53, 20)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score"
        '
        'formSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 515)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnNewRound)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.groupOptions)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblQuestion)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formSingle"
        Me.Text = "Single Player"
        Me.groupOptions.ResumeLayout(False)
        Me.groupOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents rbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOption0 As System.Windows.Forms.RadioButton
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents groupOptions As System.Windows.Forms.GroupBox
    Friend WithEvents timerAnswer As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnNewRound As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label

End Class
