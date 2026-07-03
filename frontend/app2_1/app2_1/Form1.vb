Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1

    Private client As New HttpClient()

    Private baseUrl As String =
        "http://localhost:8080"

    Private mahasiswaList As New List(Of Mahasiswa)

    Private selectedMahasiswa As Mahasiswa = Nothing

    Private Sub dgvMahasiswa_SelectedIndexChanged(
    sender As Object,
    e As EventArgs
) Handles dgvMahasiswa.SelectedIndexChanged

        If dgvMahasiswa.SelectedIndex < 0 Then Return

        selectedMahasiswa =
        mahasiswaList(dgvMahasiswa.SelectedIndex)

        txtNama.Text = selectedMahasiswa.nama
        txtUmur.Text = selectedMahasiswa.umur.ToString()
        txtNIM.Text = selectedMahasiswa.nim
        txtAlamat.Text = selectedMahasiswa.alamat

        DateTimePicker1.Value =
        DateTime.Parse(selectedMahasiswa.tglLahir)

    End Sub

    Private Async Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Await LoadMahasiswa()

    End Sub

    Private Async Function LoadMahasiswa() As Task

        Try

            Dim json As String =
            Await client.GetStringAsync(
                baseUrl & "/mahasiswa")

            mahasiswaList =
            JsonConvert.DeserializeObject(
                Of List(Of Mahasiswa))(json)

            dgvMahasiswa.Items.Clear()

            For Each m In mahasiswaList

                dgvMahasiswa.Items.Add(
                m.id & " - " & m.nama)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

    End Function

End Class
