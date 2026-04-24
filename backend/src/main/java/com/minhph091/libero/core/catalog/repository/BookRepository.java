package com.minhph091.libero.core.catalog.repository;

import com.minhph091.libero.core.catalog.entity.Book;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BookRepository extends JpaRepository<Book, Integer> {
    boolean existsBookByIsbn(String isbn);
}
