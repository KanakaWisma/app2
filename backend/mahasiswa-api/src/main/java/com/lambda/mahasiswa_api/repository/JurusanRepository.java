package com.lambda.mahasiswa_api.repository;

import com.lambda.mahasiswa_api.entity.Jurusan;
import org.springframework.data.jpa.repository.JpaRepository;

public interface JurusanRepository extends JpaRepository<Jurusan, Long> {
}