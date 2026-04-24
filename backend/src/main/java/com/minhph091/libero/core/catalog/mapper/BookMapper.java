package com.minhph091.libero.core.catalog.mapper;

import com.minhph091.libero.core.catalog.dto.BookDTO;
import com.minhph091.libero.core.catalog.dto.CreateBookRequest;
import com.minhph091.libero.core.catalog.dto.UpdateBookRequest;
import com.minhph091.libero.core.catalog.entity.Book;
import org.mapstruct.BeanMapping;
import org.mapstruct.Mapper;
import org.mapstruct.MappingTarget;
import org.mapstruct.NullValuePropertyMappingStrategy;

@Mapper(componentModel = "spring")
public interface BookMapper {
    BookDTO entityToDto(Book book);

    Book dtoToEntity(BookDTO bookDTO);

    @BeanMapping(nullValuePropertyMappingStrategy = NullValuePropertyMappingStrategy.IGNORE)
    void updateBookFromUpdateDTO(UpdateBookRequest request, @MappingTarget Book book);

    Book createDTOtoEntity(CreateBookRequest dto);
}
