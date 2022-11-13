using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea5_Progra
{
    public partial class r3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void Bnuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("inicio.aspx");
        }

        protected void Bsalvar_Click(object sender, EventArgs e)
        {
            int correcta = 0;
            int incorrecta = 0;
            if (DropDownList1.SelectedIndex == 0)
            {
                Persona.r3 = "a";
                correcta++;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                Persona.r3 = "b";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                Persona.r3 = "c";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                Persona.r3 = "d";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                Persona.r3 = "e";
                incorrecta++;
            }
            else if (DropDownList1.SelectedIndex == 5)
            {
                Persona.r3 = "f";
                incorrecta++;
            }
            Label1.Text = "Cedula: " + Persona.cedula + " \nNombre: " + Persona.nombre + " \nGenero: " + Persona.Genero + " \nR1:" + Persona.r1 + " \nR2: " + Persona.r2 + " \nR3: " + Persona.r3 + "\nRespuestas Correctas: "+correcta+"\nRespuestas Incorrectas: "+incorrecta;

            Salvar();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["EncuestasUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select respuestas.id, respuestas.cedulaR, Persona.nombre, respuestas.r1, respuestas.r2, respuestas.r3 " +
                                                       "from Respuestas" +
                                                       " inner join Persona on respuestas.cedulaR= persona.cedula"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
        protected void Salvar()
        {
            try
            {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["EncuestasUHConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO Persona(cedula, nombre, Genero) VALUES('" + Persona.cedula + "', '" + Persona.nombre + "', '" + Persona.Genero + "'  )", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

            conexion.Open();
            comando = new SqlCommand(" INSERT INTO Respuestas VALUES('" + Persona.cedula + "', '" + Persona.r1 + "', '" + Persona.r2 + "', '" + Persona.r3 + "'  )", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            }
            catch (Exception)
            {

               
            }
            

            LlenarGrid();
        }

    }
}