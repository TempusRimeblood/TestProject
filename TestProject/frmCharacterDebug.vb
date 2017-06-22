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

    Private Sub btnStrUp_Click(sender As Object, e As EventArgs) Handles btnStrUp.Click
        strUp()
        updatestats()
        stsFeedLbl.Text = "You feel stronger."
    End Sub

    Private Sub btnStrDown_Click(sender As Object, e As EventArgs) Handles btnStrDown.Click
        strDown()
        updatestats()
        stsFeedLbl.Text = "You feel weaker."
    End Sub

    Private Sub btnAgiUp_Click(sender As Object, e As EventArgs) Handles btnAgiUp.Click
        agiUp()
        updatestats()
        stsFeedLbl.Text = "You feel faster."
    End Sub

    Private Sub btnAgiDown_Click(sender As Object, e As EventArgs) Handles btnAgiDown.Click
        agiDown()
        updatestats()
        stsFeedLbl.Text = "You feel slower."
    End Sub

    Private Sub btnIntUp_Click(sender As Object, e As EventArgs) Handles btnIntUp.Click
        intUp()
        updatestats()
        stsFeedLbl.Text = "You feel smarter."
    End Sub

    Private Sub btnIntDown_Click(sender As Object, e As EventArgs) Handles btnIntDown.Click
        intDown()
        updatestats()
        stsFeedLbl.Text = "You feel dumber."
    End Sub

    Private Sub btnTghUp_Click(sender As Object, e As EventArgs) Handles btnTghUp.Click
        tghUp()
        updatestats()
        intMaxHealth = (intToughness * 3) + intHPBonus - intHPMalus
        lblCurrHP.Text = intCurrentHealth.ToString
        HPcheck()
        stsFeedLbl.Text = "You feel tougher."
    End Sub

    Private Sub btnTghDown_Click(sender As Object, e As EventArgs) Handles btnTghDown.Click
        tghDown()
        updatestats()
        intMaxHealth = (intToughness * 3) + intHPBonus - intHPMalus
        lblCurrHP.Text = intCurrentHealth.ToString
        HPcheck()
        stsFeedLbl.Text = "You feel more fragile."
    End Sub

    Private Sub btnHurt_Click(sender As Object, e As EventArgs) Handles btnHurt.Click
        debugHurt()
        HPcheck()
        lblCurrHP.Text = intCurrentHealth.ToString
        Select Case intCurrentHealth
            Case > 0
                stsFeedLbl.Text = "Ouch! You lose 1 HP."
            Case 0
                stsFeedLbl.Text = "You've lost all your HP.  You die..."
        End Select
    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        debugHeal()
        HPcheck()
        lblCurrHP.Text = intCurrentHealth.ToString
        Select Case intCurrentHealth
            Case < intMaxHealth
                stsFeedLbl.Text = "Hooray! You gain 1 HP."
            Case >= intMaxHealth
                stsFeedLbl.Text = "You have all your HP."
        End Select
    End Sub

    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        debugKill()
        lblCurrHP.Text = intCurrentHealth.ToString
        HPcheck()
        stsFeedLbl.Text = "You are dead!"
    End Sub

    Private Sub updatestats()
        intCritical = (intAgility * 2) + intLuck
        lblAgility.Text = intAgility.ToString
        lblStrength.Text = intStrength.ToString
        lblIntelligence.Text = intIntelligence.ToString
        lblToughness.Text = intToughness.ToString
        lblCurrHP.Text = intCurrentHealth.ToString
        lblMaxHP.Text = intMaxHealth.ToString
        lblLuck.Text = intLuck.ToString
        lblCrit.Text = (intCritical / 100).ToString("p")
    End Sub

    Private Sub btnHPup_Click(sender As Object, e As EventArgs) Handles btnHPup.Click
        HPup()
        HPcheck()
        updatestats()

    End Sub

    Private Sub btnHPDown_Click(sender As Object, e As EventArgs) Handles btnHPDown.Click
        HPDown()
        HPcheck()
        updatestats()
    End Sub


End Class