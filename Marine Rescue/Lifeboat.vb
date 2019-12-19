Public Class Lifeboat

    '###########################################################################################################
    'Attributes
    Public pic_tmp_lifeboat As PictureBox
    Public vsource_images() As String = {"images\north_lifeboat.png", "images\northeast_lifeboat.png",
                                        "images\east_lifeboat.png", "images\southeast_lifeboat.png",
                                        "images\south_lifeboat.png", "images\southwest_lifeboat.png",
                                        "images\west_lifeboat.png", "images\northwest_lifeboat.png"}
    Public powerengine As Integer
    Dim sentinel_vsource As Integer
    Public dirx, diry As Integer
    Dim rnd As Random = New Random()

    '###########################################################################################################
    'Construct
    Public Sub New()

        Console.WriteLine("Instancia de Lifeboat, realizada correctamente")
        powerengine = True
        diry = 0
        dirx = 0

    End Sub

    '###########################################################################################################
    'Methods

    Public Sub Lifeboat_Generator()

        'cg_ship_coordinates
        'Lifeboat Properties
        pic_tmp_lifeboat = New PictureBox()
        pic_tmp_lifeboat.Size = New Size(50, 120)
        pic_tmp_lifeboat.Location = New Point(0, 0)
        sentinel_vsource = 0
        pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        pic_tmp_lifeboat.BackColor = System.Drawing.Color.Transparent
        pic_tmp_lifeboat.SizeMode = PictureBoxSizeMode.StretchImage

        'Add Lifeboat to pan_sea domains
        Marine_Rescue.pan_sea.Controls.Add(pic_tmp_lifeboat)

    End Sub

    Public Sub Lifeboat_Movement()

        'Current Coordinate
        Dim x, y As Integer
        x = pic_tmp_lifeboat.Location.X
        y = pic_tmp_lifeboat.Location.Y

        'When Lifeboat go to Up
        If y <= 0 Then
            y = 0
            diry = -diry
            'Lifeboat_SpeedLimit()
        End If

        'When Lifeboat go to Down
        If y >= Marine_Rescue.pan_sea.Height - pic_tmp_lifeboat.Height Then
            y = Marine_Rescue.pan_sea.Height - pic_tmp_lifeboat.Height
            diry = -diry
            'Lifeboat_SpeedLimit()
        End If

        'When Lifeboat go to Left
        If x <= 0 Then
            x = 0
            dirx = -dirx
            'Lifeboat_SpeedLimit()
        End If

        'When Lifeboat go to Right
        If x >= Marine_Rescue.pan_sea.Width - pic_tmp_lifeboat.Width Then
            x = Marine_Rescue.pan_sea.Width - pic_tmp_lifeboat.Width
            dirx = -dirx
            'Lifeboat_SpeedLimit()
        End If


        'Lifeboat Movement
        pic_tmp_lifeboat.Location = New Point(x + dirx, y + diry)


        'Lifeboat Sprites

        'When Lifeboat go to North  
        If diry < 0 And dirx = 0 Then
            pic_tmp_lifeboat.Size = New Size(50, 120)
            sentinel_vsource = 0
            'Console.WriteLine("North" & sentinel_vsource)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to SouthEast     
        If diry > 0 And dirx > 0 Then
            sentinel_vsource = 3
            'Console.WriteLine("SouthEast" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(100, 120)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to East  
        If dirx > 0 And diry = 0 Then
            sentinel_vsource = 2
            'Console.WriteLine("East" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(120, 60)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to NorthEast  
        If diry < 0 And dirx > 0 Then
            sentinel_vsource = 1
            'Console.WriteLine("NorthEast" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(100, 120)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to South 
        If diry > 0 And dirx = 0 Then
            sentinel_vsource = 4
            'Console.WriteLine("South" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(50, 120)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to NorthWest  
        If dirx < 0 And diry < 0 Then
            sentinel_vsource = 7
            'Console.WriteLine("NorthWest" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(100, 120)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to West  
        If dirx < 0 And diry = 0 Then
            sentinel_vsource = 6
            'Console.WriteLine("West" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(120, 60)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

        'When Lifeboat go to SouthWest 
        If dirx < 0 And diry > 0 Then
            sentinel_vsource = 5
            'Console.WriteLine("SouthWest" & sentinel_vsource)
            pic_tmp_lifeboat.Size = New Size(100, 120)
            pic_tmp_lifeboat.Image = Image.FromFile(vsource_images(sentinel_vsource))
        End If

    End Sub

    Public Sub Lifeboat_Ricochet()
        dirx = -dirx
        diry = -diry
    End Sub

    Public Sub Lifeboat_SpeedLimit()

        'Work Variables
        Dim percent As Double = 0.5
        Dim reductionx, reductiony As Integer

        'Reduction of current Speed
        reductionx = dirx * percent
        reductiony = diry * percent
        dirx = reductionx
        diry = reductiony

    End Sub

End Class
