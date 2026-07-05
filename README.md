# Aplikasi Kedua

## Deskripsi

Aplikasi desktop untuk mengelola data mahasiswa menggunakan arsitektur REST API dengan frontend VB.NET, backend Spring Boot, dan database PostgreSQL.

---

## Teknologi yang Digunakan

### Frontend

* VB.NET (Windows Forms Desktop Application)

### Backend

* Spring Boot

### Database

* PostgreSQL

### Arsitektur

* REST API

### Dokumentasi API

* Swagger OpenAPI

---

## Aturan Pengembangan

* Tidak diperbolehkan melakukan query database langsung dari sisi frontend.
* Frontend hanya berfungsi sebagai consumer API.
* Seluruh akses data dilakukan melalui endpoint yang disediakan oleh backend.

---

## Fitur Aplikasi

### Manajemen Mahasiswa

* Menampilkan data mahasiswa
* Menambah data mahasiswa
* Mengubah data mahasiswa
* Menghapus data mahasiswa
* Mencari data mahasiswa

### Dokumentasi API

* Swagger UI untuk dokumentasi dan pengujian endpoint

---

## Arsitektur Sistem

```text
VB.NET Desktop Application
            │
            ▼
    Spring Boot REST API
            │
            ▼
        PostgreSQL
```

---

## Menjalankan Backend

1. Jalankan PostgreSQL.
2. Buat database sesuai konfigurasi pada `application.properties`.
3. Jalankan backend:

```bash
mvn spring-boot:run
```

Backend berjalan pada:

```text
http://localhost:8080
```

Swagger:

```text
http://localhost:8080/swagger-ui/index.html
```

---

## Menjalankan Frontend

1. Buka project menggunakan Visual Studio.
2. Pastikan backend sudah berjalan.
3. Jalankan aplikasi.

Frontend akan mengakses data melalui endpoint backend yang tersedia.

---

## Author

Kanaka Wisma

Telkom University
