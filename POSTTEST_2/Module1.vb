Module Module1
    Public rakBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Function CariBuku(ByVal judulTarget As String) As Integer
        Dim k As Integer
        For k = 0 To jumlahBuku - 1
            If rakBuku(k, 0).ToLower() = judulTarget.ToLower() Then
                Return k
            End If
        Next
        Return -1
    End Function
End Module