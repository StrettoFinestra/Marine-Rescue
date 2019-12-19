Public Class Marine_Rescue

    '###########################################################################################################
    'Attributes

    'Objects
    Public sea As New Sea
    Public castaway As New Survivor
    Public shark As New Shark
    Public lifeboat As New Lifeboat
    Public ship As New CoastGuardShip

    'Data Structures
    Public vpic_castaway(0) As Survivor
    Public vpic_shark(0) As Shark

    'Socoreboard Variables
    Public points As Integer = 0
    Public level As Integer = 0
    Public lifes As Integer = 5
    Public seatscount As Integer = 0
    Public fuel As Integer = 60
    Public lb_speedometer As Integer = 0
    Public time As Integer = 0

    'Element counters
    Public seacount As Integer = 0
    Public sharkcount As Integer = 0
    Public castawaycount As Integer = 0
    Public lifeboatcount As Integer = 0
    Public cg_shipcount As Integer = 0

    '###########################################################################################################
    'Construct
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    '###########################################################################################################
    'Methods

    'Menu Strip Options

    'Start
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_start.Click

        ToolStripMenuItem_Estatus(False)
        Game_Status(1)

    End Sub

    'New Game
    Private Sub Tsmi_newgame_Click(sender As Object, e As EventArgs) Handles tsmi_newgame.Click
        Game_Status(2)
    End Sub

    'Instructions
    Private Sub Tsmi_Instructions_Click(sender As Object, e As EventArgs) Handles tsmi_Instructions.Click
        Game_NewCastaway()
        Game_LevelUp()

    End Sub

    'History
    Private Sub Tsmi_history_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        MessageBox.Show("Un buque sufrió un accidente y los sobrevivientes están" & vbNewLine &
                        "en el mar. Hay que rescatarlos en una lancha de goma.")
    End Sub

    'About
    Private Sub Tsmi_about_Click(sender As Object, e As EventArgs) Handles tsmi_about.Click
        MessageBox.Show("Universidad Tecnológica de Panamá" & vbNewLine &
                        "Facultad de Ingeniería en Sistemas Computacionales" & vbNewLine &
                        "Licenciatura en Desarrollo de Software" & vbNewLine &
                        "Profesor: Ricardo Chan" & vbNewLine &
                        "Autor: Alexander Almengor" & vbNewLine &
                        "Cédula: 8-923-938")
    End Sub

    '------------------------------------------------------------------------------------------------------------
    'ToolStripMenuItem
    Sub ToolStripMenuItem_Estatus(sentinel As Boolean)
        tsmi_start.Enabled = sentinel
    End Sub

    '------------------------------------------------------------------------------------------------------------
    'Timers

    'Time Timer
    Private Sub Timer_time_Tick(sender As Object, e As EventArgs) Handles timer_time.Tick

        'Game Attributes

        'Time 
        time += 1
        Game_TsRefresh()

        'Fuel
        If fuel <= 60 And fuel > 0 Then
            fuel -= 1
            Game_TsRefresh()
        End If

        'Validations
        If castawaycount < 10 And time Mod 5 = 0 Then
            Game_NewCastaway()
        End If

    End Sub

    'Castaways Timer

    Private Sub Timer_survivor_Tick(sender As Object, e As EventArgs) Handles timer_survivor.Tick

        'Actions of all castaway in the sea if there is at least one

        If castawaycount > 0 Then

            For Each castaway As Survivor In vpic_castaway

                'Movement of all Castaway on the Sea
                castaway.Survivor_Movement()

                'Ricochet of all Castaway

                For Each shipwrecks As Survivor In vpic_castaway

                    If castaway.pic_tmp_survivor.Bounds.IntersectsWith(shipwrecks.pic_tmp_survivor.Bounds) And
                        castaway.pic_tmp_survivor.Name <> shipwrecks.pic_tmp_survivor.Name And shipwrecks.pic_tmp_survivor.AccessibleName <> "hidden" Then

                        'if intersects and different from himself, ricochet
                        castaway.Survivor_Ricochet()

                    End If

                Next

                'Coast Guard Ship Ricochet
                'It should be noted that the image is not rectangular
                If castaway.pic_tmp_survivor.Bounds.IntersectsWith(pic_cg_ship.Bounds) Then
                    castaway.Survivor_Ricochet()
                End If

            Next

        End If



        'Touchability of all Castaway


    End Sub

    'Sharkpedos Timer
    Private Sub Timer_shark_Tick(sender As Object, e As EventArgs) Handles timer_shark.Tick

        'If exist a Sharpedo on the Sea
        If sharkcount > 0 Then

            For Each sharkpedo As Shark In vpic_shark

                'Movement of all Sharkpedos on the Sea
                sharkpedo.Shark_Movement()

                'Ricochet of all Sharkpedos

                For Each shark As Shark In vpic_shark

                    If sharkpedo.pic_tmp_shark.Bounds.IntersectsWith(shark.pic_tmp_shark.Bounds) And
                        sharkpedo.pic_tmp_shark.Name <> shark.pic_tmp_shark.Name Then

                        'if intersects and different from himself, ricochet
                        sharkpedo.Shark_Ricochet()

                    End If

                Next

                'Coast Guard Ship Ricochet
                'It should be noted that the image is not rectangular
                If sharkpedo.pic_tmp_shark.Bounds.IntersectsWith(pic_cg_ship.Bounds) Then
                    sharkpedo.Shark_Ricochet()
                End If

                'If exist a Castaway
                If castawaycount > 0 Then

                    'Eat Castaway
                    For Each castaway As Survivor In vpic_castaway

                        'If they touch a castaway, then Sharpedos eat it
                        If castaway.pic_tmp_survivor.Bounds.IntersectsWith(sharkpedo.pic_tmp_shark.Bounds) And
                            castaway.pic_tmp_survivor.AccessibleName = "alive" Then

                            'Disappears Castaway, becomes a spirit
                            castaway.pic_tmp_survivor.AccessibleName = "hidden"
                            castaway.pic_tmp_survivor.Image = Nothing

                        End If

                    Next

                End If

            Next

        End If

    End Sub

    'Lifeboat Timer
    Private Sub Timer_lifeboat_Tick(sender As Object, e As EventArgs) Handles timer_lifeboat.Tick

        'If exist a Lifeboat on the Sea
        If lifeboatcount > 0 Then

            'Movement
            lifeboat.Lifeboat_Movement()

            'Power Engine Validator
            If fuel = 0 Then
                lifeboat.powerengine = False
            End If

            'Game Over
            If lifes = 0 Then
                Game_Status(0)
            End If

            'Save Castaway
            'If exist a Castaway
            If castawaycount > 0 Then

                For Each castaway As Survivor In vpic_castaway

                    If lifeboat.pic_tmp_lifeboat.Bounds.IntersectsWith(castaway.pic_tmp_survivor.Bounds) And
                    castaway.pic_tmp_survivor.AccessibleName <> "hidden" Then

                        If seatscount < 3 Then

                            'Capacity increment
                            seatscount += 1
                            Game_TsRefresh()

                            'Disappears Castaway, becomes a spirit
                            castaway.pic_tmp_survivor.AccessibleName = "hidden"
                            castaway.pic_tmp_survivor.Image = Nothing

                        End If

                    End If

                Next

            End If



            'Death
            'If exist a Sharkpedo
            If sharkcount > 0 And lifes > 0 Then

                For Each sharkpedo As Shark In vpic_shark

                    If lifeboat.pic_tmp_lifeboat.Bounds.IntersectsWith(sharkpedo.pic_tmp_shark.Bounds) Then

                        'Lose a life
                        Game_lifeboatDeath()

                    End If

                Next

            End If

            'If exist a Coast Guard Ship
            If cg_shipcount > 0 Then

                'Coast Guard Ship Ricochet
                'It should be noted that the image is not rectangular
                If lifeboat.pic_tmp_lifeboat.Bounds.IntersectsWith(pic_cg_ship.Bounds) Then

                    'Check current speak
                    If lb_speedometer <= 10 Then

                        If seatscount > 0 Then

                            Select Case seatscount

                                'One Castaway
                                Case 1

                                    points += 10
                                    seatscount = 0
                                    Game_TsRefresh()

                                'Two Castaways
                                Case 2

                                    points += 20
                                    seatscount = 0
                                    Game_TsRefresh()

                                'Three Castaways
                                Case 3

                                    points += 30
                                    seatscount = 0
                                    Game_TsRefresh()

                            End Select

                        End If

                        'Ricochet
                        lifeboat.Lifeboat_Ricochet()

                    Else

                        'Lose a life
                        Game_lifeboatDeath()

                    End If


                End If

            End If

        End If


    End Sub

    'CoastGuard Ship Timer
    Private Sub Timer_cg_ship_Tick(sender As Object, e As EventArgs) Handles timer_cg_ship.Tick

        'If exist a CoastGuard Ship on the Sea
        If cg_shipcount > 0 Then
            ship.Ship_Movement()
        End If

    End Sub

    '------------------------------------------------------------------------------------------------------------
    'Game Controls
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If lifeboat.powerengine = True Then

            If lifeboat.dirx <= 50 And lifeboat.diry <= 50 Then

                Select Case keyData

                    'When Lifeboat go to Up
                    Case Keys.Up

                        lifeboat.diry -= 5
                        If lifeboat.diry < 0 Then
                            lb_speedometer = lifeboat.diry * (-1)
                            Game_TsRefresh()
                        Else
                            lb_speedometer = lifeboat.diry
                            Game_TsRefresh()
                        End If

                    'When Lifeboat go to Down
                    Case Keys.Down

                        lifeboat.diry += 5
                        If lifeboat.diry < 0 Then
                            lb_speedometer = lifeboat.diry * (-1)
                            Game_TsRefresh()
                        Else
                            lb_speedometer = lifeboat.diry
                            Game_TsRefresh()
                        End If

                   'When Lifeboat go to Left
                    Case Keys.Left

                        lifeboat.dirx -= 5
                        If lifeboat.dirx < 0 Then
                            lb_speedometer = lifeboat.dirx * (-1)
                            Game_TsRefresh()
                        Else
                            lb_speedometer = lifeboat.dirx
                            Game_TsRefresh()
                        End If

                    'When Lifeboat go to Right
                    Case Keys.Right

                        lifeboat.dirx += 5
                        lb_speedometer = lifeboat.dirx
                        Game_TsRefresh()

                        If lifeboat.dirx < 0 Then
                            lb_speedometer = lifeboat.dirx * (-1)
                            Game_TsRefresh()
                        Else
                            lb_speedometer = lifeboat.dirx
                            Game_TsRefresh()
                        End If

                End Select

            End If

        End If

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    '------------------------------------------------------------------------------------------------------------
    'Game Logic & Generators

    'Sea Generator
    Sub Game_NewSea()
        sea.Sea_Generator()
    End Sub

    'Castaways Generator
    Sub Game_NewCastaway()

        If castawaycount <= 9 Then

            'Array redimension and add a new Castaway
            ReDim Preserve vpic_castaway(castawaycount)
            vpic_castaway(castawaycount) = New Survivor
            vpic_castaway(castawaycount).Survivor_Generator(castawaycount)
            castawaycount += 1

        End If

    End Sub

    'Sharpedos Generator
    Sub Game_NewSharpedo()

        If sharkcount <= 10 Then

            'Redim array and add a new Sharkpedo
            ReDim Preserve vpic_shark(sharkcount)
            vpic_shark(sharkcount) = New Shark
            vpic_shark(sharkcount).Shark_Generator(sharkcount, level)
            sharkcount += 1

        End If

    End Sub

    'Lifeboat Generator
    Sub Game_NewLifeboat()
        lifeboat.Lifeboat_Generator()
    End Sub

    'CoastGuard Ship Generator
    Sub Game_NewCgShip()
        ship.Ship_Generator()
    End Sub

    'Game controllers

    'Game Estatus Controller
    Sub Game_Status(estatus As Integer)

        Select Case estatus

            'New Game
            Case 2

                Application.Restart()

            'Start Game
            Case 1

                'Indicator Inicialization
                Game_TsRefresh()

                'Elements Generator Controller
                Game_NewElements()

                'Game Level Controller
                Game_LevelUp()

                'Timers Start
                Game_Timers(1)


            'Lose Game
            Case 0

                Game_Timers(0)
                MessageBox.Show("¡Has pérdido mayor suerte para la próxima!" & vbNewLine &
                        "Su puntuación alcanzada es: " & points & " puntos.")

        End Select

    End Sub

    'Game ToolStrip Menu Item Refresh
    Sub Game_TsRefresh()

        'Refresh al textfields of the ToolStrip Menu Item
        ts_txt_points.Text = points
        ts_txt_level.Text = level
        ts_txt_lifes.Text = lifes
        ts_txt_seating.Text = seatscount & " / 3"
        ts_txt_fuel.Text = fuel
        ts_txt_speedometer.Text = lb_speedometer & " px/s"
        ts_txt_time.Text = time

    End Sub

    'Game Generator Controller
    Sub Game_NewElements()

        'Call independent generators
        Game_NewSea()
        Game_NewLifeboat()
        Game_NewCgShip()

        'Update Game Counters
        seacount += 1
        lifeboatcount += 1
        cg_shipcount += 1

    End Sub

    'Game Timers Controller
    Sub Game_Timers(sentinel As Integer)

        Select Case sentinel

            'Start timers
            Case 1

                timer_time.Start()
                timer_survivor.Start()
                timer_shark.Start()
                timer_lifeboat.Start()
                timer_cg_ship.Start()

            'Stop timers
            Case 0

                timer_time.Stop()
                timer_survivor.Stop()
                timer_shark.Stop()
                timer_lifeboat.Stop()
                timer_cg_ship.Stop()

        End Select

    End Sub

    'Game Lifes Controller
    Sub Game_lifeboatDeath()

        lifes -= 1
        seatscount = 0
        fuel = 60
        Game_TsRefresh()

        'Died, remove from Marine_Rescue
        Controls.Remove(lifeboat.pic_tmp_lifeboat)
        lifeboat.pic_tmp_lifeboat.Dispose()

        'Restore a New Lifeboat
        Game_NewLifeboat()

    End Sub

    'Game Level Up Controller
    Sub Game_LevelUp()

        'Call to shark Generator and level up
        'Level 0 its only for reference
        level += 1
        ts_txt_level.Text = CStr(level)

        'Validations
        If sharkcount < 10 Then

            Game_NewSharpedo()

        End If

    End Sub


End Class