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
/// Descripción breve de Categorias
/// </summary>
public class Categorias
{
    Conexion obj_conexion = new Conexion();
    Sql obj_sql = new Sql();


    public LlenaTabla tbl_categorias_seleccionar = new LlenaTabla();
    public void void_categorias_seleccionar()
    {
        obj_conexion.SetConnection();
        tbl_categorias_seleccionar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_categorias_seleccionar.sql_string = "sp_categorias_seleccionar";
        tbl_categorias_seleccionar.LlenarTabla();

    }
}
