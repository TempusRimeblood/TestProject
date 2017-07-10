Imports System.IO

Public Class frmCharacter
    Public Sub frmCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Public Sub ReadClass()
        Dim strDescText As String
        Dim intDescLine As Integer
        lstDesc.Items.Clear()
        Select Case protag.strClass
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
        protag.blnStatsChecked = False
        protag.blnStatsMade = False
        protag.strClass = "Street Samurai"
        protag.StatCheck()
        ReadClass()
        lblAgility.Text = protag.intAgility.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblHP.Text = protag.intMaxHP.ToString
    End Sub

    Private Sub btnGunBunny_CheckedChanged(sender As Object, e As EventArgs) Handles btnGunBunny.CheckedChanged
        protag.blnStatsChecked = False
        protag.blnStatsMade = False
        protag.strClass = "Gun-Bunny"
        protag.StatCheck()
        ReadClass()
        lblAgility.Text = protag.intAgility.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblHP.Text = protag.intMaxHP.ToString
    End Sub

    Private Sub btnDecker_CheckedChanged(sender As Object, e As EventArgs) Handles btnDecker.CheckedChanged
        protag.blnStatsChecked = False
        protag.blnStatsMade = False
        protag.strClass = "Decker"
        protag.StatCheck()
        ReadClass()
        lblAgility.Text = protag.intAgility.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblHP.Text = protag.intMaxHP.ToString
    End Sub

    Private Sub btnTank_CheckedChanged(sender As Object, e As EventArgs) Handles btnTank.CheckedChanged
        protag.blnStatsChecked = False
        protag.blnStatsMade = False
        protag.strClass = "Tank"
        protag.StatCheck()
        ReadClass()
        lblAgility.Text = protag.intAgility.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblHP.Text = protag.intMaxHP.ToString
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        'This generates the derived stats, stores the character name, and launches the character-debug pseudo-gameplay form.
        protag.strName = txtName.Text
        Try
            If protag.blnStatsChecked = True Then
                protag.statgen()
                'This sets CurrentHealth to be equal to MaxHealth, to prevent an instant failstate.
                protag.intCurrentHP = protag.intMaxHP
            Else
                MessageBox.Show("Please select a class.")
            End If
        Catch
        End Try

        protag.NameCheck()
        If protag.blnNameChecked = True And protag.blnStatsChecked = True Then
            Me.Close()
            frmCharacterDebug.Show()
        End If


    End Sub

End Class