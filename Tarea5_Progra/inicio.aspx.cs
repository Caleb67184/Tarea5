using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea5_Progra
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Bsiguiente_Click1(object sender, EventArgs e)
        {
            Persona.cedula = Tcedula.Text;
            Persona.nombre = Tnombre.Text;

            if (RF.Checked)
            {
                Persona.Genero = "F";
            }
            else
            {
                Persona.Genero = "M";
            }

            Response.Redirect("r1.aspx");
        }
    }
}