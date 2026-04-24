package com.minhph091.libero.core.catalog.controller;

import com.minhph091.libero.core.catalog.dto.BookDTO;
import com.minhph091.libero.core.catalog.dto.CreateBookRequest;
import com.minhph091.libero.core.catalog.dto.UpdateBookRequest;
import com.minhph091.libero.core.catalog.entity.Book;
import com.minhph091.libero.core.catalog.mapper.BookMapper;
import com.minhph091.libero.core.catalog.repository.BookRepository;
import com.minhph091.libero.core.catalog.service.BookService;
import com.minhph091.libero.exception.ApiException;
import io.swagger.v3.oas.annotations.security.SecurityRequirement;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/v1/books")
public class BookController {
    private final BookService bookService;
    private final BookMapper bookMapper;

    @Autowired
    public BookController(BookService bookService, BookMapper bookMapper) {
        this.bookService = bookService;
        this.bookMapper = bookMapper;
    }

    @GetMapping("/{bookId}")
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<BookDTO> getBookById(@PathVariable Integer bookId) {
        Book book = bookService.findBookById(bookId).orElseThrow(()
                -> new ApiException(HttpStatus.NOT_FOUND, "Book not found", "BOOK_NOT_FOUND"));
        return ResponseEntity.status(HttpStatus.OK).body(bookMapper.entityToDto(book));
    }

    @PatchMapping("/{bookId}")
    @PreAuthorize("hasAnyRole('ROLE_LIBRARIAN', 'ROLE_ADMIN')")
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<BookDTO> updateBook(@PathVariable Integer bookId,
                                              @Valid @RequestBody UpdateBookRequest request) {
        Book book = bookService.updateBook(bookId, request);
        return ResponseEntity.status(HttpStatus.OK).body(bookMapper.entityToDto(book));
    }

    @PostMapping
    @PreAuthorize("hasAnyRole('ROLE_LIBRARIAN', 'ROLE_ADMIN')")
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<Void> createBook(@Valid @RequestBody CreateBookRequest request) {
        bookService.createBook(request);
        return ResponseEntity.status(HttpStatus.CREATED).build();
    }


}
