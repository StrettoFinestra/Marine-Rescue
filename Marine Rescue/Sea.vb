Public Class Sea

    'Attributes

    Public Const generation As Boolean = True
    Public Const matter As Boolean = True
    Public Const form As Boolean = True
    Public Const type_universe As String = "F.U.W.E" 'Finite Universe Without Edge
    Private pan_sea As PictureBox

    'Construct
    Public Sub New()


    End Sub

    'Methods

    'Generator 
    Public Sub Sea_Generator()

        'Attributes
        Dim pan_sea As PictureBox

        'Data Process
        pan_sea = New PictureBox()
        pan_sea.Size = New Size(60, 60)
        'pan_sea.Location = New Point(Rnd.Next(Marine_Rescue.sea.Width - pan_sea.Width - 10), Rnd.Next((Marine_Rescue.sea.Height - 150) - pan_sea.Height - 35))
        'pan_sea.Image = Image.FromFile()
        pan_sea.BackColor = System.Drawing.Color.Transparent
        pan_sea.SizeMode = PictureBoxSizeMode.StretchImage
        Marine_Rescue.sea.Controls.Add(pan_sea)

    End Sub

End Class
