Module CombatFunctions
    'This module handles combat-relevant functions such as attack checks, 
    'critical hit checks, and defense/dodge checks.
    Public intToHitRoll As Integer ' This is the to-hit roll result
    Public blnIsHit As Boolean ' This determines if the roll is a hit
    Public intToCritRoll As Integer ' This is the roll, if the attack hits, to determine a critical hit
    Public blnIsCrit As Boolean ' This determines if the hit is critical
    Public intDmgRoll As Integer ' This is the damage roll
    Public strHitReport As String ' This is the hit/damage report.
    Public strKillFeed As String ' This is the "kill feed," used to display a line if the monster has been killed.
    Public blnMeleeRange As Boolean ' This indicates if the fight is in melee range - used with the Engage/Disengage command
    Public blnShootRange As Boolean ' This indicates if the fight is at shooting range - used with the Engage/Disengage command

    Public Sub AttackType() ' This sub checks the active range, then when the "Attack" button is pressed launches the appropriate sub
        If blnMeleeRange = True Then
            MeleeCheck(protag.intAgility, protag.intStrength, protag.intMeleeAccMod, protag.intMeleeMinDmg,
                       protag.intMeleeMaxDmg, protag.intMeleeCritMod)
        ElseIf blnMeleeRange = False Then
            RangedCheck(protag.intAgility, protag.intRangedAccMod, protag.intRangedMinDmg,
                        protag.intRangedMaxDmg, protag.intRangedCritMod)
        End If
    End Sub



    Public Sub MeleeCheck(intAgility As Integer, intStrength As Integer, intMeleeAccuracyMod As Integer,
                          intMeleeDamageMin As Integer, intMeleeDamageMax As Integer, intMeleeCritMod As Integer)
        ' This handles melee attacks

        blnIsHit = False
        blnIsCrit = False

        Randomize()
        intToHitRoll = (100 * Rnd() + 1) 'The initial to-hit roll

        If intToHitRoll < (intAgility * 3 + 30 + intMeleeAccuracyMod) Then ' This calculates the to-hit roll versus the base hit equation
            blnIsHit = True
            Randomize()
            intToCritRoll = (100 * Rnd() + 1) ' This determines critical hits
            If intToCritRoll < ((intAgility * 3 + 30 + intMeleeAccuracyMod) - intToHitRoll) Then
                blnIsCrit = True

                Randomize()
                intDmgRoll = ((intMeleeDamageMax + (intStrength * 2)) * Rnd() + (intMeleeDamageMin + intStrength)) * intMeleeCritMod
                'Critical damage
            Else
                Randomize()
                intDmgRoll = ((intMeleeDamageMax + (intStrength * 2)) * Rnd() + (intMeleeDamageMin + intStrength))
                'Normal damage

            End If
        End If

    End Sub

    Public Sub RangedCheck(intAgility As Integer, intRangedAccuracyMod As Integer,
                          intRangedDamageMin As Integer, intRangedDamageMax As Integer, intRangedCritMod As Integer) ' This handles melee attacks

        blnIsHit = False
        blnIsCrit = False

        Randomize()
        intToHitRoll = (100 * Rnd() + 1) 'The initial to-hit roll

        If intToHitRoll < (intAgility * 3 + 30 + intRangedAccuracyMod) Then ' This calculates the to-hit roll versus the base hit equation
            blnIsHit = True
            Randomize()
            intToCritRoll = (100 * Rnd() + 1) ' This determines critical hits
            If intToCritRoll < ((intAgility * 3 + 30 + intRangedAccuracyMod) - intToHitRoll) Then
                blnIsCrit = True

                Randomize()
                intDmgRoll = (intRangedDamageMax) * Rnd() + (intRangedDamageMin) * intRangedCritMod
                'Critical damage
            Else
                Randomize()
                intDmgRoll = (intRangedDamageMax * Rnd() + intRangedDamageMin)
                'Normal damage

            End If
        End If

    End Sub

    Public Function DamageCheck(ByRef intCurrentHP As Integer, intDmgRoll As Integer, intArmorValue As Integer) As Integer
        If (intDmgRoll - intArmorValue) > 0 Then
            intCurrentHP -= (intDmgRoll - intArmorValue)
        ElseIf (intDmgRoll - intArmorValue) <= 0 Then
            intCurrentHP -= 1
        End If
        Return (intCurrentHP)
    End Function

    Public Function HitReport() As String
        strHitReport = String.Empty
        If blnIsHit = True And blnIsCrit = True Then
            strHitReport = "You critically hit for " & intDmgRoll & " damage!" & " " & strKillFeed
        ElseIf blnIsHit = True And blnIsCrit = False Then
            strHitReport = "You hit for " & intDmgRoll & " damage!" & " " & strKillFeed
        ElseIf blnIsHit = False Then
            strHitReport = "You missed!"
        End If
        Return (strHitReport)
    End Function

    'Health check (death/overheal)
    Public Function playerHPcheck(intCurrentHP As Integer, intMaxHP As Integer)
        Select Case intCurrentHP
            Case <= 0
                MessageBox.Show("You're dead...", "0xDEADBEEF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Form.ActiveForm.Close()
                intCurrentHP = Nothing
                intMaxHP = Nothing
                frmMain.Show()
            Case > intMaxHP
                intCurrentHP = intMaxHP
        End Select
        Return (intCurrentHP)
    End Function


End Module
