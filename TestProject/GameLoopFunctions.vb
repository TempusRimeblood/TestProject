﻿Module GameLoopFunctions
    'This module exists to handle gameloop functions.

    Public Sub monstergen() 'Subroutine to create a mob for the debug function.
        Mobs(intMobsCreated) = New Mob
        intMobsCreated += 1
        Mobs(intMobsCreated).strName = "Mob" & intMobsCreated
        Mobs(intMobsCreated).chooseclass()
        Mobs(intMobsCreated).monsterstatgen()
    End Sub
End Module
