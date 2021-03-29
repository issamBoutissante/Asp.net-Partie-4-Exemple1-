using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_4_Exemple_1
{
    public partial class Welcome_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Message.Text = $"Bienvenue {Request.QueryString["nom"]} {Request.QueryString["prenom"]}";
            Message.Text = $"Bienvenue {Request.Form["Nom"]} {Request.Form["Prenom"]}";
        }
    }
}