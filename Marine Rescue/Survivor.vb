Public Class Survivor : Inherits Sea

    'Attributes
    Dim vpic_tmp(9) As PictureBox
    Dim vsource_images() As String = {"images\Castaway_F.png", "images\Castaway_M.png"}
    Dim rnd As Random = New Random()

    'Construct
    Public Sub New()

        Console.WriteLine("Instancia de Survivor, realizada correctamente")

    End Sub

    'Methods

    'Generator 
    Public Sub Survivor_Generator(counter)

        If counter < 10 Then

            'Work Variables
            Dim pic_tmp As PictureBox

            'Survivor Properties
            pic_tmp = New PictureBox()
            pic_tmp.Size = New Size(60, 60)
            pic_tmp.Location = New Point(rnd.Next(Marine_Rescue.pan_sea.Width - pic_tmp.Width - 10), rnd.Next((Marine_Rescue.pan_sea.Height - 150) - pic_tmp.Height - 35))
            pic_tmp.Image = Image.FromFile(vsource_images(rnd.Next(0, 2)))
            pic_tmp.BackColor = System.Drawing.Color.Transparent
            pic_tmp.SizeMode = PictureBoxSizeMode.StretchImage
            Marine_Rescue.pan_sea.Controls.Add(pic_tmp)
            vpic_tmp(counter) = pic_tmp

        End If

    End Sub

End Class