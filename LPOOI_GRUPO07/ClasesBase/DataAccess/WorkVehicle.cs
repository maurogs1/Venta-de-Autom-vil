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
    public class WorkVehicle
    {        

        public static DataTable getAllVehiclesSP()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllVehiclesSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void addVehicleSP(Vehicle vehicle)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();

            command.CommandText = "addVehicleSP";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@marca", vehicle.Brand);
            command.Parameters.AddWithValue("@linea", vehicle.VehicleLine);
            command.Parameters.AddWithValue("@modelo", vehicle.Model);
            command.Parameters.AddWithValue("@color", vehicle.Colour);
            command.Parameters.AddWithValue("@puertas", vehicle.NumberOfDoors);
            command.Parameters.AddWithValue("@gps", vehicle.Gps);
            command.Parameters.AddWithValue("@tipoVehiculo", vehicle.idType);
            command.Parameters.AddWithValue("@claseVehiculo", vehicle.idClassVehicle);
            command.Parameters.AddWithValue("@precio", vehicle.Price);
            command.Parameters.AddWithValue("@matricula", vehicle.Enrollment);
            command.Parameters.AddWithValue("@estado", vehicle.State);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void addVehicle(Vehicle vehicle)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Vehiculo(veh_marca,veh_linea,veh_modelo,veh_color,veh_puertas," +
                "veh_gps,veh_tipo,veh_clase,veh_precio,veh_matricula) values(@marca,@linea,@modelo,@color,@puertas," +
                "@gps,@tipo,@clase,@precio,@matricula)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.AddWithValue("@marca", vehicle.Brand);
            command.Parameters.AddWithValue("@linea", vehicle.VehicleLine);
            command.Parameters.AddWithValue("@modelo", vehicle.Model);
            command.Parameters.AddWithValue("@color", vehicle.Colour);
            command.Parameters.AddWithValue("@puertas", vehicle.NumberOfDoors);
            command.Parameters.AddWithValue("@gps", vehicle.Gps);
            command.Parameters.AddWithValue("@tipo", vehicle.Type);
            command.Parameters.AddWithValue("@clase", vehicle.ClassVehicle);
            command.Parameters.AddWithValue("@precio", vehicle.Price);
            command.Parameters.AddWithValue("@matricula", vehicle.Enrollment);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable getAllVehiclesStateEnable()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getVehiclesEnables";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@estado", "DISPONIBLE");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getAllVehiclesStateSales()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getVehiclesEnables";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@estado", "VENDIDO");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void updateVehicleState(int id)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Vehiculo SET veh_estado=@estado WHERE veh_id=@id";

            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@estado", "VENDIDO");

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void updateVehicleSP(Vehicle vehicle)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "updateVehicleSP";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", vehicle.Id);
            command.Parameters.AddWithValue("@marca", vehicle.Brand);
            command.Parameters.AddWithValue("@linea", vehicle.VehicleLine);
            command.Parameters.AddWithValue("@modelo", vehicle.Model);
            command.Parameters.AddWithValue("@color", vehicle.Colour);
            command.Parameters.AddWithValue("@puertas", vehicle.NumberOfDoors);
            command.Parameters.AddWithValue("@gps", vehicle.Gps);
            command.Parameters.AddWithValue("@tipoVehiculo", vehicle.idType);
            command.Parameters.AddWithValue("@claseVehiculo", vehicle.idClassVehicle);
            command.Parameters.AddWithValue("@precio", vehicle.Price);
            command.Parameters.AddWithValue("@matricula", vehicle.Enrollment);

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public static void deleteVehicleSP(string idVehicle)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "deleteVehicleSP";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", Convert.ToInt32(idVehicle));
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable searchVehicle(string pattern)
        {
            pattern = "%" + pattern + "%"; /*Agrega comodines al patron*/
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText += " SELECT * FROM viewGetAllVehicles "; /*Uso de la vista*/
            cmd.CommandText += " WHERE (Matricula LIKE @pattern OR Linea LIKE @pattern)";
            cmd.Parameters.AddWithValue("@pattern", pattern);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getAllVehicleBrand()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllVehicleBrandSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
         
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getAllVehicleLine()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllVehicleLineSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static bool getVehiculeByEnrollment(string v)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getVehiculeByEnrollment";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            param = new SqlParameter("@matricula", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = v;
            adapter.SelectCommand.Parameters.Add(param);
            cmd.Connection = connection;
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            try
            {
                var matricula = ds.Tables[0].Rows[0];
                if (matricula[0].ToString() != null)
                    return true;
            }
            catch { }
                
            
            return false;
        }


    }
    
}
