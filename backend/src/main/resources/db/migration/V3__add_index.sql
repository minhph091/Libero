CREATE INDEX idx_users_email ON users (email);
CREATE INDEX idx_books_title ON books (title);
CREATE INDEX idx_books_isbn ON books (isbn);
CREATE INDEX idx_book_copies_barcode ON book_copies (barcode);
CREATE INDEX idx_loans_user_id ON loans (user_id);
