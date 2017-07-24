Imports System.IO

Public Class Aug
    'This is the class for augmentations
    'These are gonna be super-duper not implemented
    Public intBody As Integer ' This integer and string control the aug's "body" property, its core function
    Public strBody As String
    Public intAugPrefix As Integer ' This integer and string control the prefix
    Public strAugPrefix As Integer
    Public intAugSuffix As Integer ' This integer and string control the suffix
    Public strAugSuffix As Integer
    Public strName As String ' This is the aug name

    Public intAugType As Integer ' This dictates augmentation "type" and which slot it goes into
    'There is gonna be a WHOLE LOT OF CRAP that goes here for aug-specific parts, but this is very much not implemented
    'blnParry - parry ranged attacks
    'blnGrapple - grapple stuff
    'etc

    'This generates a head aug
    Public Sub headauggen()
        Dim strPath, strPrefix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\augprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intAugPrefix = strPrefix(10 * Rnd() + 1)
        strAugPrefix = strPrefix(10 * Rnd(-1) + 1)
    End Sub

    'This generates a body augmentation
    Public Sub bodyauggen()
        Dim strPath, strPrefix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\augprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intAugPrefix = strPrefix(10 * Rnd() + 1)
        strAugPrefix = strPrefix(10 * Rnd(-1) + 1)
    End Sub

    'This generates an arm augmentation
    Public Sub armsauggen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\augprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intAugPrefix = strPrefix(10 * Rnd() + 1)
        strAugPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\augsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intAugSuffix = strSuffix(10 * Rnd() + 1)
        strAugSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    'This generates a leg augmentation
    Public Sub legsauggen()
        Dim strPath, strPrefix(10), strSuffix(10) As String
        Dim intX As Integer = 1
        Dim reader As StreamReader
        'This randomizes the prefix
        strPath = "..\..\txt\augprefix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strPrefix(intX) = reader.ReadLine
            intX += 1
        Loop
        intAugPrefix = strPrefix(10 * Rnd() + 1)
        strAugPrefix = strPrefix(10 * Rnd(-1) + 1)
        'This randomizes the suffix
        strPath = "..\..\txt\augsuffix.txt"
        reader = File.OpenText(strPath)
        intX = 1
        Randomize()
        reader = File.OpenText(strPath)
        Do While reader.Peek <> reader.EndOfStream
            strSuffix(intX) = reader.ReadLine
            intX += 1
        Loop
        intAugSuffix = strSuffix(10 * Rnd() + 1)
        strAugSuffix = strSuffix(10 * Rnd(-1) + 1)
    End Sub

    Public Function namegen()
        strName = strAugPrefix & " " & strBody & " " & strAugSuffix
        Return (strName)
    End Function
End Class
