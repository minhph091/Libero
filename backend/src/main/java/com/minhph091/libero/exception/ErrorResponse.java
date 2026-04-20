package com.minhph091.libero.exception;

import com.fasterxml.jackson.annotation.JsonFormat;
import lombok.Builder;
import lombok.Data;

import java.time.LocalDateTime;
import java.util.List;

@Builder
public record ErrorResponse(
        String errorCode, // Mã lỗi (ví dụ: "VALIDATION_ERROR", "NOT_FOUND", "INTERNAL_SERVER_ERROR")
        String errorMessage, // Thông tin lỗi kiểu tường minh
        int status, // mã http status về lỗi
        @JsonFormat(pattern = "yyyy-MM-dd HH:mm:ss")
        LocalDateTime timestamp,
        List<ValidationError> validationErrors
) {
    @Data
    @Builder
    public static class ValidationError {
        private String field;
        private String message;
    }
}

