using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea5_Progra
{
    public partial class r2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bavanzar_Click(object sender, EventArgs e)
        {
            int correcta = 0;
            int incorrecta = 0;
            if (DropDownList1.SelectedIndex == 0)
            {
                Persona.r2 = "a";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                Persona.r2 = "b";
                correcta++;
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                Persona.r2 = "c";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                Persona.r2 = "d";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                Persona.r2 = "e";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 5)
            {
                Persona.r2 = "f";
                incorrecta++;
            }


            Response.Redirect("r3.aspx");
        }
    }
}