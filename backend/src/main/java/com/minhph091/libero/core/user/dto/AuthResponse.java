package com.minhph091.libero.core.user.dto;

import lombok.Builder;

@Builder
public record AuthResponse(String token, UserDTO user) {
}
