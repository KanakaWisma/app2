package com.lambda.mahasiswa_api.controller;

import com.lambda.mahasiswa_api.entity.Jurusan;
import com.lambda.mahasiswa_api.repository.JurusanRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/jurusan")
public class JurusanController {

    private final JurusanRepository jurusanRepository;

    public JurusanController(JurusanRepository jurusanRepository) {
        this.jurusanRepository = jurusanRepository;
    }

    @GetMapping
    public List<Jurusan> getAll() {
        return jurusanRepository.findAll();
    }

    @GetMapping("/{id}")
    public Jurusan getById(@PathVariable Long id) {
        return jurusanRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Jurusan tidak ditemukan"));
    }

    @PostMapping
    public Jurusan create(@RequestBody Jurusan jurusan) {
        return jurusanRepository.save(jurusan);
    }

    @PutMapping("/{id}")
    public Jurusan update(
            @PathVariable Long id,
            @RequestBody Jurusan jurusanBaru) {

        Jurusan jurusan = jurusanRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Jurusan tidak ditemukan"));

        jurusan.setNamaJurusan(jurusanBaru.getNamaJurusan());
        jurusan.setFakultas(jurusanBaru.getFakultas());
        jurusan.setJenjang(jurusanBaru.getJenjang());

        return jurusanRepository.save(jurusan);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        jurusanRepository.deleteById(id);
    }
}