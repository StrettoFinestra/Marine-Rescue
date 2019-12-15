Public Class Marine_Rescue

    'Attributes

    'Public sea As New Sea
    Dim survivor As New Survivor
    Dim Shark As New Shark
    Dim time As Integer = 0
    Dim Points As Integer = 0
    Dim level As Integer = 0
    Dim lifes As Integer = 0
    Dim fuel As Integer = 0
    Dim sharkcount As Integer = 0
    Dim survivorcount As Integer = 0

    'Construct
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.Controls.Add(Global.Marine_Rescue.Sea.pan_sea)

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

    'Timers
    Private Sub Timer_time_Tick(sender As Object, e As EventArgs) Handles timer_time.Tick

        'Attributes
        time += 1
        txt_time.Text = CStr(time)

        'Validations
        If survivorcount < 10 And time Mod 5 = 0 Then
            survivor.Survivor_Generator(survivorcount)
            survivorcount += 1
        End If

    End Sub

    'ToolStripMenuItem
    Sub ToolStripMenuItem_Estatus(sentinel As Boolean)
        tsmi_start.Enabled = sentinel
    End Sub

    'Game events controller
    Sub Game_Estatus(estatus As Integer)

        Select Case estatus

            Case 0

                'Indicator Inicialization

                ts_txt_points.Text = "0"
                ts_txt_level.Text = "0"
                ts_txt_lifes.Text = "5"
                ts_txt_seating.Text = "3"
                ts_txt_fuel.Text = "60"
                ts_txt_velocimeter.Text = "0 px/s"
                Game_LevelUp()

        End Select

    End Sub

    Sub Game_LevelUp()

        'Call to Shark Generator and level up
        'Level 0 its only for reference
        level += 1
        ts_txt_level.Text = CStr(level)

        'Validations
        If sharkcount < 10 Then
            Shark.Shark_Generator(sharkcount, level)
            sharkcount += 1
        End If

    End Sub


End Class