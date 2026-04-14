CREATE TABLE users (
                       user_id SERIAL PRIMARY KEY,
                       first_name VARCHAR(50) NOT NULL,
                       last_name VARCHAR(50) NOT NULL,
                       email VARCHAR(100) UNIQUE NOT NULL,
                       phone VARCHAR(20) UNIQUE NOT NULL,
                       password_hash VARCHAR(255) NOT NULL,
                       gender gender_enum DEFAULT 'O',
                       date_of_birth DATE,
                       address VARCHAR(255),
                       role role_enum DEFAULT 'ROLE_MEMBER',
                       status user_status_enum DEFAULT 'ACTIVE',
                       created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                       updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE authors (
                         author_id SERIAL PRIMARY KEY,
                         full_name VARCHAR(100) NOT NULL,
                         biography TEXT,
                         date_of_birth DATE,
                         date_of_death DATE,
                         created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE publishers (
                            publisher_id SERIAL PRIMARY KEY,
                            name VARCHAR(100) UNIQUE NOT NULL,
                            contact_email VARCHAR(100),
                            address VARCHAR(255)
);

CREATE TABLE categories (
                            category_id SERIAL PRIMARY KEY,
                            name VARCHAR(50) UNIQUE NOT NULL,
                            description VARCHAR(255)
);

CREATE TABLE books (
                       book_id SERIAL PRIMARY KEY,
                       isbn VARCHAR(20) UNIQUE NOT NULL,
                       title VARCHAR(255) NOT NULL,
                       publisher_id INT,
                       publication_year SMALLINT,
                       pages SMALLINT,
                       language VARCHAR(30) DEFAULT 'Vietnamese',
                       description TEXT,
                       cover_image_url VARCHAR(255),
                       created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE book_authors (
                              book_id INT NOT NULL,
                              author_id INT NOT NULL,
                              PRIMARY KEY (book_id, author_id)
);

CREATE TABLE book_categories (
                                 book_id INT NOT NULL,
                                 category_id INT NOT NULL,
                                 PRIMARY KEY (book_id, category_id)
);

CREATE TABLE book_copies (
                             copy_id SERIAL PRIMARY KEY,
                             book_id INT NOT NULL,
                             barcode VARCHAR(50) UNIQUE NOT NULL,
                             status copy_status_enum DEFAULT 'AVAILABLE',
                             condition_note VARCHAR(255),
                             created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE loans (
                       loan_id SERIAL PRIMARY KEY,
                       user_id INT NOT NULL,
                       copy_id INT NOT NULL,
                       borrow_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                       due_date DATE NOT NULL,
                       return_date TIMESTAMP,
                       status loan_status_enum DEFAULT 'BORROWED',
                       notes VARCHAR(255)
);

CREATE TABLE fines (
                       fine_id SERIAL PRIMARY KEY,
                       loan_id INT NOT NULL,
                       amount DECIMAL(10,2) NOT NULL,
                       reason VARCHAR(255) NOT NULL,
                       status fine_status_enum DEFAULT 'UNPAID',
                       payment_date TIMESTAMP,
                       created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
