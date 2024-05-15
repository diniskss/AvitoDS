
![Screenshot_20240408_141934](https://github.com/diniskss/AvitoDS/assets/106401449/f6da58c1-2756-47a7-bb7d-35ca3c163169)

Скрипт создания БД:
CREATE TABLE clients (
    user_id INT PRIMARY KEY,
    login VARCHAR(50),
    password VARCHAR(50),
    name VARCHAR(100),
    registration_date DATE,
    phone_number VARCHAR(20)
);

CREATE TABLE seller (
    user_id INT PRIMARY KEY,
    rating DECIMAL(3, 1),
    phone_number VARCHAR(20),
    adv_id INT,
    FOREIGN KEY (user_id) REFERENCES clients(user_id)
);

CREATE TABLE advertisement (
    adv_id INT PRIMARY KEY,
    name VARCHAR(255),
    date_of_creation DATE,
    user_id INT,
    type VARCHAR(50),
    price DECIMAL(10, 2),
    description TEXT,
    images TEXT,
    FOREIGN KEY (user_id) REFERENCES seller(user_id)
);

CREATE TABLE favorites (
    user_id INT,
    adv_id INT,
    FOREIGN KEY (user_id) REFERENCES clients(user_id)
);
