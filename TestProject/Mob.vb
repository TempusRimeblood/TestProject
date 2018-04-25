Imports System.IO

Public Class Mob
    Public Property strName As String ' Enemy name
    Public Property intClassDetermine As Integer ' Randomized integer, used to determine if melee or ranged enemy
    Public Property strClass As String ' Stores the enemy class
    Public Property intStrength As Integer ' Strength
    Public Property intAgility As Integer ' Agility
    Public Property intToughness As Integer ' Toughness
    Public Property intCurrentHP As Integer 'Current HP
    Public Property intMaxHP As Integer 'Max HP
    Public Property blnIsTarget As Boolean
    Public Property blnMonsterMade 'Boolean value to confirm stats are made
    Public Property blnMonsterKilled = False 'Boolean value to determine if the monster has been killed. Starts as False.
    Public Property MobMelee As New MeleeWeapon ' Mobs have melee weapons, too
    Public Property MobGun As New RangedWeapon ' Mobs can have ranged weapons
    Public Property MobHelm As New Armor ' Mob armor is the next four variables
    Public Property MobTorso As New Armor
    Public Property MobGloves As New Armor
    Public Property MobBoots As New Armor '
    Public Property intMobArmorValue As Integer ' Mob's armor value - this is subtracted from the incoming damage
    Public Property intMeleeAccuracyMod As Integer ' Accuracy modifier - this will apply to combat functions
    Public Property intRangedAccuracyMod As Integer ' Accuracy modifier - this will apply to combat functions
    Public Property intRangedDamageMin As Integer 'Minimum ranged damage, determined by weapon
    Public Property intRangedDamageMax As Integer 'Maximum melee damage, determined by weapon
    Public Property intMeleeDamageMin As Integer 'Minimum melee damage, determined by weapon
    Public Property intMeleeDamageMax As Integer 'Maximum melee damage, determined by weapon
    Property blnHasHelmet As Boolean
    Property blnHasTorso As Boolean
    Property blnHasBoots As Boolean
    Property blnHasGloves As Boolean ' These booleans dictate how many pieces of armor an enemy has
    Property intMobIdentifier ' This integer should designate the order of mob spawns

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

    Public Function monsterstatgen() ' This generates the monster's stats, scaling based on player stats.
        Select Case strClass
            Case "Melee"
                MonsterMeleeGen()
                MonsterArmorGen()
                Randomize()
                intStrength = ((protag.intStrength + 4) * Rnd() + (protag.intStrength - 2))
                Randomize()
                intAgility = ((protag.intAgility + 1) * Rnd() + (protag.intAgility - 3))
                Randomize()
                intToughness = ((protag.intToughness + 3) * Rnd() + (protag.intToughness - 1))
                intMaxHP = intToughness * 20
                intCurrentHP = intMaxHP
                intMeleeDamageMax = MobMelee.intWpnMaxDamage
                intMeleeDamageMin = MobMelee.intWpnMinDamage
                intMeleeAccuracyMod = MobMelee.intAccuracyMod
                intRangedDamageMax = intAgility * 2
                intRangedDamageMin = intAgility - 1
                If intRangedDamageMin <= 0 Then
                    intRangedDamageMin = 1
                End If
                blnMonsterMade = True
            Case "Ranged"
                MonsterRangedGen()
                MonsterArmorGen()
                Randomize()
                intStrength = ((protag.intStrength + 1) * Rnd() + (protag.intStrength - 3))
                Randomize()
                intAgility = ((protag.intAgility + 4) * Rnd() + (protag.intAgility - 1))
                Randomize()
                intToughness = ((protag.intToughness + 2) * Rnd() + (protag.intToughness - 2))
                intMaxHP = intToughness * 20
                intCurrentHP = intMaxHP
                intRangedDamageMin = MobGun.intWpnDmgMin
                intRangedDamageMax = MobGun.intWpnDmgMax
                intRangedAccuracyMod = MobGun.intAccuracyMod
                intMeleeDamageMax = intStrength * 3
                intMeleeDamageMin = intStrength - 2
                If intMeleeDamageMin <= 0 Then
                    intMeleeDamageMin = 1
                End If
                blnMonsterMade = True
        End Select
        Return (blnMonsterMade)
    End Function

    Public Sub monsterHPcheck() ' This checks the mob's HP to determine if it is dead or not.
        Select Case intCurrentHP
            Case > 0
            Case <= 0
                blnMonsterKilled = True
                strKillFeed = "You killed the " & strName & "!"
                Me.Finalize()
        End Select
    End Sub

    Public Sub MonsterMeleeGen()
        Dim strPath, strBody(50), strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the melee weapon body, determining what kind of weapon it is
        strPath = "..\..\txt\meleebody.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBody(intX) = reader.ReadLine
            intX += 1
        Loop
        Randomize()
        MobMelee.intBody = (50 * Rnd() + 1)
        MobMelee.strBody = strBody(50 * Rnd(-1) + 1)
        Select Case MobMelee.intBody
            Case < 0, >= 10
                MobMelee.intWeaponType = 1 ' Sword
                MobMelee.SwordGen()
                MobMelee.namegen()
                MobMelee.SwordStat()

            Case > 10, <= 20
                MobMelee.intWeaponType = 2 ' Axe
                MobMelee.AxeGen()
                MobMelee.namegen()
                MobMelee.AxeStat()

            Case > 20, <= 30
                MobMelee.intWeaponType = 3 ' Club
                MobMelee.ClubGen()
                MobMelee.namegen()
                MobMelee.BluntStat()

            Case > 30, <= 40
                MobMelee.intWeaponType = 4 ' Dagger
                MobMelee.KnifeGen()
                MobMelee.namegen()
                MobMelee.KnifeStat()

            Case > 40, <= 50
                MobMelee.intWeaponType = 5 ' Power/Miscellaneous
                MobMelee.PowerGen()
                MobMelee.namegen()
                MobMelee.PowerStat()
        End Select
    End Sub

    Public Sub MonsterRangedGen()
        Dim strPath, strRcvr(60), strMag(5), strStock(6), strSight(10), strBarrel(7), strUnder(7) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the upper receiver, determining what kind of weapon it is
        strPath = "..\..\txt\upprrcvr.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strRcvr(intX) = reader.ReadLine
            intX += 1
        Loop
        Randomize()
        MobGun.intUpprRcvr = (60 * Rnd() + 1)
        MobGun.strUpprRcvr = strRcvr(60 * Rnd(-1) + 1)
        Select Case MobGun.intUpprRcvr
            Case < 0, > 16
                MobGun.intWeaponType = 1 ' Assault Rifle
                MobGun.ARGen()
                MobGun.gunstat()
            Case >= 16, <= 30
                MobGun.intWeaponType = 2 ' Shotgun
                MobGun.SGgen()
                MobGun.gunstat()
            Case >= 31, <= 45
                MobGun.intWeaponType = 3 ' Handgun
                MobGun.HGgen()
                MobGun.gunstat()
            Case >= 46, <= 60
                MobGun.intWeaponType = 4 ' Heavy Weapon
                MobGun.HVYgen()
                MobGun.gunstat()
        End Select
    End Sub

    Public Sub MonsterArmorGen()
        Dim rng = New Random()
        blnHasHelmet = rng.Next(0, 2) > 0
        blnHasBoots = rng.Next(0, 2) > 0
        blnHasGloves = rng.Next(0, 2) > 0
        blnHasTorso = rng.Next(0, 2) > 0
        If blnHasHelmet = True Then
            MobHelm.HelmetGen()
            MobHelm.HelmetStats()
            MobHelm.Affixes()
        End If
        If blnHasBoots = True Then
            MobBoots.BootsGen()
            MobBoots.BootsStats()
            MobBoots.Affixes()
        End If
        If blnHasGloves = True Then
            MobGloves.GloveGen()
            MobGloves.GlovesStats()
            MobGloves.Affixes()
        End If
        If blnHasTorso = True Then
            MobTorso.TorsoGen()
            MobTorso.TorsoStats()
            MobTorso.Affixes()
        End If

        intMobArmorValue = MobHelm.intArmorValue + MobTorso.intArmorValue + MobGloves.intArmorValue + MobBoots.intArmorValue
    End Sub


End Class
