using System;
using EDUCACION.Scripts;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUCACION.usuarioAdministrador
{
    public partial class Registro : Form
    {
        ACCIONREGISTRO obj = new ACCIONREGISTRO();
        string oper = "Nuevo";
        String Tip;
        public Registro()
        {
            InitializeComponent();
        }
        private void CargaProveedores()
        {

            dtgRegistro.Rows.Clear();
            obj = new ACCIONREGISTRO();
            if (obj.Listar().Count > 0)
            {
                obj.Listar().ForEach((prov) =>
                {
                    dtgRegistro.Rows.Add(prov.Codigo, prov.CIAlumno, prov.CodigoCurso, prov.Gestion, prov.Fecha, prov.Total);
                });

            }
            else
            {
                MessageBox.Show("No se tiene datos!!!");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            ACCIONREGISTRO obj = new ACCIONREGISTRO();
            obj.cls.Codigo = codAsignatura.Text.Trim();
            obj.cls.CIAlumno = ciAlumno.Text.Trim();
            obj.cls.CodigoCurso = codCurso.Text.Trim();
            obj.cls.Gestion = gestion.Text.Trim();
            obj.cls.Fecha = Convert.ToDateTime(fecha.Text.Trim());
            obj.cls.Total = Convert.ToDecimal(total.Text.Trim());

            if (String.IsNullOrEmpty(codAsignatura.Text))
            {
                MessageBox.Show("Nesesitamos que introdusca su CI");

                //MessageBox.Show("Entro por aqui");
            }
            if (obj.Verificar(codAsignatura.Text))
            {
                obj.cls.Codigo = codAsignatura.Text;
                obj.operacion = 0;
            }
            else
            {
                obj.operacion = 1;

            }

            if (obj.Ejecutar())
            {
                MessageBox.Show("Operacion satisfactoria");
                CargaProveedores();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            dtgRegistro.Columns.Add("Codigo", "Codigo");
            dtgRegistro.Columns.Add("CIAlumno", "CIAlumno");
            dtgRegistro.Columns.Add("CodCurso", "CodCurso");
            dtgRegistro.Columns.Add("Gestion", "Gestion");
            dtgRegistro.Columns.Add("Fecha", "Fecha");
            dtgRegistro.Columns.Add("Total", "Total");
            CargaProveedores();

            //CargaProveedoresDataTable();

            /*foreach (DataGridView fila in dtgProveedores.Rows)
            {
                DataGridViewCell columna1 = fila.Columns[1].v .Cells[0];
            }*/

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            oper = "Nuevo";
            codAsignatura.Text = "";
            ciAlumno.Text = "";
            codCurso.Text = "";
            gestion.Text = "";
            fecha.Text = "";
            total.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oper = "Eliminar";
            obj.cls.Codigo = codAsignatura.Text;
            obj.operacion = 2;
            if (obj.Ejecutar())
            {
                MessageBox.Show("Operacion satisfactoria");
                CargaProveedores();
            }
        }

        private void dtgRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            codAsignatura.Text = dtgRegistro.CurrentRow.Cells[0].Value.ToString();
            codAsignatura.Text = dtgRegistro.CurrentRow.Cells[1].Value.ToString();
            ciAlumno.Text = dtgRegistro.CurrentRow.Cells[2].Value.ToString();
            codCurso.Text = dtgRegistro.CurrentRow.Cells[3].Value.ToString();
            gestion.Text = dtgRegistro.CurrentRow.Cells[4].Value.ToString();
            fecha.Text = dtgRegistro.CurrentRow.Cells[5].Value.ToString();
            total.Text = dtgRegistro.CurrentRow.Cells[6].Value.ToString();
            oper = "Modi";
        }

        private void rdEstudiante_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
