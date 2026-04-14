package com.minhph091.libero.user.enity;

import com.minhph091.libero.common.enums.Gender;
import com.minhph091.libero.common.enums.Role;
import com.minhph091.libero.common.enums.UserStatus;
import jakarta.persistence.*;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.annotations.UpdateTimestamp;

import java.time.LocalDate;
import java.time.LocalDateTime;

@Entity
@Table(name = "users")
@Setter
@Getter
@NoArgsConstructor
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "user_id")
    private Integer id;
    private String firstName;
    private String lastName;
    private String email;
    private String phone;
    private String passwordHash;
    @Enumerated(EnumType.STRING)
    private Gender gender;
    private LocalDate dateOfBirth;
    private String address;
    @Enumerated(EnumType.STRING)
    private Role role;
    @Enumerated(EnumType.STRING)
    private UserStatus status;
    @CreationTimestamp
    @Column(updatable = false)
    private LocalDateTime createdAt;
    @UpdateTimestamp
    private LocalDateTime updatedAt;

}
