Public Class Mob
    Public strName As String ' Enemy name
    Public intClassDetermine As Integer ' Randomized integer, used to determine if melee or ranged enemy
    Public strClass As String ' Stores the enemy class
    Public intStrength As Integer ' Strength
    Public intAgility As Integer ' Agility
    Public intToughness As Integer ' Toughness
    Public intCurrentHP As Integer 'Current HP
    Public intMaxHP As Integer 'Max HP
    Public blnMonsterMade 'Boolean value to confirm stats are made

    'Attempting to add function to randomize intClassDetermine.
    Public Function chooseclass()
        Randomize()
        intClassDetermine = (2 * Rnd() + 1)
        If intClassDetermine = 1 Then
            strClass = "Melee"
        ElseIf intClassDetermine = 2 Then
            strClass = "Ranged"
        End If
        Return (strClass)


    End Function

    Public Function monsterstatgen()
        Select Case strClass
            Case "Melee"
                Randomize()
                intStrength = ((protag.intStrength + 4) * Rnd() + (protag.intStrength - 2))
                Randomize()
                intAgility = ((protag.intAgility + 1) * Rnd() + (protag.intStrength - 3))
                Randomize()
                intToughness = ((protag.intToughness + 3) * Rnd() + (protag.intToughness - 1))
                intMaxHP = intToughness * 3
                intCurrentHP = intMaxHP
                blnMonsterMade = True
            Case "Ranged"
                Randomize()
                intStrength = ((protag.intStrength + 1) * Rnd() + (protag.intStrength - 3))
                Randomize()
                intAgility = ((protag.intAgility + 4) * Rnd() + (protag.intStrength - 1))
                Randomize()
                intToughness = ((protag.intToughness + 2) * Rnd() + (protag.intToughness - 2))
                intMaxHP = intToughness * 3
                intCurrentHP = intMaxHP
                blnMonsterMade = True
        End Select
        Return (blnMonsterMade)
    End Function



End Class
