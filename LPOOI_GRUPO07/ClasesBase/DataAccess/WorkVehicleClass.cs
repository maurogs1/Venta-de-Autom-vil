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
    public class WorkVehicleClass
    {
        public static DataTable getAllVehiclesClass()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT cv_Id as 'Id', cv_descripcion as 'Descripcion' FROM ClaseVehiculo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            //Ejecuta la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void addVehicleClass(VehicleClass vehicleClass)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO ClaseVehiculo(cv_descripcion) values(@descripcion)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.AddWithValue("@descripcion", vehicleClass.Description);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static void updateVehicleClass(VehicleClass vehicleClass)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE ClaseVehiculo SET cv_descripcion=@descripcion WHERE cv_Id=@id";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", vehicleClass.Id);
            cmd.Parameters.AddWithValue("@descripcion", vehicleClass.Description);


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteVehicleClass(string id)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM ClaseVehiculo WHERE cv_Id=@id";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
