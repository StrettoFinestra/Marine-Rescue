Public Class CoastGuardShip

    'Attributes

    Public Const generation As Boolean = True
    Public Const matter As Boolean = True
    Public Const form As Boolean = True
    Dim vsource_images() As String = {"images\CoastGuard_Ship.png"}
    Public x_coordinate, y_coordinate As Integer
    Public xi_coordinate, yi_coordinate As Integer
    Public w_ship, h_ship, direction As Integer
    Public test As Boolean

    'Construct
    Public Sub New()

        Console.WriteLine("Instancia de CoastGuardShip, realizada correctamente")

    End Sub

    'Methods

    Public Sub Ship_Generator()


        If ((generation = True) And (form = True) And (matter = True)) Then

            'Coast Guard Ship Properties
            Marine_Rescue.pic_cg_ship.Image = Image.FromFile(vsource_images(0))
            Marine_Rescue.pic_cg_ship.Visible = True

        End If


    End Sub

    Public Sub Ship_Movement()

        'Current coordinates are obtained

        x_coordinate = Marine_Rescue.pic_cg_ship.Location.X
        y_coordinate = Marine_Rescue.pic_cg_ship.Location.Y

        'Ship Movement reached the limit on the left
        If (x_coordinate <= 0) Then

            direction -= -1
            x_coordinate = 0
            Console.WriteLine(direction & "en primer if")
        End If

        If (x_coordinate >= Marine_Rescue.pan_sea.Width - 35) Then

            'If the ship crosses the edge of the sea it restarts position
            direction += 1
            x_coordinate = Marine_Rescue.pan_sea.Width - 35

        End If

        Marine_Rescue.pic_cg_ship.Location = New Point(x_coordinate - 10, y_coordinate)
        Console.WriteLine(matter)

    End Sub

    Public Sub setTest(result As Boolean)
        Me.test = result
    End Sub

End Class
