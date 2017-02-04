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
        Me.vehicleList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDBritishC = New System.Windows.Forms.RadioButton()
        Me.RDAlberta = New System.Windows.Forms.RadioButton()
        Me.RDOntario = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHHybrid = New System.Windows.Forms.CheckBox()
        Me.CHIncludeDD = New System.Windows.Forms.CheckBox()
        Me.CHElectricalT = New System.Windows.Forms.CheckBox()
        Me.CHExhuastST = New System.Windows.Forms.CheckBox()
        Me.CKEngineTest = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGetQuote = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vehicleList
        '
        Me.vehicleList.FormattingEnabled = True
        Me.vehicleList.Items.AddRange(New Object() {"Tesla Model S", "Tesla Model X", "Tesla Model 3", "Ford Mustang", "Honda Civic", "Toyota Camry (Hybrid)", "Toyota Camry"})
        Me.vehicleList.Location = New System.Drawing.Point(30, 64)
        Me.vehicleList.Name = "vehicleList"
        Me.vehicleList.Size = New System.Drawing.Size(206, 160)
        Me.vehicleList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vehicle"
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(30, 272)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.Size = New System.Drawing.Size(708, 198)
        Me.txtReport.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDBritishC)
        Me.GroupBox1.Controls.Add(Me.RDAlberta)
        Me.GroupBox1.Controls.Add(Me.RDOntario)
        Me.GroupBox1.Location = New System.Drawing.Point(545, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 156)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'RDBritishC
        '
        Me.RDBritishC.AutoSize = True
        Me.RDBritishC.Location = New System.Drawing.Point(18, 101)
        Me.RDBritishC.Name = "RDBritishC"
        Me.RDBritishC.Size = New System.Drawing.Size(99, 17)
        Me.RDBritishC.TabIndex = 2
        Me.RDBritishC.TabStop = True
        Me.RDBritishC.Text = "British Columbia"
        Me.RDBritishC.UseVisualStyleBackColor = True
        '
        'RDAlberta
        '
        Me.RDAlberta.AutoSize = True
        Me.RDAlberta.Location = New System.Drawing.Point(18, 64)
        Me.RDAlberta.Name = "RDAlberta"
        Me.RDAlberta.Size = New System.Drawing.Size(58, 17)
        Me.RDAlberta.TabIndex = 1
        Me.RDAlberta.TabStop = True
        Me.RDAlberta.Text = "Alberta"
        Me.RDAlberta.UseVisualStyleBackColor = True
        '
        'RDOntario
        '
        Me.RDOntario.AutoSize = True
        Me.RDOntario.Location = New System.Drawing.Point(18, 31)
        Me.RDOntario.Name = "RDOntario"
        Me.RDOntario.Size = New System.Drawing.Size(59, 17)
        Me.RDOntario.TabIndex = 0
        Me.RDOntario.TabStop = True
        Me.RDOntario.Text = "Ontario"
        Me.RDOntario.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHHybrid)
        Me.GroupBox2.Controls.Add(Me.CHIncludeDD)
        Me.GroupBox2.Controls.Add(Me.CHElectricalT)
        Me.GroupBox2.Controls.Add(Me.CHExhuastST)
        Me.GroupBox2.Controls.Add(Me.CKEngineTest)
        Me.GroupBox2.Location = New System.Drawing.Point(775, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 191)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vehicle Tests"
        '
        'CHHybrid
        '
        Me.CHHybrid.AutoSize = True
        Me.CHHybrid.Location = New System.Drawing.Point(24, 168)
        Me.CHHybrid.Name = "CHHybrid"
        Me.CHHybrid.Size = New System.Drawing.Size(149, 17)
        Me.CHHybrid.TabIndex = 4
        Me.CHHybrid.Text = "Battery Test (Only Hybrid!)"
        Me.CHHybrid.UseVisualStyleBackColor = True
        '
        'CHIncludeDD
        '
        Me.CHIncludeDD.AutoSize = True
        Me.CHIncludeDD.Location = New System.Drawing.Point(24, 135)
        Me.CHIncludeDD.Name = "CHIncludeDD"
        Me.CHIncludeDD.Size = New System.Drawing.Size(161, 17)
        Me.CHIncludeDD.TabIndex = 3
        Me.CHIncludeDD.Text = "Include Detailed Diagnostics"
        Me.CHIncludeDD.UseVisualStyleBackColor = True
        '
        'CHElectricalT
        '
        Me.CHElectricalT.AutoSize = True
        Me.CHElectricalT.Location = New System.Drawing.Point(24, 97)
        Me.CHElectricalT.Name = "CHElectricalT"
        Me.CHElectricalT.Size = New System.Drawing.Size(130, 17)
        Me.CHElectricalT.TabIndex = 2
        Me.CHElectricalT.Text = "Electrical System Test"
        Me.CHElectricalT.UseVisualStyleBackColor = True
        '
        'CHExhuastST
        '
        Me.CHExhuastST.AutoSize = True
        Me.CHExhuastST.Location = New System.Drawing.Point(24, 63)
        Me.CHExhuastST.Name = "CHExhuastST"
        Me.CHExhuastST.Size = New System.Drawing.Size(125, 17)
        Me.CHExhuastST.TabIndex = 1
        Me.CHExhuastST.Text = "Exhaust System Test"
        Me.CHExhuastST.UseVisualStyleBackColor = True
        '
        'CKEngineTest
        '
        Me.CKEngineTest.AutoSize = True
        Me.CKEngineTest.Location = New System.Drawing.Point(24, 30)
        Me.CKEngineTest.Name = "CKEngineTest"
        Me.CKEngineTest.Size = New System.Drawing.Size(83, 17)
        Me.CKEngineTest.TabIndex = 0
        Me.CKEngineTest.Text = "Engine Test"
        Me.CKEngineTest.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(242, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 216)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnGetQuote
        '
        Me.btnGetQuote.Location = New System.Drawing.Point(764, 272)
        Me.btnGetQuote.Name = "btnGetQuote"
        Me.btnGetQuote.Size = New System.Drawing.Size(271, 197)
        Me.btnGetQuote.TabIndex = 6
        Me.btnGetQuote.Text = "Get Quote"
        Me.btnGetQuote.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(878, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(169, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 507)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetQuote)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vehicleList)
        Me.Controls.Add(Me.txtReport)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Testing Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vehicleList As ListBox
    Friend WithEvents Label1 As Label
    Private WithEvents txtReport As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDBritishC As RadioButton
    Friend WithEvents RDAlberta As RadioButton
    Friend WithEvents RDOntario As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CHIncludeDD As CheckBox
    Friend WithEvents CHElectricalT As CheckBox
    Friend WithEvents CHExhuastST As CheckBox
    Friend WithEvents CKEngineTest As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGetQuote As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents CHHybrid As CheckBox
End Class
