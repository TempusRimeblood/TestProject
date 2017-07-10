Imports System.IO

Public Class RangedWeapon
    'This class is for randomly-affixed ranged weapons.
    Public intUpprRcvr As String 'Upper Receiver - controls what kind of ranged weapon it is.  This will have more effects later.
    Public intWeaponType As String 'Weapon Type - this is the type of weapon determined by the Upper Reciever
    Public intMagazine As String 'Magazine - mostly fluff, to be implemented if there is an ammo system implemented
    Public intStock As String 'Stock - this is going to affect the weapon's accuracy rating, if the weapon can have a stock
    Public intBarrel As String 'Barrel mod - this will have different effects when event generation becomes a thing
    Public intUnder As String 'Underbarrel mod - on weapons that support this, different effects, possibly even melee weapon.
    Public intSight As String 'Sight mod - this affects the weapon's accuracy
    Public strName As String 'Weapon name - this will be aggregated from the various mod strings e.g. "Smartlinked Ergo-Grip Riot Shotgun"

    'These are the variables that affect stats and derived stats
    Public intWpnDmgMin As Integer ' Minimum ranged weapon damage
    Public intWpnDmgMax As Integer ' Maximum ranged weapon damage
    Public intAccuracyMod As Integer ' Weapon accuracy and critical chance modifier


End Class
