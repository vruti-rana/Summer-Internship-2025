using System.Collections.Generic;
using Npgsql;
using userportal.Models;

namespace userportal.Data
{
    public class Employeedata
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=user";

        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();

            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM employees";
            using var cmd = new NpgsqlCommand(query, con);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    Id = (int)reader["id"],
                    Name = reader["name"].ToString(),
                    Email = reader["email"].ToString(),
                    Department = reader["department"].ToString()
                });
            }
            return employees;
        }

        public void AddEmployee(Employee emp)
        {
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO employees (name, email, department) VALUES (@name, @email, @dept)";
            using var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("name", emp.Name);
            cmd.Parameters.AddWithValue("email", emp.Email);
            cmd.Parameters.AddWithValue("dept", emp.Department);
            cmd.ExecuteNonQuery();
        }

        public Employee GetEmployeeById(int id)
        {
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM employees WHERE id = @id";
            using var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Employee
                {
                    Id = (int)reader["id"],
                    Name = reader["name"].ToString(),
                    Email = reader["email"].ToString(),
                    Department = reader["department"].ToString()
                };
            }
            return null;
        }

        public void UpdateEmployee(Employee emp)
        {
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            string query = "UPDATE employees SET name = @name, email = @email, department = @dept WHERE id = @id";
            using var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", emp.Id);
            cmd.Parameters.AddWithValue("name", emp.Name);
            cmd.Parameters.AddWithValue("email", emp.Email);
            cmd.Parameters.AddWithValue("dept", emp.Department);
            cmd.ExecuteNonQuery();
        }

        public void DeleteEmployee(int id)
        {
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            string query = "DELETE FROM employees WHERE id = @id";
            using var cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
