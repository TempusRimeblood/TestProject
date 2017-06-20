Module GlobalVariables
    'This module is for initializing global variables that will be used through the entirety of the game.
    'Capture character name from character creation screen
    Public strName As String
    'Capture character class from character creation screen
    Public strClass As String
    'These global variables are for monitoring player stats.
    Public intStrength As Integer 'Strength, for determining melee damage modifiers and inventory capacity
    Public intIntelligence As Integer 'Intelligence, for determining computer challenges and hacking
    Public intAgility As Integer 'Agility, affects accuracy in melee/ranged and chance to dodge
    Public intToughness As Integer 'Toughness, affects HP
    Public intLuck As Integer 'This is Luck.  It is a hidden stat and will be implemented later.  Possibly for crit chance.
    'These variables are for derived stats.
    Public intMaxHealth As Integer 'Maximum HP, affected by Toughness and items.
    Public intCurrentHealth As Integer 'Current HP, affected by whether the player has been attacked successfully.
    Public intCritical As Integer 'Critical Hit Chance, affected by the equipped weapon and Luck.
    'This is a block of test code to determine derived statistics.
    'The following line sets the StatsMade variable to false, for use in the character creation screen/game launch.
    Public blnStatsMade As Boolean = False
    Public blnStatsChecked As Boolean = False
    Public Function StatCheck()
        Select Case strClass
            Case "StreetSam"
                intStrength = 8
                intAgility = 5
                intToughness = 5
                intIntelligence = 2
                intMaxHealth = intToughness * 3
            Case "GunBunny"
                intStrength = 2
                intAgility = 8
                intToughness = 5
                intIntelligence = 5
                intMaxHealth = intToughness * 3
            Case "Decker"
                intStrength = 5
                intAgility = 5
                intIntelligence = 8
                intToughness = 2
                intMaxHealth = intToughness * 3
            Case "Tank"
                intToughness = 8
                intStrength = 5
                intAgility = 2
                intIntelligence = 5
                intMaxHealth = intToughness * 3
        End Select
        Return (blnStatsChecked = True)
    End Function
    Public Function statgen()
        'Call a random number generator using system timer as a random seed.
        Randomize()
        'This determines intLuck randomly, as a value between 1 and 6.
        intLuck = CInt(6 * Rnd() + 1)
        'This sets MaxHealth to Toughness * 3.
        'intMaxHealth = intToughness * 3
        'This sets CurrentHealth to be equal to MaxHealth, to prevent an instant failstate.
        intCurrentHealth = intMaxHealth
        'This determines Critical Chance, using Agility as the base stat and intLuck as a modifier.
        intCritical = (intAgility * 2) + intLuck
        'This line returns the blnStatsMade value to True, allowing the game to launch.
        Return (blnStatsMade = True)
    End Function
End Module
