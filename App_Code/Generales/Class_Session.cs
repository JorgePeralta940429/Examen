using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public class Class_Session
{


public bool cadena;
    int salida;

    public bool void_valida_sesion(string id_session){

        if(int.TryParse(id_session,out salida)){

            if(int.Parse(id_session)>0){
                return true;
            }
            else{
                return false;
            }



        }
        else{
        return false;
        }


    }


}
