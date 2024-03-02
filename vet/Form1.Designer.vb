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
        Me.recordsList = New System.Windows.Forms.ListView()
        Me.no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.petName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diagnosis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.owner = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.note = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'recordsList
        '
        Me.recordsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.no, Me.petName, Me.type, Me.gender, Me.diagnosis, Me.note, Me.owner, Me.vet, Me.dateCreated})
        Me.recordsList.FullRowSelect = True
        Me.recordsList.GridLines = True
        Me.recordsList.Location = New System.Drawing.Point(12, 68)
        Me.recordsList.Name = "recordsList"
        Me.recordsList.Size = New System.Drawing.Size(1088, 473)
        Me.recordsList.TabIndex = 0
        Me.recordsList.UseCompatibleStateImageBehavior = False
        Me.recordsList.View = System.Windows.Forms.View.Details
        '
        'no
        '
        Me.no.Text = "No."
        Me.no.Width = 42
        '
        'petName
        '
        Me.petName.Text = "Pet Name"
        Me.petName.Width = 163
        '
        'type
        '
        Me.type.Text = "Type"
        Me.type.Width = 85
        '
        'gender
        '
        Me.gender.Text = "Gender"
        Me.gender.Width = 88
        '
        'diagnosis
        '
        Me.diagnosis.Text = "Diagnose"
        Me.diagnosis.Width = 110
        '
        'owner
        '
        Me.owner.Text = "Owner Name"
        Me.owner.Width = 167
        '
        'dateCreated
        '
        Me.dateCreated.Text = "Date Created"
        Me.dateCreated.Width = 169
        '
        'vet
        '
        Me.vet.Text = "Responsible Vet"
        Me.vet.Width = 152
        '
        'note
        '
        Me.note.Text = "Note"
        Me.note.Width = 88
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 551)
        Me.Controls.Add(Me.recordsList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents recordsList As System.Windows.Forms.ListView
    Friend WithEvents no As System.Windows.Forms.ColumnHeader
    Friend WithEvents petName As System.Windows.Forms.ColumnHeader
    Friend WithEvents type As System.Windows.Forms.ColumnHeader
    Friend WithEvents gender As System.Windows.Forms.ColumnHeader
    Friend WithEvents diagnosis As System.Windows.Forms.ColumnHeader
    Friend WithEvents owner As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateCreated As System.Windows.Forms.ColumnHeader
    Friend WithEvents vet As System.Windows.Forms.ColumnHeader
    Friend WithEvents note As System.Windows.Forms.ColumnHeader

End Class
