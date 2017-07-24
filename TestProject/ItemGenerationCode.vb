Imports System.IO
Module ItemGenerationCode

    'This module contains the code for generating random items.  It's probably
    'more than a little hacky, but I'm doing the best I can with what I know how
    'to do.
    Public intRangedCreated As Integer
    Public intMeleeCreated As Integer
    Public intArmorCreated As Integer
    Public intAugsCreated As Integer

    Public Gun(512) As RangedWeapon
    Public Melee(512) As MeleeWeapon
    Public Armor(512) As Armor
    Public Augs(512) As Aug

    'This sub determines what kind of loot to generate on a loot drop.
    Public Sub makeloot()
        Dim rnditemcode As Integer
        Dim rnditemtype As String
        Dim rndweapontype As String
        Randomize()
        rnditemcode = (3 * Rnd() + 1)
        Select Case rnditemcode
            Case 1
                rnditemtype = "Weapon"
                Randomize()
                rndweapontype = (2 * Rnd() + 1)
                Select Case rndweapontype
                    Case 1
                        rndweapontype = "Melee"
                        meleegen()
                    Case 2
                        rndweapontype = "Ranged"
                        RangedGen()
                End Select
            Case 2
                rnditemtype = "Armor"
                armorgen()
            Case 3
                rnditemtype = "Augment"
                auggen()
        End Select
    End Sub
    'This is the ranged weapon generation function.  I can break this and the XXgen() functions out into the RangedWeapon class
    'for simplicity's sake.

    Public Sub RangedGen()
        Gun(intRangedCreated) = New RangedWeapon
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
        Gun(intRangedCreated).intUpprRcvr = strRcvr(60 * Rnd() + 1)
        Gun(intRangedCreated).strUpprRcvr = strRcvr(60 * Rnd(-1) + 1)
        Select Case Gun(intRangedCreated).intUpprRcvr
            Case < 0, > 16
                Gun(intRangedCreated).intWeaponType = 1 ' Assault Rifle
                Gun(intRangedCreated).ARGen()
                Gun(intRangedCreated).gunstat()
            Case >= 16, <= 30
                Gun(intRangedCreated).intWeaponType = 2 ' Shotgun
                Gun(intRangedCreated).SGgen()
                Gun(intRangedCreated).gunstat()
            Case >= 31, <= 45
                Gun(intRangedCreated).intWeaponType = 3
                Gun(intRangedCreated).HGgen()
                Gun(intRangedCreated).gunstat() ' Handgun
            Case >= 46, <= 60
                Gun(intRangedCreated).intWeaponType = 4
                Gun(intRangedCreated).HVYgen()
                Gun(intRangedCreated).gunstat() ' Heavy Weapon
        End Select
        intRangedCreated += 1
    End Sub



    'This is the melee generation sub. It starts the process of generating a new melee weapon, but the core functions and subs
    'are contained within the actual MeleeWeapon class.
    Public Sub MeleeGen()
        Melee(intMeleeCreated) = New MeleeWeapon
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
        Melee(intMeleeCreated).intBody = strBody(50 * Rnd() + 1)
        Melee(intMeleeCreated).strBody = strBody(50 * Rnd(-1) + 1)
        Select Case Melee(intMeleeCreated).intBody
            Case < 0, >= 10
                Melee(intMeleeCreated).intWeaponType = 1 ' Sword
                Melee(intMeleeCreated).SwordGen()
                Melee(intMeleeCreated).namegen()
                Melee(intMeleeCreated).SwordStat()

            Case > 10, <= 20
                Melee(intMeleeCreated).intWeaponType = 2 ' Axe
                Melee(intMeleeCreated).AxeGen()
                Melee(intMeleeCreated).namegen()
                Melee(intMeleeCreated).AxeStat()

            Case > 20, <= 30
                Melee(intMeleeCreated).intWeaponType = 3 ' Club
                Melee(intMeleeCreated).ClubGen()
                Melee(intMeleeCreated).namegen()
                Melee(intMeleeCreated).BluntStat()

            Case > 30, <= 40
                Melee(intMeleeCreated).intWeaponType = 4 ' Dagger
                Melee(intMeleeCreated).KnifeGen()
                Melee(intMeleeCreated).namegen()
                Melee(intMeleeCreated).KnifeStat()

            Case > 40, <= 50
                Melee(intMeleeCreated).intWeaponType = 5 ' Power/Miscellaneous
                Melee(intMeleeCreated).PowerGen()
                Melee(intMeleeCreated).namegen()
                Melee(intMeleeCreated).PowerStat()
        End Select
        intMeleeCreated += 1
    End Sub

    'This is the armor generation sub

    Public Sub armorgen()
        Armor(intarmorCreated) = New Armor
        Dim strPath, strBody(40), strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the armor body, determining what kind of armor it is
        strPath = "..\..\txt\armorbody.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBody(intX) = reader.ReadLine
            intX += 1
        Loop
        Randomize()
        Armor(intArmorCreated).intBody = strBody(40 * Rnd() + 1)
        Armor(intArmorCreated).strBody = strBody(40 * Rnd(-1) + 1)
        Select Case Armor(intArmorCreated).intBody
            Case < 0, >= 10
                Armor(intArmorCreated).intArmorType = 1 ' Helmet
                Armor(intArmorCreated).helmetgen()
                Armor(intArmorCreated).namegen()
                Armor(intArmorCreated).HelmetStats()
                Armor(intArmorCreated).Affixes()

            Case > 10, <= 20
                Armor(intArmorCreated).intArmorType = 2 ' Torso
                Armor(intArmorCreated).torsogen()
                Armor(intArmorCreated).namegen()
                Armor(intArmorCreated).TorsoStats()
                Armor(intArmorCreated).Affixes()
            Case > 20, <= 30
                Armor(intArmorCreated).intArmorType = 3 ' Gloves
                Armor(intArmorCreated).glovegen()
                Armor(intArmorCreated).namegen()
                Armor(intArmorCreated).GlovesStats()
                Armor(intArmorCreated).Affixes()
            Case > 30, <= 40
                Armor(intArmorCreated).intArmorType = 4 ' Boots
                Armor(intArmorCreated).bootsgen()
                Armor(intArmorCreated).namegen()
                Armor(intArmorCreated).BootsStats()
                Armor(intArmorCreated).Affixes()

        End Select
        intArmorCreated += 1
    End Sub

    'This is the aug generation sub
    Public Sub auggen()
        Augs(intAugsCreated) = New Aug
        Dim strPath, strBody(20), strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the aug body, determining what kind of aug it is
        strPath = "..\..\txt\augbody.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBody(intX) = reader.ReadLine
            intX += 1
        Loop
        Randomize()
        Augs(intAugsCreated).intBody = strBody(20 * Rnd() + 1)
        Augs(intAugsCreated).strBody = strBody(20 * Rnd(-1) + 1)
        Select Case Armor(intArmorCreated).intBody
            Case < 0, >= 5
                Augs(intAugsCreated).intAugType = 1 ' Head
                Augs(intAugsCreated).headauggen()
                Augs(intAugsCreated).namegen()
            Case > 6, <= 10
                Augs(intAugsCreated).intAugType = 2 ' Body
                Augs(intAugsCreated).bodyauggen()
                Augs(intAugsCreated).namegen()

            Case > 10, <= 15
                Augs(intAugsCreated).intAugType = 3 ' Arms
                Augs(intAugsCreated).armsauggen()
                Augs(intAugsCreated).namegen()

            Case > 16, <= 20
                Augs(intAugsCreated).intAugType = 4 ' Legs
                Augs(intAugsCreated).legsauggen()
                Augs(intAugsCreated).namegen()

        End Select
        intAugsCreated += 1
    End Sub

End Module
