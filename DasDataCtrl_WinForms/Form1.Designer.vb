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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTestMe = New System.Windows.Forms.Button()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDSKey = New System.Windows.Forms.TextBox()
        Me.txtAKey = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "New line"
        '
        'txtLine
        '
        Me.txtLine.Location = New System.Drawing.Point(204, 133)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(379, 20)
        Me.txtLine.TabIndex = 16
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(601, 133)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 15
        Me.btnAddNew.Text = "Add new"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(128, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 354)
        Me.DataGridView1.TabIndex = 14
        '
        'btnTestMe
        '
        Me.btnTestMe.Location = New System.Drawing.Point(601, 190)
        Me.btnTestMe.Name = "btnTestMe"
        Me.btnTestMe.Size = New System.Drawing.Size(75, 23)
        Me.btnTestMe.TabIndex = 13
        Me.btnTestMe.Text = "Test"
        Me.btnTestMe.UseVisualStyleBackColor = True
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(125, 85)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(41, 13)
        Me.label22.TabIndex = 12
        Me.label22.Text = "ds guid"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "access key"
        '
        'txtDSKey
        '
        Me.txtDSKey.Location = New System.Drawing.Point(204, 82)
        Me.txtDSKey.Name = "txtDSKey"
        Me.txtDSKey.Size = New System.Drawing.Size(379, 20)
        Me.txtDSKey.TabIndex = 10
        '
        'txtAKey
        '
        Me.txtAKey.Location = New System.Drawing.Point(204, 37)
        Me.txtAKey.Name = "txtAKey"
        Me.txtAKey.Size = New System.Drawing.Size(379, 20)
        Me.txtAKey.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 611)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLine)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTestMe)
        Me.Controls.Add(Me.label22)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDSKey)
        Me.Controls.Add(Me.txtAKey)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtLine As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTestMe As Button
    Friend WithEvents label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDSKey As TextBox
    Friend WithEvents txtAKey As TextBox
End Class
