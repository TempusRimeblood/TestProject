<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMobDebug
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
        Me.gbxBackEnd = New System.Windows.Forms.GroupBox()
        Me.lblMobClass = New System.Windows.Forms.Label()
        Me.lblMobSpawn = New System.Windows.Forms.Label()
        Me.lblMobName = New System.Windows.Forms.Label()
        Me.lblClassIndicate = New System.Windows.Forms.Label()
        Me.lblNumIndicator = New System.Windows.Forms.Label()
        Me.lblNameIndicate = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblMobArmor = New System.Windows.Forms.Label()
        Me.lblMobCurrentHP = New System.Windows.Forms.Label()
        Me.lblMobArmorValue = New System.Windows.Forms.Label()
        Me.btnMobCreate = New System.Windows.Forms.Button()
        Me.gbxBackEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mob Test Screen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxBackEnd
        '
        Me.gbxBackEnd.Controls.Add(Me.lblMobClass)
        Me.gbxBackEnd.Controls.Add(Me.lblMobSpawn)
        Me.gbxBackEnd.Controls.Add(Me.lblMobName)
        Me.gbxBackEnd.Controls.Add(Me.lblClassIndicate)
        Me.gbxBackEnd.Controls.Add(Me.lblNumIndicator)
        Me.gbxBackEnd.Controls.Add(Me.lblNameIndicate)
        Me.gbxBackEnd.Location = New System.Drawing.Point(9, 58)
        Me.gbxBackEnd.Name = "gbxBackEnd"
        Me.gbxBackEnd.Size = New System.Drawing.Size(366, 123)
        Me.gbxBackEnd.TabIndex = 1
        Me.gbxBackEnd.TabStop = False
        Me.gbxBackEnd.Text = "Back-End Info"
        '
        'lblMobClass
        '
        Me.lblMobClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMobClass.Location = New System.Drawing.Point(184, 89)
        Me.lblMobClass.Name = "lblMobClass"
        Me.lblMobClass.Size = New System.Drawing.Size(164, 23)
        Me.lblMobClass.TabIndex = 6
        '
        'lblMobSpawn
        '
        Me.lblMobSpawn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMobSpawn.Location = New System.Drawing.Point(184, 56)
        Me.lblMobSpawn.Name = "lblMobSpawn"
        Me.lblMobSpawn.Size = New System.Drawing.Size(164, 23)
        Me.lblMobSpawn.TabIndex = 4
        '
        'lblMobName
        '
        Me.lblMobName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMobName.Location = New System.Drawing.Point(184, 22)
        Me.lblMobName.Name = "lblMobName"
        Me.lblMobName.Size = New System.Drawing.Size(164, 23)
        Me.lblMobName.TabIndex = 3
        '
        'lblClassIndicate
        '
        Me.lblClassIndicate.AutoSize = True
        Me.lblClassIndicate.Location = New System.Drawing.Point(14, 90)
        Me.lblClassIndicate.Name = "lblClassIndicate"
        Me.lblClassIndicate.Size = New System.Drawing.Size(56, 13)
        Me.lblClassIndicate.TabIndex = 2
        Me.lblClassIndicate.Text = "Mob Class"
        '
        'lblNumIndicator
        '
        Me.lblNumIndicator.AutoSize = True
        Me.lblNumIndicator.Location = New System.Drawing.Point(14, 57)
        Me.lblNumIndicator.Name = "lblNumIndicator"
        Me.lblNumIndicator.Size = New System.Drawing.Size(93, 13)
        Me.lblNumIndicator.TabIndex = 1
        Me.lblNumIndicator.Text = "Mob Spawn Order"
        '
        'lblNameIndicate
        '
        Me.lblNameIndicate.AutoSize = True
        Me.lblNameIndicate.Location = New System.Drawing.Point(14, 23)
        Me.lblNameIndicate.Name = "lblNameIndicate"
        Me.lblNameIndicate.Size = New System.Drawing.Size(35, 13)
        Me.lblNameIndicate.TabIndex = 0
        Me.lblNameIndicate.Text = "Name"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(23, 221)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(46, 13)
        Me.lblHP.TabIndex = 2
        Me.lblHP.Text = "Mob HP"
        '
        'lblMobArmor
        '
        Me.lblMobArmor.AutoSize = True
        Me.lblMobArmor.Location = New System.Drawing.Point(23, 258)
        Me.lblMobArmor.Name = "lblMobArmor"
        Me.lblMobArmor.Size = New System.Drawing.Size(88, 13)
        Me.lblMobArmor.TabIndex = 3
        Me.lblMobArmor.Text = "Mob Armor Value"
        '
        'lblMobCurrentHP
        '
        Me.lblMobCurrentHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMobCurrentHP.Location = New System.Drawing.Point(193, 221)
        Me.lblMobCurrentHP.Name = "lblMobCurrentHP"
        Me.lblMobCurrentHP.Size = New System.Drawing.Size(164, 23)
        Me.lblMobCurrentHP.TabIndex = 4
        '
        'lblMobArmorValue
        '
        Me.lblMobArmorValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMobArmorValue.Location = New System.Drawing.Point(193, 257)
        Me.lblMobArmorValue.Name = "lblMobArmorValue"
        Me.lblMobArmorValue.Size = New System.Drawing.Size(164, 23)
        Me.lblMobArmorValue.TabIndex = 5
        '
        'btnMobCreate
        '
        Me.btnMobCreate.Location = New System.Drawing.Point(26, 347)
        Me.btnMobCreate.Name = "btnMobCreate"
        Me.btnMobCreate.Size = New System.Drawing.Size(90, 23)
        Me.btnMobCreate.TabIndex = 6
        Me.btnMobCreate.Text = "Spawn a Mob"
        Me.btnMobCreate.UseVisualStyleBackColor = True
        '
        'frmMobDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 422)
        Me.Controls.Add(Me.btnMobCreate)
        Me.Controls.Add(Me.lblMobArmorValue)
        Me.Controls.Add(Me.lblMobCurrentHP)
        Me.Controls.Add(Me.lblMobArmor)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.gbxBackEnd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMobDebug"
        Me.Text = "Mob Debugger"
        Me.gbxBackEnd.ResumeLayout(False)
        Me.gbxBackEnd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbxBackEnd As GroupBox
    Friend WithEvents lblMobClass As Label
    Friend WithEvents lblMobSpawn As Label
    Friend WithEvents lblMobName As Label
    Friend WithEvents lblClassIndicate As Label
    Friend WithEvents lblNumIndicator As Label
    Friend WithEvents lblNameIndicate As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblMobArmor As Label
    Friend WithEvents lblMobCurrentHP As Label
    Friend WithEvents lblMobArmorValue As Label
    Friend WithEvents btnMobCreate As Button
End Class
