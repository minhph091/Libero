package com.minhph091.libero.core.catalog.repository;

import com.minhph091.libero.core.catalog.entity.Book;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;

import java.util.Optional;

public interface BookRepository extends JpaRepository<Book, Integer>, JpaSpecificationExecutor<Book> {
    boolean existsBookByIsbn(String isbn);
    Optional<Book> findBookByIdAndDeletedAtIsNull(Integer id);
}
