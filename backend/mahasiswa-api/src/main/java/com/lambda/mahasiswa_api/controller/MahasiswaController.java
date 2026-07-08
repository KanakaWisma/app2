package com.lambda.mahasiswa_api.controller;

import com.lambda.mahasiswa_api.entity.Jurusan;
import com.lambda.mahasiswa_api.entity.Mahasiswa;
import com.lambda.mahasiswa_api.repository.JurusanRepository;
import com.lambda.mahasiswa_api.repository.MahasiswaRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/mahasiswa")
public class MahasiswaController {

    private final MahasiswaRepository mahasiswaRepository;
    private final JurusanRepository jurusanRepository;

    public MahasiswaController(MahasiswaRepository mahasiswaRepository, JurusanRepository jurusanRepository) {
        this.mahasiswaRepository = mahasiswaRepository;
        this.jurusanRepository = jurusanRepository;
    }

    @GetMapping
    public List<Mahasiswa> getAll() {
        return mahasiswaRepository.findAll();
    }

    @GetMapping("/{id}")
    public Mahasiswa getById(@PathVariable Long id) {
        return mahasiswaRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Mahasiswa tidak ditemukan"));
    }

    @PostMapping
    public Mahasiswa create(@RequestBody Mahasiswa mahasiswa) {
        if (mahasiswa.getJurusan() != null && mahasiswa.getJurusan().getIdJurusan() != null) {
            Jurusan jurusanAsli = jurusanRepository.findById(mahasiswa.getJurusan().getIdJurusan()).orElse(null);
            mahasiswa.setJurusan(jurusanAsli);   
        }
        return mahasiswaRepository.save(mahasiswa);
    }

    @PutMapping("/{id}")
    public Mahasiswa update(
            @PathVariable Long id,
            @RequestBody Mahasiswa mahasiswaBaru) {

        Mahasiswa mahasiswa = mahasiswaRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Mahasiswa tidak ditemukan"));

        mahasiswa.setNama(mahasiswaBaru.getNama());
        mahasiswa.setUmur(mahasiswaBaru.getUmur());
        mahasiswa.setNim(mahasiswaBaru.getNim());
        mahasiswa.setTglLahir(mahasiswaBaru.getTglLahir());
        mahasiswa.setAlamat(mahasiswaBaru.getAlamat());
        mahasiswa.setJurusan(mahasiswaBaru.getJurusan());
        
        if (mahasiswaBaru.getJurusan() != null && mahasiswaBaru.getJurusan().getIdJurusan() != null) {
            Jurusan jurusanAsli = jurusanRepository.findById(mahasiswaBaru.getJurusan().getIdJurusan()).orElse(null);
            mahasiswa.setJurusan(jurusanAsli);
        }

        return mahasiswaRepository.save(mahasiswa);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        mahasiswaRepository.deleteById(id);
    }
}