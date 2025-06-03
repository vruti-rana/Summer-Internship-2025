CREATE TABLE students1 (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    branch VARCHAR(50),
    city VARCHAR(50)
);

INSERT INTO students1 (name, branch, city) VALUES
('Vruti', 'IT', 'gujarat'),
('jiya', 'CSD', 'mumbai'),
('siya', 'CP', 'vadodara');

SELECT * FROM students1;

INSERT INTO students1 (name, branch, city) VALUES
('Neha', 'CP', 'ahmedabad'),
('Priya', 'IT', 'surat'),
('Seju', 'CSD', 'nagpur');

SELECT * FROM students;

SELECT * FROM students WHERE branch = 'IT';



CREATE TABLE departments (
    dept_id SERIAL PRIMARY KEY,
    dept_name VARCHAR(50) NOT NULL
);

INSERT INTO departments (dept_name) VALUES
('IT'),
('CSD'),
('CP');

SELECT * FROM departments;

SELECT * FROM students1 ORDER BY name ASC;

SELECT * FROM students1 WHERE id>=2 AND id<=5;








