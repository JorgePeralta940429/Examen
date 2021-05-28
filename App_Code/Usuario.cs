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
/// Descripción breve de Usuario
/// </summary>
public class Usuario
       

{
    Conexion obj_conexion = new Conexion();
    

    public string id_usuario;
    public string nombre;
    public string ap_pat;
    public string ap_mat;
    public string edad;
       


    public LlenaTabla tbl_usuario_agregar = new LlenaTabla();
    public void void_usuario_agregar()
    {
        
 
        obj_conexion.SetConnection();
        tbl_usuario_agregar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_usuario_agregar.sql_string = "sp_usuario_agregar @nombre = N'"+nombre+"',@ap_pat = N'"+ap_pat+"',@ap_mat = N'"+ap_mat+"',@edad = N'"+edad+"'";
        tbl_usuario_agregar.LlenarTabla();



    }



    public LlenaTabla tbl_usuario_eliminar= new LlenaTabla();
    public void void_usuario_eliminar()
    {



        obj_conexion.SetConnection();
        tbl_usuario_eliminar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_usuario_eliminar.sql_string = "sp_usuario_eliminar @id_usuario ="+id_usuario;
        tbl_usuario_eliminar.LlenarTabla();



    }






    public LlenaTabla tbl_usuario_modificar = new LlenaTabla();
    public void void_usuario_modificar()
    {



        obj_conexion.SetConnection();
        tbl_usuario_modificar.cadena_conexion = obj_conexion.cadena_conexion;
        tbl_usuario_modificar.sql_string = "sp_usuario_modificar @id_usuario = "+id_usuario+",@nombre = N'"+nombre+"',@ap_pat = N'"+ap_pat+"',@ap_mat = N'"+ap_mat+"',@edad ="+edad;
        tbl_usuario_modificar.LlenarTabla();



    }








}
