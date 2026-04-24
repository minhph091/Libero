package com.minhph091.libero.core.catalog.dto;

import jakarta.validation.constraints.NotBlank;

public record CreateBookRequest(
        @NotBlank(message = "ISBN is required")
        String isbn,
        @NotBlank(message = "Title is required")
        String title,
        Integer publisherId,
        @NotBlank(message = "Publication year is required")
        Short publicationYear,
        @NotBlank(message = "Pages is required")
        Short pages,
        String language,
        String description,
        String coverImageUrl) {
}
