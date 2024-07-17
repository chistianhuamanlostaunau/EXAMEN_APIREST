

CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Document_Number VARCHAR(8),
    Salary DECIMAL(18, 2),
    Age INT,
    Profile VARCHAR(50),
    Admission_Date DATE
);

INSERT INTO Employees (Name, Document_Number, Salary, Age, Profile, Admission_Date)
VALUES 
('Christian Huaman', '42717846', 4500, 30, 'Programador Backend', '2020-01-15'),
('Pilar Lostaunau', '25487584', 4000, 28, 'Programador Frontend', '2020-02-20'),
('Carlos Lostaunau', '54876235', 3000, 25, 'Analista de Calidad', '2020-03-12'),
('Elva Ortega', '65874582', 5000, 29, 'Administrador de Base de Datos', '2020-04-02'),
('Enzo Perez', '64875843', 4000, 28, 'Analista Funcional', '2020-05-21'),
-- 5 del 2020
('Jose Espinoza', '34567890', 9000, 35, 'Jefe TI', '2021-03-22'),
('Regina Carrillo', '62578485', 6000, 33, 'Lider Tecnico', '2021-03-10'),
('Lucha Levano', '22548756', 6000, 31, 'Lider Tecnico', '2021-06-11'),
('Elvira Arbulu', '62548758', 5000, 30, 'Jefe de Calidad', '2021-07-07'),
('Enrique Ortega', '65475315', 6000, 34, 'Lider Tecnico', '2021-08-13'),
-- 5 del 2021
('Nancy Hernades', '45678901', 48000, 26, 'Digitador', '2022-04-12'),
('Pedro Paredes', '24587546', 48000, 24, 'Digitador', '2022-05-09'),
('Julio Menendez', '65485321', 48000, 23, 'Digitador', '2022-10-12'),
('Albaro Paes', '98564875', 48000, 26, 'Digitador', '2022-08-21'),
('Andrea Estrada', '89653458', 48000, 22, 'Digitador', '2022-07-15'),
('Lucia Nano', '44527866', 48000, 21, 'Digitador', '2022-04-19'),
('Paty Luna', '66587912', 48000, 29, 'Digitador', '2022-11-11'),
('Elsa Danez', '99445876', 48000, 24, 'Digitador', '2022-04-10'),
('Alejandra Meza', '32664225', 48000, 21, 'Digitador', '2022-12-12'),
('David Marley', '15429876', 48000, 22, 'Digitador', '2022-01-02');
-- 10 del 2022
