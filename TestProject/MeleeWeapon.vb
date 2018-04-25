Imports System.IO
Public Class MeleeWeapon
    'This is the melee weapon class
    Public intBody As Integer ' This integer and string control the basic body of the weapon
    Public strBody As String
    Public intWpnPrefix As Integer ' This integer and string control the prefix of the weapon
    Public strWpnPrefix As String
    Public intWpnSuffix As Integer ' This integer and string control the suffix of the weapon
    Public strWpnSuffix As String
    Public intWeaponType As Integer 'denotes weapon type, determines prefix and suffix list

    'Basic principle here is going to be "X Y of Z" where it's "Serrated Katana of Attacking" or whatever

    Public strName As String ' Weapon name!
    Public intWpnMinDamage ' Minimum damage
    Public intWpnMaxDamage ' Maximum damage
    Public intAccuracyMod ' Accuracy modifier
    Public intCritMod ' Affects critical damage

    'Other variables will be put here as booleans, etc. for weapon-derived statistics (parry chance, etc.)
    'blnCanParry - parry ability
    'intParryMod - parry chance
    'intArmorPen - armor penetration
    'etc

    Public Sub SwordGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\bladeprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnPrefix = (10 * Rnd() + 1)
        strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\bladesuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSuffix = (10 * Rnd() + 1)
        strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    Public Sub AxeGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\axeprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnPrefix = strPrefix(10 * Rnd() + 1)
        strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\axesuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSuffix = strSuffix(10 * Rnd() + 1)
        strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    Public Sub ClubGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\bluntprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnPrefix = strPrefix(5 * Rnd() + 1)
        strWpnPrefix = strPrefix(5 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\bluntsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSuffix = strSuffix(5 * Rnd() + 1)
        strWpnSuffix = strSuffix(5 * Rnd(-1) + 1)
    End Sub
    Public Sub KnifeGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\bladeprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnPrefix = strPrefix(10 * Rnd() + 1)
        strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\bladesuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSuffix = strSuffix(10 * Rnd() + 1)
        strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub
    Public Sub PowerGen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\powerprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnPrefix = strPrefix(10 * Rnd() + 1)
        strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\powersuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intWpnSuffix = strSuffix(10 * Rnd() + 1)
        strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    Public Function namegen()
        strName = strWpnPrefix & " " & strBody & " " & strWpnSuffix
        Return (strName)
    End Function

    Public Sub AxeStat()
        intWpnMinDamage = 5
        intWpnMaxDamage = 30
        intCritMod = 4
        intAccuracyMod = -15
        Select Case intWpnPrefix
            Case 1 ' Null Value
            Case 2 ' Serrated
                intWpnMinDamage += 5
                intWpnMaxDamage += 10
            Case 3 ' Heavy-Headed
                intWpnMinDamage += 10
                intWpnMaxDamage += 15
                intCritMod = 6
            Case 4 ' Honed
                intWpnMinDamage += 2
                intWpnMaxDamage += 5
                intAccuracyMod += 10
            Case 5 ' Murderous
                intWpnMaxDamage += 5
                intAccuracyMod += 5
                intCritMod = 5
            Case 6 ' Wicked
                intWpnMinDamage += 5
                intAccuracyMod += 5
                intCritMod = 5
            Case 7 ' Butcher's
                intCritMod = 6
            Case 8 ' Slasher's
                intWpnMinDamage += 10
                intWpnMaxDamage += 10
                intCritMod = 5
            Case 9 ' Nano-Grip
                intAccuracyMod += 20
            Case 10 ' Bisector
                intCritMod = 10
                intAccuracyMod -= 15
                intWpnMinDamage += 10
                intWpnMaxDamage += 20
        End Select
        Select Case intWpnSuffix
            Case 1 ' Null Value
                'This will also be implemented with the blood-soaked machete
            Case 2 ' of Heft
                intWpnMaxDamage += 5
            Case 3 ' of Cleaving
                intAccuracyMod += 5
            Case 4 ' of the Executioner
                intCritMod += 1
            Case 5 ' of Bloodshed
                intWpnMinDamage += 3
            Case 6 ' of Precision
                intAccuracyMod += 10
            Case 7 ' of Death
                intWpnMaxDamage += 5
                intWpnMinDamage += 5
            Case 8 ' of the Guillotine
                intWpnMinDamage -= 5
                intCritMod += 1
            Case 9 ' of Dismemberment
                intWpnMaxDamage += 10
            Case 10 ' of Brutality
                intCritMod += 2
        End Select
    End Sub
    Public Sub SwordStat()
        intWpnMinDamage = 10
        intWpnMaxDamage = 30
        intCritMod = 3
        Select Case intWpnPrefix
            Case 1 ' Null Value
            Case 2 ' Serrated
                intWpnMinDamage += 5
                intWpnMaxDamage += 10
            Case 3 ' Monofilament
                intWpnMinDamage += 10
                intWpnMaxDamage += 15
                intCritMod = 5
            Case 4 ' Honed
                intWpnMinDamage += 2
                intWpnMaxDamage += 5
                intAccuracyMod += 10
            Case 5 ' Full-Tang
                intWpnMinDamage += 5
                intWpnMaxDamage += 5
                intAccuracyMod += 5
            Case 6 ' Carbon-Fiber
                intWpnMinDamage += 10
                intWpnMaxDamage += 5
                intAccuracyMod += 5
            Case 7 ' Nano-Grip
                intAccuracyMod += 20
            Case 8 ' Blood-Grooved
                intWpnMaxDamage += 10
                intCritMod = 4
            Case 9 ' Heavy-Bladed
                intWpnMinDamage -= 5
                intWpnMaxDamage += 25
                intCritMod = 5
            Case 10 ' Blood-Soaked
                'THIS DOESN'T DO ANYTHING, IT'S FOR FLUFF UNTIL I IMPLEMENT 
                'AN EASTER EGG REGARDING A BLOOD-SOAKED MACHETE AND ITS RIGHTFUL OWNER
                'HINT: HE HAS A HOCKEY MASK
        End Select
        Select Case intWpnSuffix
            Case 1 ' Null Value
                'This will also be implemented with the blood-soaked machete
            Case 2 ' of Slashing
                intWpnMinDamage += 3
            Case 3 ' of Precision
                intAccuracyMod += 5
            Case 4 ' of Stabbing
                intWpnMinDamage += 4
            Case 5 ' of Pain
                intCritMod += 1
            Case 6 ' of Exsanguination
                intWpnMinDamage += 5
            Case 7 ' of Lethality
                intWpnMaxDamage += 5
            Case 8 ' of Ease
                intAccuracyMod += 10
                intCritMod -= 1
            Case 9 ' of the Wind
                intAccuracyMod += 4
                intCritMod += 1
            Case 10 ' of Deftness
                intAccuracyMod += 5
        End Select
    End Sub
    Public Sub KnifeStat()
        intWpnMinDamage = 5
        intWpnMaxDamage = 15
        intAccuracyMod = 20
        intCritMod = 3
        Select Case intWpnPrefix
            Case 1 ' Null Value
            Case 2 ' Serrated
                intWpnMinDamage += 5
                intWpnMaxDamage += 10
            Case 3 ' Monofilament
                intWpnMinDamage += 10
                intWpnMaxDamage += 15
                intCritMod = 5
            Case 4 ' Honed
                intWpnMinDamage += 2
                intWpnMaxDamage += 5
                intAccuracyMod += 10
            Case 5 ' Full-Tang
                intWpnMinDamage += 5
                intWpnMaxDamage += 5
                intAccuracyMod += 5
            Case 6 ' Carbon-Fiber
                intWpnMinDamage += 10
                intWpnMaxDamage += 5
                intAccuracyMod += 5
            Case 7 ' Nano-Grip
                intAccuracyMod += 20
            Case 8 ' Blood-Grooved
                intWpnMaxDamage += 10
                intCritMod = 4
            Case 9 ' Heavy-Bladed
                intWpnMinDamage += 1
                intWpnMaxDamage += 10
                intAccuracyMod -= 15
            Case 10 ' Blood-Soaked
                'THIS STILL DOESN'T DO ANYTHING
        End Select
        Select Case intWpnSuffix
            Case 1 ' Null Value
                'This still won't do anything
            Case 2 ' of Slashing
                intWpnMinDamage += 3
            Case 3 ' of Precision
                intAccuracyMod += 10
            Case 4 ' of Stabbing
                intWpnMinDamage += 5
                intWpnMaxDamage += 10
                intAccuracyMod += 15
            Case 5 ' of Pain
                intCritMod += 1
            Case 6 ' of Exsanguination
                intWpnMinDamage += 5
            Case 7 ' of Lethality
                intWpnMaxDamage += 5
            Case 8 ' of Ease
                intAccuracyMod += 20
                intCritMod -= 1
            Case 9 ' of the Wind
                intAccuracyMod += 4
                intCritMod += 1
            Case 10 ' of Deftness
                intAccuracyMod += 5
        End Select
    End Sub
    Public Sub BluntStat()
        intWpnMinDamage = 15
        intWpnMaxDamage = 40
        intCritMod = 2
        Select Case intWpnPrefix
            Case 1 ' Null Value
            Case 2 ' Powerful
                intWpnMinDamage += 5
                intWpnMaxDamage += 10
            Case 3 ' Heavy-Headed
                intWpnMinDamage += 10
                intWpnMaxDamage += 15
                intCritMod = 3
            Case 4 ' Spiked
                intWpnMaxDamage += 10
                intCritMod = 3
            Case 5 ' Reinforced
                intWpnMinDamage += 5
                intWpnMaxDamage += 5
                intAccuracyMod += 5
            Case 6 ' Nano-Grip
                intAccuracyMod += 15
            Case 7 ' Limb-Crushing
                intWpnMinDamage += 10
            Case 8 ' Balanced
                intWpnMinDamage += 5
                intWpnMaxDamage -= 5
                intAccuracyMod += 10
            Case 9 ' Weighted
                intWpnMinDamage -= 5
                intWpnMaxDamage += 25
                intAccuracyMod -= 10
            Case 10 ' Lightweight
                intWpnMinDamage -= 5
                intWpnMaxDamage -= 15
                intAccuracyMod += 20
        End Select
        Select Case intWpnSuffix
            Case 1 ' Null Value
            Case 2 ' of Crushing
                intWpnMaxDamage += 5
            Case 3 ' of Smashing
                intWpnMinDamage += 5
            Case 4 ' of Precision
                intAccuracyMod += 5
            Case 5 ' of Destruction
                intWpnMinDamage += 5
                intWpnMaxDamage += 5
            Case 6 ' of Brutality
                intCritMod += 2
            Case 7 ' of Power
                intWpnMaxDamage += 10
            Case 8 ' of Violence
                intWpnMinDamage += 10
            Case 9 ' of the Juggernaut
                intWpnMaxDamage += 10
                intWpnMinDamage += 10
                intAccuracyMod += 10
                intCritMod -= 1
            Case 10 ' of Laying Waste
                intAccuracyMod -= 30
                intWpnMinDamage += 25
                intWpnMaxDamage += 25
        End Select
    End Sub
    Public Sub PowerStat()
        Select Case intBody
            Case 41 ' Electro-Knuckles
                intWpnMinDamage = 10
                intWpnMaxDamage = 25
                intCritMod = 3
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the Suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 42 ' Stun Baton
                intWpnMinDamage = 15
                intWpnMaxDamage = 35
                intCritMod = 2
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 43 ' Shock Hammer
                intWpnMinDamage = 20
                intWpnMaxDamage = 45
                intCritMod = 2
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 44 ' Monofilament Whip
                intWpnMinDamage = 1
                intWpnMaxDamage = 50
                intAccuracyMod = -10
                intCritMod = 5
                Do Until intWpnPrefix <> 2 And intWpnPrefix <> 3 And intWpnPrefix <> 4 And intWpnPrefix <> 5
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 2
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the Suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 6 ' Bloody
                        intAccuracyMod -= 5
                        intWpnMinDamage += 5
                    Case 7 ' Shredding
                        intWpnMinDamage += 10
                        intWpnMaxDamage += 10
                        intAccuracyMod = -5
                    Case 8 ' Violent
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 9 ' Brutal
                        intCritMod += 2
                    Case 10 ' Lethal
                        intCritMod += 5
                        intWpnMaxDamage += 15
                        intAccuracyMod -= 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 5 ' of the Slasher
                        intWpnMinDamage += 10
                        intWpnMaxDamage += 10
                        intCritMod -= 1
                    Case 6 ' of the End
                        intWpnMinDamage += 1
                        intWpnMaxDamage += 20
                        intAccuracyMod += 15
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 10
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 15
                End Select
            Case 45 ' Monofilament Combat Chainsaw
                intWpnMinDamage = 35
                intWpnMaxDamage = 70
                intAccuracyMod = -30
                intCritMod = 4
                Do Until intWpnPrefix <> 2 And intWpnPrefix <> 3 And intWpnPrefix <> 4 And intWpnPrefix <> 5
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 2
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 6 ' Bloody
                        intWpnMinDamage += 5
                    Case 7 ' Shredding
                        intWpnMinDamage += 10
                        intWpnMaxDamage += 10
                        intAccuracyMod += 10
                    Case 8 ' Violent
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 15
                    Case 9 ' Brutal
                        intCritMod += 2
                    Case 10 ' Lethal
                        intCritMod += 5
                        intWpnMaxDamage += 15
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 5 ' of the Slasher
                        intWpnMinDamage += 10
                        intWpnMaxDamage += 10
                        intCritMod += 2
                    Case 6 ' of the End
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 20
                        intAccuracyMod += 15
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 10
                    Case 9 ' of Violence
                        intWpnMinDamage += 10
                        intWpnMaxDamage += 10
                    Case 10 ' of Swiftness
                        intAccuracyMod += 20
                End Select
            Case 46 ' Shock Blade
                intWpnMinDamage = 15
                intWpnMaxDamage = 35
                intCritMod = 3
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 47 ' Thermoconductive Blade
                intWpnMinDamage = 20
                intWpnMaxDamage = 30
                intCritMod = 3
                Do Until intWpnPrefix <> 5 And intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 48 ' Power Fist
                intWpnMinDamage = 20
                intWpnMaxDamage = 45
                intCritMod = 2
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 49 ' Pneumatic Hammer
                intWpnMinDamage = 25
                intWpnMaxDamage = 45
                intCritMod = 5
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
            Case 50 ' Electro-Claw Gauntlets
                intWpnMinDamage = 30
                intWpnMaxDamage = 55
                intCritMod = 4
                Do Until intWpnPrefix <> 6 And intWpnPrefix <> 7 And intWpnPrefix <> 8 And intWpnPrefix <> 10
                    Dim strPath, strPrefix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the prefix
                    strPath = "..\..\txt\powerprefix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strPrefix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnPrefix = strPrefix(10 * Rnd() + 1)
                    strWpnPrefix = strPrefix(10 * Rnd(-1) + 1)
                Loop
                Do Until intWpnSuffix <> 5 And intWpnSuffix <> 6
                    Dim strPath, strSuffix(10) As String
                    Dim intX As Integer = 1
                    Dim reader As StreamReader
                    'This randomizes the suffix
                    strPath = "..\..\txt\powersuffix.txt"
                    reader = File.OpenText(strPath)
                    intX = 1
                    Randomize()
                    reader = File.OpenText(strPath)
                    Do While reader.Peek <> reader.EndOfStream
                        strSuffix(intX) = reader.ReadLine
                        intX += 1
                    Loop
                    intWpnSuffix = strSuffix(10 * Rnd() + 1)
                    strWpnSuffix = strSuffix(10 * Rnd(-1) + 1)
                Loop
                Select Case intWpnPrefix
                    Case 1 ' Null
                    Case 2 ' Capacitive
                        intWpnMinDamage += 5
                    Case 3 ' Overcharged
                        intWpnMaxDamage += 5
                    Case 4 ' Pain-Inducing
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 5 ' Convulsive
                        intCritMod += 2
                    Case 9 ' Brutal
                        intCritMod += 1
                        intWpnMaxDamage += 10
                End Select
                Select Case intWpnSuffix
                    Case 1 ' Null
                    Case 2 ' of Lightning
                        intWpnMinDamage += 5
                    Case 3 ' of Pain
                        intWpnMaxDamage += 5
                    Case 4 ' of Death
                        intCritMod += 1
                    Case 7 ' of Brutality
                        intCritMod += 2
                    Case 8 ' of Precision
                        intAccuracyMod += 5
                    Case 9 ' of Violence
                        intWpnMinDamage += 5
                        intWpnMaxDamage += 5
                    Case 10 ' of Swiftness
                        intAccuracyMod += 10
                End Select
        End Select
    End Sub
End Class
