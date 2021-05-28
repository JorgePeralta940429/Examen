using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public class Conexion
{

   public string server;
   public string user;
   public  string password;
   public string database;
    public string cadena_conexion;

    public void SetConnection()
    {
        server = "192.168.0.11";
        user = "sa";
        password = "sasa";
        database = "base";
        cadena_conexion = "server="+server+"; Persist Security Info=false; database=" +database+ "; uid="+user+"; pwd="+password+";";





    }




}
