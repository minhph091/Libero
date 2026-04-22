package com.minhph091.libero.core.user.dto;

import com.minhph091.libero.common.enums.Gender;
import jakarta.validation.constraints.Pattern;
import jakarta.validation.constraints.Size;
import lombok.Builder;

import java.time.LocalDate;

@Builder
public record UpdateUserRequest(
        @Size(min = 3, max = 50, message = "First name must be between 3 and 50 characters")
        String firstName,
        @Size(min = 3, max = 50, message = "Last name must be between 3 and 50 characters")
        String lastName,
        @Pattern(regexp = "^\\+?[0-9]{10,15}$", message = "Invalid phone number format")
        String phone,
        Gender gender,
        LocalDate dateOfBirth,
        String address
) {
}
