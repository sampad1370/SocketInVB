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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ipAddress = New System.Windows.Forms.MaskedTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.port = New System.Windows.Forms.NumericUpDown()
		Me.connect = New System.Windows.Forms.Button()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.recievedDataList = New System.Windows.Forms.RichTextBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.data = New System.Windows.Forms.NumericUpDown()
		Me.sendData = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(20, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "IP:"
		'
		'ipAddress
		'
		Me.ipAddress.Location = New System.Drawing.Point(32, 21)
		Me.ipAddress.Mask = "000.000.000.000"
		Me.ipAddress.Name = "ipAddress"
		Me.ipAddress.Size = New System.Drawing.Size(100, 20)
		Me.ipAddress.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(-3, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(29, 13)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Port:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.port)
		Me.GroupBox1.Controls.Add(Me.ipAddress)
		Me.GroupBox1.Controls.Add(Me.connect)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(143, 118)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Server Address:"
		'
		'port
		'
		Me.port.Location = New System.Drawing.Point(32, 47)
		Me.port.Maximum = New Decimal(New Integer() {65556, 0, 0, 0})
		Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.port.Name = "port"
		Me.port.Size = New System.Drawing.Size(46, 20)
		Me.port.TabIndex = 3
		Me.port.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'connect
		'
		Me.connect.Location = New System.Drawing.Point(32, 73)
		Me.connect.Name = "connect"
		Me.connect.Size = New System.Drawing.Size(100, 23)
		Me.connect.TabIndex = 3
		Me.connect.Text = "Connect"
		Me.connect.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.GroupBox5)
		Me.GroupBox2.Controls.Add(Me.GroupBox4)
		Me.GroupBox2.Controls.Add(Me.GroupBox1)
		Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox2.Location = New System.Drawing.Point(5, 5)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(444, 231)
		Me.GroupBox2.TabIndex = 4
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Connect To Server"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.recievedDataList)
		Me.GroupBox5.Location = New System.Drawing.Point(155, 19)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(282, 203)
		Me.GroupBox5.TabIndex = 1
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Recieved Data:"
		'
		'recievedDataList
		'
		Me.recievedDataList.Dock = System.Windows.Forms.DockStyle.Fill
		Me.recievedDataList.Location = New System.Drawing.Point(3, 16)
		Me.recievedDataList.Name = "recievedDataList"
		Me.recievedDataList.ReadOnly = True
		Me.recievedDataList.Size = New System.Drawing.Size(276, 184)
		Me.recievedDataList.TabIndex = 5
		Me.recievedDataList.Text = ""
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Label3)
		Me.GroupBox4.Controls.Add(Me.data)
		Me.GroupBox4.Controls.Add(Me.sendData)
		Me.GroupBox4.Location = New System.Drawing.Point(8, 143)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(141, 81)
		Me.GroupBox4.TabIndex = 0
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Send Data"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 21)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(33, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Data:"
		'
		'data
		'
		Me.data.Location = New System.Drawing.Point(45, 19)
		Me.data.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
		Me.data.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.data.Name = "data"
		Me.data.Size = New System.Drawing.Size(64, 20)
		Me.data.TabIndex = 3
		Me.data.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'sendData
		'
		Me.sendData.Location = New System.Drawing.Point(6, 49)
		Me.sendData.Name = "sendData"
		Me.sendData.Size = New System.Drawing.Size(117, 23)
		Me.sendData.TabIndex = 0
		Me.sendData.Text = "Send"
		Me.sendData.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(454, 241)
		Me.Controls.Add(Me.GroupBox2)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(470, 280)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(470, 280)
		Me.Name = "Form1"
		Me.Padding = New System.Windows.Forms.Padding(5)
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ipAddress As MaskedTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents port As NumericUpDown
	Friend WithEvents connect As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents recievedDataList As RichTextBox
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents Label3 As Label
	Friend WithEvents data As NumericUpDown
	Friend WithEvents sendData As Button
End Class
