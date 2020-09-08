using AlumnosPromedios.Code;
using AlumnosPromedios.SqlserverBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlumnosPromedios
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetDatos set = new SetDatos();
            GridView1.DataSource =  set.Mostrar();
            GridView1.DataBind();
            btnConfirmar.Visible = false;

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //CREACION DE VARIABLES
                string carnet = txtCarnet.Text.Trim();
                decimal not1 = Convert.ToDecimal(txtNota1.Text);
                decimal not2 = Convert.ToDecimal(txtNota2.Text);
                decimal not3 = Convert.ToDecimal(txtNota3.Text);

                //INSTANCIA DE CLASE
                SetDatos datos = new SetDatos();

                //converitimos a varaible el metodo
                bool sqlInsertar = datos.Insertar(carnet, not1, not2, not3);

                //MENSAJE
                if (sqlInsertar == true)
                {
                    noti.Text = "NOTIFICACION: insertados los datos correctos";
                    GridView1.DataSource = datos.Mostrar();
                    GridView1.DataBind();

                }
                else
                {
                    noti.Text = "NOTIFICACION: No se pudo insertar los datos";
                }
            }
            catch
            {
                //ENVIA MENSAJE A UN LABEL
                noti.Text = "Alerta: Alguno de los datos es incorrectos";
            }
            finally
            {
                //ENVA VACIA LOS TEXTBOX
                txtNota1.Text = "";
                txtNota2.Text = "";
                txtNota3.Text = "";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string carnet = txtCarnet.Text;
            SetDatos set = new SetDatos();
            bool sqlEliminar = set.Eliminar(carnet);

            if (sqlEliminar == true)
            {
                noti.Text = "NOTIFICACION: Eliminacion de los datos correctos";
                GridView1.DataSource = set.Mostrar();
                GridView1.DataBind();

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string carnet = txtCarnet.Text.Trim();
            SetDatos set = new SetDatos();
            GridView1.DataSource = set.Buscar(carnet);
            GridView1.DataBind();

            noti.Text = "Busqueda satisfactoria";
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            //CREACION DE VARIABLES
            string carnet = txtCarnet.Text.Trim();
            
            //INSTANCIA
            SetDatos set = new SetDatos();
            GridView1.DataSource = set.Buscar(carnet);
            GridView1.DataBind();

            if (GridView1.Rows.Count > 0)
            {


                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    txtNota1.Text = GridView1.Rows[i].Cells[2].Text;
                    txtNota2.Text = GridView1.Rows[i].Cells[3].Text;
                    txtNota3.Text = GridView1.Rows[i].Cells[4].Text;
                }


                decimal not1 = Convert.ToDecimal(txtNota1.Text);
                decimal not2 = Convert.ToDecimal(txtNota2.Text);
                decimal not3 = Convert.ToDecimal(txtNota3.Text);
                btnConfirmar.Visible = true;
                
            }
            
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //CREACION DE VARIABLES
            string carnet = txtCarnet.Text.Trim();
            decimal not1 = Convert.ToDecimal(txtNota1.Text);
            decimal not2 = Convert.ToDecimal(txtNota2.Text);
            decimal not3 = Convert.ToDecimal(txtNota3.Text);


            //INSTANCIA
            SetDatos set = new SetDatos();
            bool confirmar =  set.Actualizar(carnet, not1,not2, not3);

            if (confirmar == true)
            {
                GridView1.DataSource = set.Buscar(carnet);
                GridView1.DataBind();

                noti.Text = "El estudiante con carnet " + carnet + " se actualizo correctamente";
                txtNota1.Text = "";
                txtNota2.Text = "";
                txtNota3.Text = "";
            }
            
        }
    }
}