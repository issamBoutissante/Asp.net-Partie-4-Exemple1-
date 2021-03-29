using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_4_Exemple_1
{
    public partial class Page21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Envoyer_Click(object sender, EventArgs e)
        {
            Response.Cookies["nom"].Value = Nom.Text;
            Response.Cookies["prenom"].Value = Prenom.Text;
            Response.Cookies["nom"].Expires = Response.Cookies["prenom"].Expires = DateTime.Now.AddHours(1);
            Response.Redirect("Page22.aspx");
        }
    }
}