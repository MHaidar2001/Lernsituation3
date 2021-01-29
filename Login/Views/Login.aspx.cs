using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login.Views
{
    public partial class Login : System.Web.UI.Page
    {
        private controller _verwalter;

        public controller Verwalter { get => _verwalter; set => _verwalter = value; }
        public Login()
        {
            Verwalter = Global.Verwalter;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
           string index= Verwalter.ueberpruefen(TxtUser.Text,txtpass.Text);
            if (index == "0")
            {
                Label3.Visible = true;
                Label3.Text = "gültige Anmeldedaten. Versuchen Sie es noch einmal!";
            }
            else if (index == "1")
            {
                

            }
            else if (index=="3")
            {
                Label3.Visible = true;
                Label3.Text = "Datenbank nicht erreichba";

            }
        }
    }
}