using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AlumnosPromedios.SqlserverBD
{
    public class sqlQueryDB
    {
        public DataSet conexion(string query)
        {

            /*
               FUNCIONA COMO UNA API 
                VENTAJAS: 
                        1-ARCHIVO ESCALABLE.
                        2-FACI MODIFICACION.
                        3-SE PUEDE CONVERTIR A .DLL
                        4-NO REQUIERE MUCHO CODIGO.
            */


            //consulta desde la clase x: de caulquier clase se puede llamar y enviar datos
            string slqQuery = query;

            //SERVIDOR
            string server = "Data Source=.;Initial Catalog=promedios;Integrated Security=True";

            //CONEXION SQLSERVER
            SqlConnection con = new SqlConnection(server);
            con.Open();

            //creando dataset nuevo
            DataSet ds = new DataSet();

            // creando adaptador para enviar parametros
            SqlDataAdapter dp = new SqlDataAdapter(query, con);

            //Adatamos el la consulta 
            dp.Fill(ds);

            //cerramos Conexion
            con.Close();

            //retorna el dataset
            return ds;

        }
    }
}