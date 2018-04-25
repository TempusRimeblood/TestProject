Module MobSpawnFunctions

    Public PendingMob As New Mob
    Public Sub MobGen()
        PendingMob.chooseclass()
        PendingMob.monsterstatgen()
    End Sub
End Module
