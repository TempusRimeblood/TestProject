Public Class Player
    'This module is for initializing global variables that will be used through the entirety of the game.

    'Capture character name from character creation screen
    Public strName As String

    'Capture character class from character creation screen
    Public strClass As String

    'These global variables are for monitoring player stats.
    Public intStrength As Integer 'Strength, for determining melee damage modifiers and inventory capacity
    Public intIntelligence As Integer 'Intelligence, for determining computer challenges and hacking
    Public intAgility As Integer 'Agility, affects accuracy in melee/ranged and chance to dodge
    Public intToughness As Integer 'Toughness, affects HP
    Public intLuck As Integer 'This is Luck.  It is a hidden stat and will be implemented later.  Possibly for crit chance.

    'These variables are for derived stats.
    Public intMaxHealth As Integer 'Maximum HP, affected by Toughness and items.
    Public intCurrentHealth As Integer 'Current HP, affected by whether the player has been attacked successfully.
    Public intCritical As Integer 'Critical Hit Chance, affected by the equipped weapon and Luck.
    Public intHPBonus As Integer 'HP Bonus, applied by items and events that boost Max HP without boosting Toughness
    Public intHPMalus As Integer 'HP Malus, applied by items and events that lower Max HP without lowering Toughness

    Public intNameCount As Integer 'Set name counter for character validation
    Public blnNameChecked As Boolean = False 'Verify that name has been checked

    'This is a block of code to determine derived statistics.
    'The following line sets the StatsMade and StatsChecked variable to false, for use in the character creation screen/game launch.
    Public blnStatsMade As Boolean = False
    Public blnStatsChecked As Boolean = False

    Public Function StatCheck()
        'StatCheck assigns values to the initialized variables on a per-class basis, and re-assigns them
        'based on the class selected.
        Select Case strClass
            Case "Street Samurai"
                intStrength = 8
                intAgility = 5
                intToughness = 5
                intIntelligence = 2
                intMaxHealth = intToughness * 3
                blnStatsChecked = True
            Case "Gun-Bunny"
                intStrength = 2
                intAgility = 8
                intToughness = 5
                intIntelligence = 5
                intMaxHealth = intToughness * 3
                blnStatsChecked = True
            Case "Decker"
                intStrength = 5
                intAgility = 5
                intIntelligence = 8
                intToughness = 2
                intMaxHealth = intToughness * 3
                blnStatsChecked = True
            Case "Tank"
                intToughness = 8
                intStrength = 5
                intAgility = 2
                intIntelligence = 5
                intMaxHealth = intToughness * 3
                blnStatsChecked = True
        End Select
        Return (blnStatsChecked = True)
    End Function
    Public Function statgen()
        'Call a random number generator using system timer as a random seed.
        Randomize()
        'This determines intLuck randomly, as a value between 1 and 6.
        intLuck = CInt(6 * Rnd() + 1)
        'This determines Critical Chance, using Agility as the base stat and intLuck as a modifier.
        intCritical = (intAgility * 2) + intLuck
        'This line returns the blnStatsMade value to True, allowing the game to launch.
        Return (blnStatsMade = True)
    End Function

    'This function basically only exists to verify that the character's name is valid.
    Public Function NameCheck()
        For intNameCount = 0 To strName.Length - 1
            If IsAlpha(strName.ElementAt(intNameCount)) Or
                    IsNumeric(strName.ElementAt(intNameCount)) Then
                blnNameChecked = True
            Else MessageBox.Show("Alphanumeric characters only.", "CAN'T BRICK THIS ONE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                intNameCount = strName.Length - 1
            End If
        Next
        Return (blnNameChecked = True)
    End Function

    'This is the standard alphanumeric verification function - 
    'there are probably going to be a lot of callbacks to this.

    Public Function IsAlpha(strChar As String) As Boolean
        'declare variables
        Dim blnLetterFound = False
        Dim intAsc As Integer

        intAsc = Asc(strChar)
        'check if ASCII number is in the upper or lowercase range
        If (intAsc >= 65 And intAsc <= 90) Or (intAsc >= 97 And intAsc <= 122) Then
            blnLetterFound = True
        End If
        'result
        Return (blnLetterFound)

    End Function
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
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
        Return (intToughness)
    End Function

    'Toughness decrease function.
    Public Function tghDown()
        intToughness -= 1
        intMaxHealth = intToughness * 3 + intHPBonus - intHPMalus
        HPcheck(protag.intCurrentHealth, protag.intMaxHealth)
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
End Class
