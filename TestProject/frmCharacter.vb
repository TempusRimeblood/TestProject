Imports System.IO

Public Class frmCharacter
    Private Sub frmCharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Read()
        'Creating StreamReader to read description text
        Dim sr As StreamReader = New StreamReader("../../txt/classdesc.txt")
        'Setting file to be read and outputting lines
        Dim numLines As Integer = 0
        Dim line As String = sr.ReadLine()
        While line IsNot Nothing
            numLines = numLines + 1
            line = sr.ReadLine()
        End While
        'If statements to output descriptions
        If btnStreetSam.Checked = True Then
            lstDesc.Items.Clear()
            line = sr.ReadLine()
            lstDesc.Items.Add(line)
        End If
        If btnGunBunny.Checked = True Then
            lstDesc.Items.Clear()
            line = sr.ReadLine(2)
            lstDesc.Items.Add(line)
        End If
        If btnDecker.Checked = True Then
            lstDesc.Items.Clear()
            line = sr.ReadLine(3)
            lstDesc.Items.Add(line)
        End If
        If btnTank.Checked = True Then
            lstDesc.Items.Clear()
            line = sr.ReadLine(4)
            lstDesc.Items.Add(line)
        End If
        sr.Close()
    End Sub

    Private Sub btnStreetSam_CheckedChanged(sender As Object, e As EventArgs) Handles btnStreetSam.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "StreetSam"
        StatCheck()
        Read()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = lblIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnGunBunny_CheckedChanged(sender As Object, e As EventArgs) Handles btnGunBunny.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "GunBunny"
        StatCheck()
        Read()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = lblIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnDecker_CheckedChanged(sender As Object, e As EventArgs) Handles btnDecker.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "Decker"
        StatCheck()
        Read()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = lblIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub

    Private Sub btnTank_CheckedChanged(sender As Object, e As EventArgs) Handles btnTank.CheckedChanged
        blnStatsChecked = False
        blnStatsMade = False
        strClass = "Tank"
        StatCheck()
        Read()
        lblAgility.Text = intAgility.ToString
        lblIntelligence.Text = lblIntelligence.ToString
        lblStrength.Text = intStrength.ToString
        lblToughness.Text = intToughness.ToString
        lblHP.Text = intMaxHealth.ToString
    End Sub
End Class