package com.minhph091.libero.core.user.mapper;

import com.minhph091.libero.core.user.dto.UpdateUserRequest;
import com.minhph091.libero.core.user.dto.UserDTO;
import com.minhph091.libero.core.user.entity.User;
import org.mapstruct.BeanMapping;
import org.mapstruct.Mapper;
import org.mapstruct.MappingTarget;
import org.mapstruct.NullValuePropertyMappingStrategy;

@Mapper(componentModel = "spring")
public interface UserMapper {
    @BeanMapping(nullValuePropertyMappingStrategy = NullValuePropertyMappingStrategy.IGNORE)
        // Bỏ qua update giá trị null
    void updateUserFromRequest(UpdateUserRequest dto, @MappingTarget User entity);

    UserDTO userToUserDTO(User user);
}
