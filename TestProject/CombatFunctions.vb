Module CombatFunctions
    'This module handles combat-relevant functions such as attack checks, 
    'critical hit checks, and defense/dodge checks.
    Public intToHitRoll As Integer ' This is the to-hit roll result
    Public blnIsHit As Boolean ' This determines if the roll is a hit
    Public intToCritRoll As Integer ' This is the roll, if the attack hits, to determine a critical hit
    Public blnIsCrit As Boolean ' This determines if the hit is critical
    Public intDmgRoll As Integer ' This is the damage roll
    Public intTotalDamage As Integer ' This is the total damage dealt.
    Public strHitReport As String ' This is the hit/damage report.

    Public Sub AttackCheck()

        blnIsHit = False
        blnIsCrit = False

        Randomize()
        intToHitRoll = (100 * Rnd() + 1) 'The initial to-hit roll

        If intToHitRoll < (intAgility * 8 + 30) Then ' This calculates the to-hit roll versus the base hit equation
            blnIsHit = True
            Randomize()
            intToCritRoll = (100 * Rnd() + 1) ' This determines critical hits
            If intToCritRoll < ((intAgility * 8 + 30) - intToHitRoll) Then
                blnIsCrit = True

                Randomize()
                intDmgRoll = ((intStrength * 2) * Rnd() + (intStrength * 3)) 'Critical damage is between 3-5x Strength
            Else
                Randomize()
                intDmgRoll = ((intStrength) * Rnd() + intStrength) 'Normal damage is between 1-2x Strength

            End If
        End If

    End Sub

    Public Function HitReport()
        strHitReport = String.Empty
        If blnIsHit = True And blnIsCrit = True Then
            strHitReport = "You critically strike for " & intDmgRoll & " damage!"
        ElseIf blnIsHit = True And blnIsCrit = False Then
            strHitReport = "You strike for " & intDmgRoll & " damage!"
        ElseIf blnIsHit = False Then
            strHitReport = "You missed! Take another swing!"
        End If
        Return (strHitReport)
    End Function


End Module
