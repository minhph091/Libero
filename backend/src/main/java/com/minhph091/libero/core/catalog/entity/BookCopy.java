package com.minhph091.libero.core.catalog.entity;

import com.minhph091.libero.common.enums.BookStatus;
import jakarta.persistence.*;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;

import java.time.LocalDateTime;

@Entity
@Table(name = "book_copies")
@Getter
@Setter
@NoArgsConstructor

public class BookCopy {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "copy_id")
    private Integer id;
    @ManyToOne
    @JoinColumn(name = "book_id")
    private Book book;
    private String barcode;
    @Enumerated(EnumType.STRING)
    private BookStatus status;
    private String conditionNote;
    @CreationTimestamp
    @Column(updatable = false)
    private LocalDateTime createdAt;
}
