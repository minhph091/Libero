package com.minhph091.libero.catalog.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;
import jakarta.persistence.*;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.Set;

@Entity
@Table(name = "authors")
@Setter
@Getter
@NoArgsConstructor
public class Author {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "author_id")
    private Integer id;
    private String fullName;
    private String biography;
    private LocalDate dateOfBirth;
    private LocalDate dateOfDeath;
    @JsonIgnore
    @ManyToMany(mappedBy = "authors", cascade = {
            CascadeType.MERGE,
            CascadeType.PERSIST})
    private Set<Book> books;

    @CreationTimestamp
    @Column(updatable = false)
    private LocalDateTime createdAt;

}
