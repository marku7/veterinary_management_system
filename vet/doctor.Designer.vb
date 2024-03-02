<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctor
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
        Me.docImage = New System.Windows.Forms.PictureBox()
        Me.vetName = New System.Windows.Forms.Label()
        Me.specialization = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.docphone = New System.Windows.Forms.Label()
        Me.docEmail = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Label()
        Me.sched = New System.Windows.Forms.Label()
        CType(Me.docImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'docImage
        '
        Me.docImage.Location = New System.Drawing.Point(28, 28)
        Me.docImage.Margin = New System.Windows.Forms.Padding(4)
        Me.docImage.Name = "docImage"
        Me.docImage.Size = New System.Drawing.Size(360, 331)
        Me.docImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.docImage.TabIndex = 1
        Me.docImage.TabStop = False
        '
        'vetName
        '
        Me.vetName.AutoSize = True
        Me.vetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vetName.Location = New System.Drawing.Point(416, 28)
        Me.vetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vetName.Name = "vetName"
        Me.vetName.Size = New System.Drawing.Size(111, 36)
        Me.vetName.TabIndex = 2
        Me.vetName.Text = "Label1"
        '
        'specialization
        '
        Me.specialization.AutoSize = True
        Me.specialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialization.Location = New System.Drawing.Point(418, 81)
        Me.specialization.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.specialization.Name = "specialization"
        Me.specialization.Size = New System.Drawing.Size(71, 25)
        Me.specialization.TabIndex = 3
        Me.specialization.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Doctor's Fee:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(552, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "fee"
        '
        'docphone
        '
        Me.docphone.AutoSize = True
        Me.docphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.docphone.Location = New System.Drawing.Point(416, 237)
        Me.docphone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.docphone.Name = "docphone"
        Me.docphone.Size = New System.Drawing.Size(67, 25)
        Me.docphone.TabIndex = 6
        Me.docphone.Text = "phone"
        '
        'docEmail
        '
        Me.docEmail.AutoSize = True
        Me.docEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.docEmail.Location = New System.Drawing.Point(419, 274)
        Me.docEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.docEmail.Name = "docEmail"
        Me.docEmail.Size = New System.Drawing.Size(58, 25)
        Me.docEmail.TabIndex = 7
        Me.docEmail.Text = "email"
        '
        'add
        '
        Me.add.AutoSize = True
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.Location = New System.Drawing.Point(419, 315)
        Me.add.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(45, 25)
        Me.add.TabIndex = 8
        Me.add.Text = "add"
        '
        'sched
        '
        Me.sched.AutoSize = True
        Me.sched.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sched.Location = New System.Drawing.Point(418, 151)
        Me.sched.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sched.Name = "sched"
        Me.sched.Size = New System.Drawing.Size(65, 25)
        Me.sched.TabIndex = 9
        Me.sched.Text = "sched"
        '
        'doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 416)
        Me.Controls.Add(Me.sched)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.docEmail)
        Me.Controls.Add(Me.docphone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.specialization)
        Me.Controls.Add(Me.vetName)
        Me.Controls.Add(Me.docImage)
        Me.Name = "doctor"
        Me.Text = "doctor"
        CType(Me.docImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents docImage As System.Windows.Forms.PictureBox
    Friend WithEvents vetName As System.Windows.Forms.Label
    Friend WithEvents specialization As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents docphone As System.Windows.Forms.Label
    Friend WithEvents docEmail As System.Windows.Forms.Label
    Friend WithEvents add As System.Windows.Forms.Label
    Friend WithEvents sched As System.Windows.Forms.Label
End Class
