using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace EDUCACION
{
    public partial class Crear_Actividad : Form
    {

        SqlCommand cmd;
        SqlDataReader reader;
        String cadena = "";
        CONEXION conexion = new CONEXION();

        Computer myComputer = new Computer();
        OpenFileDialog dialogo = new OpenFileDialog();

        private int codCursoMateria;

        public Crear_Actividad()
        {
            InitializeComponent();
        }

        public Crear_Actividad(int _codCursoMateria)
        {
            codCursoMateria = _codCursoMateria;

            InitializeComponent();
        }

        private void addArchivo_Click(object sender, EventArgs e)
        {
            var resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                archivo.Text = dialogo.FileName;
            }

        }

        private void subirArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                cadena = "Insert into ACTIVIDAD(Codigo, CodigoCurAsig, Nombre, Detalle, Direccion) " +
                "values (@Codigo, @CodigoCurAsig, @Nombre, @Detalle, @Direccion)";
                cmd = new SqlCommand(cadena, conexion.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Codigo", "1255");
                cmd.Parameters.AddWithValue("CodigoCurAsig", codCursoMateria);
                cmd.Parameters.AddWithValue("@Nombre", actividad.Text);
                cmd.Parameters.AddWithValue("@Direccion", detalle.Text);
                cmd.ExecuteNonQuery();

                String getArchivo = archivo.Text;
                String aux = "", extension = "";
                char caracter = '.';
                int posicion = 0;
                int can;

                for (can = getArchivo.Length - 1; can >= 0; can--)
                {
                    aux += getArchivo[can];

                    if (getArchivo[can].Equals(caracter))
                    {
                        posicion = can;
                        can = -1;
                    }
                }
                for (can = aux.Length - 1; can >= 0; can--)
                {
                    extension += aux[can];
                }

                can = nomArchivo.Text.Length;
                if (can < 41)
                {
                    myComputer.FileSystem.CopyFile(archivo.Text, @"D:\Proyecto_formativo\EDUCACION\Archivos\" + nomArchivo.Text + extension);

                    MessageBox.Show("Exito al guardar");
                }
                else
                {
                    MessageBox.Show("Solamante se permite 40 carácteres como máximo");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la subida de datos");
            }

            cmd.Dispose();
            conexion.con.Dispose();
            conexion.con.Close();

            this.Close();
        }
    }
}
