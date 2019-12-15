Public Class Shark

    'Attributes
    Dim vpic_tmp(9) As PictureBox
    Dim vsource_images() As String = {"images\Sharpedo.png", "images\Mega_Sharpedo.png"}
    Dim rnd As Random = New Random()

    'Construct
    Public Sub New()


    End Sub

    'Methods

    Public Sub Shark_Generator(counter, lvlstatus)

        If counter < 10 Then

            'Attributes
            Dim pic_tmp As PictureBox

            'Shark Properties
            pic_tmp = New PictureBox()
            pic_tmp.Size = New Size(100, 100)
            pic_tmp.Location = New Point(rnd.Next(Marine_Rescue.pan_sea.Width - pic_tmp.Width - 10), rnd.Next(Marine_Rescue.pan_sea.Height - pic_tmp.Height - 35))
            pic_tmp.BackColor = System.Drawing.Color.Transparent
            pic_tmp.SizeMode = PictureBoxSizeMode.StretchImage

            If lvlstatus <= 5 Then
                pic_tmp.Image = Image.FromFile(vsource_images(0))
            Else
                pic_tmp.Image = Image.FromFile(vsource_images(1))
            End If
            Marine_Rescue.pan_sea.Controls.Add(pic_tmp)
            vpic_tmp(counter) = pic_tmp

        End If

    End Sub

End Class
