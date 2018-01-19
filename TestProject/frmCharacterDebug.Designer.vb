<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacterDebug
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCrit = New System.Windows.Forms.Label()
        Me.lblLuck = New System.Windows.Forms.Label()
        Me.lblMaxHP = New System.Windows.Forms.Label()
        Me.lblCurrHP = New System.Windows.Forms.Label()
        Me.lblToughness = New System.Windows.Forms.Label()
        Me.lblIntelligence = New System.Windows.Forms.Label()
        Me.lblAgility = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStrUp = New System.Windows.Forms.Button()
        Me.btnStrDown = New System.Windows.Forms.Button()
        Me.btnHurt = New System.Windows.Forms.Button()
        Me.btnAgiUp = New System.Windows.Forms.Button()
        Me.btnAgiDown = New System.Windows.Forms.Button()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.btnIntUp = New System.Windows.Forms.Button()
        Me.btnIntDown = New System.Windows.Forms.Button()
        Me.btnHPup = New System.Windows.Forms.Button()
        Me.btnTghUp = New System.Windows.Forms.Button()
        Me.btnTghDown = New System.Windows.Forms.Button()
        Me.btnHPDown = New System.Windows.Forms.Button()
        Me.btnHeal = New System.Windows.Forms.Button()
        Me.btnAtkTest = New System.Windows.Forms.Button()
        Me.stsFeed = New System.Windows.Forms.StatusStrip()
        Me.stsFeedLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnMobDebug = New System.Windows.Forms.Button()
        Me.btnItemDebug = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.stsFeed.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(145, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(208, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCrit)
        Me.GroupBox1.Controls.Add(Me.lblLuck)
        Me.GroupBox1.Controls.Add(Me.lblMaxHP)
        Me.GroupBox1.Controls.Add(Me.lblCurrHP)
        Me.GroupBox1.Controls.Add(Me.lblToughness)
        Me.GroupBox1.Controls.Add(Me.lblIntelligence)
        Me.GroupBox1.Controls.Add(Me.lblAgility)
        Me.GroupBox1.Controls.Add(Me.lblStrength)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 351)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stats"
        '
        'lblCrit
        '
        Me.lblCrit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCrit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrit.Location = New System.Drawing.Point(179, 304)
        Me.lblCrit.Name = "lblCrit"
        Me.lblCrit.Size = New System.Drawing.Size(52, 14)
        Me.lblCrit.TabIndex = 15
        '
        'lblLuck
        '
        Me.lblLuck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLuck.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuck.Location = New System.Drawing.Point(179, 279)
        Me.lblLuck.Name = "lblLuck"
        Me.lblLuck.Size = New System.Drawing.Size(52, 14)
        Me.lblLuck.TabIndex = 14
        '
        'lblMaxHP
        '
        Me.lblMaxHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxHP.Location = New System.Drawing.Point(179, 159)
        Me.lblMaxHP.Name = "lblMaxHP"
        Me.lblMaxHP.Size = New System.Drawing.Size(52, 14)
        Me.lblMaxHP.TabIndex = 13
        '
        'lblCurrHP
        '
        Me.lblCurrHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrHP.Location = New System.Drawing.Point(179, 129)
        Me.lblCurrHP.Name = "lblCurrHP"
        Me.lblCurrHP.Size = New System.Drawing.Size(52, 14)
        Me.lblCurrHP.TabIndex = 12
        '
        'lblToughness
        '
        Me.lblToughness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblToughness.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToughness.Location = New System.Drawing.Point(179, 98)
        Me.lblToughness.Name = "lblToughness"
        Me.lblToughness.Size = New System.Drawing.Size(52, 14)
        Me.lblToughness.TabIndex = 11
        '
        'lblIntelligence
        '
        Me.lblIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIntelligence.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntelligence.Location = New System.Drawing.Point(179, 70)
        Me.lblIntelligence.Name = "lblIntelligence"
        Me.lblIntelligence.Size = New System.Drawing.Size(52, 14)
        Me.lblIntelligence.TabIndex = 10
        '
        'lblAgility
        '
        Me.lblAgility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAgility.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgility.Location = New System.Drawing.Point(179, 42)
        Me.lblAgility.Name = "lblAgility"
        Me.lblAgility.Size = New System.Drawing.Size(52, 14)
        Me.lblAgility.TabIndex = 9
        '
        'lblStrength
        '
        Me.lblStrength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrength.Location = New System.Drawing.Point(179, 15)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(52, 14)
        Me.lblStrength.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Critical Chance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Luck"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Max Health"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current Health"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Toughness"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Intelligence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agility"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Strength"
        '
        'btnStrUp
        '
        Me.btnStrUp.Location = New System.Drawing.Point(255, 46)
        Me.btnStrUp.Name = "btnStrUp"
        Me.btnStrUp.Size = New System.Drawing.Size(75, 23)
        Me.btnStrUp.TabIndex = 2
        Me.btnStrUp.Text = "STR Up"
        Me.btnStrUp.UseVisualStyleBackColor = True
        '
        'btnStrDown
        '
        Me.btnStrDown.Location = New System.Drawing.Point(336, 46)
        Me.btnStrDown.Name = "btnStrDown"
        Me.btnStrDown.Size = New System.Drawing.Size(75, 23)
        Me.btnStrDown.TabIndex = 3
        Me.btnStrDown.Text = "STR Down"
        Me.btnStrDown.UseVisualStyleBackColor = True
        '
        'btnHurt
        '
        Me.btnHurt.Location = New System.Drawing.Point(255, 158)
        Me.btnHurt.Name = "btnHurt"
        Me.btnHurt.Size = New System.Drawing.Size(75, 23)
        Me.btnHurt.TabIndex = 4
        Me.btnHurt.Text = "Hurt"
        Me.btnHurt.UseVisualStyleBackColor = True
        '
        'btnAgiUp
        '
        Me.btnAgiUp.Location = New System.Drawing.Point(255, 73)
        Me.btnAgiUp.Name = "btnAgiUp"
        Me.btnAgiUp.Size = New System.Drawing.Size(75, 23)
        Me.btnAgiUp.TabIndex = 5
        Me.btnAgiUp.Text = "AGI Up"
        Me.btnAgiUp.UseVisualStyleBackColor = True
        '
        'btnAgiDown
        '
        Me.btnAgiDown.Location = New System.Drawing.Point(336, 75)
        Me.btnAgiDown.Name = "btnAgiDown"
        Me.btnAgiDown.Size = New System.Drawing.Size(75, 23)
        Me.btnAgiDown.TabIndex = 6
        Me.btnAgiDown.Text = "AGI Down"
        Me.btnAgiDown.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(417, 159)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(75, 23)
        Me.btnKill.TabIndex = 7
        Me.btnKill.Text = "Die"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnIntUp
        '
        Me.btnIntUp.Location = New System.Drawing.Point(255, 102)
        Me.btnIntUp.Name = "btnIntUp"
        Me.btnIntUp.Size = New System.Drawing.Size(75, 23)
        Me.btnIntUp.TabIndex = 8
        Me.btnIntUp.Text = "INT Up"
        Me.btnIntUp.UseVisualStyleBackColor = True
        '
        'btnIntDown
        '
        Me.btnIntDown.Location = New System.Drawing.Point(336, 101)
        Me.btnIntDown.Name = "btnIntDown"
        Me.btnIntDown.Size = New System.Drawing.Size(75, 23)
        Me.btnIntDown.TabIndex = 9
        Me.btnIntDown.Text = "INT Down"
        Me.btnIntDown.UseVisualStyleBackColor = True
        '
        'btnHPup
        '
        Me.btnHPup.Location = New System.Drawing.Point(255, 187)
        Me.btnHPup.Name = "btnHPup"
        Me.btnHPup.Size = New System.Drawing.Size(75, 23)
        Me.btnHPup.TabIndex = 10
        Me.btnHPup.Text = "HP Up"
        Me.btnHPup.UseVisualStyleBackColor = True
        '
        'btnTghUp
        '
        Me.btnTghUp.Location = New System.Drawing.Point(255, 129)
        Me.btnTghUp.Name = "btnTghUp"
        Me.btnTghUp.Size = New System.Drawing.Size(75, 23)
        Me.btnTghUp.TabIndex = 11
        Me.btnTghUp.Text = "TGH Up"
        Me.btnTghUp.UseVisualStyleBackColor = True
        '
        'btnTghDown
        '
        Me.btnTghDown.Location = New System.Drawing.Point(336, 130)
        Me.btnTghDown.Name = "btnTghDown"
        Me.btnTghDown.Size = New System.Drawing.Size(75, 23)
        Me.btnTghDown.TabIndex = 12
        Me.btnTghDown.Text = "TGH Down"
        Me.btnTghDown.UseVisualStyleBackColor = True
        '
        'btnHPDown
        '
        Me.btnHPDown.Location = New System.Drawing.Point(336, 188)
        Me.btnHPDown.Name = "btnHPDown"
        Me.btnHPDown.Size = New System.Drawing.Size(75, 23)
        Me.btnHPDown.TabIndex = 13
        Me.btnHPDown.Text = "HP Down"
        Me.btnHPDown.UseVisualStyleBackColor = True
        '
        'btnHeal
        '
        Me.btnHeal.Location = New System.Drawing.Point(336, 159)
        Me.btnHeal.Name = "btnHeal"
        Me.btnHeal.Size = New System.Drawing.Size(75, 23)
        Me.btnHeal.TabIndex = 14
        Me.btnHeal.Text = "Heal"
        Me.btnHeal.UseVisualStyleBackColor = True
        '
        'btnAtkTest
        '
        Me.btnAtkTest.Location = New System.Drawing.Point(255, 256)
        Me.btnAtkTest.Name = "btnAtkTest"
        Me.btnAtkTest.Size = New System.Drawing.Size(75, 23)
        Me.btnAtkTest.TabIndex = 15
        Me.btnAtkTest.Text = "Attack Test"
        Me.btnAtkTest.UseVisualStyleBackColor = True
        '
        'stsFeed
        '
        Me.stsFeed.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsFeedLbl})
        Me.stsFeed.Location = New System.Drawing.Point(0, 403)
        Me.stsFeed.Name = "stsFeed"
        Me.stsFeed.Size = New System.Drawing.Size(509, 22)
        Me.stsFeed.TabIndex = 16
        Me.stsFeed.Text = "StatusStrip1"
        '
        'stsFeedLbl
        '
        Me.stsFeedLbl.Name = "stsFeedLbl"
        Me.stsFeedLbl.Size = New System.Drawing.Size(120, 17)
        Me.stsFeedLbl.Text = "ToolStripStatusLabel1"
        '
        'btnMobDebug
        '
        Me.btnMobDebug.Location = New System.Drawing.Point(255, 305)
        Me.btnMobDebug.Name = "btnMobDebug"
        Me.btnMobDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnMobDebug.TabIndex = 17
        Me.btnMobDebug.Text = "Mob Debug"
        Me.btnMobDebug.UseVisualStyleBackColor = True
        '
        'btnItemDebug
        '
        Me.btnItemDebug.Location = New System.Drawing.Point(255, 339)
        Me.btnItemDebug.Name = "btnItemDebug"
        Me.btnItemDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnItemDebug.TabIndex = 18
        Me.btnItemDebug.Text = "Item Test"
        Me.btnItemDebug.UseVisualStyleBackColor = True
        '
        'frmCharacterDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 425)
        Me.Controls.Add(Me.btnItemDebug)
        Me.Controls.Add(Me.btnMobDebug)
        Me.Controls.Add(Me.stsFeed)
        Me.Controls.Add(Me.btnAtkTest)
        Me.Controls.Add(Me.btnHeal)
        Me.Controls.Add(Me.btnHPDown)
        Me.Controls.Add(Me.btnTghDown)
        Me.Controls.Add(Me.btnTghUp)
        Me.Controls.Add(Me.btnHPup)
        Me.Controls.Add(Me.btnIntDown)
        Me.Controls.Add(Me.btnIntUp)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.btnAgiDown)
        Me.Controls.Add(Me.btnAgiUp)
        Me.Controls.Add(Me.btnHurt)
        Me.Controls.Add(Me.btnStrDown)
        Me.Controls.Add(Me.btnStrUp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmCharacterDebug"
        Me.Text = "Character Debug Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.stsFeed.ResumeLayout(False)
        Me.stsFeed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCrit As Label
    Friend WithEvents lblLuck As Label
    Friend WithEvents lblMaxHP As Label
    Friend WithEvents lblCurrHP As Label
    Friend WithEvents lblToughness As Label
    Friend WithEvents lblIntelligence As Label
    Friend WithEvents lblAgility As Label
    Friend WithEvents lblStrength As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStrUp As Button
    Friend WithEvents btnStrDown As Button
    Friend WithEvents btnHurt As Button
    Friend WithEvents btnAgiUp As Button
    Friend WithEvents btnAgiDown As Button
    Friend WithEvents btnKill As Button
    Friend WithEvents btnIntUp As Button
    Friend WithEvents btnIntDown As Button
    Friend WithEvents btnHPup As Button
    Friend WithEvents btnTghUp As Button
    Friend WithEvents btnTghDown As Button
    Friend WithEvents btnHPDown As Button
    Friend WithEvents btnHeal As Button
    Friend WithEvents btnAtkTest As Button
    Friend WithEvents stsFeed As StatusStrip
    Friend WithEvents stsFeedLbl As ToolStripStatusLabel
    Friend WithEvents btnMobDebug As Button
    Friend WithEvents btnItemDebug As Button
End Class
