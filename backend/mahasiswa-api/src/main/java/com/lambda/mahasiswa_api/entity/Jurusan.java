package com.lambda.mahasiswa_api.entity;

import jakarta.persistence.*;

@Entity
@Table(name = "jurusan")
public class Jurusan {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id_jurusan")
    private Long idJurusan;

    @Column(name = "nama_jurusan")
    private String namaJurusan;

    @Column(name = "fakultas")
    private String fakultas;

    @Column(name = "jenjang")
    private String jenjang;

    public Long getIdJurusan() {
        return idJurusan;
    }

    public void setIdJurusan(Long idJurusan) {
        this.idJurusan = idJurusan;
    }

    public String getNamaJurusan() {
        return namaJurusan;
    }

    public void setNamaJurusan(String namaJurusan) {
        this.namaJurusan = namaJurusan;
    }

    public String getFakultas() {
        return fakultas;
    }

    public void setFakultas(String fakultas) {
        this.fakultas = fakultas;
    }

    public String getJenjang() {
        return jenjang;
    }

    public void setJenjang(String jenjang) {
        this.jenjang = jenjang;
    }
}
