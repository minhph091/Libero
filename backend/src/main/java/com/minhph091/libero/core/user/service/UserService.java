package com.minhph091.libero.core.user.service;

import com.minhph091.libero.common.enums.Role;
import com.minhph091.libero.common.enums.UserStatus;
import com.minhph091.libero.core.user.dto.ChangePasswordRequest;
import com.minhph091.libero.exception.ApiException;
import com.minhph091.libero.core.user.dto.RegistrationRequest;
import com.minhph091.libero.core.user.enity.User;
import com.minhph091.libero.core.user.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

@Service
public class UserService {
    private final UserRepository userRepository;
    private final PasswordEncoder passwordEncoder;

    @Autowired
    public UserService(UserRepository userRepository, PasswordEncoder passwordEncoder) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
    }

    public User findByEmail(String email) {
        return userRepository.findUserByEmail(email);
    }

    @Transactional
    public User registerUser(RegistrationRequest request) {
        if (userRepository.existsByEmail(request.email())) {
            throw new ApiException(HttpStatus.CONFLICT, "Email already exists", "EMAIL_ALREADY_EXISTS");
        }
        if (userRepository.existsByPhone(request.phoneNumber())) {
            throw new ApiException(HttpStatus.CONFLICT, "Phone number already exists", "PHONE_ALREADY_EXISTS");
        }
        User user = RegistrationRequest.toEntity(request);
        user.setRole(Role.ROLE_MEMBER);
        user.setPasswordHash(passwordEncoder.encode(request.password()));
        user.setStatus(UserStatus.ACTIVE);
        userRepository.save(user);
        return user;
    }

    @Transactional
    public void changePassword(Integer userId, ChangePasswordRequest request) {
        User user = userRepository.findById(userId).orElseThrow(()
                -> new ApiException(HttpStatus.NOT_FOUND, "User not found"));
        if (!passwordEncoder.matches(request.currentPassword(), user.getPasswordHash())) {
            throw new ApiException(HttpStatus.BAD_REQUEST, "Current password is incorrect", "INVALID_CURRENT_PASSWORD");
        }
        user.setPasswordHash(passwordEncoder.encode(request.newPassword()));
        userRepository.save(user);
    }
}
