Imports System.IO

Public Class frmCharacter
    Private Sub frmCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ReadClass()
        Dim strDescText As String
        Dim intDescLine As Integer
        lstDesc.Items.Clear()
        Select Case strClass
            Case "Street Samurai"
                intDescLine = 0
            Case "Gun-Bunny"
                intDescLine = 1
            Case "Decker"
                intDescLine = 2
            Case "Tank"
                intDescLine = 3
        End Select
        strDescText = File.ReadAllLines("..\..\txt\classdesc.txt").ElementAt(intDescLine).ToString
        lstDesc.Items.Add(strDescText)
    End Sub

    Private Sub btnStreetSam_CheckedChanged(sender As Object, e As EventArgs) Handles btnStreetSam.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "Street Samurai"
        StatCheck()
        ReadClass()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = intIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnGunBunny_CheckedChanged(sender As Object, e As EventArgs) Handles btnGunBunny.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "Gun-Bunny"
        StatCheck()
        ReadClass()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = intIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnDecker_CheckedChanged(sender As Object, e As EventArgs) Handles btnDecker.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "Decker"
        StatCheck()
        ReadClass()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = intIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnTank_CheckedChanged(sender As Object, e As EventArgs) Handles btnTank.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "Tank"
        StatCheck()
        ReadClass()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = intIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        'This generates the derived stats, stores the character name, and launches the character-debug pseudo-gameplay form.
        strName = txtName.Text
        Try
            If blnStatsChecked = True Then
                statgen()
                'This sets CurrentHealth to be equal to MaxHealth, to prevent an instant failstate.
                intCurrentHealth = intMaxHealth
            Else
                MessageBox.Show("Please select a class.")
            End If
        Catch
        End Try

        NameCheck()
        If blnNameChecked = True And blnStatsChecked = True Then
            Me.Close()
            frmCharacterDebug.Show()
        End If


    End Sub
End Class