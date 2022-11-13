using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea5_Progra
{
    public partial class r1 : System.Web.UI.Page
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
                Persona.r1 = "a";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                Persona.r1 = "b";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                Persona.r1 = "c";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                Persona.r1 = "d";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                Persona.r1 = "e";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 5)
            {
                Persona.r1 = "f";
                correcta++;
            }
            

            Response.Redirect("r2.aspx");
        }
    }
}