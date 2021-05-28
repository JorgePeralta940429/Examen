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

public partial class Formulario : System.Web.UI.Page
{
    Principales obj_principal = new Principales();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btn_usuario_agrega_Click(object sender, EventArgs e)
    {

       obj_principal.obj_usuario.nombre=Txt_nombre.Text;
       obj_principal.obj_usuario.ap_pat = txt_paterno.Text;
       obj_principal.obj_usuario.ap_mat = txt_materno.Text;
       obj_principal.obj_usuario.edad = txt_edad.Text;
       obj_principal.obj_usuario.void_usuario_agregar();
       Response.Redirect("Usuarios_Seleccionar.aspx");
    }
}
