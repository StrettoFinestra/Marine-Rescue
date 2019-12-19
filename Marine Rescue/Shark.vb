Public Class Shark

    '###########################################################################################################
    'Attributes

    Public pic_tmp_shark As PictureBox
    Public dirx, diry As Integer
    Public vsource_images() As String = {"images\Sharpedo.png", "images\Mega_Sharpedo.png"}
    Dim rnd As Random = New Random()

    '###########################################################################################################
    'Construct
    Public Sub New()

        Console.WriteLine("Instancia de Shark, realizada correctamente")
        diry = 10
        dirx = 10

    End Sub

    '###########################################################################################################
    'Methods

    Public Sub Shark_Generator(counter, lvlstatus)

        If counter < 10 Then

            'Work Variables
            Dim x, y As Integer

            Dim rndlocation As Integer

            'Shark Properties
            pic_tmp_shark = New PictureBox()

            'Difficulty Sharkpedos

            If lvlstatus <= 5 Then

                'Normal Sharkpedos
                pic_tmp_shark.Image = Image.FromFile(vsource_images(0))
                pic_tmp_shark.Size = New Size(65, 65)

            Else

                'Mega Sharkpedos
                pic_tmp_shark.Image = Image.FromFile(vsource_images(1))
                pic_tmp_shark.Size = New Size(75, 75)

            End If


            'Square Shark Location Generator
            rndlocation = rnd.Next(1, 5)

            Select Case rndlocation


                Case 1

                    Debug.WriteLine("Left")
                    x = 0
                    y = rnd.Next(0, Marine_Rescue.pan_sea.Height - pic_tmp_shark.Height - 10)


                Case 2

                    Debug.WriteLine("Right")
                    x = Marine_Rescue.pan_sea.Width - pic_tmp_shark.Width - 10
                    y = rnd.Next(0, Marine_Rescue.pan_sea.Height - pic_tmp_shark.Height - 10)


                Case 3

                    Debug.WriteLine("Up")
                    y = 0
                    x = rnd.Next(0, Marine_Rescue.pan_sea.Width - pic_tmp_shark.Width - 10)


                Case 4

                    Debug.WriteLine("Down")
                    y = Marine_Rescue.pan_sea.Height - pic_tmp_shark.Width - 10
                    x = rnd.Next(0, Marine_Rescue.pan_sea.Width - pic_tmp_shark.Width - 10)


            End Select

            pic_tmp_shark.Location = New Point(x, y)
            pic_tmp_shark.BackColor = System.Drawing.Color.Transparent
            pic_tmp_shark.SizeMode = PictureBoxSizeMode.StretchImage
            pic_tmp_shark.Name = "Sharkpedo" & counter

            'Add Sharkpedo to sea
            Marine_Rescue.pan_sea.Controls.Add(pic_tmp_shark)

        End If


    End Sub

    Public Sub Shark_Movement()

        'Current Coordinate
        Dim x, y As Integer
        x = pic_tmp_shark.Location.X
        y = pic_tmp_shark.Location.Y

        'When Sharkpedos go to Up
        If y <= 0 Then
            y = 0
            diry = -diry
        End If

        'When Sharkpedos go to  Down
        If y >= Marine_Rescue.pan_sea.Height - pic_tmp_shark.Height Then
            y = Marine_Rescue.pan_sea.Height - pic_tmp_shark.Height
            diry = -diry
        End If

        'When Sharkpedos go to Left
        If x <= 0 Then
            x = 0
            dirx = -dirx
        End If

        'When Sharkpedos go to Right
        If x >= Marine_Rescue.pan_sea.Width - pic_tmp_shark.Width Then
            x = Marine_Rescue.pan_sea.Width - pic_tmp_shark.Width
            dirx = -dirx
        End If

        'Sharkpedos Movement
        pic_tmp_shark.Location = New Point(x + dirx, y + diry)

    End Sub

    'Increment speed force of all Sharkpedos
    Public Sub Shark_IncrementSpeed()
        diry += 10
        dirx += 10
    End Sub

    'Principle of action and reaction for all Sharkpedos
    Public Sub Shark_Ricochet()
        dirx = -dirx
        diry = -diry
    End Sub

End Class
