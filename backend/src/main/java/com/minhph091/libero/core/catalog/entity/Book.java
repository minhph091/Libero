package com.minhph091.libero.core.catalog.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;
import jakarta.persistence.*;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;

import java.time.LocalDateTime;
import java.util.Set;

@Entity
@Table(name = "books")
@Setter
@Getter
@NoArgsConstructor
public class Book {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "book_id")
    private Integer id;
    private String isbn;
    private String title;
    @ManyToOne
    @JoinColumn(name = "publisher_id")
    private Publisher publisher;
    private Short publicationYear;
    private Short pages;
    private String language;
    private String description;
    private String coverImageUrl;

    @JsonIgnore
    @ManyToMany(fetch = FetchType.LAZY, cascade = {
            CascadeType.MERGE, CascadeType.PERSIST
    })
    @JoinTable(
            name = "book_authors",
            joinColumns = @JoinColumn(name = "book_id"),
            inverseJoinColumns = @JoinColumn(name = "author_id")
    )
    private Set<Author> authors;

    @JsonIgnore
    @ManyToMany(fetch = FetchType.LAZY, cascade = {
            CascadeType.MERGE, CascadeType.PERSIST
    })
    @JoinTable(
            name = "book_categories",
            joinColumns = @JoinColumn(name = "book_id"),
            inverseJoinColumns = @JoinColumn(name = "category_id")
    )
    private Set<Category> categories;
    @JsonIgnore
    @OneToMany(mappedBy = "book", fetch = FetchType.LAZY, cascade = {
            CascadeType.MERGE, CascadeType.PERSIST
    })
    private Set<BookCopy> bookCopies;

    @CreationTimestamp
    @Column(updatable = false)
    private LocalDateTime createdAt;
}
