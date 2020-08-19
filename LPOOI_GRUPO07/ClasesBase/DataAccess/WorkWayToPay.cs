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
    public class WorkWayToPay
    {
        public static DataTable getAllWayToPays()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT fp_Id as 'Id', fp_descripcion as 'Descripcion' FROM FormaPago";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;

            //Ejecuta la consulta 
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void addWayToPay(WayToPay wayToPay)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO FormaPago(fp_descripcion) values(@descripcion)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.AddWithValue("@descripcion", wayToPay.Description);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static void updateWayToPay(WayToPay wayToPay)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE FormaPago SET fp_descripcion=@descripcion WHERE fp_id=@id";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", wayToPay.Id);
            cmd.Parameters.AddWithValue("@descripcion", wayToPay.Description);


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void deleteWayToPay(string id)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM FormaPago WHERE fp_id=@id";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
