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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUid = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(257, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(234, 86)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        Me.lblName.Visible = False
        '
        'lblUid
        '
        Me.lblUid.AutoSize = True
        Me.lblUid.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUid.ForeColor = System.Drawing.Color.Red
        Me.lblUid.Location = New System.Drawing.Point(273, 159)
        Me.lblUid.Name = "lblUid"
        Me.lblUid.Size = New System.Drawing.Size(139, 54)
        Me.lblUid.TabIndex = 1
        Me.lblUid.Text = "Label2"
        Me.lblUid.Visible = False
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblphone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblphone.Location = New System.Drawing.Point(283, 248)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(104, 41)
        Me.lblphone.TabIndex = 2
        Me.lblphone.Text = "Label3"
        Me.lblphone.Visible = False
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLoc.Location = New System.Drawing.Point(283, 313)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(104, 41)
        Me.lblLoc.TabIndex = 3
        Me.lblLoc.Text = "Label4"
        Me.lblLoc.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(62, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(861, 80)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Resolve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(62, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(62, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Unique ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(62, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 32)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(62, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 32)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Location"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(62, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(283, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label4"
        Me.Label2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 535)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lblUid)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "College Safety"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblUid As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
