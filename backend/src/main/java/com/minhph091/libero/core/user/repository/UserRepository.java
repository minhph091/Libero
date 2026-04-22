package com.minhph091.libero.core.user.repository;

import com.minhph091.libero.core.user.entity.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;

public interface UserRepository extends JpaRepository<User, Integer>, JpaSpecificationExecutor<User> {
    User findUserByEmail(String email);

    boolean existsByPhone(String phone);
    boolean existsByEmail(String email);
}
