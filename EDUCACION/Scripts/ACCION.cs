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
    internal class ACCION
    {

        internal int operacion = 0; //0:Insercion, 1:Modificacion, 2:Eliminacion
        internal claseMateria cls = new claseMateria();
        //protected claseProveedor cls = new claseProveedor();
        SqlCommand cmd;
        SqlDataReader reader;
        String cadena = "";
        CONEXION conexion = new CONEXION();

        public List<claseMateria> Listar()
        {
            List<claseMateria> lista = new List<claseMateria>();
            //reader = new SqlDataReader();
            cadena = "Select Codigo,Nombre,Descripcion from ASIGNATURA";
            cmd = new SqlCommand(cadena, conexion.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //reader.FieldCount;
                while (reader.Read())
                {
                    claseMateria cls = new claseMateria();
                    cls.Codigo = Convert.ToInt32(reader["Codigo"]);
                    cls.Nombre = reader["Nombre"].ToString();
                    cls.Descripcion = reader["Descripcion"].ToString();
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
            cadena = "Select Codigo,Nombre,Descripcion from ASIGNATURA";
            adapter.SelectCommand = new SqlCommand(cadena, conexion.con);
            adapter.Fill(ds);
            return ds;
        }
        public DataTable ListarDataTable()
        {
            cadena = "Select Codigo,Nombre,Descripcion from ASIGNATURA";
            cmd = new SqlCommand(cadena, conexion.con);
            DataTable dtable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtable);
            return dtable;
        }
        private static claseMateria CargaUs(IDataReader reader)
        {
            claseMateria cls = new claseMateria();
            cls.Codigo = Convert.ToInt32(reader["Codigo"]);
            cls.Nombre = reader["Nombre"].ToString();
            cls.Descripcion = reader["Descripcion"].ToString();
            return cls;
        }
        public int ObtieneCodigo()
        {
            int correlativo = 0;
            cadena = "Select isnull(Max(Codigo),0)+1 codigo from ASIGNATURA";
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
                        cadena = "Insert into ASIGNATURA(Codigo,Nombre,Descripcion) values (@Codigo, @Nombre,@Descripcion)";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Nombre", cls.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", cls.Descripcion);
                        cmd.ExecuteNonQuery();

                    }

                    else if (operacion == 1)
                    {
                        cadena = "Update ASIGNATURA set Nombre=@Nombre,Descripcion=@Descripcion where Codigo=@Codigo";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", cls.Codigo);
                        cmd.Parameters.AddWithValue("@Nombre", cls.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", cls.Descripcion);
                        cmd.ExecuteNonQuery();
                    }

                    else if (operacion == 2)
                    {
                        cadena = "Delete from ASIGNATURA where Codigo=@Codigo";
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
                    conexion.con.Dispose();
                    conexion.con.Close();
                }

            }
            return bandera;
        }

        public bool Modificar()
        {
            bool bandera = true;
            int codigo1 = ObtieneCodigo();
            Console.WriteLine(codigo1);

            if (!conexion.flagBD)
            {
                Console.WriteLine("Error en la conexion a la base de datos");
            }
            else
            {
                try
                {
                    cadena = "Insert into ASIGNATURA(Codigo,Nombre,Descripcion) values (@Codigo,@Nombre,@Descripcion)";
                    cmd = new SqlCommand(cadena, conexion.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Codigo", codigo1);
                    cmd.Parameters.AddWithValue("@Nombre", cls.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", cls.Descripcion);
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
        ~ACCION() { }
    }
    class claseMateria
    {
        public int Codigo;
        public String Nombre;
        public String Descripcion;


        ~claseMateria() { }
    }
}

