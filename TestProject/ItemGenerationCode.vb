Imports System.IO
Module ItemGenerationCode

    'This module contains the code for generating random items.  It's probably
    'more than a little hacky, but I'm doing the best I can with what I know how
    'to do.
    Public intRangedCreated As Integer
    Public intMeleeCreated As Integer
    Public intHelmetCreated As Integer
    Public intTorsoCreated As Integer
    Public intGlovesCreated As Integer
    Public intBootsCreated As Integer
    Public intHeadCreated As Integer
    Public intBodyCreated As Integer
    Public intArmsCreated As Integer
    Public intLegsCreated As Integer

    Public Gun(512) As RangedWeapon
    Public Melee(512) As MeleeWeapon
    Public Helmet(512) As Helmet
    Public Torso(512) As Torso
    Public Gloves(512) As Gloves
    Public Boots(512) As Boots
    Public Head(512) As HeadAug
    Public Body(512) As BodyAug
    Public Arms(512) As ArmsAug
    Public Legs(512) As LegsAug

    Public Sub makeloot()
        Dim rnditemcode As Integer
        Dim rnditemtype As String
        Dim rndweapontype As String
        Dim rndarmortype As String
        Dim rndaugtype As String
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
                Randomize()
                rndarmortype = (4 * Rnd() + 1)
                Select Case rndarmortype
                    Case 1
                        rndarmortype = "Helmet"
                        helmetgen()
                    Case 2
                        rndarmortype = "Torso"
                        torsogen()
                    Case 3
                        rndarmortype = "Gloves"
                        glovesgen()
                    Case 4
                        rndarmortype = "Boots"
                        bootsgen()
                End Select

            Case 3
                rnditemtype = "Augment"
                Randomize()
                rndaugtype = (4 * Rnd() + 1)
                Select Case rndaugtype
                    Case 1
                        rndaugtype = "Head"
                        headauggen()
                    Case 2
                        rndaugtype = "Body"
                        bodyauggen()
                    Case 3
                        rndaugtype = "Arms"
                        armsauggen()
                    Case 4
                        rndaugtype = "Legs"
                        legsauggen()
                End Select
        End Select
    End Sub

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
End Module
