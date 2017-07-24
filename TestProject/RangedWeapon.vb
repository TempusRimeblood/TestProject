Imports System.IO

Public Class RangedWeapon
    'This class is for randomly-affixed ranged weapons.
    Public intUpprRcvr As Integer 'Upper Receiver - controls what kind of ranged weapon it is.  This will have more effects later.
    Public strUpprRcvr As String
    Public intWeaponType As Integer 'Weapon Type - this is the type of weapon determined by the Upper Reciever
    Public intMagazine As Integer 'Magazine - mostly fluff, to be implemented if there is an ammo system implemented
    Public strMagazine As String
    Public intStock As Integer 'Stock - this is going to affect the weapon's accuracy rating, if the weapon can have a stock
    Public strStock As String
    Public intBarrel As Integer 'Barrel mod - this will have different effects when event generation becomes a thing
    Public strBarrel As String
    Public intUnder As Integer 'Underbarrel mod - on weapons that support this, different effects, possibly even melee weapon.
    Public strUnder As String
    Public intSight As Integer 'Sight mod - this affects the weapon's accuracy
    Public strSight As String
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
        Select Case intStock
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
        Select Case intSight
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
        Select Case intBarrel
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
        Select Case intUnder
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

End Class
