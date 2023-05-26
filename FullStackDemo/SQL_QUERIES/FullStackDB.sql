CREATE DATABASE FullStackDemo;

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(255) NOT NULL
);

INSERT INTO Users (FirstName, LastName, Email)
VALUES ('Test First', 'Test Last', 'test@test.test');