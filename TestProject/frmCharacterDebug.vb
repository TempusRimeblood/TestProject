Public Class frmCharacterDebug
    Private Sub frmCharacterDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = protag.strName & ", " & protag.strClass
        lblAgility.Text = protag.intAgility.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblCurrHP.Text = protag.intCurrentHP.ToString
        lblMaxHP.Text = protag.intMaxHP.ToString
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
        lblCurrHP.Text = protag.intCurrentHP.ToString
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        stsFeedLbl.Text = "You feel tougher."
    End Sub

    Private Sub btnTghDown_Click(sender As Object, e As EventArgs) Handles btnTghDown.Click
        protag.tghDown()
        updatestats()
        lblCurrHP.Text = protag.intCurrentHP.ToString
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        stsFeedLbl.Text = "You feel more fragile."
    End Sub

    Private Sub btnHurt_Click(sender As Object, e As EventArgs) Handles btnHurt.Click
        protag.debugHurt()
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        lblCurrHP.Text = protag.intCurrentHP.ToString
        Select Case protag.intCurrentHP
            Case > 0
                stsFeedLbl.Text = "Ouch! You lose 1 HP."
            Case 0
                stsFeedLbl.Text = "You've lost all your HP.  You die..."
        End Select
    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click
        protag.debugHeal()
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        lblCurrHP.Text = protag.intCurrentHP.ToString
        Select Case protag.intCurrentHP
            Case < protag.intMaxHP
                stsFeedLbl.Text = "Hooray! You gain 1 HP."
            Case >= protag.intMaxHP
                stsFeedLbl.Text = "You have all your HP."
        End Select
    End Sub

    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        protag.debugKill()
        lblCurrHP.Text = protag.intCurrentHP.ToString
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        stsFeedLbl.Text = "You are dead!"
    End Sub

    Private Sub updatestats()
        lblMaxHP.Text = protag.intMaxHP.ToString
        protag.intCritical = (protag.intAgility * 2) + protag.intLuck
        lblAgility.Text = protag.intAgility.ToString
        lblStrength.Text = protag.intStrength.ToString
        lblIntelligence.Text = protag.intIntelligence.ToString
        lblToughness.Text = protag.intToughness.ToString
        lblCurrHP.Text = protag.intCurrentHP.ToString
        lblLuck.Text = protag.intLuck.ToString
        lblCrit.Text = (protag.intCritical / 100).ToString("p")
    End Sub

    Private Sub btnHPup_Click(sender As Object, e As EventArgs) Handles btnHPup.Click
        protag.HPup()
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        updatestats()

    End Sub

    Private Sub btnHPDown_Click(sender As Object, e As EventArgs) Handles btnHPDown.Click
        protag.HPDown()
        playerHPcheck(protag.intCurrentHP, protag.intMaxHP)
        updatestats()
    End Sub

    Private Sub btnAtkTest_Click(sender As Object, e As EventArgs) Handles btnAtkTest.Click
        AttackType()
        DamageCheck(Mobs(intMobsCreated).intCurrentHP, intDmgRoll, Mobs(intMobsCreated).intMobArmorValue)
        HitReport()
        stsFeedLbl.Text = strHitReport
    End Sub

    Private Sub btnMobSpawner_Click(sender As Object, e As EventArgs) Handles btnMobDebug.Click

    End Sub
End Class