Public Class frmCharacterDebug
    Private Sub frmCharacterDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = protag.strName & ", " & protag.strClass
        lblAgility.Text = protag.intAgility.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        lblMaxHP.Text = protag.intMaxHealth.ToString
        lblLuck.Text = protag.intLuck.ToString
        lblCrit.Text = (protag.intCritical / 100).ToString("p")
    End Sub

    Private Sub btnStrUp_Click(sender As Object, e As EventArgs) Handles btnStrUp.Click
        protag.strUp()
        updatestats()
        stsFeedLbl.Text = "You feel stronger."
    End Sub

    Private Sub btnStrDown_Click(sender As Object, e As EventArgs) Handles btnStrDown.Click
        protag.strDown()
        updatestats()
        stsFeedLbl.Text = "You feel weaker."
    End Sub

    Private Sub btnAgiUp_Click(sender As Object, e As EventArgs) Handles btnAgiUp.Click
        protag.agiUp()
        updatestats()
        stsFeedLbl.Text = "You feel faster."
    End Sub

    Private Sub btnAgiDown_Click(sender As Object, e As EventArgs) Handles btnAgiDown.Click
        protag.agiDown()
        updatestats()
        stsFeedLbl.Text = "You feel slower."
    End Sub

    Private Sub btnIntUp_Click(sender As Object, e As EventArgs) Handles btnIntUp.Click
        protag.intUp()
        updatestats()
        stsFeedLbl.Text = "You feel smarter."
    End Sub

    Private Sub btnIntDown_Click(sender As Object, e As EventArgs) Handles btnIntDown.Click
        protag.intDown()
        updatestats()
        stsFeedLbl.Text = "You feel dumber."
    End Sub

    Private Sub btnTghUp_Click(sender As Object, e As EventArgs) Handles btnTghUp.Click
        protag.tghUp()
        updatestats()
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        stsFeedLbl.Text = "You feel tougher."
    End Sub

    Private Sub btnTghDown_Click(sender As Object, e As EventArgs) Handles btnTghDown.Click
        protag.tghDown()
        updatestats()
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        stsFeedLbl.Text = "You feel more fragile."
    End Sub

    Private Sub btnHurt_Click(sender As Object, e As EventArgs) Handles btnHurt.Click
        protag.debugHurt()
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        Select Case protag.intCurrentHealth
            Case > 0
                stsFeedLbl.Text = "Ouch! You lose 1 HP."
            Case 0
                stsFeedLbl.Text = "You've lost all your HP.  You die..."
        End Select
    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        protag.debugHeal()
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        Select Case protag.intCurrentHealth
            Case < protag.intMaxHealth
                stsFeedLbl.Text = "Hooray! You gain 1 HP."
            Case >= protag.intMaxHealth
                stsFeedLbl.Text = "You have all your HP."
        End Select
    End Sub

    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        protag.debugKill()
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        stsFeedLbl.Text = "You are dead!"
    End Sub

    Private Sub updatestats()
        lblMaxHP.Text = protag.intMaxHealth.ToString
        protag.intCritical = (protag.intAgility * 2) + protag.intLuck
        lblAgility.Text = protag.intAgility.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblCurrHP.Text = protag.intCurrentHealth.ToString
        lblLuck.Text = protag.intLuck.ToString
        lblCrit.Text = (protag.intCritical / 100).ToString("p")
    End Sub

    Private Sub btnHPup_Click(sender As Object, e As EventArgs) Handles btnHPup.Click
        protag.HPup()
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        updatestats()

    End Sub

    Private Sub btnHPDown_Click(sender As Object, e As EventArgs) Handles btnHPDown.Click
        protag.HPDown()
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        updatestats()
    End Sub

    Private Sub btnAtkTest_Click(sender As Object, e As EventArgs) Handles btnAtkTest.Click
        AttackCheck(protag.intAgility, protag.intStrength)
        HitReport()
        stsFeedLbl.Text = strHitReport
    End Sub
End Class