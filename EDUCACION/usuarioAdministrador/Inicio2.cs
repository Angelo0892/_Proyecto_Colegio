using EDUCACION.usuarioAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCACION
{
    public partial class Inicio2 : Form
    {
        public Inicio2()
        {
            InitializeComponent();
        }

        private void Profesorbtntool_Click(object sender, EventArgs e)
        {
            Form prof= new Profesor();
            prof.Show();
        }

        private void Estudiantebtntool_Click(object sender, EventArgs e)
        {
            Form alum = new Alumno();
            alum.Show();
        }

        private void Materiabtntool_Click(object sender, EventArgs e)
        {
            Form mat = new Materia();
            mat.Show();
        }

        private void Cursobtntool_Click(object sender, EventArgs e)
        {
            Form curso = new Curso();
            curso.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Registrobtntool_Click(object sender, EventArgs e)
        {
            Form registro = new Registro();
            registro.Show();
        }
    }
}
