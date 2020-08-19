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
    public class WorkTypeOfVehicle
    {
        

        public static DataTable getAllTypesOfVehcles()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT tv_id as 'Id', tv_descripcion as 'Descripcion' FROM TipoVehiculo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            //Ejecuta la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void addTypeOfVehicle(TypeOfVehicle typeOfVehicle)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO TipoVehiculo(tv_descripcion) values(@descripcion)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.AddWithValue("@descripcion", typeOfVehicle.Description);
       
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static void updateTypeOfVehicle(TypeOfVehicle typeOfVehicle)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE TipoVehiculo SET tv_descripcion=@descripcion WHERE tv_Id=@id";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", typeOfVehicle.Id);
            cmd.Parameters.AddWithValue("@descripcion", typeOfVehicle.Description);
           

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteTypeOfVehicle(string id)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM TipoVehiculo WHERE tv_Id=@id";

            cmd.CommandType = CommandType.Text;
            
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
