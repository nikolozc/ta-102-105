<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnShowPerson = New System.Windows.Forms.Button()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.txtBoxLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxYearsBF = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowPerson
        '
        Me.btnShowPerson.Location = New System.Drawing.Point(12, 200)
        Me.btnShowPerson.Name = "btnShowPerson"
        Me.btnShowPerson.Size = New System.Drawing.Size(168, 23)
        Me.btnShowPerson.TabIndex = 0
        Me.btnShowPerson.Text = "Show Person"
        Me.btnShowPerson.UseVisualStyleBackColor = True
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(14, 27)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(166, 23)
        Me.txtBoxFirstName.TabIndex = 1
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.Location = New System.Drawing.Point(12, 94)
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.Size = New System.Drawing.Size(168, 23)
        Me.txtBoxLastName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last  Name:"
        '
        'txtBoxYearsBF
        '
        Me.txtBoxYearsBF.Location = New System.Drawing.Point(15, 157)
        Me.txtBoxYearsBF.Name = "txtBoxYearsBF"
        Me.txtBoxYearsBF.Size = New System.Drawing.Size(165, 23)
        Me.txtBoxYearsBF.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Years Being Friends:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 242)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxYearsBF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoxLastName)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Controls.Add(Me.btnShowPerson)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowPerson As Button
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxYearsBF As TextBox
    Friend WithEvents Label3 As Label
End Class
