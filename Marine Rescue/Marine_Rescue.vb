Public Class Marine_Rescue

    'Attributes

    'Objects
    Public sea As New Sea
    Public castaway As New Survivor
    Public shark As New Shark
    Public ship As New CoastGuardShip

    'Data Structures
    Public vpic_castaway(0) As Survivor
    Public vpic_shark(0) As Shark

    'Socoreboard Variables
    Public time As Integer = 0
    Public points As Integer = 0
    Public level As Integer = 0
    Public lifes As Integer = 0
    Public fuel As Integer = 0

    'Counters
    Public sharkcount As Integer = 0
    Public castawaycount As Integer = 0
    Public seatscount As Integer = 0

    'Construct
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Methods

    'Menu Strip Options

    'Start
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_start.Click
        ToolStripMenuItem_Estatus(False)
        Game_Estatus(0)
        timer_time.Start()
    End Sub

    'New Game
    Private Sub Tsmi_newgame_Click(sender As Object, e As EventArgs) Handles tsmi_newgame.Click

    End Sub

    'Instructions
    Private Sub Tsmi_Instructions_Click(sender As Object, e As EventArgs) Handles tsmi_Instructions.Click
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

    'ToolStripMenuItem
    Sub ToolStripMenuItem_Estatus(sentinel As Boolean)
        tsmi_start.Enabled = sentinel
    End Sub

    'Timers

    'Time Timer
    Private Sub Timer_time_Tick(sender As Object, e As EventArgs) Handles timer_time.Tick

        'Attributes
        time += 1
        ts_txt_time.Text = CStr(time)

        'Validations
        If castawaycount < 10 And time Mod 5 = 0 Then
            Game_NewCastaway()
        End If

    End Sub

    'castaway Timer

    Private Sub Timer_survivor_Tick(sender As Object, e As EventArgs) Handles timer_survivor.Tick

        'Actions of all castaway in the sea if there is at least one

        If castawaycount > 0 Then

            For Each castaway As Survivor In vpic_castaway

                'Movement of all Castaway on the Sea
                castaway.Survivor_Movement()

                'Bounce of all Castaway

                For Each shipwrecks As Survivor In vpic_castaway
                    If castaway.pic_tmp_survivor.Bounds.IntersectsWith(shipwrecks.pic_tmp_survivor.Bounds) And
                        castaway.pic_tmp_survivor.Name <> shipwrecks.pic_tmp_survivor.Name Then
                        castaway.Survivor_Rebound()
                    End If
                Next

            Next

        End If



        'Touchability of all Castaway


    End Sub

    'Shark Timer
    Private Sub Timer_shark_Tick(sender As Object, e As EventArgs) Handles timer_shark.Tick

        'Movement of all Sharkpedo on the Sea

        If sharkcount > 0 Then

            For Each sharkpedo As Shark In vpic_shark
                sharkpedo.Shark_Movement()
            Next

        End If

    End Sub

    'Lifeboat Timer
    Private Sub Timer_lifeboat_Tick(sender As Object, e As EventArgs) Handles timer_lifeboat.Tick

    End Sub

    'CoastGuard Ship Timer
    Private Sub Timer_cg_ship_Tick(sender As Object, e As EventArgs) Handles timer_cg_ship.Tick

        ship.Ship_Movement()

    End Sub

    '################################################################################################
    'Game Logic

    'Castaway Generator

    Sub Game_NewCastaway()

        If castawaycount <= 10 Then
            ReDim Preserve vpic_castaway(castawaycount)
            vpic_castaway(castawaycount) = New Survivor
            vpic_castaway(castawaycount).Survivor_Generator(castawaycount)
            'vpic_castaway(castawaycount) = New Survivor
            'vpic_castaway(castawaycount).Survivor_Generator()
            castawaycount += 1

        End If

    End Sub

    Sub Game_NewSharpedo()

        If sharkcount <= 10 Then
            ReDim Preserve vpic_shark(sharkcount)
            vpic_shark(sharkcount) = New Shark
            vpic_shark(sharkcount).Shark_Generator(sharkcount, level)
            'vpic_castaway(castawaycount) = New Survivor
            'vpic_castaway(castawaycount).Survivor_Generator()
            sharkcount += 1
        End If

    End Sub

    'Game events controller
    Sub Game_Estatus(estatus As Integer)

        Select Case estatus

            Case 0

                'Indicator Inicialization

                ts_txt_points.Text = "0"
                ts_txt_level.Text = "0"
                ts_txt_lifes.Text = "5"
                ts_txt_seating.Text = "0 / 3"
                ts_txt_fuel.Text = "60"
                ts_txt_velocimeter.Text = "0 px/s"

                'Elements Generator Controller
                sea.Sea_Generator()
                ship.Ship_Generator()

                'Game Level Controller
                Game_LevelUp()

                'Timers Start
                timer_survivor.Start()
                timer_shark.Start()
                timer_cg_ship.Start()


        End Select

    End Sub

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