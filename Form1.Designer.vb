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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Storm1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Storm2 = New System.Windows.Forms.PictureBox()
        Me.Storm3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Storm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Storm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Storm3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 540)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Storm1
        '
        Me.Storm1.BackColor = System.Drawing.Color.Green
        Me.Storm1.Image = Global.SNAKEge.My.Resources.Resources._31323_7_storm_free_download
        Me.Storm1.Location = New System.Drawing.Point(51, 524)
        Me.Storm1.Name = "Storm1"
        Me.Storm1.Size = New System.Drawing.Size(82, 94)
        Me.Storm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Storm1.TabIndex = 1
        Me.Storm1.TabStop = False
        Me.Storm1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'Storm2
        '
        Me.Storm2.BackColor = System.Drawing.Color.Green
        Me.Storm2.Image = Global.SNAKEge.My.Resources.Resources._31323_7_storm_free_download
        Me.Storm2.Location = New System.Drawing.Point(757, 34)
        Me.Storm2.Name = "Storm2"
        Me.Storm2.Size = New System.Drawing.Size(82, 94)
        Me.Storm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Storm2.TabIndex = 2
        Me.Storm2.TabStop = False
        Me.Storm2.Visible = False
        '
        'Storm3
        '
        Me.Storm3.BackColor = System.Drawing.Color.Green
        Me.Storm3.Image = Global.SNAKEge.My.Resources.Resources._31323_7_storm_free_download
        Me.Storm3.Location = New System.Drawing.Point(728, 505)
        Me.Storm3.Name = "Storm3"
        Me.Storm3.Size = New System.Drawing.Size(82, 94)
        Me.Storm3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Storm3.TabIndex = 3
        Me.Storm3.TabStop = False
        Me.Storm3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Storm3)
        Me.Controls.Add(Me.Storm2)
        Me.Controls.Add(Me.Storm1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Snake Game Daw"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Storm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Storm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Storm3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Storm1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Storm2 As PictureBox
    Friend WithEvents Storm3 As PictureBox
End Class
