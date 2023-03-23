
-- This is a single line comment!

/*

	This is a multi-line comment!

*/

-- All versions of SQL allow you to
-- Create
-- Read
-- Update
-- Delete

--CREATE TABLE Users (
--	id int NOT NULL IDENTITY PRIMARY KEY,
--	FirstName NVARCHAR(100),
--	LastName NVARCHAR(100),
--	BirthDate DATETIME2,
--	EmailAddress NVARCHAR(50),
--	PhoneNumber NVARCHAR(25)
--);

--CREATE TABLE Comments (
--	id int NOT NULL IDENTITY PRIMARY KEY,
--	Comment NVARCHAR(1000) NOT NULL,
--	DateCreated DATETIME2 NOT NULL,
--	LastUpdated DATETIME2 NOT NULL,
--	UserId int FOREIGN KEY REFERENCES Users(id)
--);


--INSERT INTO Users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber)
--VALUES ('Antonio','Manzari','2018-06-23 07:30:20','antoniomanzari@gmail.com','1-313-111-1111');

--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('John', 'Smith', '1990-05-01', 'john.smith@example.com', '(123) 456-7890');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Jane', 'Doe', '1985-02-14', 'jane.doe@example.com', '(987) 654-3210');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Michael', 'Johnson', '1995-11-30', 'michael.johnson@example.com', '(555) 123-4567');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Samantha', 'Williams', '1988-08-22', 'samantha.williams@example.com', '(999) 888-7777');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('David', 'Brawn', '1977-04-12', 'david.brown@example.com', '(555) 555-5555');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Andrea', 'García', '1989-07-26', 'andrea.garcia@example.com', '(123) 456-7890');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Matteo', 'Rossi', '1984-10-02', 'matteo.rossi@example.com', '(987) 654-3210');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Yusuf', 'Öztürk', '1991-12-25', 'yusuf.ozturk@example.com', '(999) 888-7777');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Maria', 'González', '1980-09-18', 'maria.gonzalez@example.com', '(555) 555-5555');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Anna', 'Li', '1993-06-08', 'anna.li@example.com', '(123) 456-7890');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Luis', 'Gómez', '1987-04-20', 'luis.gomez@example.com', '(987) 654-3210');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Jasmine', 'Kim', '1992-01-01', 'jasmine.kim@example.com', '(555) 123-4567');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Amir', 'Hassan', '1986-08-12', 'amir.hassan@example.com', '(999) 888-7777');
--INSERT INTO users (FirstName, LastName, BirthDate, EmailAddress, PhoneNumber) VALUES ('Sofia', 'Pereira', '1979-05-30', 'sofia.pereira@example.com', '(555) 555-5555');

--INSERT INTO Comments (Comment, DateCreated, LastUpdated, UserId)
--VALUES ('Dogs are so loyal and always happy to see you!','2018-06-23 07:30:20','2018-06-23 07:30:20', 7);
--INSERT INTO comments (Comment, DateCreated, LastUpdated, UserId)
--VALUES ('Dogs are so loyal and always happy to see you!', '2022-01-01', '2022-03-16', 7),
--       ('Cats are such independent creatures, and they make great companions.', '2022-01-02', '2022-03-16', 7),
--       ('Horses are so majestic and powerful, and riding them can be an incredible experience.', '2022-01-03', '2022-03-16', 7),
--       ('Rabbits are so cute and cuddly, and they make great pets for kids.', '2022-01-04', '2022-03-16', 4),
--       ('Parrots are incredibly intelligent and can be great at mimicking human speech.', '2022-01-05', '2022-03-16', 5),
--       ('Turtles are fascinating creatures and can live for many years.', '2022-01-06', '2022-03-16', 1),
--       ('Hamsters are so adorable and can be lots of fun to watch as they run on their wheels.', '2022-01-07', '2022-03-16', 1),
--       ('Goldfish are such beautiful and calming creatures, and they can be great pets for people who do not have a lot of space.', '2022-01-08', '2022-03-16', 3),
--       ('Snakes may not be for everyone, but they are fascinating creatures and can make great pets for people who are interested in them.', '2022-01-09', '2022-03-16', 4),
--       ('Guinea pigs are social animals and can make great pets for families with kids.', '2022-01-10', '2022-03-16', 8),
--       ('Pandas are so funny', '2022-01-11', '2022-03-17', 8);




-- Select ALL columns and ALL users
SELECT * FROM Users;

-- Select a particular column, like the email address
SELECT EmailAddress From Users;

-- Select only the top 5 email addresses from the user table, also include the Id
SELECT TOP (5) id, EmailAddress FROM Users;

-- Get all users that have the first name John
SELECT * FROM Users WHERE FirstName = 'Antonio';

-- Get all users that have a first name that start with the letter A
SELECT * FROM Users WHERE FirstName LIKE 'a%';


-- Joins!!!

-- Get all the comments from a particular user (not a join)
SELECT * FROM Comments WHERE UserId = 7;

-- Get the user's first name and any comments they've made
-- The first name exists on the User table, and the comments are in the comment table
-- We need to access BOTH tables to get all the data that we are after.

-- Note this is an INNER JOIN which only displays results if there is a matching user id
SELECT Users.FirstName, Comments.Comment
FROM Comments
INNER JOIN Users ON Comments.UserId = Users.id;

-- Note this is a LEFT JOIN which is returning EVERY 
--   row from the User table whether it finds a matching user id on the comment or not
SELECT Users.FirstName, Comments.Comment
FROM Users
LEFT JOIN Comments ON Comments.UserId = Users.id;