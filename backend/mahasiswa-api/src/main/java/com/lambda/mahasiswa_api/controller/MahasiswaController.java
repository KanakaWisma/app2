package com.lambda.mahasiswa_api.controller;

import com.lambda.mahasiswa_api.entity.Mahasiswa;
import com.lambda.mahasiswa_api.repository.MahasiswaRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/mahasiswa")
public class MahasiswaController {

    private final MahasiswaRepository mahasiswaRepository;

    public MahasiswaController(MahasiswaRepository mahasiswaRepository) {
        this.mahasiswaRepository = mahasiswaRepository;
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

        return mahasiswaRepository.save(mahasiswa);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        mahasiswaRepository.deleteById(id);
    }
}