using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de LlenaTabla
/// </summary>
public class LlenaTabla
{

    public string sql_string;
    public string cadena_conexion;
    public DataTable tabla_llena;
    Conexion con = new Conexion();


    public void LlenarTabla()
    {

        try
        {

            tabla_llena = new DataTable();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = cadena_conexion;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_string, connection);

            adapter.Fill(tabla_llena);

            connection.Close();
            cadena_conexion = null;
            sql_string = null;
        }
        catch(Exception e){

        }


    }






}
