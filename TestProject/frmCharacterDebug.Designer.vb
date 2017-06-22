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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.lblAgility = New System.Windows.Forms.Label()
        Me.lblIntelligence = New System.Windows.Forms.Label()
        Me.lblToughness = New System.Windows.Forms.Label()
        Me.lblCurrHP = New System.Windows.Forms.Label()
        Me.lblMaxHP = New System.Windows.Forms.Label()
        Me.lblLuck = New System.Windows.Forms.Label()
        Me.lblCrit = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Strength"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Intelligence"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current Health"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Luck"
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
        'lblStrength
        '
        Me.lblStrength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrength.Location = New System.Drawing.Point(179, 15)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(52, 14)
        Me.lblStrength.TabIndex = 8
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
        'lblIntelligence
        '
        Me.lblIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIntelligence.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntelligence.Location = New System.Drawing.Point(179, 70)
        Me.lblIntelligence.Name = "lblIntelligence"
        Me.lblIntelligence.Size = New System.Drawing.Size(52, 14)
        Me.lblIntelligence.TabIndex = 10
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
        'lblCurrHP
        '
        Me.lblCurrHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrHP.Location = New System.Drawing.Point(179, 129)
        Me.lblCurrHP.Name = "lblCurrHP"
        Me.lblCurrHP.Size = New System.Drawing.Size(52, 14)
        Me.lblCurrHP.TabIndex = 12
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
        'lblLuck
        '
        Me.lblLuck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLuck.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuck.Location = New System.Drawing.Point(179, 279)
        Me.lblLuck.Name = "lblLuck"
        Me.lblLuck.Size = New System.Drawing.Size(52, 14)
        Me.lblLuck.TabIndex = 14
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
        'frmCharacterDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 398)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmCharacterDebug"
        Me.Text = "Character Debug Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
