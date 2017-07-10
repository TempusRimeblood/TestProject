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

        Dim strPath, strRcvr(60), strMag(4), strStock(5), str As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        strPath = "..\..\txt\upprrcvr.txt"
        reader = File.OpenText(strPath)

        Do While reader.Peek <> reader.EndOfStream
            strRcvr(intX) = reader.ReadLine
            intX += 1
        Loop

        Randomize()
        Gun(intRangedCreated).intUpprRcvr = strRcvr(60 * Rnd() + 1)
        Select Case Gun(intRangedCreated).intUpprRcvr
            Case < 0, > 16
                Gun(intRangedCreated).intWeaponType = 1 ' Assault Rifle
            Case >= 16, <= 30
                Gun(intRangedCreated).intWeaponType = 2 ' Shotgun
            Case >= 31, <= 45
                Gun(intRangedCreated).intWeaponType = 3 ' Handgun
            Case >= 46, <= 60
                Gun(intRangedCreated).intWeaponType = 4 ' Heavy Weapon
        End Select
        If Gun(intRangedCreated).intWeaponType = 1 Then
            intX = 1
            Randomize()
            strPath = "..\..\txt\magazine.txt"
            reader = File.OpenText(strPath)
            Do While reader.Peek <> reader.EndOfStream
                strMag(intX) = reader.ReadLine
                intX += 1
            Loop
            Gun(intRangedCreated).intMagazine = strMag(4 * Rnd() + 1)
            Gun(intRangedCreated).strMagazine = strMag(4 * Rnd(-1) + 1)
        End If
        intRangedCreated += 1
    End Sub
End Module
