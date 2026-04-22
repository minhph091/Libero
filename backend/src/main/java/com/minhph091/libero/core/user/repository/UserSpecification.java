package com.minhph091.libero.core.user.repository;

import com.minhph091.libero.common.enums.Role;
import com.minhph091.libero.common.enums.UserStatus;
import com.minhph091.libero.core.user.entity.User;
import org.springframework.data.jpa.domain.Specification;

public class UserSpecification {
    public static Specification<User> hasKeyword(String keyword) {
        return (root, query, criteriaBuilder) -> {
            if (keyword == null || keyword.isBlank()) {
                return null;
            }
            String likePattern = "%" + keyword.toLowerCase() + "%";
            return criteriaBuilder.or(
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("firstName")), likePattern),
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("lastName")), likePattern),
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("email")), likePattern),
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("phone")), likePattern)
            );
        };
    }

    public static Specification<User> hasRole(Role role) {
        return (root, query, criteriaBuilder) -> {
            if (role == null) {
                return null;
            }
            return criteriaBuilder.equal(root.get("role"), role);
        };
    }

    public static Specification<User> hasStatus(UserStatus status) {
        return (root, query, criteriaBuilder) -> {
            if (status == null) {
                return null;
            }
            return criteriaBuilder.equal(root.get("status"), status);
        };
    }
}
