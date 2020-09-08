using AlumnosPromedios.SqlserverBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AlumnosPromedios.Code
{
    public class SetDatos
    {
        public bool Insertar(string carnet, decimal not1, decimal not2, decimal not3)
        {
            bool set = false;
            try
            {
                //CONSUMIENDO PARAMETROS
                string id = carnet;
                decimal vnota1 = not1;
                decimal vnota2 = not2;
                decimal vnota3 = not3;


                //validacion
                if (id.Length > 0 && vnota1 !=0  && vnota2 != 0 && vnota3 != 0)
                {
                    set = true;

                    if (set == true) {

                        //INICALIZAR VARIABLES
                        decimal promedio, vpromedio;

                        //SUMA DE NOTAS
                        promedio = vnota1 + vnota2 + vnota3;

                        //PROMEDIO SE DIVIDE ENTRE TRES PORQUE SON TRES NOTAS
                        //EL ENUNCIADO NO PIDE PORCENTAJE POR NOTA
                        vpromedio = promedio / 3;

                        try
                        {
                            //INSTANCIA PARA LA BD 
                            sqlQueryDB sqlQuery = new sqlQueryDB();

                            string sqlComda = "insert into alumnos(carnet, nota1, nota2, nota3, promedio)values('" + id + "', " + vnota1 + ", " + vnota2 + "," + vnota3 + "," + vpromedio + ")".ToString();

                            //ENVIAMOS LA CADENA COMO PARAMETRO
                            sqlQuery.conexion(sqlComda);

                            set = true;
                        }
                        catch
                        {
                            set = false;
                        }

                    }
                }
                else
                {
                    set = false;
                }
            }
            catch
            {
                set = false;
            }

            return set;
            
        }
        public DataSet Mostrar()
        {
            sqlQueryDB sqlQuery = new sqlQueryDB();
            
            DataSet dataSet;

            string mostrar = "select cod as Numero, carnet as Carnet, nota1  as Nota1, nota2 as Nota2, nota3 as Nota3, promedio as Promedio from alumnos";

            dataSet = sqlQuery.conexion(mostrar);

            return dataSet;
        }

        public bool Eliminar(string carnet)
        {
            string vcarnet = carnet;
            bool set = false;
            string cadena = "delete from alumnos where carnet =" + vcarnet;

            try
            {
                sqlQueryDB sql = new sqlQueryDB();
                sql.conexion(cadena);
                set = true;
            }
            catch
            {
                set = false;
            }
            return set;

        }
        public DataSet Buscar(string carnet)
        {
            sqlQueryDB sqlQuery = new sqlQueryDB();
            
            DataSet dataSet;

            string vcarnet = carnet;
            string mostrar = "select cod as Numero, carnet as Carnet, nota1  as Nota1, nota2 as Nota2, nota3 as Nota3, promedio as Promedio from alumnos where carnet ="+vcarnet;

            dataSet = sqlQuery.conexion(mostrar);

            return dataSet;
        }
        
        public bool Actualizar(string carnet, decimal not1, decimal not2, decimal not3)
        {
           
            //VARIABLES 
            string vcarnet = carnet;
            decimal vnota1 = not1;
            decimal vnota2 = not2;
            decimal vnota3 = not3;
            decimal promedio = 0;

            bool data = false;
            try
            {
                //Proceso
                promedio = vnota1 + vnota2 + vnota3;
                promedio = promedio / 3;

                string cadena2 = "update alumnos set nota1 =" + vnota1 + ", nota2 = " + vnota2 + ", nota3 = " + vnota3 + ", promedio = "+promedio+" where carnet =" + vcarnet.ToString();
                

                sqlQueryDB sql = new sqlQueryDB();
                sql.conexion(cadena2);

                data = true;
            }
            catch
            {
                data = false;
            }
            return data;
           
        }
        
    }

}