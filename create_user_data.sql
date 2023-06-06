CREATE TABLE user_data (
    id INT PRIMARY KEY,
    userName VARCHAR(30) NOT NULL,
    passwordHash BINARY(64) NOT NULL,
    firstName VARCHAR(30),
    lastName VARCHAR(30),
    createdAt TIMESTAMP NOT NULL,
    modifiedAt TIMESTAMP NOT NULL
);
