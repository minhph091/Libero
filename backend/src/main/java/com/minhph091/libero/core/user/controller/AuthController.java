package com.minhph091.libero.core.user.controller;

import com.minhph091.libero.core.user.dto.RegistrationRequest;
import com.minhph091.libero.security.CustomUserDetails;
import com.minhph091.libero.security.JwtTokenProvider;
import com.minhph091.libero.core.user.dto.AuthResponse;
import com.minhph091.libero.core.user.dto.LoginRequest;
import com.minhph091.libero.core.user.dto.UserDTO;
import com.minhph091.libero.core.user.entity.User;
import com.minhph091.libero.core.user.service.UserService;
import jakarta.validation.Valid;
import org.jspecify.annotations.NonNull;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("v1/auth")
public class AuthController {
    private final AuthenticationManager authenticationManager;
    private final JwtTokenProvider jwtTokenProvider;
    private final UserService userService;

    @Autowired
    public AuthController(AuthenticationManager authenticationManager,
                          JwtTokenProvider jwtTokenProvider,
                          UserService userService) {
        this.authenticationManager = authenticationManager;
        this.jwtTokenProvider = jwtTokenProvider;
        this.userService = userService;
    }

    @PostMapping("/login")
    public ResponseEntity<@NonNull AuthResponse> login(@Valid @RequestBody LoginRequest loginRequest) {
        Authentication authentication = authenticationManager.authenticate(
                new UsernamePasswordAuthenticationToken(
                        loginRequest.email(),
                        loginRequest.password())
        );
        CustomUserDetails userDetails = (CustomUserDetails) authentication.getPrincipal();
        String token = jwtTokenProvider.generateToken(userDetails);
        User user = userService.findByEmail(userDetails.getUsername());
        AuthResponse response = AuthResponse.builder()
                .token(token)
                .user(UserDTO.fromEntity(user))
                .build();
        return ResponseEntity.status(HttpStatus.OK).body(response);
    }

    @PostMapping("/register")
    public ResponseEntity<@NonNull UserDTO> register(@Valid @RequestBody RegistrationRequest registrationRequest) {
        User user = userService.registerUser(registrationRequest);
        UserDTO response = UserDTO.fromEntity(user);
        return ResponseEntity.status(HttpStatus.CREATED).body(response);
    }

}
