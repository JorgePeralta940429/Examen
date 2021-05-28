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
/// Descripción breve de Administrador
/// </summary>
public class Administrador
{


    Sql obj_sql=new Sql();

    public string administrador;
    public string contraseña;
    Conexion obj_conexion = new Conexion();


    //nuevo
    //administrador login

    public LlenaTabla tbl_administrador_login = new LlenaTabla();
    public void void_administrador_login()
    {
        obj_conexion.SetConnection();
        tbl_administrador_login.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_administrador_login.sql_string = "sp_administrador_login @administrador = N'"+obj_sql.SecureSql(administrador)+"', @contraseña = N'"+obj_sql.SecureSql(contraseña)+"'";
        tbl_administrador_login.LlenarTabla();

    }






    //nuevo
    //super-administrador agregar

    public LlenaTabla tbl_super_administrador_agregar = new LlenaTabla();
    public void void_super_administrador_agregar(string id_super, string administrador, string contraseña)
    {
        obj_conexion.SetConnection();
        tbl_super_administrador_agregar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_super_administrador_agregar.sql_string = "sp_super_administrador_agregar @id_super = " + obj_sql.SecureSql(id_super) + ",@administrador = N'" + obj_sql.SecureSql(administrador) + "',@contraseña = N'" + obj_sql.SecureSql(contraseña) + "'";
        tbl_super_administrador_agregar.LlenarTabla();

    }



}
