package com.minhph091.libero.core.catalog.dto;

import com.minhph091.libero.core.catalog.entity.Publisher;
import lombok.Builder;

@Builder
public record BookDTO(
        Integer id,
        String isbn,
        String title,
        Publisher publisher,
        Short publicationYear,
        Short pages,
        String language,
        String description,
        String coverImageUrl
) {
}
