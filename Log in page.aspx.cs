using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_4_Exemple_1
{
    public partial class Log_in_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Envoyer_Click(object sender, EventArgs e)
        {
            Server.Transfer("welcome Page.aspx");
           // Response.Redirect($"welcome Page.aspx?nom={Nom.Text}&prenom={Prenom.Text}");
        }
    }
}