Public Class CoastGuardShip

    '###########################################################################################################
    'Attributes

    Public Const generation As Boolean = True
    Public Const matter As Boolean = True
    Public Const form As Boolean = True
    Dim pic_tmp_cg_ship As PictureBox
    Dim vsource_images() As String = {"images\CoastGuard_Ship.png"}
    Public dirx, diry As Integer
    Public x_coordinate, y_coordinate As Integer

    '###########################################################################################################
    'Construct
    Public Sub New()

        Console.WriteLine("Instancia de CoastGuardShip, realizada correctamente")
        dirx = -10
        diry = 0

    End Sub

    '###########################################################################################################
    'Methods

    Public Sub Ship_Generator()


        If ((generation = True) And (form = True) And (matter = True)) Then

            'Coast Guard Ship Properties
            Marine_Rescue.pic_cg_ship.Image = Image.FromFile(vsource_images(0))
            'Marine_Rescue.pic_cg_ship.Size = New Size(200, 150)
            Marine_Rescue.pic_cg_ship.Visible = True

        End If


    End Sub

    Public Sub Ship_Movement()

        'Current Coordinate
        Dim w, x, y As Integer
        w = Marine_Rescue.pic_cg_ship.Width
        x = Marine_Rescue.pic_cg_ship.Location.X
        y = Marine_Rescue.pic_cg_ship.Location.Y

        'Coast Guard Ship transfer of the negative zone completely

        If x <= -w Then

            x = Marine_Rescue.pan_sea.Width + w

        End If

        Marine_Rescue.pic_cg_ship.Location = New Point(x + dirx, y + diry)

        'Console.WriteLine(matter)

    End Sub

    Public Sub Ship_Radar()

        'Calculate current coordinates
        x_coordinate = Marine_Rescue.pic_cg_ship.Location.X
        y_coordinate = Marine_Rescue.pic_cg_ship.Location.Y

    End Sub


End Class