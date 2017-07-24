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
                ARGen()
                Gun(intRangedCreated).gunstat()
            Case >= 16, <= 30
                Gun(intRangedCreated).intWeaponType = 2 ' Shotgun
                SGgen()
                Gun(intRangedCreated).gunstat()
            Case >= 31, <= 45
                Gun(intRangedCreated).intWeaponType = 3
                HGgen()
                Gun(intRangedCreated).gunstat() ' Handgun
            Case >= 46, <= 60
                Gun(intRangedCreated).intWeaponType = 4
                HVYgen()
                Gun(intRangedCreated).gunstat() ' Heavy Weapon
        End Select
        intRangedCreated += 1
    End Sub

    Public Sub ARGen()
        Dim strPath, strRcvr(60), strMag(5), strStock(6), strSight(10), strBarrel(7), strUnder(7) As String
        Dim intX As Integer
        Dim reader As StreamReader
        'This determines the magazine type
        intX = 1
        Randomize()
        strPath = "..\..\txt\magazine.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strMag(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intMagazine = strMag(5 * Rnd() + 1)
        Gun(intRangedCreated).strMagazine = strMag(5 * Rnd(-1) + 1)

        'This determines the stock type
        intX = 1
        Randomize()
        strPath = "..\..\txt\stock.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strStock(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intStock = strStock(6 * Rnd() + 1)
        Gun(intRangedCreated).strStock = strStock(6 * Rnd(-1) + 1)

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intSight = strSight(10 * Rnd() + 1)
        Gun(intRangedCreated).strSight = strSight(10 * Rnd(-1) + 1)

        'This determines the barrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\barrel.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBarrel(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intBarrel = strBarrel(7 * Rnd() + 1)
        Gun(intRangedCreated).strBarrel = strBarrel(7 * Rnd(-1) + 1)

        'This is the underbarrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\under.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strUnder(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intUnder = strUnder(7 * Rnd() + 1)
        Gun(intRangedCreated).strUnder = strUnder(7 * Rnd(-1) + 1)

        'Name generation
        Gun(intRangedCreated).strName = Gun(intRangedCreated).strStock & " " & Gun(intRangedCreated).strSight & " " & Gun(intRangedCreated).strMagazine &
            " " & Gun(intRangedCreated).strUnder & " " & Gun(intRangedCreated).strBarrel & " " & Gun(intRangedCreated).strUpprRcvr
    End Sub

    Public Sub SGgen() 'Shotgun generation
        Dim strPath, strRcvr(60), strMag(5), strStock(6), strSight(10), strBarrel(7), strUnder(7) As String
        Dim intX As Integer
        Dim reader As StreamReader
        'This determines the magazine type
        intX = 1
        Randomize()
        strPath = "..\..\txt\magazine.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strMag(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intMagazine <> 4 And Gun(intRangedCreated).intMagazine <> 5
            Gun(intRangedCreated).intMagazine = strMag(5 * Rnd() + 1)
            Gun(intRangedCreated).strMagazine = strMag(5 * Rnd(-1) + 1)
        Loop

        'This determines the stock type
        intX = 1
        Randomize()
        strPath = "..\..\txt\stock.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strStock(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intStock = strStock(6 * Rnd() + 1)
        Gun(intRangedCreated).strStock = strStock(6 * Rnd(-1) + 1)

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intSight < 7
            Gun(intRangedCreated).intSight = strSight(10 * Rnd() + 1)
            Gun(intRangedCreated).strSight = strSight(10 * Rnd(-1) + 1)
        Loop

        'This determines the barrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\barrel.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBarrel(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intBarrel < 5
            Gun(intRangedCreated).intBarrel = strBarrel(7 * Rnd() + 1)
            Gun(intRangedCreated).strBarrel = strBarrel(7 * Rnd(-1) + 1)
        Loop

        'This is the underbarrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\under.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strUnder(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intUnder <> 6
            Gun(intRangedCreated).intUnder = strUnder(7 * Rnd() + 1)
            Gun(intRangedCreated).strUnder = strUnder(7 * Rnd(-1) + 1)
        Loop

        'Name generation
        Gun(intRangedCreated).strName = Gun(intRangedCreated).strStock & " " & Gun(intRangedCreated).strSight & " " & Gun(intRangedCreated).strMagazine &
            " " & Gun(intRangedCreated).strUnder & " " & Gun(intRangedCreated).strBarrel & " " & Gun(intRangedCreated).strUpprRcvr
    End Sub

    Public Sub HGgen() 'Handgun generation
        Dim strPath, strRcvr(60), strMag(5), strStock(6), strSight(10), strBarrel(7), strUnder(7) As String
        Dim intX As Integer
        Dim reader As StreamReader
        'This determines the magazine type
        intX = 1
        Randomize()
        strPath = "..\..\txt\magazine.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strMag(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intMagazine <> 4
            Gun(intRangedCreated).intMagazine = strMag(5 * Rnd() + 1)
            Gun(intRangedCreated).strMagazine = strMag(5 * Rnd(-1) + 1)
        Loop

        'Stock work - this is because pistols cannot have stocks in-game
        Gun(intRangedCreated).intStock = 1
        Gun(intRangedCreated).strStock = "NULL"

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intSight < 5
            Gun(intRangedCreated).intSight = strSight(10 * Rnd() + 1)
            Gun(intRangedCreated).strSight = strSight(10 * Rnd(-1) + 1)
        Loop

        'This determines the barrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\barrel.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBarrel(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intBarrel <> 2 And Gun(intRangedCreated).intBarrel <> 3
            Gun(intRangedCreated).intBarrel = strBarrel(7 * Rnd() + 1)
            Gun(intRangedCreated).strBarrel = strBarrel(7 * Rnd(-1) + 1)
        Loop

        'This is the underbarrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\under.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strUnder(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intUnder <> 2 And Gun(intRangedCreated).intUnder <> 3 And Gun(intRangedCreated).intUnder <> 6
            Gun(intRangedCreated).intUnder = strUnder(7 * Rnd() + 1)
            Gun(intRangedCreated).strUnder = strUnder(7 * Rnd(-1) + 1)
        Loop

        'Name generation
        Gun(intRangedCreated).strName = Gun(intRangedCreated).strStock & " " & Gun(intRangedCreated).strSight & " " & Gun(intRangedCreated).strMagazine &
            " " & Gun(intRangedCreated).strUnder & " " & Gun(intRangedCreated).strBarrel & " " & Gun(intRangedCreated).strUpprRcvr
    End Sub
    Public Sub HVYgen() 'Heavy Weapons generation
        Dim strPath, strRcvr(60), strMag(5), strStock(6), strSight(10), strBarrel(7), strUnder(7) As String
        Dim intX As Integer
        Dim reader As StreamReader
        'This determines the magazine type
        intX = 1
        Randomize()
        strPath = "..\..\txt\magazine.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strMag(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).strMagazine <> 4
            Gun(intRangedCreated).intMagazine = strMag(5 * Rnd() + 1)
            Gun(intRangedCreated).strMagazine = strMag(5 * Rnd(-1) + 1)
        Loop

        'This determines the stock type
        intX = 1
        Randomize()
        strPath = "..\..\txt\stock.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strStock(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intStock = strStock(6 * Rnd() + 1)
        Gun(intRangedCreated).strStock = strStock(6 * Rnd(-1) + 1)

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intSight = strSight(10 * Rnd() + 1)
        Gun(intRangedCreated).strSight = strSight(10 * Rnd(-1) + 1)

        'This determines the barrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\barrel.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBarrel(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until Gun(intRangedCreated).intBarrel <> 3 And Gun(intRangedCreated).intBarrel <> 5
            Gun(intRangedCreated).intBarrel = strBarrel(7 * Rnd() + 1)
            Gun(intRangedCreated).strBarrel = strBarrel(7 * Rnd(-1) + 1)
        Loop

        'This is the underbarrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\under.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strUnder(intX) = reader.ReadLine
            intX += 1
        Loop
        Gun(intRangedCreated).intUnder = strUnder(7 * Rnd() + 1)
        Gun(intRangedCreated).strUnder = strUnder(7 * Rnd(-1) + 1)

        'Name generation
        Gun(intRangedCreated).strName = Gun(intRangedCreated).strStock & " " & Gun(intRangedCreated).strSight & " " & Gun(intRangedCreated).strMagazine &
            " " & Gun(intRangedCreated).strUnder & " " & Gun(intRangedCreated).strBarrel & " " & Gun(intRangedCreated).strUpprRcvr
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
        Melee(intArmorCreated).strBody = strBody(40 * Rnd(-1) + 1)
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

End Module
