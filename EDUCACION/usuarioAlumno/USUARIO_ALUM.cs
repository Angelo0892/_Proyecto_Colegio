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

namespace EDUCACION.usuarioAlumno
{
    public partial class USUARIO_ALUM : Form
    {
        public USUARIO_ALUM()
        {
            InitializeComponent();
        }

        public USUARIO_ALUM(String id)
        {
            InitializeComponent();

            CONEXION conexion = new CONEXION();

            SqlDataReader reader;
            SqlCommand cmd;

            //String nombres = "";

            String cadenaSelect;

            //cadena2 = "SELECT Nombres FROM USUARIO WHERE CI=" + "'"+id+"'";
            cadenaSelect = "SELECT * FROM CURSO INNER JOIN (USUARIO INNER JOIN REGISTRA ON CI = CIAlumno) " +
                "ON REGISTRA.CodigoCurso = CURSO.Codigo " +
                "WHERE CI=" + "'" + id + "'";
            //MessageBox.Show(cadenaSelect);

            cmd = new SqlCommand(cadenaSelect, conexion.con);

            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    nombre.Text = reader["Nombres"].ToString() + " ";
                    nombre.Text += reader["ApellidoP"].ToString() + " ";
                    nombre.Text += reader["ApellidoM"].ToString();
                    curso.Text = reader["Grado"].ToString();
                    seccion.Text = reader["Seccion"].ToString();
                }
            }

            reader.Close();
            reader = null;

            cadenaSelect = "SELECT Nombre FROM ASIGNATURA";

            cmd = new SqlCommand(cadenaSelect, conexion.con);

            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    informacionMateria.Items.Add(reader["Nombre"]);
                }
            }
            reader.Close();

            /*
            cadenaSelect = "SELECT * FROM ASIGNATURA INNER JOIN (USUARIO INNER JOIN PROFESOR_ASIG ON CI = CIProfesor) " +
                "ON ASIGNATURA.Codigo = PROFESOR_ASIG.CodigoAsignatura " +
                "WHERE ASIGNATURA.Codigo=" + "'" + codMateria + "'";
            
            cmd = new SqlCommand(cadenaSelect, conexion.con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    profesor.Text = reader["Nombres"].ToString() + " ";
                    profesor.Text += reader["ApellidoP"].ToString();
                    materia.Text = reader["Nombre"].ToString();
                    informacionM.Text = reader["Descripcion"].ToString();
                }
            }
            */
            //cmd = new SqlCommand(cadenaSelect, conexion.con);

        }

        private void informacionMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            String materiaN = informacionMateria.Items[informacionMateria.SelectedIndex].ToString();

            CONEXION conexion = new CONEXION();

            SqlDataReader reader;
            SqlCommand cmd;

            String cadenaSelect;

            //cadena2 = "SELECT Nombres FROM USUARIO WHERE CI=" + "'"+id+"'";
            cadenaSelect = "SELECT * FROM ASIGNATURA INNER JOIN (USUARIO INNER JOIN PROFESOR_ASIG ON " +
                "CI = CIProfesor) ON ASIGNATURA.Codigo = PROFESOR_ASIG.CodigoAsignatura " +
                "WHERE ASIGNATURA.Nombre =" + "'" + materiaN + "'";

            cmd = new SqlCommand(cadenaSelect, conexion.con);

            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                materia.Text = reader["Nombre"].ToString();
                detalle.Text = reader["Descripcion"].ToString();
                profesor.Text = reader["Nombres"].ToString() + " ";
                profesor.Text += reader["ApellidoP"].ToString() + " ";
                profesor.Text += reader["ApellidoM"].ToString();
            }
            else
            {
                reader.Close();
                cadenaSelect = "SELECT * FROM ASIGNATURA WHERE Nombre=" + "'" + materiaN + "'";
                cmd = new SqlCommand(cadenaSelect, conexion.con);

                cmd.CommandType = CommandType.Text;
                reader = cmd.ExecuteReader();
                reader.Read();

                materia.Text = reader["Nombre"].ToString();
                detalle.Text = reader["Descripcion"].ToString();
                profesor.Text = "No hay profesor";
            }
            reader.Close();

        }

        private void actividad_Click(object sender, EventArgs e)
        {

        }
    }
}
