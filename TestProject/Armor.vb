Imports System.IO

Public Class Armor
    'This is the Armor class (not to be confused with Armor Class, despite this being an old-school-inspired RPG.)
    Public intBody As Integer ' This integer and string control the armor's Body property
    Public strBody As String
    Public intArmPrefix As Integer ' This integer and string control the armor's prefix
    Public strArmPrefix As String
    Public intArmSuffix As Integer ' This integer and string control the armor's suffix
    Public strArmSuffix As String
    Public intArmorType As Integer ' This controls the armor's type, which affects which slot it equips to.
    Public strName As String ' This is the armor's name, as "X Y of Z" such as "Studded Combat Boots of Grip"

    'This integer is armor value, and is theoretically a randomized number.  Static values may be used in its stead.
    Public intArmorValue As Integer

    'Integers and Booleans will go here eventually regarding armor-derived properties and other stats, like dodge chance etc.
    'intDodgeMod - dodge chance
    'blnIsBulky - event-based modifier
    'etc.

    'Helmet generation sub
    Public Sub HelmetGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\armorprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmPrefix = strPrefix(10 * Rnd() + 1)
        strArmPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\armorsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmSuffix = strSuffix(10 * Rnd() + 1)
        strArmSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    'Torso generation sub
    Public Sub TorsoGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\armorprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmPrefix = strPrefix(10 * Rnd() + 1)
        strArmPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\armorsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmSuffix = strSuffix(10 * Rnd() + 1)
        strArmSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    'Gloves generation sub
    Public Sub GloveGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\armorprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmPrefix = strPrefix(10 * Rnd() + 1)
        strArmPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\armorsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmSuffix = strSuffix(10 * Rnd() + 1)
        strArmSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    'Boots generation sub
    Public Sub BootsGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\armorprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmPrefix = strPrefix(10 * Rnd() + 1)
        strArmPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\armorsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intArmSuffix = strSuffix(10 * Rnd() + 1)
        strArmSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    Public Function namegen()
        strName = strArmPrefix & " " & strBody & " " & strArmSuffix
        Return (strName)
    End Function

    Public Sub HelmetStats() ' this generates armor numbers for the helmet
        Randomize()
        Select Case intBody
            Case 1
                intArmorValue = (3 * Rnd() + 1)
            Case 2
                intArmorValue = (4 * Rnd() + 1)
            Case 3
                intArmorValue = (4 * Rnd() + 2)
            Case 4
                intArmorValue = (5 * Rnd() + 2)
            Case 5
                intArmorValue = (6 * Rnd() + 3)
            Case 6
                intArmorValue = (7 * Rnd() + 4)
            Case 7
                intArmorValue = (7 * Rnd() + 5)
            Case 8
                intArmorValue = (8 * Rnd() + 5)
            Case 9
                intArmorValue = (9 * Rnd() + 6)
            Case 10
                intArmorValue = (11 * Rnd() + 8)
        End Select
    End Sub
    Public Sub TorsoStats() ' this generates armor numbers for the torso
        Randomize()
        Select Case intBody
            Case 11
                intArmorValue = (5 * Rnd() + 3)
            Case 12
                intArmorValue = (6 * Rnd() + 3)
            Case 13
                intArmorValue = (7 * Rnd() + 4)
            Case 14
                intArmorValue = (8 * Rnd() + 5)
            Case 15
                intArmorValue = (9 * Rnd() + 6)
            Case 16
                intArmorValue = (10 * Rnd() + 7)
            Case 17
                intArmorValue = (12 * Rnd() + 9)
            Case 18
                intArmorValue = (15 * Rnd() + 11)
            Case 19
                intArmorValue = (17 * Rnd() + 13)
            Case 20
                intArmorValue = (20 * Rnd() + 15)
        End Select
    End Sub
    Public Sub GlovesStats() ' this generates armor numbers for the gloves
        Randomize()
        Select Case intBody
            Case 21
                intArmorValue = (3 * Rnd() + 1)
            Case 22
                intArmorValue = (4 * Rnd() + 1)
            Case 23
                intArmorValue = (4 * Rnd() + 2)
            Case 24
                intArmorValue = (5 * Rnd() + 2)
            Case 25
                intArmorValue = (6 * Rnd() + 3)
            Case 26
                intArmorValue = (7 * Rnd() + 4)
            Case 27
                intArmorValue = (7 * Rnd() + 5)
            Case 28
                intArmorValue = (8 * Rnd() + 5)
            Case 29
                intArmorValue = (9 * Rnd() + 6)
            Case 30
                intArmorValue = (11 * Rnd() + 8)
        End Select
    End Sub

    Public Sub BootsStats() ' this generates armor numbers for the boots
        Randomize()
        Select Case intBody
            Case 31
                intArmorValue = (3 * Rnd() + 1)
            Case 32
                intArmorValue = (4 * Rnd() + 1)
            Case 33
                intArmorValue = (4 * Rnd() + 2)
            Case 34
                intArmorValue = (5 * Rnd() + 2)
            Case 35
                intArmorValue = (6 * Rnd() + 3)
            Case 36
                intArmorValue = (7 * Rnd() + 4)
            Case 37
                intArmorValue = (7 * Rnd() + 5)
            Case 38
                intArmorValue = (8 * Rnd() + 5)
            Case 39
                intArmorValue = (9 * Rnd() + 6)
            Case 40
                intArmorValue = (11 * Rnd() + 8)
        End Select
    End Sub

    Public Sub Affixes() ' this does armor affixes
        Select Case intArmPrefix
            Case 1 ' null
            Case 2 ' plated
                intArmorValue += 3
            Case 3 ' studded
                intArmorValue += 1
            Case 4 ' reinforced
                intArmorValue += 2
            Case 5 ' nano-fiber
                intArmorValue += 2
                'this is gonna modify dodge later
            Case 6 ' gel-lined
                intArmorValue += 4
            Case 7 ' heavy
                intArmorValue += 4
                'this is gonna modify dodge later
            Case 8 'lightweight
                intArmorValue -= 2
                'this is gonna modify dodge later
            Case 9 ' balanced
                intArmorValue += 3
                'dodge blah blah
            Case 10 ' form-fitting
                'dodge blah blah
        End Select
        Select Case intArmSuffix
            Case 1 ' null
            Case 2 ' of grip
                'not implemented yet
            Case 3 ' of reinforcement
                intArmorValue += 2
            Case 4 ' of Bulwarks
                intArmorValue += 5
                'dodge blah blah
            Case 5 ' of Swiftness
                'dodge blah blah
            Case 6 ' of the Juggernaut
                'dodge blah
                'other features not implemented yet - bonus on closing distance/melee combat
            Case 7 ' of Advancing
                'see Juggernaut but minus the dodge penalty with a smaller bonus
            Case 8 ' of Agility
                'dodge blah blah, better than swiftness
            Case 9 ' of Absorption
                intArmorValue += 4
            Case 10 ' of Defense
                intArmorValue += 3
        End Select
    End Sub

End Class
