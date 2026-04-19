package com.minhph091.libero.exception;

import lombok.Getter;
import org.springframework.http.HttpStatus;

// Exception chung cho các lỗi API
@Getter
public class ApiException extends RuntimeException {
    private final HttpStatus status;
    private final String message;
    private final String errorCode;

    public ApiException(HttpStatus status, String message, String errorCode) {
        super(message);
        this.status = status;
        this.message = message;
        this.errorCode = errorCode;
    }

    public ApiException(HttpStatus status, String message) {
        this(status, message, status.name());
    }

}
