Public Class frmMobDebug
    Private Sub frmMobDebug_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmCharacterDebug.blnIsMobDebug = False ' This makes sure only one instance of the mob debugger can be open.
    End Sub

    Private Sub frmMobDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intMobsSpawned = 1

    End Sub

    Private Sub btnMobCreate_Click(sender As Object, e As EventArgs) Handles btnMobCreate.Click
        MobGen() ' Generates stats for the mob
        intMobsSpawned += 1 ' Increments the number of mobs spawned by 1
        MobList.Add(New Mob) ' Adds the mob to the list
        MobRefresh()


    End Sub



    Sub MobRefresh() ' Updates text fields for mobs
        lblMobClass.Text = MobList.Last.strClass
        lblMobName.Text = "Steve-Dave" ' Mob name - this isn't implemented yet, so they're all named Steve-Dave
        lblMobSpawn.Text = intMobsSpawned - 1
        lblMobCurrentHP.Text = MobList.Last.intCurrentHP.ToString
        lblMobArmorValue.Text = MobList.Last.intMobArmorValue.ToString
    End Sub


End Class