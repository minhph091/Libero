package com.minhph091.libero.core.user.controller;

import com.minhph091.libero.core.user.dto.ChangePasswordRequest;
import com.minhph091.libero.core.user.dto.UpdateEmailRequest;
import com.minhph091.libero.core.user.dto.UpdateUserRequest;
import com.minhph091.libero.core.user.dto.UserDTO;
import com.minhph091.libero.core.user.entity.User;
import com.minhph091.libero.core.user.mapper.UserMapper;
import com.minhph091.libero.core.user.service.UserService;
import com.minhph091.libero.exception.ApiException;
import com.minhph091.libero.security.CustomUserDetails;
import io.swagger.v3.oas.annotations.security.SecurityRequirement;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.annotation.AuthenticationPrincipal;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/v1/users")
public class UserController {
    private final UserService userService;
    private final UserMapper userMapper;

    @Autowired
    public UserController(UserService userService, UserMapper userMapper) {
        this.userService = userService;
        this.userMapper = userMapper;
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

    @PatchMapping("/me")
    @SecurityRequirement(name = "bearerAuth")
    public ResponseEntity<UserDTO> updateProfile(
            @AuthenticationPrincipal CustomUserDetails userDetails,
            @Valid @RequestBody UpdateUserRequest request
    ) {
        Integer userId = userDetails.getId();
        User user = userService.updateCurrentUser(userId, request);
        UserDTO response = userMapper.userToUserDTO(user);
        return ResponseEntity.status(HttpStatus.OK).body(response);
    }

    @PutMapping("/change-email")
    public ResponseEntity<Void> changeEmail(
            @AuthenticationPrincipal CustomUserDetails userDetails,
            @Valid @RequestBody UpdateEmailRequest request
    ) {
        Integer userId = userDetails.getId();
        userService.changeUserEmail(userId, request.email());
        return ResponseEntity.status(HttpStatus.OK).build();
    }

    @GetMapping("/me")
    public ResponseEntity<UserDTO> getCurrentUser(
            @AuthenticationPrincipal CustomUserDetails userDetails
    ) {
        Integer userId = userDetails.getId();
        User user = userService.getUserById(userId)
                .orElseThrow(() -> new ApiException(HttpStatus.NOT_FOUND, "User not found"));
        return ResponseEntity.status(HttpStatus.OK).body(userMapper.userToUserDTO(user));
    }

    @GetMapping("/{userId}")
    @PreAuthorize("hasAnyRole('ROLE_ADMIN', 'ROLE_LIBRARIAN')")
    public ResponseEntity<UserDTO> getUserById(@PathVariable Integer userId) {
        User user = userService.getUserById(userId)
                .orElseThrow(() -> new ApiException(HttpStatus.NOT_FOUND, "User not found"));
        return ResponseEntity.status(HttpStatus.OK).body(userMapper.userToUserDTO(user));
    }


}
