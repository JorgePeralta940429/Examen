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
/// Descripción breve de Administradores
/// </summary>
public class Administradores
{


    Conexion obj_conexion = new Conexion();
    Sql obj_sql = new Sql();


    //nuevo super administradores seleccionar
    public LlenaTabla tbl_super_administradores_seleccionar = new LlenaTabla();
    public void void_super_administradores_seleccionar(string id_super)
    {
        obj_conexion.SetConnection();
        tbl_super_administradores_seleccionar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_super_administradores_seleccionar.sql_string = "sp_super_administradores_seleccionar @id_super = "+obj_sql.SecureSql(id_super);
        tbl_super_administradores_seleccionar.LlenarTabla();

    }



    //nuevo super administradores disponibles seleccionar
    public LlenaTabla tbl_super_administradores_disponibles_seleccionar = new LlenaTabla();
    public void void_super_administradores_disponibles_seleccionar(string id_super)
    {
        obj_conexion.SetConnection();
        tbl_super_administradores_disponibles_seleccionar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_super_administradores_disponibles_seleccionar.sql_string = "sp_super_administradores_disponibles_seleccionar @id_super = " + obj_sql.SecureSql(id_super);
        tbl_super_administradores_disponibles_seleccionar.LlenarTabla();

    }
}
