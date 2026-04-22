package com.minhph091.libero.core.user.service;

import com.minhph091.libero.common.enums.Role;
import com.minhph091.libero.common.enums.UserStatus;
import com.minhph091.libero.core.user.dto.ChangePasswordRequest;
import com.minhph091.libero.core.user.dto.UpdateUserRequest;
import com.minhph091.libero.core.user.mapper.UserMapper;
import com.minhph091.libero.exception.ApiException;
import com.minhph091.libero.core.user.dto.RegistrationRequest;
import com.minhph091.libero.core.user.entity.User;
import com.minhph091.libero.core.user.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.Optional;

@Service
public class UserService {
    private final UserRepository userRepository;
    private final PasswordEncoder passwordEncoder;
    private final UserMapper userMapper;

    @Autowired
    public UserService(UserRepository userRepository, PasswordEncoder passwordEncoder, UserMapper userMapper) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
        this.userMapper = userMapper;
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

    @Transactional
    public User updateCurrentUser(Integer userId, UpdateUserRequest request) {
        User user = userRepository.findById(userId).orElseThrow(()
                -> new ApiException(HttpStatus.NOT_FOUND, "User not found"));
        if (request.phone() != null && !request.phone().equals(user.getPhone())) {
            if (userRepository.existsByPhone(request.phone())) {
                throw new ApiException(HttpStatus.CONFLICT, "Phone number already exists", "PHONE_ALREADY_EXISTS");
            }
        }
        userMapper.updateUserFromRequest(request, user);
        userRepository.save(user);
        return user;
    }

    @Transactional
    public void changeUserEmail(Integer userId, String email) {
        User user = userRepository.findById(userId).orElseThrow(()
                -> new ApiException(HttpStatus.NOT_FOUND, "User not found"));
        if (userRepository.existsByEmail(email)) {
            throw new ApiException(HttpStatus.CONFLICT, "Email already exists", "EMAIL_ALREADY_EXISTS");
        }
        user.setEmail(email);
        userRepository.save(user);
    }

    @Transactional(readOnly = true)
    public Optional<User> getUserById(Integer userId) {
        return userRepository.findById(userId);
    }
}
