Public Class Jurusan

    Public Property idJurusan As Long
    Public Property namaJurusan As String
    Public Property fakultas As String
    Public Property jenjang As String

    Public Overrides Function ToString() As String

        Return namaJurusan

    End Function

End Class