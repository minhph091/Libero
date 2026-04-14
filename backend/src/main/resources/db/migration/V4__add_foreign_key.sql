ALTER TABLE books ADD FOREIGN KEY (publisher_id) REFERENCES publishers (publisher_id) ON DELETE SET NULL;
ALTER TABLE book_authors ADD FOREIGN KEY (book_id) REFERENCES books (book_id) ON DELETE CASCADE;
ALTER TABLE book_authors ADD FOREIGN KEY (author_id) REFERENCES authors (author_id) ON DELETE CASCADE;
ALTER TABLE book_categories ADD FOREIGN KEY (book_id) REFERENCES books (book_id) ON DELETE CASCADE;
ALTER TABLE book_categories ADD FOREIGN KEY (category_id) REFERENCES categories (category_id) ON DELETE CASCADE;
ALTER TABLE book_copies ADD FOREIGN KEY (book_id) REFERENCES books (book_id) ON DELETE CASCADE;
ALTER TABLE loans ADD FOREIGN KEY (user_id) REFERENCES users (user_id) ON DELETE RESTRICT;
ALTER TABLE loans ADD FOREIGN KEY (copy_id) REFERENCES book_copies (copy_id) ON DELETE RESTRICT;
ALTER TABLE fines ADD FOREIGN KEY (loan_id) REFERENCES loans (loan_id) ON DELETE CASCADE;