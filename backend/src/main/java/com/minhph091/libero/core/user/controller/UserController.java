package com.minhph091.libero.core.user.controller;

import com.minhph091.libero.core.user.dto.ChangePasswordRequest;
import com.minhph091.libero.core.user.dto.UserDTO;
import com.minhph091.libero.core.user.enity.User;
import com.minhph091.libero.core.user.service.UserService;
import com.minhph091.libero.security.CustomUserDetails;
import io.swagger.v3.oas.annotations.security.SecurityRequirement;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.annotation.AuthenticationPrincipal;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/v1/users")
public class UserController {
    private final UserService userService;

    @Autowired
    public UserController(UserService userService) {
        this.userService = userService;
    }

    @PostMapping("/change-password")
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<Void> changePassword(
            @AuthenticationPrincipal CustomUserDetails userDetails,
            @Valid @RequestBody ChangePasswordRequest request) {
        Integer userId = userDetails.getId();
        userService.changePassword(userId, request);
        return ResponseEntity.status(HttpStatus.OK).build();
    }

}
