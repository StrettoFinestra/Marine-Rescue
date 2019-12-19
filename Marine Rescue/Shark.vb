Public Class Shark

    'Attributes
    Dim vpic_tmp(9) As PictureBox
    Dim vsource_images() As String = {"images\Sharpedo.png", "images\Mega_Sharpedo.png"}
    Dim rnd As Random = New Random()

    'Construct
    Public Sub New()

        Console.WriteLine("Instancia de Shark, realizada correctamente")

    End Sub

    'Methods

    Public Sub Shark_Generator(counter, lvlstatus)

        If counter < 10 Then

            'Work Variables
            Dim x, y As Integer
            Dim pic_tmp As PictureBox
            Dim rndlocation As Integer

            'Shark Properties
            pic_tmp = New PictureBox()
            pic_tmp.Size = New Size(100, 100)

            'Square Shark Location Generator
            rndlocation = rnd.Next(1, 5)

            Select Case rndlocation

                Case 1

                    Debug.WriteLine("Left")
                    x = 0
                    y = rnd.Next(0, Marine_Rescue.pan_sea.Height - pic_tmp.Height - 10)



                Case 2

                    Debug.WriteLine("Right")
                    x = Marine_Rescue.pan_sea.Width - pic_tmp.Width - 10
                    y = rnd.Next(0, Marine_Rescue.pan_sea.Height - pic_tmp.Height - 10)


                Case 3

                    Debug.WriteLine("Up")
                    y = 0
                    x = rnd.Next(0, Marine_Rescue.pan_sea.Width - pic_tmp.Width - 10)


                Case 4

                    Debug.WriteLine("Down")
                    y = Marine_Rescue.pan_sea.Height - pic_tmp.Width - 10
                    x = rnd.Next(0, Marine_Rescue.pan_sea.Width - pic_tmp.Width - 10)


            End Select

            pic_tmp.Location = New Point(x, y)
            pic_tmp.BackColor = System.Drawing.Color.Transparent
            pic_tmp.SizeMode = PictureBoxSizeMode.StretchImage

            'Difficulty sharks
            If lvlstatus <= 5 Then
                'Easy Shark
                pic_tmp.Image = Image.FromFile(vsource_images(0))
            Else
                'Hard Shark
                pic_tmp.Image = Image.FromFile(vsource_images(1))
            End If

            Marine_Rescue.pan_sea.Controls.Add(pic_tmp)
            vpic_tmp(counter) = pic_tmp

        End If


    End Sub


End Class
