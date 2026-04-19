package com.minhph091.libero.core.user.dto;

import com.minhph091.libero.common.enums.Gender;
import com.minhph091.libero.common.enums.Role;
import com.minhph091.libero.common.enums.UserStatus;
import com.minhph091.libero.core.user.enity.User;

import java.time.LocalDate;

public record UserDTO(Integer userId, String firstName, String lastName, String email, String phone, Gender gender,
                      LocalDate dateOfBirth, String address, Role role, UserStatus userStatus) {
    public static UserDTO fromEntity(User user) {
        return new UserDTO(
                user.getId(),
                user.getFirstName(),
                user.getLastName(),
                user.getEmail(),
                user.getPhone(),
                user.getGender(),
                user.getDateOfBirth(),
                user.getAddress(),
                user.getRole(),
                user.getStatus()
        );
    }
}
