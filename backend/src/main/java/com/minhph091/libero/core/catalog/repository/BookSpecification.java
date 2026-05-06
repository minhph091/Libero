package com.minhph091.libero.core.catalog.repository;

import com.minhph091.libero.core.catalog.entity.Author;
import com.minhph091.libero.core.catalog.entity.Book;
import com.minhph091.libero.core.catalog.entity.Category;
import com.minhph091.libero.core.catalog.entity.Publisher;
import org.springframework.data.jpa.domain.Specification;

public class BookSpecification {
    public static Specification<Book> hasKeyword(String keyword) {
        return (root, query, criteriaBuilder) -> {
            if (keyword == null || keyword.isBlank()) {
                return null;
            }
            String likePattern = "%" + keyword.toLowerCase() + "%";
            return criteriaBuilder.or(
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("isbn")), likePattern),
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("title")), likePattern),
                    criteriaBuilder.like(criteriaBuilder.lower(root.get("description")), likePattern)
            );
        };
    }

    public static Specification<Book> hasAuthorId(Integer authorId) {
        return (root, query, criteriaBuilder) -> {
            if (authorId == null) {
                return null;
            }
            return criteriaBuilder.isMember(authorId, root.get("authors"));
        };
    }

    public static Specification<Book> hasPublisherId(Integer publisherId) {
        return (root, query, criteriaBuilder) -> {
            if (publisherId == null) {
                return null;
            }
            return criteriaBuilder.equal(root.get("publishers"), publisherId);
        };
    }

    public static Specification<Book> hasCategoryId(Integer categoryId) {
        return (root, query, criteriaBuilder) -> {
            if (categoryId == null) {
                return null;
            }
            return criteriaBuilder.isMember(categoryId, root.get("categories"));
        };
    }

}
