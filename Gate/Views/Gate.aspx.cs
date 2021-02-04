using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gate.Views
{
    public partial class Gate : System.Web.UI.Page
    {
        private controller _verwalter;
        private static string _name;

        public controller Verwalter { get => _verwalter; set => _verwalter = value; }
        public static string Name { get => _name; set => _name = value; }

        public Gate()
        {
            Verwalter = Global.Verwalter;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Verwalter.Liste.Count!=0)
            {
                Session["user"] = Verwalter.Liste[0].Name;
                if ((string)Session["user"] != "")
                {
                    Label1.Text = "Hallo, " + (string)Session["user"];
                    Button1.Visible = false;
                }

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:44354/Views/Login");
        }
    }
}