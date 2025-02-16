using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebAppWithMVC.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ActsJan25; Integrated Security = True;";


            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from employees";

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpNo = reader.GetInt32("EmpNo");
                    emp.Name = reader.GetString("Name");
                    emp.Basic = reader.GetDecimal("Basic");
                    emp.DeptNo = reader.GetInt32("DeptNo");

                    employees.Add(emp);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return employees;
        }

        public static  Employee GetEmployee(int EmpNo)
        {
            Employee emp = null;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ActsJan25; Integrated Security = True;";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employees where EmpNo=@EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                SqlDataReader reader = cmd.ExecuteReader();
                if ((reader.HasRows))
                {
                    if (reader.Read())
                    {
                        emp = new Employee();
                        emp.EmpNo = reader.GetInt32("EmpNo");
                        emp.Name = reader.GetString("Name");
                        emp.Basic = reader.GetDecimal("Basic");
                        emp.DeptNo = reader.GetInt32("DeptNo");

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return emp;

        }

        public static void Insert(Employee emp)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ActsJan25; Integrated Security = True;";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employees values(@EmpNo, @Name, @Basic, @DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public static void Update(Employee emp)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ActsJan25; Integrated Security = True;";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employees set Name=@Name, Basic=@Basic, DeptNo=@DeptNo where EmpNo= @EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Delete(int EmpNo)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ActsJan25; Integrated Security = True;";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Employees where EmpNo=@EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
               

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
