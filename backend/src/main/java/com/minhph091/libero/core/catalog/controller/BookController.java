package com.minhph091.libero.core.catalog.controller;

import com.minhph091.libero.core.catalog.dto.BookDTO;
import com.minhph091.libero.core.catalog.dto.CreateBookRequest;
import com.minhph091.libero.core.catalog.dto.UpdateBookRequest;
import com.minhph091.libero.core.catalog.entity.Author;
import com.minhph091.libero.core.catalog.entity.Book;
import com.minhph091.libero.core.catalog.entity.Category;
import com.minhph091.libero.core.catalog.entity.Publisher;
import com.minhph091.libero.core.catalog.mapper.BookMapper;
import com.minhph091.libero.core.catalog.service.BookService;
import com.minhph091.libero.exception.ApiException;
import io.swagger.v3.oas.annotations.security.SecurityRequirement;
import jakarta.persistence.criteria.Order;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

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
        if (book.getDeletedAt() != null) {
            throw new ApiException(HttpStatus.NOT_FOUND, "Book not found", "BOOK_NOT_FOUND");
        }
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

    @DeleteMapping("/{bookId}")
    @PreAuthorize("hasAnyRole('ROLE_LIBRARIAN', 'ROLE_ADMIN')")
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<Void> deleteBook(@PathVariable Integer bookId) {
        bookService.deleteBook(bookId);
        return ResponseEntity.status(HttpStatus.NO_CONTENT).build();
    }

    @GetMapping
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<Page<BookDTO>> getBooks(
            @RequestParam(required = false) String keyword,
            @RequestParam(required = false) Integer publisherId,
            @RequestParam(required = false) Integer authorId,
            @RequestParam(required = false) Integer categoryId,
            @RequestParam(defaultValue = "0") int page,
            @RequestParam(defaultValue = "10") int size,
            @RequestParam(defaultValue = "created_at,desc") String[] sort
    ) {
        Publisher publisher = null;
        if (publisherId != null) {
            publisher = new Publisher();
            publisher.setId(publisherId);
        }
        Author author = null;
        if (authorId != null) {
            author = new Author();
            author.setId(authorId);
        }
        Category category = null;
        if (categoryId != null) {
            category = new Category();
            category.setId(categoryId);
        }
        List<Sort.Order> orders = new ArrayList<>();
        if (sort[0].contains(",")) {
            for (String sortOrder : sort) {
                String[] _sort = sortOrder.split(",");
                orders.add(new Sort.Order(Sort.Direction.fromString(_sort[1]), _sort[0]));
            }
        } else {
            orders.add(new Sort.Order(Sort.Direction.fromString(sort[1]), sort[0]));
        }
        Pageable pageable = PageRequest.of(page, size, Sort.by(orders));
        Page<Book> bookPage = bookService.getBooksByPage(keyword, authorId, publisherId, categoryId, pageable);
        Page<BookDTO> bookDTOPage = bookPage.map(bookMapper::entityToDto);
        return ResponseEntity.status(HttpStatus.OK).body(bookDTOPage);
    }


}
