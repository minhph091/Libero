package com.minhph091.libero.core.catalog.service;

import com.minhph091.libero.core.catalog.dto.CreateBookRequest;
import com.minhph091.libero.core.catalog.dto.UpdateBookRequest;
import com.minhph091.libero.core.catalog.entity.Author;
import com.minhph091.libero.core.catalog.entity.Book;
import com.minhph091.libero.core.catalog.entity.Category;
import com.minhph091.libero.core.catalog.entity.Publisher;
import com.minhph091.libero.core.catalog.mapper.BookMapper;
import com.minhph091.libero.core.catalog.repository.BookRepository;
import com.minhph091.libero.core.catalog.repository.BookSpecification;
import com.minhph091.libero.core.catalog.repository.PublisherRepository;
import com.minhph091.libero.exception.ApiException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.time.LocalDateTime;
import java.util.Optional;

@Service
public class BookService {
    private final BookRepository bookRepository;
    private final PublisherRepository publisherRepository;
    private final BookMapper bookMapper;

    @Autowired
    public BookService(BookRepository bookRepository,
                       BookMapper bookMapper,
                       PublisherRepository publisherRepository) {
        this.bookRepository = bookRepository;
        this.bookMapper = bookMapper;
        this.publisherRepository = publisherRepository;
    }

    @Transactional(readOnly = true)
    public Optional<Book> findBookById(Integer id) {
        return bookRepository.findById(id);
    }

    @Transactional
    public void createBook(CreateBookRequest request) {
        if (bookRepository.existsBookByIsbn((request.isbn()))) {
            throw new ApiException(HttpStatus.BAD_REQUEST, "ISBN already exists", "ISBN_ALREADY_EXISTS");
        }
        if (request.publisherId() != null && !publisherRepository.existsById(request.publisherId())) {
            throw new ApiException(HttpStatus.NOT_FOUND, "Publisher not found", "PUBLISHER_NOT_FOUND");
        }
        bookRepository.save(bookMapper.createDTOtoEntity(request));
    }

    @Transactional
    public Book updateBook(Integer id, UpdateBookRequest request) {
        Book book = bookRepository.findById(id).orElseThrow(()
                -> new ApiException(HttpStatus.NOT_FOUND, "Book not found", "BOOK_NOT_FOUND"));
        if (book.getDeletedAt() != null) {
            throw new ApiException(HttpStatus.NOT_FOUND, "Book not found", "BOOK_NOT_FOUND");
        }

        if (bookRepository.existsBookByIsbn(request.isbn()) && !book.getIsbn().equalsIgnoreCase(request.isbn())) {
            throw new ApiException(HttpStatus.BAD_REQUEST, "ISBN already exists", "ISBN_ALREADY_EXISTS");
        }
        if (request.publisherId() != null && !publisherRepository.existsById(request.publisherId())) {
            throw new ApiException(HttpStatus.NOT_FOUND, "Publisher not found", "PUBLISHER_NOT_FOUND");
        }
        bookMapper.updateBookFromUpdateDTO(request, book);
        return bookRepository.save(book);
    }

    @Transactional
    public void deleteBook(Integer id) {
        Book book = bookRepository.findBookByIdAndDeletedAtIsNull(id).orElseThrow(()
                -> new ApiException(HttpStatus.NOT_FOUND, "Book not found", "BOOK_NOT_FOUND"));
        book.setDeletedAt(LocalDateTime.now());
        bookRepository.save(book);
    }

    @Transactional(readOnly = true)
    public Page<Book> getBooksByPage(String keyword, Integer authorId,
                                     Integer publisherId, Integer categoryId, Pageable pageable) {
        Specification<Book> specification = Specification.where(BookSpecification.hasKeyword(keyword))
                .and(BookSpecification.hasAuthorId(authorId))
                .and(BookSpecification.hasPublisherId(publisherId))
                .and(BookSpecification.hasCategoryId(categoryId));
        return bookRepository.findAll(specification, pageable);
    }


}
