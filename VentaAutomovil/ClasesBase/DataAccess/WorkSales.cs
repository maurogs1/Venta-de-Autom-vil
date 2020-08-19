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
    public class WorkSales
    {
        public static DataTable getAllWaysToPays()
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

        public static DataTable getAllCustomers()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT cli_dni as 'Dni', cli_id as 'Id',";
            command.CommandText += " cli_nombre as 'Nombre',";
            command.CommandText += " cli_apellido as 'Apellido',";
            command.CommandText += " cli_direccion as 'Direccion',";
            command.CommandText += " cli_telefono as 'Telefono',";
            command.CommandText += " cli_apellido+' '+cli_nombre AS 'Nombre Completo'";
            command.CommandText += " FROM Cliente";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getAllVehicles()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "getAllVehiclesState";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@estado", "DISPONIBLE");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertarVenta(Sale sale)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Venta(vta_fecha,fp_id,vta_precio_final,cli_id,veh_id,usu_id,vta_estado) values(@fecha,@fp,@preciofinal,@cli,@veh,@usuid,@estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@fecha", sale.Date);
            cmd.Parameters.AddWithValue("@fp", sale.idPaymentMethod);
            cmd.Parameters.AddWithValue("@preciofinal", sale.FinalPrice);
            cmd.Parameters.AddWithValue("@cli", sale.CustomerID);
            cmd.Parameters.AddWithValue("@veh", sale.VehicleID);
            cmd.Parameters.AddWithValue("@usuid", sale.UserId);
            cmd.Parameters.AddWithValue("@estado", sale.State);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable getSaleByCustomer(string v)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandText = "GetByCustomer";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            param = new SqlParameter("@cliente", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = v;
            adapter.SelectCommand.Parameters.Add(param);
            command.Connection = cnn;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int getCountSaleByCustomer(string customer)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getCountSaleByCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@cliente", customer);
            cmd.Parameters.Add("@count_sales", SqlDbType.Int);
            cmd.Parameters["@count_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@count_sales"].Value;
            return quantity;
        }

        public static int getImportTotalSaleByCustomer(string customer)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getImportTotalSaleByCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@cliente", customer);
            cmd.Parameters.Add("@sum_sales", SqlDbType.Int);
            cmd.Parameters["@sum_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@sum_sales"].Value;
            return quantity;
        }

        public static DataTable getAllSalesSP()
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllSalesSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable getAllSalesState(string State)
        {
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "getAllSalesStateSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado", State);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable getSaleByDate(DateTime firstDate, DateTime lastDate)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandText = "GetAllSalesByDate";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            param = new SqlParameter("@fechamin", SqlDbType.Date);
            param.Direction = ParameterDirection.Input;
            param.Value = firstDate;
            adapter.SelectCommand.Parameters.Add(param);
            param = new SqlParameter("@fechamax", SqlDbType.Date);
            param.Direction = ParameterDirection.Input;
            param.Value = lastDate;
            adapter.SelectCommand.Parameters.Add(param);
            command.Connection = cnn;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int getCountSaleByDate(DateTime firstDate, DateTime lastDate)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getCountSaleByDate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@fechamin", firstDate);
            cmd.Parameters.AddWithValue("@fechamax", lastDate);
            cmd.Parameters.Add("@count_sales", SqlDbType.Int);
            cmd.Parameters["@count_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@count_sales"].Value;
            return quantity;
        }

        public static int getImportTotalSaleByDate(DateTime firstDate, DateTime lastDate)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getImportTotalSaleByDate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@fechamin", firstDate);
            cmd.Parameters.AddWithValue("@fechamax", lastDate);
            cmd.Parameters.Add("@sum_sales", SqlDbType.Int);
            cmd.Parameters["@sum_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            try
            {
                quantity = (int)cmd.Parameters["@sum_sales"].Value;
                return quantity;
            }
            catch { return quantity=0; }
            
         
        }




        public static DataTable getSaleByUser(string userName)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandText = "GetByUserSales";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            param = new SqlParameter("@usuario", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = userName;
            adapter.SelectCommand.Parameters.Add(param);
            command.Connection = cnn;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int getCountSaleByUser(string userName)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getCountSaleByUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@usuario", userName);
            cmd.Parameters.Add("@count_sales", SqlDbType.Int);
            cmd.Parameters["@count_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@count_sales"].Value;
            return quantity;
        }

        public static int getImportTotalSaleByUser(string userName)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getImportTotalSaleByUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@usuario", userName);
            cmd.Parameters.Add("@sum_sales", SqlDbType.Int);
            cmd.Parameters["@sum_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@sum_sales"].Value;
            return quantity;
        }

        public static DataTable getSaleByBrand(string search)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandText = "GetByBrand";
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            param = new SqlParameter("@marca", SqlDbType.Text);
            param.Direction = ParameterDirection.Input;
            param.Value = search;
            adapter.SelectCommand.Parameters.Add(param);
            command.Connection = cnn;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int getCountSaleByBrand(string brand)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getCountSaleByBrand";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@marca", brand);
            cmd.Parameters.Add("@count_sales", SqlDbType.Int);
            cmd.Parameters["@count_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@count_sales"].Value;
            return quantity;
        }

        public static int getImportTotalSaleByBrand(string brand)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getImportTotalSaleByBrand";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@marca", brand);
            cmd.Parameters.Add("@sum_sales", SqlDbType.Int);
            cmd.Parameters["@sum_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@sum_sales"].Value;
            return quantity;
        }

        public static DataTable getUsersByRol()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandText = "GetUsersByRol";
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = cnn;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static void updateStateSale(int id)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Venta SET vta_estado=@estado WHERE vta_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@estado", "ANULADO");
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static int getAllSalesQuantity()
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllSalesQuantity";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.Add("@count_sales",SqlDbType.Int);
            cmd.Parameters["@count_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@count_sales"].Value;
            return quantity;
        }

        public static int getAllSalesStateQuantity(string State)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getAllSalesStateQuantity";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@estado", State);
            cmd.Parameters.Add("@count_sales_state", SqlDbType.Int);
            cmd.Parameters["@count_sales_state"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@count_sales_state"].Value;
            return quantity;
        }

        public static int getSalesImportTotal()
        {
            int importTotal;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getSalesImportTotal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.Add("@sum_sales", SqlDbType.Int);
            cmd.Parameters["@sum_sales"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            importTotal = (int)cmd.Parameters["@sum_sales"].Value;
            return importTotal;
        }

        public static int getSalesStateImportTotal(string State)
        {
            int quantity;
            SqlConnection connection = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getSalesStateImportTotal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@estado", State);
            cmd.Parameters.Add("@sum_sales_state", SqlDbType.Int);
            cmd.Parameters["@sum_sales_state"].Direction = ParameterDirection.Output;

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            quantity = (int)cmd.Parameters["@sum_sales_state"].Value;
            return quantity;
        }
    }

}

