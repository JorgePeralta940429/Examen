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
/// Descripción breve de Sql
/// </summary>
public class Sql
{
    public bool answer;
    public string SecureSql(string strVar)
    {
        answer=true;
        string final;
        strVar = strVar.Trim();
        // sirve para darle seguridad a las consultas, para evitar ser hakeadas.
        string[] banned ={ "select", "update", "drop", ";", "--", "*", "insert", "delete", "xp_", "'", "alter" };
        for (int i = 0; i < banned.Length; i++)
        {



            strVar = strVar.Replace(banned[i],"");


        }
        final = strVar;

        return final;


    }



    //nuevo
    //valida sql

    public bool SqlVerify(string cadena)
    {

        cadena = cadena.Trim();
        
        string[] banned ={ "select", "update", "drop", ";", "--", "*", "insert", "delete", "xp_", "'", "alter","[","]","(",")" };
        for (int i = 0; i < banned.Length; i++)
        {


            string[] splits = cadena.Split(' ');
            for (int x = 0; x < splits.Length; x++)
            {
                
                if(splits[x].Equals(banned[i])){
                    return false;
                }


            }
            




         


        }
        return true;
        

    }








}
