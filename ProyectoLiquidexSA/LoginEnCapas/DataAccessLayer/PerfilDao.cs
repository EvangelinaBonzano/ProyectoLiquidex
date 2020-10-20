using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ProyectoLiquidexSA.Entities;
using System.Data;
using System.Windows.Forms;

namespace ProyectoLiquidexSA.DataAccessLayer
{
    public class PerfilDao
    {
        public IList<Perfil> GetAll()
        {
            List<Perfil> listadoBugs = new List<Perfil>();

            var strSql = "SELECT p.id_perfil, p.nombre, p.borrado From Perfiles p WHERE p.borrado = 0 ";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }

        public IList<Perfil> GetByFiltersSinParametros(String condiciones)
        {

            List<Perfil> lst = new List<Perfil>();

            String strSql = ("SELECT p.id_perfil, p.nombre, p.borrado From Perfiles p WHERE p.borrado = 0 ");

            //agrego condiciones
            strSql += condiciones;

            //var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        public Perfil GetUserConParametros(string nombrePerfil)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT p.id_perfil, ",
                                          "        p.nombre, ",
                                          "        p.borrado ",
                                          "   FROM Perfiles p",
                                          "  WHERE p.borrado=0 AND p.nombre = @nombre");



            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombrePerfil);


            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQLConParametros(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }



        private Perfil ObjectMapping(DataRow row)
        {
            Perfil oPerfil = new Perfil
            {
                IdPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                Nombre = row["nombre"].ToString(),
                Borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oPerfil;
        }

        internal bool Create(Perfil oPerfil, SueldoPerfilHistorico oSueldoPerfilHistorico)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                //SIN PARAMETROS

                string str_sql = "INSERT INTO Perfiles (nombre, borrado)" +
                            " VALUES (" +
                            "'" + oPerfil.Nombre + "'" + "," +
                             "0)";


                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql)==1);
                dm.EjecutarSQL(str_sql);

                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                MessageBox.Show(Convert.ToString(newId), "muestro el identity", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ////Guarda en id_bug el identity generado

                oPerfil.IdPerfil = Convert.ToInt32(newId);

                string sqlhisto = "INSERT INTO SueldoPerfilHistorico (id_perfil,fecha,sueldo,borrado)" +
                                  " VALUES(" + oPerfil.IdPerfil + "," + "'" + oSueldoPerfilHistorico.Fecha.ToString("yyyy-MM-dd") + "'" + "," + oSueldoPerfilHistorico.Sueldo + "," +
                                        "0)";
                MessageBox.Show(sqlhisto, "muestro la sentencia insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dm.EjecutarSQL(sqlhisto);


                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        internal bool Update(Perfil oPerfil)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Perfiles " +
                             "SET nombre=" + "'" + oPerfil.Nombre + "'" +
                             " WHERE id_perfil=" + oPerfil.IdPerfil + " AND  borrado=0";

                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql)==1);
                dm.EjecutarSQL(str_sql);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        internal bool Delete(Perfil oPerfil)
        {
            //SIN PARAMETROS
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();
                string str_sql = "UPDATE Perfiles " +
                             "SET borrado=1" +
                             " WHERE id_perfil=" + oPerfil.IdPerfil + " AND  borrado=0";

                //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
                dm.EjecutarSQL(str_sql);
                dm.Commit();
            }

            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

    }

}