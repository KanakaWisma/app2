Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Private Class MahasiswaRequest

        Public Property nama As String
        Public Property umur As Integer
        Public Property nim As String
        Public Property tglLahir As String
        Public Property alamat As String

        Public Property jurusan As Jurusan

    End Class

    Private jurusanList As New List(Of Jurusan)

    Private client As New HttpClient()

    Private baseUrl As String =
        "http://localhost:8080"

    Private mahasiswaList As New List(Of Mahasiswa)

    Private selectedMahasiswa As Mahasiswa = Nothing

    Private selectedId As Long = 0

    Private filteredMahasiswa As New List(Of Mahasiswa)

    Private Sub dgvMahasiswa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvMahasiswa.SelectedIndexChanged
        If dgvMahasiswa.SelectedIndex < 0 Then Return

        Try
            selectedMahasiswa = filteredMahasiswa(dgvMahasiswa.SelectedIndex)
            selectedId = selectedMahasiswa.id

            txtNama.Text = selectedMahasiswa.nama
            txtUmur.Text = selectedMahasiswa.umur.ToString()
            txtNIM.Text = selectedMahasiswa.nim
            txtAlamat.Text = selectedMahasiswa.alamat

            Try
                DateTimePicker1.Value = selectedMahasiswa.tglLahir
            Catch exDate As Exception
                DateTimePicker1.Value = DateTime.Now
            End Try

            If selectedMahasiswa.jurusan IsNot Nothing Then
                For i As Integer = 0 To cmbJurusan.Items.Count - 1
                    Dim j As Jurusan = CType(cmbJurusan.Items(i), Jurusan)
                    If j.idJurusan = selectedMahasiswa.jurusan.idJurusan Then
                        cmbJurusan.SelectedIndex = i

                        Exit For
                    End If
                Next
            Else
                cmbJurusan.SelectedIndex = -1
            End If

        Catch ex As Exception
            MessageBox.Show("Error pas nampilin data: " & ex.Message)
        End Try
    End Sub

    Private Async Sub Form1_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        Await LoadJurusan()
        Await LoadMahasiswa()

    End Sub

    Private Sub cmbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJurusan.SelectedIndexChanged

        Dim selectedJurusan As Jurusan = TryCast(cmbJurusan.SelectedItem, Jurusan)

        If selectedJurusan IsNot Nothing Then
            txtFakultas.Text = selectedJurusan.fakultas
            cmbJenjang.Text = selectedJurusan.jenjang
        End If
    End Sub

    Private Async Function LoadMahasiswa() As Task

        Try

            Dim json As String =
            Await client.GetStringAsync(
                baseUrl & "/mahasiswa")

            mahasiswaList =
JsonConvert.DeserializeObject(
    Of List(Of Mahasiswa))(json)

            filteredMahasiswa =
New List(Of Mahasiswa)(mahasiswaList)

            dgvMahasiswa.Items.Clear()

            For Each m In mahasiswaList

                dgvMahasiswa.Items.Add(
                    m.nama & " - " & m.nim)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Function

    Private Async Function LoadJurusan() As Task

        Try

            Dim json As String =
        Await client.GetStringAsync(
            baseUrl & "/jurusan")

            jurusanList =
            JsonConvert.DeserializeObject(
                Of List(Of Jurusan))(json)

            cmbJurusan.Items.Clear()

            For Each j In jurusanList

                cmbJurusan.Items.Add(j)

            Next

            If cmbJurusan.Items.Count > 0 Then
                cmbJurusan.SelectedIndex = 0
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Function

    Private Sub SearchMahasiswa()

        Dim keyword As String =
        txtSearch.Text.ToLower()

        dgvMahasiswa.Items.Clear()

        filteredMahasiswa.Clear()

        For Each m In mahasiswaList

            If m.nama.ToLower().Contains(keyword) _
            OrElse m.nim.ToLower().Contains(keyword) Then

                filteredMahasiswa.Add(m)

                dgvMahasiswa.Items.Add(
                m.nama & " - " & m.nim)

            End If

        Next

    End Sub

    Private Async Sub btnSave_Click(
    sender As Object,
    e As EventArgs
) Handles btnSave.Click

        Try

            Dim data As New MahasiswaRequest With {
                .nama = txtNama.Text,
                .umur = Integer.Parse(txtUmur.Text),
                .nim = txtNIM.Text,
                .tglLahir = DateTimePicker1.Value.ToString("yyyy-MM-dd"),
                .alamat = txtAlamat.Text,
                .jurusan =
                    CType(
                    cmbJurusan.SelectedItem,
                    Jurusan)
                }

            Dim json =
                JsonConvert.SerializeObject(data)

            MessageBox.Show(json)

            Dim content =
                New StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json")

            Dim response =
                Await client.PostAsync(
                    baseUrl & "/mahasiswa",
                    content)

            If response.IsSuccessStatusCode Then

                MessageBox.Show("Data berhasil disimpan")

                Await LoadJurusan()
                Await LoadMahasiswa()

            Else

                Dim errorText =
                    Await response.Content.ReadAsStringAsync()

                MessageBox.Show(errorText)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Sub

    Private Async Sub btnUpdate_Click(
    sender As Object,
    e As EventArgs
) Handles btnUpdate.Click

        Try

            If selectedId = 0 Then

                MessageBox.Show("Pilih data dulu")
                Return

            End If

            Dim data As New MahasiswaRequest With {
                .nama = txtNama.Text,
                .umur = Integer.Parse(txtUmur.Text),
                .nim = txtNIM.Text,
                .tglLahir = DateTimePicker1.Value.ToString("yyyy-MM-dd"),
                .alamat = txtAlamat.Text,
                .jurusan =
    CType(
        cmbJurusan.SelectedItem,
        Jurusan)
                }

            Dim json =
                JsonConvert.SerializeObject(data)

            Dim content =
                New StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json")

            Dim response =
                Await client.PutAsync(
                    baseUrl & "/mahasiswa/" & selectedId,
                    content)

            If response.IsSuccessStatusCode Then

                MessageBox.Show("Data berhasil diupdate")

                Await LoadMahasiswa()

            Else

                MessageBox.Show(
                    Await response.Content.ReadAsStringAsync())

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Sub

    Private Async Sub btnDelete_Click(
    sender As Object,
    e As EventArgs
) Handles btnDelete.Click

        Try

            If selectedId = 0 Then

                MessageBox.Show("Pilih data dulu")
                Return

            End If

            Dim response =
                Await client.DeleteAsync(
                    baseUrl & "/mahasiswa/" & selectedId)

            If response.IsSuccessStatusCode Then

                MessageBox.Show("Data berhasil dihapus")

                selectedId = 0

                Await LoadMahasiswa()

            Else

                MessageBox.Show(
                    Await response.Content.ReadAsStringAsync())

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Sub

    Private Sub btnReset_Click(
    sender As Object,
    e As EventArgs
) Handles btnReset.Click

        txtNama.Clear()
        txtUmur.Clear()
        txtNIM.Clear()
        txtAlamat.Clear()

        DateTimePicker1.Value = DateTime.Now

        selectedId = 0

    End Sub

    Private Sub btnSearch_Click(
    sender As Object,
    e As EventArgs
) Handles btnSearch.Click

        SearchMahasiswa()

    End Sub

    Private Sub txtSearch_TextChanged(
    sender As Object,
    e As EventArgs
) Handles txtSearch.TextChanged

        SearchMahasiswa()

    End Sub

End Class