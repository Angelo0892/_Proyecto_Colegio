using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace EDUCACION
{
    internal class ACCIONCURSO
    {
        internal int operacion = 0; //0:Insercion, 1:Modificacion, 2:Eliminacion
        internal claseCurso cls = new claseCurso();
        //protected claseProveedor cls = new claseProveedor();
        SqlCommand cmd;
        SqlDataReader reader;
        String cadena = "";
        CONEXION conexion = new CONEXION();

        public List<claseCurso> Listar()
        {
            List<claseCurso> lista = new List<claseCurso>();
            //reader = new SqlDataReader();
            cadena = "Select Codigo,Grado,Seccion,Aula from CURSO";
            cmd = new SqlCommand(cadena, conexion.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //reader.FieldCount;
                while (reader.Read())
                {
                    claseCurso cls = new claseCurso();
                    cls.Codigo = Convert.ToInt32(reader["Codigo"]);
                    cls.Grado = reader["Grado"].ToString();
                    cls.Seccion = reader["Seccion"].ToString();
                    cls.Aula = Convert.ToInt32(reader["Aula"]);
                    lista.Add(cls);
                    cls = null;
                }
            }
            reader.Close();
            return lista;
        }



        public DataSet ListarDataSET()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cadena = "Select Codigo,Grado,Seccion,Aula from CURSO";
            adapter.SelectCommand = new SqlCommand(cadena, conexion.con);
            adapter.Fill(ds);
            return ds;
        }
        public DataTable ListarDataTable()
        {
            cadena = "Select Codigo,Grado,Seccion,Aula from CURSO";
            cmd = new SqlCommand(cadena, conexion.con);
            DataTable dtable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtable);
            return dtable;
        }
        private static claseCurso CargaUs(IDataReader reader)
        {
            claseCurso cls = new claseCurso();
            cls.Codigo = Convert.ToInt32(reader["Codigo"]);
            cls.Grado = reader["Grado"].ToString();
            cls.Seccion = reader["Seccion"].ToString();
            cls.Aula = Convert.ToInt32(reader["Aula"]);
            return cls;
        }
        public int ObtieneCodigo()
        {
            int correlativo = 0;
            cadena = "Select isnull(Max(Codigo),0)+1 codigo from CURSO";
            cmd = new SqlCommand(cadena, conexion.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    correlativo = reader.GetInt32(0);
                }
            }
            reader.Close();
            return correlativo;
        }

        public bool Ejecutar()
        {
            bool bandera = true;
            int codigo = 0;

            if (!conexion.flagBD)
            {
                Console.WriteLine("Error en la conexion a la base de datos");
            }
            else
            {

                try
                {
                    if (operacion == 0)
                    {
                        codigo = ObtieneCodigo();
                        cadena = "Insert into CURSO(Codigo,Grado,Seccion,Aula) values (@Codigo, @Grado,@Seccion,@Aula)";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Grado", cls.Grado);
                        cmd.Parameters.AddWithValue("@Seccion", cls.Seccion);
                        cmd.Parameters.AddWithValue("@Aula", cls.Aula);
                        cmd.ExecuteNonQuery();

                    }

                    else if (operacion == 1)
                    {
                        cadena = "Update CURSO set Grado=@Grado,Seccion=@Seccion,Aula=@Aula where Codigo=@Codigo";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", cls.Codigo);
                        cmd.Parameters.AddWithValue("@Grado", cls.Grado);
                        cmd.Parameters.AddWithValue("@Seccion", cls.Seccion);
                        cmd.Parameters.AddWithValue("@Aula", cls.Aula);
                        cmd.ExecuteNonQuery();
                    }

                    else if (operacion == 2)
                    {
                        cadena = "Delete from CURSO where Codigo=@Codigo";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", cls.Codigo);
                        cmd.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    cmd.Dispose();
                    //conexion.con.Dispose();
                    //conexion.con.Close();
                }

            }
            return bandera;
        }

        /*
        public bool Modificar()
        {
            bool bandera = true;
            int codigo = ObtieneCodigo();
            Console.WriteLine(codigo);

            if (!conexion.flagBD)
            {
                Console.WriteLine("Error en la conexion a la base de datos");
            }
            else
            {
                try
                {
                    cadena = "Insert into CURSO(Codigo,Grado,Seccion,Aula) values (@Codigo,@Grado,@Seccion,@Aula)";
                    cmd = new SqlCommand(cadena, conexion.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Grado", cls.Grado);
                    cmd.Parameters.AddWithValue("@Seccion", cls.Seccion);
                    cmd.Parameters.AddWithValue("@Aula", cls.Aula);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    cmd.Dispose();
                    conexion.con.Dispose();
                    conexion.con.Close();
                }

            }
            return bandera;
        }
        */
        ~ACCIONCURSO()
        {

        }
    }
    class claseCurso
    {
        public int Codigo;
        public String Grado;
        public String Seccion;
        public int Aula;

        ~claseCurso() { }

    }
}
