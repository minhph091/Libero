package com.minhph091.libero.core.catalog.dto;

public record UpdateBookRequest(
        String isbn,
        String title,
        Integer publisherId,
        Short publicationYear,
        Short pages,
        String language,
        String description,
        String coverImageUrl
) {
}
