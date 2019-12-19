Public Class Sea

    'Attributes

    Public Const generation As Boolean = True
    Public Const matter As Boolean = True
    Public Const form As Boolean = True
    Public Const type_universe As String = "F.U.W.E" 'Finite Universe Without Edge

    'Construct
    Public Sub New()
        Console.WriteLine("Instancia de Sea, realizada correctamente")
    End Sub
    'Methods

    'Generator 
    Public Sub Sea_Generator()

        If ((generation = True) And (form = True) And (matter = True) And (type_universe = "F.U.W.E")) Then

            'Sea Properties
            Marine_Rescue.pan_sea.Visible = True

        End If

    End Sub

End Class
