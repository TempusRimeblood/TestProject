<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacter
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
        Me.boxClass = New System.Windows.Forms.GroupBox()
        Me.btnTank = New System.Windows.Forms.RadioButton()
        Me.btnDecker = New System.Windows.Forms.RadioButton()
        Me.btnGunBunny = New System.Windows.Forms.RadioButton()
        Me.btnStreetSam = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxDesc = New System.Windows.Forms.GroupBox()
        Me.lstDesc = New System.Windows.Forms.ListBox()
        Me.boxStats = New System.Windows.Forms.GroupBox()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblToughness = New System.Windows.Forms.Label()
        Me.lblIntelligence = New System.Windows.Forms.Label()
        Me.lblAgility = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.boxClass.SuspendLayout()
        Me.boxDesc.SuspendLayout()
        Me.boxStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxClass
        '
        Me.boxClass.Controls.Add(Me.btnTank)
        Me.boxClass.Controls.Add(Me.btnDecker)
        Me.boxClass.Controls.Add(Me.btnGunBunny)
        Me.boxClass.Controls.Add(Me.btnStreetSam)
        Me.boxClass.Location = New System.Drawing.Point(12, 41)
        Me.boxClass.Name = "boxClass"
        Me.boxClass.Size = New System.Drawing.Size(174, 287)
        Me.boxClass.TabIndex = 0
        Me.boxClass.TabStop = False
        Me.boxClass.Text = "Classes"
        '
        'btnTank
        '
        Me.btnTank.AutoSize = True
        Me.btnTank.Location = New System.Drawing.Point(6, 136)
        Me.btnTank.Name = "btnTank"
        Me.btnTank.Size = New System.Drawing.Size(50, 17)
        Me.btnTank.TabIndex = 13
        Me.btnTank.TabStop = True
        Me.btnTank.Text = "Tank"
        Me.btnTank.UseVisualStyleBackColor = True
        '
        'btnDecker
        '
        Me.btnDecker.AutoSize = True
        Me.btnDecker.Location = New System.Drawing.Point(6, 106)
        Me.btnDecker.Name = "btnDecker"
        Me.btnDecker.Size = New System.Drawing.Size(60, 17)
        Me.btnDecker.TabIndex = 12
        Me.btnDecker.TabStop = True
        Me.btnDecker.Text = "Decker"
        Me.btnDecker.UseVisualStyleBackColor = True
        '
        'btnGunBunny
        '
        Me.btnGunBunny.AutoSize = True
        Me.btnGunBunny.Location = New System.Drawing.Point(6, 76)
        Me.btnGunBunny.Name = "btnGunBunny"
        Me.btnGunBunny.Size = New System.Drawing.Size(78, 17)
        Me.btnGunBunny.TabIndex = 11
        Me.btnGunBunny.TabStop = True
        Me.btnGunBunny.Text = "Gun-Bunny"
        Me.btnGunBunny.UseVisualStyleBackColor = True
        '
        'btnStreetSam
        '
        Me.btnStreetSam.AutoSize = True
        Me.btnStreetSam.Location = New System.Drawing.Point(6, 42)
        Me.btnStreetSam.Name = "btnStreetSam"
        Me.btnStreetSam.Size = New System.Drawing.Size(94, 17)
        Me.btnStreetSam.TabIndex = 10
        Me.btnStreetSam.TabStop = True
        Me.btnStreetSam.Text = "Street Samurai"
        Me.btnStreetSam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Make A Character"
        '
        'boxDesc
        '
        Me.boxDesc.Controls.Add(Me.lstDesc)
        Me.boxDesc.Location = New System.Drawing.Point(238, 87)
        Me.boxDesc.Name = "boxDesc"
        Me.boxDesc.Size = New System.Drawing.Size(200, 195)
        Me.boxDesc.TabIndex = 0
        Me.boxDesc.TabStop = False
        Me.boxDesc.Text = "Description"
        '
        'lstDesc
        '
        Me.lstDesc.FormattingEnabled = True
        Me.lstDesc.Location = New System.Drawing.Point(6, 19)
        Me.lstDesc.Name = "lstDesc"
        Me.lstDesc.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDesc.Size = New System.Drawing.Size(188, 160)
        Me.lstDesc.TabIndex = 14
        '
        'boxStats
        '
        Me.boxStats.Controls.Add(Me.lblHP)
        Me.boxStats.Controls.Add(Me.Label6)
        Me.boxStats.Controls.Add(Me.lblToughness)
        Me.boxStats.Controls.Add(Me.lblIntelligence)
        Me.boxStats.Controls.Add(Me.lblAgility)
        Me.boxStats.Controls.Add(Me.lblStrength)
        Me.boxStats.Controls.Add(Me.Label5)
        Me.boxStats.Controls.Add(Me.Label4)
        Me.boxStats.Controls.Add(Me.Label3)
        Me.boxStats.Controls.Add(Me.Label2)
        Me.boxStats.Location = New System.Drawing.Point(476, 41)
        Me.boxStats.Name = "boxStats"
        Me.boxStats.Size = New System.Drawing.Size(222, 287)
        Me.boxStats.TabIndex = 1
        Me.boxStats.TabStop = False
        Me.boxStats.Text = "Stats"
        '
        'lblHP
        '
        Me.lblHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHP.Location = New System.Drawing.Point(116, 214)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(100, 23)
        Me.lblHP.TabIndex = 9
        Me.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Health"
        '
        'lblToughness
        '
        Me.lblToughness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToughness.Location = New System.Drawing.Point(116, 137)
        Me.lblToughness.Name = "lblToughness"
        Me.lblToughness.Size = New System.Drawing.Size(100, 23)
        Me.lblToughness.TabIndex = 7
        Me.lblToughness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIntelligence
        '
        Me.lblIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIntelligence.Location = New System.Drawing.Point(116, 107)
        Me.lblIntelligence.Name = "lblIntelligence"
        Me.lblIntelligence.Size = New System.Drawing.Size(100, 23)
        Me.lblIntelligence.TabIndex = 6
        Me.lblIntelligence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAgility
        '
        Me.lblAgility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAgility.Location = New System.Drawing.Point(116, 77)
        Me.lblAgility.Name = "lblAgility"
        Me.lblAgility.Size = New System.Drawing.Size(100, 23)
        Me.lblAgility.TabIndex = 5
        Me.lblAgility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStrength
        '
        Me.lblStrength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStrength.Location = New System.Drawing.Point(116, 45)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(100, 23)
        Me.lblStrength.TabIndex = 4
        Me.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Toughness"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Intelligence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Agility"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Strength"
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(295, 305)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(90, 23)
        Me.btnLaunch.TabIndex = 14
        Me.btnLaunch.Text = "GO"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(238, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Name"
        '
        'frmCharacter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 340)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.boxStats)
        Me.Controls.Add(Me.boxDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxClass)
        Me.Name = "frmCharacter"
        Me.Text = "Character Creation"
        Me.boxClass.ResumeLayout(False)
        Me.boxClass.PerformLayout()
        Me.boxDesc.ResumeLayout(False)
        Me.boxStats.ResumeLayout(False)
        Me.boxStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boxClass As GroupBox
    Friend WithEvents btnTank As RadioButton
    Friend WithEvents btnDecker As RadioButton
    Friend WithEvents btnGunBunny As RadioButton
    Friend WithEvents btnStreetSam As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents boxDesc As GroupBox
    Friend WithEvents boxStats As GroupBox
    Friend WithEvents lblHP As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblToughness As Label
    Friend WithEvents lblIntelligence As Label
    Friend WithEvents lblAgility As Label
    Friend WithEvents lblStrength As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLaunch As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lstDesc As ListBox
End Class
