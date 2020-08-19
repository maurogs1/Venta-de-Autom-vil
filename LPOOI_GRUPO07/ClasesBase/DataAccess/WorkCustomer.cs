using ClasesBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.DataAccess
{
    public class WorkCustomer
    {
        public static DataTable getAllCustomers()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cli_id as 'Id', ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_apellido 'Apellido', ";
            cmd.CommandText += " cli_direccion as 'Direccion', ";
            cmd.CommandText += " cli_telefono as 'Telefono'";
            cmd.CommandText += " FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void addCustomer(Customer customer)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(cli_dni,cli_nombre,cli_apellido,cli_direccion,cli_telefono) values(@dni,@nombre,@apellido,@direccion,@telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", customer.DNI);
            cmd.Parameters.AddWithValue("@nombre", customer.Name);
            cmd.Parameters.AddWithValue("@apellido", customer.LastName);
            cmd.Parameters.AddWithValue("@direccion", customer.Address);
            cmd.Parameters.AddWithValue("@telefono", customer.Phone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void deleteCustomer(string customerId)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE FROM Cliente WHERE cli_id=@id";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(customerId));

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public static void updateCustomer(Customer customer)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET cli_dni=@dni,cli_nombre=@nombre, cli_apellido=@apellido, cli_direccion=@direccion, cli_telefono=@telefono WHERE cli_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@id", customer.Id);
            cmd.Parameters.AddWithValue("@dni", customer.DNI);
            cmd.Parameters.AddWithValue("@nombre", customer.Name);
            cmd.Parameters.AddWithValue("@apellido", customer.LastName);
            cmd.Parameters.AddWithValue("@direccion", customer.Address);
            cmd.Parameters.AddWithValue("@telefono", customer.Phone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable searchCustomer(string pattern)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cli_id as 'Id', ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_apellido 'Apellido', ";
            cmd.CommandText += " cli_direccion as 'Direccion', ";
            cmd.CommandText += " cli_telefono as 'Telefono'";
            cmd.CommandText += " FROM Cliente WHERE (cli_dni LIKE @pattern OR cli_telefono LIKE @pattern)"; 
            cmd.Parameters.AddWithValue("@pattern", pattern);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getAllCustomersOrderLastName()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllCustomersOrderLastNameSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
