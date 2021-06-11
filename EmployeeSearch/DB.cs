using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeSearch
{
    internal class DB
    {
        const string CONNECTION_STRING = @"Data Source=DESKTOP-9MECFH5\SQLEXPRESS;Integrated Security=True";
        const string INSERT_COMMAND = "INSERT INTO Employee (id, name, position, hourlypay)" + "VALUES (@ID, @NAME, @POSITION, @HOURLY_PAY)";
        const string UPDATE_COMMAND = "UPDATE Employee " + "SET id = @ID, name = @NAME, position = @POSITION, hourlypay = @HOURLY_PAY " + "WHERE Id = @ID";
        const string DELTET_COMMAND = "DELETE FROM Employee WHERE id = @ID";
        const string SELECT_COMMAND = "SELECT id, name, position, hourlypay FROM Employee";
        const string DATABASE_STATUS = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Personal') BEGIN CREATE DATABASE Personal END;";
        const string USE_DATABASE_COMAND = "Use Personal;";
        const string TABLE_STATUS = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employee' and xtype='U') BEGIN CREATE TABLE Employee( [id] [numeric](18, 0) NOT NULL PRIMARY KEY, [name] [varchar](50) NOT NULL, [position] [varchar](50) NOT NULL, [hourlypay] [numeric](18, 0) NOT NULL ) END";

        private readonly SqlConnection conn;
        private static DB db;
        public static DB Instance { get { db ??= new DB(); return db; } }

        private DB()
        {
            conn = new SqlConnection(CONNECTION_STRING);
            conn.Open();
        }

        public bool Insert(Employee employee)
        {
            using SqlCommand cmd = new SqlCommand(INSERT_COMMAND, conn);
            cmd.Parameters.AddWithValue("@ID", employee.Id);
            cmd.Parameters.AddWithValue("@NAME", employee.Name);
            cmd.Parameters.AddWithValue("@POSITION", employee.Position);
            cmd.Parameters.AddWithValue("@HOURLY_PAY", employee.HourlyPay);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(Employee employee)
        {
            using SqlCommand cmd = new SqlCommand(UPDATE_COMMAND, conn);
            cmd.Parameters.AddWithValue("@ID", employee.Id);
            cmd.Parameters.AddWithValue("@POSITION", employee.Position);
            cmd.Parameters.AddWithValue("@NAME", employee.Name);
            cmd.Parameters.AddWithValue("@HOURLY_PAY", employee.HourlyPay);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(Employee employee)
        {
            using SqlCommand cmd = new SqlCommand(DELTET_COMMAND, conn);
            cmd.Parameters.AddWithValue("@ID", employee.Id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<Employee> Get()
        {
            List<Employee> employees = new List<Employee>();

            using SqlCommand cmd = new SqlCommand(SELECT_COMMAND, conn);
            using SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                employees.Add(new Employee
                {
                    Id = (float)dr.GetDecimal(dr.GetOrdinal("id")),
                    Name = dr.GetString(dr.GetOrdinal("name")),
                    Position = dr.GetString(dr.GetOrdinal("position")),
                    HourlyPay = dr.GetDecimal(dr.GetOrdinal("hourlyPay")),
                    IsNew = false
                });
            dr.Close();

            return employees;
        }

        public void checkStatus()
        {
            SqlCommand cmd = new SqlCommand(DATABASE_STATUS, conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(USE_DATABASE_COMAND, conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(TABLE_STATUS, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
