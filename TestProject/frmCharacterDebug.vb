Public Class frmCharacterDebug
    Private Sub frmCharacterDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = strName & ", " & strClass
        lblAgility.Text = intAgility.ToString
        lblStrength.Text = intStrength.ToString
        lblIntelligence.Text = intIntelligence.ToString
        lblToughness.Text = intToughness.ToString
        lblCurrHP.Text = intCurrentHealth.ToString
        lblMaxHP.Text = intMaxHealth.ToString
        lblLuck.Text = intLuck.ToString
        lblCrit.Text = (intCritical / 100).ToString("p")
    End Sub
End Class