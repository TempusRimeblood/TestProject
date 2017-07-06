Module CombatFunctions
    'This module handles combat-relevant functions such as attack checks, 
    'critical hit checks, and defense/dodge checks.
    Public intToHitRoll As Integer ' This is the to-hit roll result
    Public blnIsHit As Boolean ' This determines if the roll is a hit
    Public intToCritRoll As Integer ' This is the roll, if the attack hits, to determine a critical hit
    Public blnIsCrit As Boolean ' This determines if the hit is critical
    Public intDmgRoll As Integer ' This is the damage roll
    Public intTotalDamage As Integer ' This is the total damage dealt, which gets calculated by adding things like weapon values et al. To be implemented later.
    Public strHitReport As String ' This is the hit/damage report.
    Public strKillFeed As String ' This is the "kill feed," used to display a line if the monster has been killed.

    Public Function AttackCheck(intAgility As Integer, intStrength As Integer) As Integer

        If Mobs(intMobsCreated).blnMonsterKilled = False Then
            MessageBox.Show("There is nothing to attack here.", "NO TARGET", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            strHitReport = "You can't attack the darkness."
            intDmgRoll = 0
        End If

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
        Return (intDmgRoll)

    End Function

    Public Function DamageCheck(ByRef intCurrentHP As Integer, intDmgRoll As Integer) As Integer
        intCurrentHP -= intDmgRoll
        Return (intCurrentHP)
    End Function

    Public Function HitReport() As String
        strHitReport = String.Empty
        If blnIsHit = True And blnIsCrit = True Then
            strHitReport = "You critically strike for " & intDmgRoll & " damage!" & " " & strKillFeed
        ElseIf blnIsHit = True And blnIsCrit = False Then
            strHitReport = "You strike for " & intDmgRoll & " damage!" & " " & strKillFeed
        ElseIf blnIsHit = False Then
            strHitReport = "You missed! Take another swing!"
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
