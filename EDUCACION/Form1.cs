using EDUCACION.usuarioAlumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCACION
{
    public partial class Inicio1 : Form
    {
        CONEXION conexion;

        public Inicio1()
        {
            InitializeComponent();
        }

        private void Inicio1_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            conexion = new CONEXION();
            SqlDataReader reader = null;
            SqlCommand cmd;
            String cadenaSelect;


            String nombre = txtNombre.Text;
            String password = txtPassword.Text;
            String ciUsuario, tipo;

            const String profesor = "Profesor", alumno = "Alumno", administrador = "Administrador";

            cadenaSelect = "SELECT CI FROM LOGIN_U WHERE " +
                "nombre=" + "'" + nombre+ "' AND contrasena=" + "'" + password + "'";

            cmd = new SqlCommand(cadenaSelect, conexion.con);

            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            try 
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    ciUsuario = reader["CI"].ToString();

                    reader.Close();

                    cadenaSelect = "SELECT Tipo FROM USUARIO WHERE CI=" + "'" + ciUsuario + "'";

                    cmd = new SqlCommand(cadenaSelect, conexion.con);

                    cmd.CommandType = CommandType.Text;
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        tipo = reader["Tipo"].ToString();

                        //MessageBox.Show(tipo);

                        if (tipo.Equals(profesor))
                        {
                            MessageBox.Show("Esta es la ventana de profesor");
                        }
                        if (tipo.Equals(alumno))
                        {
                            
                            USUARIO_ALUM usuarioA = new USUARIO_ALUM(ciUsuario);

                            usuarioA.Show();
                            this.Hide();
                            //this.Dispose();
                            
                        }
                        if (tipo.Equals(administrador))
                        {
                            Inicio2 usuarioAdm = new Inicio2();

                            usuarioAdm.Show();
                            this.Hide();
                            //this.Dispose();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el inicio de sesión");
            }

            /*
            Form ini = new Inicio2();
            ini.Show();
            */
        }
    }
}
