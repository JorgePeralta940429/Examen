using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Usuarios_Seleccionar : System.Web.UI.Page
{
    Principales obj_principal = new Principales();
    protected void Page_Init(object sender, EventArgs e)
    {

obj_principal.obj_usuarios.void_usuarios_seleccionar();

       if(obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows.Count>0){

           string cadena=cadena="";
for(int x=0; x<obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows.Count; x++){

    string id_usuario=obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows[x]["id_usuario"].ToString();
    string nombre=obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows[x]["nombre"].ToString();
    string paterno=obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows[x]["ap_pat"].ToString();
    string materno=obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows[x]["ap_mat"].ToString();
    string edad=obj_principal.obj_usuarios.tbl_suarios_seleccionar.tabla_llena.Rows[x]["edad"].ToString();


    cadena = cadena + "<tr>"
     + "<th scope='row'>" + id_usuario + "</th>"
      + "<td>" + nombre + "</td>"
     + "<td>" + paterno + "</td>"
     + "<td>" + materno + "</td>"
     + "<td>" + edad + "</td>"
     + "<td><a href='usuario_eliminar.aspx?id_usuario="+id_usuario+"'>Eliminar</a></td>"
     + "<td><a href='Usuario_Modificar.aspx?id_usuario="+id_usuario+"'>Modificar</a></td>"
     + "</tr>";


}

Literal1.Text = cadena;





       }



     


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Formulario.aspx");
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
