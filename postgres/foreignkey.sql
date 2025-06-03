DROP TABLE IF EXISTS students;

CREATE TABLE students (
    student_id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    city VARCHAR(100),
    dept_id INT,
    FOREIGN KEY (dept_id) REFERENCES departments(dept_id)
);

INSERT INTO students (name, city, dept_id) VALUES
('Vruti', 'nadiad', 1),  -- IT
('Jiya', 'Mumbai', 2),    -- CSD
('Siya', 'Vadodara', 3),  -- CP
('annu', 'Delhi', 1),
('seju', 'Pune', 2);

SELECT s.*, d.dept_name
FROM students s
LEFT JOIN departments d ON s.dept_id = d.dept_id;




