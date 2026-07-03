package com.lambda.mahasiswa_api.repository;

import com.lambda.mahasiswa_api.entity.Mahasiswa;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MahasiswaRepository extends JpaRepository<Mahasiswa, Long> {
}