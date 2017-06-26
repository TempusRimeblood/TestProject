Module GameLoopFunctions
    'This module exists to handle gameloop functions.
    'Stat increases/decreases, health and death checks, and combat mechanics are contained here.

    'Strength increase function.
    Public Function strUp()
        intStrength += 1
        Return (intStrength)
    End Function

    'Strength decrease function.
    Public Function strDown()
        intStrength -= 1
        Return (intStrength)
    End Function

    'Agility increase function.
    Public Function agiUp()
        intAgility += 1
        Return (intAgility)
    End Function

    'Agility decrease function.
    Public Function agiDown()
        intAgility -= 1
        Return (intAgility)
    End Function

    'Intelligence increase function.
    Public Function intUp()
        intIntelligence += 1
        Return (intIntelligence)
    End Function

    'Intelligence decrease function.
    Public Function intDown()
        intIntelligence -= 1
        Return (intIntelligence)
    End Function

    'Toughness increase function.
    Public Function tghUp()
        intToughness += 1
        intCurrentHealth += 3
        intMaxHealth = intToughness * 3 + intHPBonus - intHPMalus
        HPcheck()
        Return (intToughness)
    End Function

    'Toughness decrease function.
    Public Function tghDown()
        intToughness -= 1
        intMaxHealth = intToughness * 3 + intHPBonus - intHPMalus
        HPcheck()
        Return (intToughness)
    End Function

    'Luck increase function.
    Public Function lckUp()
        intLuck += 1
        Return (intLuck)
    End Function

    'Luck decrease function.
    Public Function lckDown()
        intLuck -= 1
        Return (intLuck)
    End Function

    'Debug hurt function
    Public Function debugHurt()
        intCurrentHealth -= 1
        Return (intCurrentHealth)
    End Function

    'Debug heal function
    Public Function debugHeal()
        If intCurrentHealth < intMaxHealth Then
            intCurrentHealth += 1
        Else
            intCurrentHealth += 0
        End If
        Return (intCurrentHealth)
    End Function

    'Debug kill function
    Public Function debugKill()
        intCurrentHealth = 0
        Return (intCurrentHealth)
    End Function

    'Health check (death/overheal)
    Public Function HPcheck()
        Select Case intCurrentHealth
            Case <= 0
                MessageBox.Show("You're dead...", "0xDEADBEEF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Form.ActiveForm.Close()
                intCurrentHealth = Nothing
                intMaxHealth = Nothing
                frmMain.Show()
            Case > intMaxHealth
                intCurrentHealth = intMaxHealth
        End Select
        Return (intCurrentHealth)
    End Function

    'Raises Max HP and current HP
    Public Function HPup()
        intHPBonus += 1
        intCurrentHealth += 1
        intMaxHealth = (intToughness * 3) + intHPBonus - intHPMalus
        Return (intHPBonus)
    End Function

    'Lowers Max HP - if current HP is lower than Max HP, current HP is not affected
    Public Function HPDown()
        intHPMalus += 1
        intMaxHealth = (intToughness * 3) + intHPBonus - intHPMalus
        If intCurrentHealth > intMaxHealth Then
            intCurrentHealth = intMaxHealth
        End If
        Return (intHPMalus)
    End Function
End Module
