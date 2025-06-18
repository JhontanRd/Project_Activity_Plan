USE ComplementaryActivityDB;

CREATE TABLE Courses(
	course_ID INT IDENTITY(400, 1) NOT NULL,
	course_name VARCHAR (50) NOT NULL,
	PRIMARY KEY (course_ID)
)

CREATE TABLE Students(
	student_ID INT IDENTITY(100, 1) NOT NULL,
	student_RA VARCHAR (8) UNIQUE NOT NULL,
	student_name VARCHAR (40) NOT NULL,
	last_name VARCHAR (40) NOT NULL,
	campus VARCHAR (20) NOT NULL,
	fk_course_ID INT NOT NULL,
	PRIMARY KEY (student_ID),
	FOREIGN KEY (fk_course_ID) REFERENCES Courses (course_ID)
)

CREATE TABLE ActivityTypes(
	activity_type_ID INT IDENTITY(600, 1) NOT NULL,
	activity_name VARCHAR (50) NOT NULL,
	PRIMARY KEY (activity_type_ID)
)

CREATE TABLE Activities(
	activity_ID INT IDENTITY(800, 1) NOT NULL,
	fk_activity_type INT NOT NULL,
	fK_student_ID INT NOT NULL,
	report_ID VARCHAR (8) UNIQUE NOT NULL,
	activity_name VARCHAR (40) NOT NULL,
	activity_date DATE NOT NULL,
	activity_hours TIME(0) NOT NULL,
	PRIMARY KEY (activity_ID),
	FOREIGN KEY (fk_activity_type) REFERENCES ActivityTypes (activity_type_ID),
	FOREIGN KEY (fK_student_ID) REFERENCES Students (student_ID)
)
