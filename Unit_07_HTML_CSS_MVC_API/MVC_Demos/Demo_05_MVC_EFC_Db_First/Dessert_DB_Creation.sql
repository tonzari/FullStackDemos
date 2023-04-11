CREATE DATABASE DessertDb;

USE DessertDb;

CREATE TABLE Desserts (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    Type NVARCHAR(50) NOT NULL,
    Price DECIMAL(5, 2) NOT NULL,
    Available BIT NOT NULL
);

INSERT INTO Desserts (Name, Type, Price, Available)
VALUES ('Chocolate Cake', 'Cake', 10.50, 1),
       ('Strawberry Cheesecake', 'Cheesecake', 12.00, 1),
       ('Lemon Tart', 'Tart', 8.25, 1),
       ('Apple Pie', 'Pie', 9.75, 0),
       ('Vanilla Ice Cream', 'Ice Cream', 4.50, 1);

       INSERT INTO Desserts (Name, Type, Price, Available)
VALUES ('Chocolate Chip Cookie', 'Cookie', 1.50, 1),
       ('Blueberry Muffin', 'Muffin', 2.75, 1),
       ('Tiramisu', 'Cake', 11.00, 1),
       ('Pecan Pie', 'Pie', 10.00, 0),
       ('Carrot Cake', 'Cake', 10.50, 1),
       ('Raspberry Sorbet', 'Sorbet', 4.00, 1),
       ('Creme Brulee', 'Custard', 6.50, 1),
       ('Brownie', 'Bar', 2.00, 1),
       ('Peanut Butter Cookie', 'Cookie', 1.75, 1),
       ('Red Velvet Cake', 'Cake', 11.50, 0),
       ('Key Lime Pie', 'Pie', 9.50, 1),
       ('Banana Bread', 'Bread', 7.00, 1),
       ('Black Forest Cake', 'Cake', 12.00, 1),
       ('Mango Ice Cream', 'Ice Cream', 4.75, 1),
       ('Chocolate Eclair', 'Pastry', 3.50, 1),
       ('Oatmeal Raisin Cookie', 'Cookie', 1.50, 1),
       ('Pumpkin Pie', 'Pie', 9.00, 0),
       ('Cupcake', 'Cupcake', 2.50, 1),
       ('Bread Pudding', 'Pudding', 6.00, 1),
       ('Gelato', 'Ice Cream', 4.25, 1);
