using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCACION.Scripts
{
    internal class ACCIONREGISTRO
    {

        internal int operacion = 0; //0:Insercion, 1:Modificacion, 2:Eliminacion
        internal claseRegistro cls = new claseRegistro();
        //protected claseProveedor cls = new claseProveedor();
        SqlCommand cmd;
        SqlDataReader reader;
        String cadena = "";
        CONEXION conexion = new CONEXION();

        public List<claseRegistro> Listar()
        {
            List<claseRegistro> lista = new List<claseRegistro>();
            //reader = new SqlDataReader();
            cadena = "Select Codigo, CIAlumno, CodigoCurso, Gestion, Fecha, Total from REGISTRA";
            cmd = new SqlCommand(cadena, conexion.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //reader.FieldCount;
                while (reader.Read())
                {
                    claseRegistro cls = new claseRegistro();
                    cls.Codigo = reader["Codigo"].ToString();
                    cls.CIAlumno = reader["CIAlumno"].ToString();
                    cls.CodigoCurso = reader["CodigoCurso"].ToString();
                    cls.Gestion = reader["Gestion"].ToString();
                    cls.Fecha = Convert.ToDateTime(reader["Fecha"]);
                    cls.Total = Convert.ToDecimal(reader["Total"]);
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
            cadena = "Select Codigo, CIAlumno, CodigoCurso, Gestion, Fecha, Total from REGISTRA";
            adapter.SelectCommand = new SqlCommand(cadena, conexion.con);
            adapter.Fill(ds);
            return ds;
        }
        public DataTable ListarDataTable()
        {
            cadena = "Select Codigo, CIAlumno, CodigoCurso, Gestion, Fecha, Total from REGISTRA";
            cmd = new SqlCommand(cadena, conexion.con);
            DataTable dtable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtable);
            return dtable;
        }
        private static claseUsuario CargaUs(IDataReader reader)
        {
            claseUsuario cls = new claseUsuario();
            cls.CI = reader["Codigo"].ToString();
            cls.Nombres = reader["CIAlumno"].ToString();
            cls.ApellidoP = reader["CodigoCurso"].ToString();
            cls.ApellidoM = reader["Gestion"].ToString();
            cls.Domicilio = reader["Fecha"].ToString();
            cls.Tipo = reader["Total"].ToString();
            return cls;
        }
        public int ObtieneCodigo()
        {
            int correlativo = 0;
            cadena = "Select isnull(CI) codigo from REGISTRA";
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

        public bool Verificar(String ci)
        {
            bool verdad = true;

            cadena = "Select Codigo from REGISTRA";
            cmd = new SqlCommand(cadena, conexion.con);

            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    if (ci.Equals(reader["Codigo"].ToString()))
                    {
                        verdad = false;
                    }
                }
            }
            reader.Close();

            return verdad;
        }

        public bool Ejecutar()
        {
            bool bandera = true;

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
                        cadena = "Insert into REGISTRA(Codigo, CIAlumno, CodigoCurso, Gestion, Fecha, Total) values (@Codigo, @CIAlumno, @CodigoCurso, @Gestion, @Fecha, @Total)";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", cls.Codigo);
                        cmd.Parameters.AddWithValue("@CIAlumno", cls.CIAlumno);
                        cmd.Parameters.AddWithValue("@CodigoCurso", cls.CodigoCurso);
                        cmd.Parameters.AddWithValue("@Gestion", cls.Gestion);
                        cmd.Parameters.AddWithValue("@Fecha", cls.Fecha);
                        cmd.Parameters.AddWithValue("@Total", cls.Total);
                        cmd.ExecuteNonQuery();

                    }

                    else if (operacion == 1)
                    {
                        cadena = "Update REGISTRA set CIAlumno=@CIAlumno, CodigoCurso=@CodigoCurso, Gestion=@Gestion, Fecha=@Fecha, Total=@Total where Codigo=@Codigo";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Codigo", cls.Codigo);
                        cmd.Parameters.AddWithValue("@CIAlumno", cls.CIAlumno);
                        cmd.Parameters.AddWithValue("@CodigoCurso", cls.CodigoCurso);
                        cmd.Parameters.AddWithValue("@Gestion", cls.Gestion);
                        cmd.Parameters.AddWithValue("@Fecha", cls.Fecha);
                        cmd.Parameters.AddWithValue("@Total", cls.Total);
                        cmd.ExecuteNonQuery();
                    }

                    else if (operacion == 2)
                    {
                        cadena = "Delete from REGISTRA where Codigo=@Codigo";
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
                    cadena = "Insert into USUARIO(CI,Nombres,ApellidoP,ApellidoM,Domicilio,Tipo,Celular,CorreoE) values (@CI,@Nombres,@ApellidoP,@ApellidoM,@Domicilio.@Tipo,@Celular,@CorreoE)";
                    cmd = new SqlCommand(cadena, conexion.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@CI", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", cls.Nombres);
                    cmd.Parameters.AddWithValue("@ApellidoP", cls.ApellidoP);
                    cmd.Parameters.AddWithValue("@ApellidoM", cls.ApellidoM);
                    cmd.Parameters.AddWithValue("@Domicilio", cls.Domicilio);
                    cmd.Parameters.AddWithValue("@Tipo", cls.Tipo);
                    cmd.Parameters.AddWithValue("@Celular", cls.Celular);
                    cmd.Parameters.AddWithValue("@CorreoE", cls.CorreoE);
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
        ~ACCIONREGISTRO() { }
    }
    class claseRegistro
    {
        public String Codigo;
        public String CIAlumno;
        public String CodigoCurso;
        public String Gestion;
        public DateTime Fecha;
        public Decimal Total;

        ~claseRegistro() { }
    }

}
