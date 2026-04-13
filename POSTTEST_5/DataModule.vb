Public Module DataModule
    ' DataTable digunakan sebagai database sementara untuk menampung data sepatu 
    Public dtSepatu As New DataTable

    Public Sub InisialisasiData()

        If dtSepatu.Columns.Count = 0 Then
            dtSepatu.Columns.Add("ID", GetType(String))
            dtSepatu.Columns.Add("Merk", GetType(String))
            dtSepatu.Columns.Add("Ukuran", GetType(Integer))
            dtSepatu.Columns.Add("Stok", GetType(Integer))
        End If
    End Sub
End Module