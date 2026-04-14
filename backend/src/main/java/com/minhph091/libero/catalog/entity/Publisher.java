package com.minhph091.libero.catalog.entity;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Set;

@Entity
@Table(name = "publishers")
@Setter
@Getter
@NoArgsConstructor
public class Publisher {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "publisher_id")
    private Integer id;
    private String name;
    private String contactEmail;
    private String address;
    @OneToMany(mappedBy = "publisher", fetch = FetchType.LAZY, cascade = {
            CascadeType.MERGE, CascadeType.PERSIST
    })
    private Set<Book> books;
}
