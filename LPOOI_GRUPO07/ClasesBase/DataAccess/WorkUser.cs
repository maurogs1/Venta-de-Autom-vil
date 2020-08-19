using ClasesBase.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.DataAccess
{
    public class WorkUser
    {

        public static DataTable getAllRoles()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM rol";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static int getRolByName(string find)
        {

            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_id From Rol ";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " rol_descripcion LIKE @find ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@find", "%" + find + "%");

            //Ejecuta la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
        
            da.Fill(ds);



            return Convert.ToInt32(ds.Tables[0].Rows[0]["rol_id"].ToString());






        }

        public static DataTable getAllUsers()
        { 
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " usu_id as 'Id', ";
            cmd.CommandText += " usu_apellido_nombre as 'Nombre Completo', ";
            cmd.CommandText += " usu_nombre 'Usuario', ";
            cmd.CommandText += " usu_password as 'Contraseña', ";
            cmd.CommandText += " rol_descripcion as 'Rol'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_id=U.role_id)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            //Ejecuta la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public static void addUser(User user)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Usuario(usu_nombre,usu_password,usu_apellido_nombre,role_id) values(@user,@pass,@apenom,@rol)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.AddWithValue("@user", user.Username);
            command.Parameters.AddWithValue("@pass", user.Password);
            command.Parameters.AddWithValue("@apenom", user.LastName);
            command.Parameters.AddWithValue("@rol", user.RolCode);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void updateUser(User user)
        {
         

            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            
            cmd.CommandText = "UPDATE Usuario SET usu_nombre=@usuario,usu_password=@contrasena, usu_apellido_nombre=@apellidoNombre, role_id=@rol, usu_recordar_usuario=@recordar WHERE usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@usuario", user.Username);
            cmd.Parameters.AddWithValue("@contrasena", user.Password);
            cmd.Parameters.AddWithValue("@apellidoNombre", user.LastName);
            cmd.Parameters.AddWithValue("@rol", user.RolCode);
            cmd.Parameters.AddWithValue("@recordar", user.SaveUser);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void updateUser(User user, bool isUserSaved)
        {


            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = "UPDATE Usuario set usu_recordar_usuario = 0 UPDATE Usuario SET usu_nombre=@usuario,usu_password=@contrasena, usu_apellido_nombre=@apellidoNombre, role_id=@rol, usu_recordar_usuario=@recordar WHERE usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@usuario", user.Username);
            cmd.Parameters.AddWithValue("@contrasena", user.Password);
            cmd.Parameters.AddWithValue("@apellidoNombre", user.LastName);
            cmd.Parameters.AddWithValue("@rol", user.RolCode);
            cmd.Parameters.AddWithValue("@recordar", user.SaveUser);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        public static void deleteUser(string id)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM Usuario WHERE usu_id=@id";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable searchUser(string patron)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT ";
            cmd.CommandText += " usu_id as 'Id', ";
            cmd.CommandText += " usu_apellido_nombre as 'Nombre Completo', ";
            cmd.CommandText += " usu_nombre 'Usuario', ";
            cmd.CommandText += " usu_password as 'Contraseña', ";
            cmd.CommandText += " rol_descripcion as 'Rol'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_id=U.role_id)";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " usu_nombre LIKE @patron ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@patron", "%" + patron + "%");

            //Ejecuta la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        
    }
}
