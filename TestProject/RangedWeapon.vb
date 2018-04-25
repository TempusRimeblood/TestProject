Imports System.IO

Public Class RangedWeapon
    'This class is for randomly-affixed ranged weapons.
    Public intUpprRcvr As Integer 'Upper Receiver - controls what kind of ranged weapon it is.  This will have more effects later.
    Public strUpprRcvr As String
    Public intWeaponType As Integer 'Weapon Type - this is the type of weapon determined by the Upper Reciever
    Public intMagazine As Integer 'Magazine - mostly fluff, to be implemented if there is an ammo system implemented
    Public strMagazine As String
    Public intWpnStock As Integer 'Stock - this is going to affect the weapon's accuracy rating, if the weapon can have a stock
    Public strWpnStock As String
    Public intWpnBarrel As Integer 'Barrel mod - this will have different effects when event generation becomes a thing
    Public strWpnBarrel As String
    Public intWpnUnder As Integer 'Underbarrel mod - on weapons that support this, different effects, possibly even melee weapon.
    Public strWpnUnder As String
    Public intWpnSight As Integer 'Sight mod - this affects the weapon's accuracy
    Public strWpnSight As String
    Public strName As String 'Weapon name - this will be aggregated from the various mod strings e.g. "Smartlinked Ergo-Grip Riot Shotgun"

    'These are the variables that affect stats and derived stats
    Public intWpnDmgMin As Integer ' Minimum ranged weapon damage
    Public intWpnDmgMax As Integer ' Maximum ranged weapon damage
    Public intAccuracyMod As Integer ' Weapon accuracy and critical chance modifier
    Public intCritMod As Integer ' critical damage multiplier

    'Note: other weapon-derived properties are gonna be put here
    'blnFreeShotOffense - offensive trait for shotguns when closing to melee range
    'blnFreeShotDefense - defensive trait for pistols when enemy closes to melee range
    'blnSilenced - event-based trait for silenced weapons
    'blnRockNRoll - event-based trait for LMGs
    'etc

    Public Sub gunstat()
        Select Case intWeaponType
            Case 1 ' Assault Rifle
                intWpnDmgMin = 10
                intWpnDmgMax = 25
                intCritMod = 3
            Case 2 ' Shotgun
                intWpnDmgMin = 5
                intWpnDmgMax = 40
                intCritMod = 5
            Case 3 'Handgun
                intWpnDmgMin = 5
                intWpnDmgMax = 20
                intCritMod = 2
            Case 4 ' Heavy Weapon
                intWpnDmgMin = 15
                intWpnDmgMax = 35
                intAccuracyMod = -15
                intCritMod = 4
        End Select
        Select Case intWpnStock
            Case 1 ' Null value, represents a default stock/lack thereof
                intAccuracyMod += 0
            Case 2 ' Recoil-Absorbing
                intAccuracyMod += 5
            Case 3 ' Padded
                intAccuracyMod += 3
            Case 4 ' Folding
                intAccuracyMod += 2
            Case 5 ' Braced
                intAccuracyMod += 10
            Case 6 ' Hip-Slung
                intAccuracyMod += 7
        End Select
        Select Case intWpnSight
            Case 1 ' Null value, represents a default iron-sight
                intAccuracyMod += 0
            Case 2 ' Red Dot Sight
                intAccuracyMod += 5
            Case 3 ' Reflex Sight
                intAccuracyMod += 5
            Case 4 ' Tritium Sight
                intAccuracyMod += 3
            Case 5 ' Marksman Sight
                intAccuracyMod += 3
            Case 6 ' Holographic Sight
                intAccuracyMod += 5
            Case 7 ' ACOG Scope
                intAccuracyMod += 8
            Case 8 ' Hard-Light Construct Scope
                intAccuracyMod += 10
            Case 9 ' Magnified Scope
                intAccuracyMod += 10
            Case 10 ' Extended Battle Rifle Scope
                intAccuracyMod += 15
        End Select
        Select Case intWpnBarrel
            Case 1 ' Null value, represents no barrel modification
                intWpnDmgMin += 0
                intWpnDmgMax += 0
            Case 2 ' Long Barrel
                intWpnDmgMax += 5
                intWpnDmgMin += 2
                intAccuracyMod += 2
            Case 3 ' Sawn-Off
                Select Case intWeaponType
                    Case 1 ' Assault Rifle
                        intWpnDmgMax -= 1
                        intWpnDmgMin -= 1
                        intAccuracyMod -= 2
                    Case 2 ' Shotgun
                        intWpnDmgMax += 10
                        intWpnDmgMin += 5
                        intAccuracyMod -= 10
                    Case 3 ' Handgun
                        'This doesn't exist.
                    Case 4 ' Heavy Weapon
                        intWpnDmgMax -= 0
                        intWpnDmgMax -= 0
                        intAccuracyMod -= 10
                End Select
            Case 4 ' Compensated
                intAccuracyMod += 5
            Case 5 ' Suppressed
                intWpnDmgMax -= 5
                intWpnDmgMin -= 2
                intAccuracyMod -= 3
            Case 6 ' Heavy-Caliber
                intWpnDmgMax += 10
                intWpnDmgMin += 10
                intAccuracyMod -= 3
            Case 7 ' Heat-Dispersing
                Select Case intWeaponType
                    Case 1, 2, 3
                        intAccuracyMod += 5
                    Case 4
                        intAccuracyMod += 10
                End Select
        End Select
        Select Case intWpnUnder
            Case 1 ' Null value, represents no underbarrel attachment
            Case 2 ' Ergonomic Grip
                Select Case intWeaponType
                    Case 1, 2, 3
                        intAccuracyMod += 5
                    Case 4
                        intAccuracyMod += 3
                End Select
            Case 3 ' Cruiser Grip
                Select Case intWeaponType
                    Case 1, 2
                        intAccuracyMod += 5
                    Case 3, 4
                        intAccuracyMod += 2
                End Select
            Case 4 ' Tac-Lighted
                Select Case intWeaponType
                    Case 1, 2, 3
                        intAccuracyMod += 4
                    Case 4
                        intAccuracyMod += 2
                End Select
            Case 5 ' Laser-Sighted
                Select Case intWeaponType
                    Case 1, 4
                        intAccuracyMod += 3
                    Case 2, 3
                        intAccuracyMod += 5
                End Select
            Case 6 ' Bipod-Mounted
                Select Case intWeaponType
                    Case 1
                        intAccuracyMod += 2
                    Case 4
                        intAccuracyMod += 15
                End Select
            Case 7 ' GunCam-Mounted
                intAccuracyMod += 5
        End Select
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
        intMagazine = (5 * Rnd() + 1)
        strMagazine = strMag(5 * Rnd(-1) + 1)

        'This determines the stock type
        intX = 1
        Randomize()
        strPath = "..\..\txt\stock.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strStock(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnStock = (6 * Rnd() + 1)
        strWpnStock = strStock(6 * Rnd(-1) + 1)

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSight = (10 * Rnd() + 1)
        strWpnSight = strSight(10 * Rnd(-1) + 1)

        'This determines the barrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\barrel.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBarrel(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnBarrel = (7 * Rnd() + 1)
        strWpnBarrel = strBarrel(7 * Rnd(-1) + 1)

        'This is the underbarrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\under.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strUnder(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnUnder = (7 * Rnd() + 1)
        strWpnUnder = strUnder(7 * Rnd(-1) + 1)

        'Name generation
        strName = strWpnStock & " " & strWpnSight & " " & strMagazine &
            " " & strWpnUnder & " " & strWpnBarrel & " " & strUpprRcvr
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
        Do Until intMagazine <> 4 And intMagazine <> 5
            intMagazine = (5 * Rnd() + 1)
            strMagazine = strMag(5 * Rnd(-1) + 1)
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
        intWpnStock = (6 * Rnd() + 1)
        strWpnStock = strStock(6 * Rnd(-1) + 1)

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until intWpnSight < 7
            intWpnSight = (10 * Rnd() + 1)
            strWpnSight = strSight(10 * Rnd(-1) + 1)
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
        Do Until intWpnBarrel < 5
            intWpnBarrel = (7 * Rnd() + 1)
            strWpnBarrel = strBarrel(7 * Rnd(-1) + 1)
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
        Do Until intWpnUnder <> 6
            intWpnUnder = (7 * Rnd() + 1)
            strWpnUnder = strUnder(7 * Rnd(-1) + 1)
        Loop

        'Name generation
        strName = strWpnStock & " " & strWpnSight & " " & strMagazine &
            " " & strWpnUnder & " " & strWpnBarrel & " " & strUpprRcvr
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
        Do Until intMagazine <> 4
            intMagazine = (5 * Rnd() + 1)
            strMagazine = strMag(5 * Rnd(-1) + 1)
        Loop

        'Stock work - this is because pistols cannot have stocks in-game
        intWpnStock = 1
        strWpnStock = "NULL"

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until intWpnSight < 5
            intWpnSight = (10 * Rnd() + 1)
            strWpnSight = strSight(10 * Rnd(-1) + 1)
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
        Do Until intWpnBarrel <> 2 And intWpnBarrel <> 3
            intWpnBarrel = (7 * Rnd() + 1)
            strWpnBarrel = strBarrel(7 * Rnd(-1) + 1)
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
        Do Until intWpnUnder <> 2 And intWpnUnder <> 3 And intWpnUnder <> 6
            intWpnUnder = (7 * Rnd() + 1)
            strWpnUnder = strUnder(7 * Rnd(-1) + 1)
        Loop

        'Name generation
        strName = strWpnStock & " " & strWpnSight & " " & strMagazine &
            " " & strWpnUnder & " " & strWpnBarrel & " " & strUpprRcvr
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
        Do Until strMagazine <> 4
            intMagazine = (5 * Rnd() + 1)
            strMagazine = strMag(5 * Rnd(-1) + 1)
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
        intWpnStock = (6 * Rnd() + 1)
        strWpnStock = strStock(6 * Rnd(-1) + 1)

        'This determines the sight type
        intX = 1
        Randomize()
        strPath = "..\..\txt\sight.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSight(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSight = (10 * Rnd() + 1)
        strWpnSight = strSight(10 * Rnd(-1) + 1)

        'This determines the barrel modification
        intX = 1
        Randomize()
        strPath = "..\..\txt\barrel.txt"
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strBarrel(intX) = reader.ReadLine
            intX += 1
        Loop
        Do Until intWpnBarrel <> 3 And intWpnBarrel <> 5
            intWpnBarrel = (7 * Rnd() + 1)
            strWpnBarrel = strBarrel(7 * Rnd(-1) + 1)
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
        intWpnUnder = (7 * Rnd() + 1)
        strWpnUnder = strUnder(7 * Rnd(-1) + 1)

        'Name generation
        strName = strWpnStock & " " & strWpnSight & " " & strMagazine &
            " " & strWpnUnder & " " & strWpnBarrel & " " & strUpprRcvr
    End Sub
End Class
