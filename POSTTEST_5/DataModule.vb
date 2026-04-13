Imports MySqlConnector

Public Module DataModule
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("Server=localhost;Port=3306;Database=db_sepatu;User ID=root;Password=;")
    End Function

    Public Function GetAllSepatu() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_sepatu AS ID, merk AS Merk, ukuran AS Ukuran, stok AS Stok FROM tb_sepatu ORDER BY id_sepatu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchSepatu(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_sepatu AS ID, merk AS Merk, ukuran AS Ukuran, stok AS Stok FROM tb_sepatu WHERE merk LIKE @key"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanSepatu(merk As String, ukuran As Integer, stok As Integer) As Boolean
        Try
            ' ID tidak dimasukkan karena Auto Increment di database
            Dim query As String = "INSERT INTO tb_sepatu (merk, ukuran, stok) VALUES (@merk, @ukuran, @stok)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@merk", merk)
                    cmd.Parameters.AddWithValue("@ukuran", ukuran)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahSepatu(id As String, merk As String, ukuran As Integer, stok As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_sepatu SET merk=@merk, ukuran=@ukuran, stok=@stok WHERE id_sepatu=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@merk", merk)
                    cmd.Parameters.AddWithValue("@ukuran", ukuran)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusSepatu(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_sepatu WHERE id_sepatu=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
End Module