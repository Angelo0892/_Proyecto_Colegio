using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace EDUCACION
{
    internal class ACCCIONUSUARIO
    {
        internal int operacion = 0; //0:Insercion, 1:Modificacion, 2:Eliminacion
        internal claseUsuario cls = new claseUsuario();
        //protected claseProveedor cls = new claseProveedor();
        SqlCommand cmd;
        SqlDataReader reader;
        String cadena = "";
        CONEXION conexion = new CONEXION();

        public List<claseUsuario> Listar()
        {
            List<claseUsuario> lista = new List<claseUsuario>();
            //reader = new SqlDataReader();
            cadena = "Select CI,Nombres,ApellidoP,ApellidoM,Domicilio,Tipo,Celular,CorreoE from USUARIO";
            cmd = new SqlCommand(cadena, conexion.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //reader.FieldCount;
                while (reader.Read())
                {
                    claseUsuario cls = new claseUsuario();
                    cls.CI = reader["CI"].ToString();
                    cls.Nombres = reader["Nombres"].ToString();
                    cls.ApellidoP = reader["ApellidoP"].ToString();
                    cls.ApellidoM = reader["ApellidoM"].ToString();
                    cls.Domicilio = reader["Domicilio"].ToString();
                    cls.Tipo = reader["Tipo"].ToString();
                    cls.Celular = Convert.ToInt32(reader["Celular"]);
                    cls.CorreoE = reader["CorreoE"].ToString();
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
            cadena = "Select CI,Nombre,ApellidoP,ApellidoM,Domicilio,Tipo,Celular,CorreoE from USUARIO";
            adapter.SelectCommand = new SqlCommand(cadena, conexion.con);
            adapter.Fill(ds);
            return ds;
        }
        public DataTable ListarDataTable()
        {
            cadena = "Select CI,Nombre,ApellidoP,ApellidoM,Domicilio,Tipo,Celular,CorreoE from USUARIO";
            cmd = new SqlCommand(cadena, conexion.con);
            DataTable dtable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dtable);
            return dtable;
        }
        private static claseUsuario CargaUs(IDataReader reader)
        {
            claseUsuario cls = new claseUsuario();
            cls.CI = reader["CI"].ToString();
            cls.Nombres = reader["Nombres"].ToString();
            cls.ApellidoP = reader["ApellidoP"].ToString();
            cls.ApellidoM = reader["ApellidoM"].ToString();
            cls.Domicilio = reader["Domicilio"].ToString();
            cls.Tipo = reader["Tipo"].ToString();
            cls.Celular = Convert.ToInt32(reader["Celular"]);
            cls.CorreoE = reader["CorreoE"].ToString();
            return cls;
        }
        public int ObtieneCodigo()
        {
            int correlativo = 0;
            cadena = "Select isnull(CI) codigo from USUARIO";
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

            cadena = "Select CI from USUARIO";
            cmd = new SqlCommand(cadena, conexion.con);

            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    if (ci.Equals(reader["CI"].ToString()))
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
                        cadena = "Insert into USUARIO(CI,Nombres,ApellidoP,ApellidoM,Domicilio,Tipo,Celular,CorreoE) values (@CI, @Nombres,@ApellidoP,@ApellidoM,@Domicilio,@Tipo,@Celular,@CorreoE)";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@CI", cls.CI);
                        cmd.Parameters.AddWithValue("@Nombres", cls.Nombres);
                        cmd.Parameters.AddWithValue("@ApellidoP", cls.ApellidoP);
                        cmd.Parameters.AddWithValue("@ApellidoM", cls.ApellidoM);
                        cmd.Parameters.AddWithValue("@Domicilio", cls.Domicilio);
                        cmd.Parameters.AddWithValue("@Tipo", cls.Tipo);
                        cmd.Parameters.AddWithValue("@Celular", cls.Celular);
                        cmd.Parameters.AddWithValue("@CorreoE", cls.CorreoE);
                        cmd.ExecuteNonQuery();

                    }

                    else if (operacion == 1)
                    {
                        cadena = "Update USUARIO set Nombres=@Nombres,ApellidoP=@ApellidoP,ApellidoM=@ApellidoM,Domicilio=@Domicilio,Tipo=@Tipo,Celular=@Celular,CorreoE=@CorreoE where CI=@CI";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@CI", cls.CI);
                        cmd.Parameters.AddWithValue("@Nombres", cls.Nombres);
                        cmd.Parameters.AddWithValue("@ApellidoP", cls.ApellidoP);
                        cmd.Parameters.AddWithValue("@ApellidoM", cls.ApellidoM);
                        cmd.Parameters.AddWithValue("@Domicilio", cls.Domicilio);
                        cmd.Parameters.AddWithValue("@Tipo", cls.Tipo);
                        cmd.Parameters.AddWithValue("@Celular", cls.Celular);
                        cmd.Parameters.AddWithValue("@CorreoE", cls.CorreoE);
                        cmd.ExecuteNonQuery();
                    }

                    else if (operacion == 2)
                    {
                        cadena = "Delete from USUARIO where CI=@CI";
                        cmd = new SqlCommand(cadena, conexion.con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@CI", cls.CI);
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
        ~ACCCIONUSUARIO() { }
    }
    class claseUsuario
    {
        public String CI;
        public String Nombres;
        public String ApellidoP;
        public String ApellidoM;
        public String Domicilio;
        public String Tipo;
        public int Celular;
        public String CorreoE;

        ~claseUsuario() { }
    }
}

