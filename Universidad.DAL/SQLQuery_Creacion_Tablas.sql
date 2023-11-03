CREATE TABLE Students(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(255),
	LasName NVARCHAR(255),
	Addres NVARCHAR(255),
	CellPhone INT,
	Email NVARCHAR(255),
	Descripcion NVARCHAR(255),
	CoursesId INT FOREIGN KEY REFERENCES Courses(Id),
	FechaCreacion DATETIME DEFAULT GETDATE(),
	FechaModificacion DATETIME NULL
);

CREATE TABLE Qualifications(
	Id INT PRIMARY KEY IDENTITY,
	Nota VARCHAR(255)
);

CREATE TABLE Courses(
	Id INT PRIMARY KEY IDENTITY,
	Names VARCHAR(255),
	QualificationsId INT FOREIGN KEY REFERENCES Qualifications(Id)
);

CREATE TABLE CoursStudent(
	Id INT PRIMARY KEY IDENTITY,
	StudentId INT FOREIGN KEY REFERENCES Students(Id),
	CourseId INT FOREIGN KEY REFERENCES Courses(Id),
	FechaCreacion DATETIME DEFAULT GETDATE(),
	FechaModificacion DATETIME NULL
);



INSERT INTO Students(FirstName, LasName, Addres,CellPhone, Email, Descripcion, CoursesId) 
VALUES('Yiver','Ropero','cra 5 #8a-58',632145,'correo@correo.com','Registro 1', 3);

INSERT INTO Courses(Names) 
VALUES('Algebra'),('Fisica'),('Calculo'),('Quimica'),
('Programacion'),('Electromagnetismo'),('Deporte');


SELECT * FROM Students;