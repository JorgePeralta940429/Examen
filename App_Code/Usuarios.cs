using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Descripción breve de Usuarios
/// </summary>
public class Usuarios
{

    Conexion obj_conexion = new Conexion();

   


    public LlenaTabla tbl_suarios_seleccionar = new LlenaTabla();
    public void void_usuarios_seleccionar()
    {

        obj_conexion.SetConnection();
        tbl_suarios_seleccionar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_suarios_seleccionar.sql_string = "sp_usuarios_seleccionar";
        tbl_suarios_seleccionar.LlenarTabla();


    }



}
