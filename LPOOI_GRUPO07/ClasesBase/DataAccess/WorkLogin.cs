using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesBase.Model;

namespace ClasesBase.DataAccess
{
    public class WorkLogin
    {

        public static DataTable loginUser(string userName, string password)
        {
            SqlConnection con = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand com = new SqlCommand();
            com.CommandText = @"SELECT * FROM Usuario WHERE (usu_nombre=@pattern1 AND usu_password=@pattern2)";
            com.CommandType = CommandType.Text;
            com.Connection = con;
            com.Parameters.AddWithValue("@pattern1", userName);
            com.Parameters.AddWithValue("@pattern2", password);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(com);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public static User getUserSaved()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "GetSavedUser";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = connection;
            DataSet ds = new DataSet();
            da.Fill(ds);
            User savedUser = new User();
            try
            {
                if (ds.Tables.Count >= 1)
                {
                    var ddd = ds.Tables[0].Rows[0];
                    savedUser.Username = ddd[0].ToString();
                    savedUser.Password = ddd[1].ToString();
                    savedUser.SaveUser = Convert.ToBoolean(ddd[2]);
                }
            }
            catch { }
            
            
            return savedUser;
        }


    }
}
