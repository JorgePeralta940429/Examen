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

public partial class usuario_eliminar : System.Web.UI.Page
{
    Principales obj_principal = new Principales();
    protected void Page_Init(object sender, EventArgs e)
    {


        string id_usuario = Request.QueryString["id_usuario"].ToString();


        obj_principal.obj_usuario.id_usuario=id_usuario;
        obj_principal.obj_usuario.void_usuario_eliminar();
        Response.Redirect("Usuarios_Seleccionar.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
