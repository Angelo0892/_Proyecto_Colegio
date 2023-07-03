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
    public partial class Curso : Form
    {
        ACCIONCURSO obj = new ACCIONCURSO();
        string oper = "Nuevo";
        public Curso()
        {
            InitializeComponent();
        }

        private void CargaProveedores()
        {

            dtgCurso.Rows.Clear();

            //dtgProveedores.AutoGenerateColumns = false;
            //dtgProveedores.DataSource = obj.Listar();
            //// dtgProveedores.DataMember = "Proveedores";
            ////dtgProveedores.da .DataSource = obj.Listar();
            /*
            foreach (var prov in obj.Listar())
            {                
                dtgProveedores.Rows.Add(prov.CodProveedor, prov.Nombre, prov.Direccion, prov.Celular);
            }
            */
            obj = new ACCIONCURSO();
            if (obj.Listar().Count > 0)
            {
                obj.Listar().ForEach((prov) =>
                {
                    dtgCurso.Rows.Add(prov.Codigo, prov.Grado, prov.Seccion, prov.Aula);
                });

            }
            else
            {
                MessageBox.Show("No se tiene datos!!!");
            }
        }


        /*private void CargaProveedoresDataSET()//Este no carga tomar en cuenta
        {
            dtgProveedores.DataSource = obj.ListarDataSET();
            //dtgProveedores.DataMember = "Proveedores";
        }
        */
        private void CargaProveedoresDataTable()
        {
            dtgCurso.DataSource = obj.ListarDataTable();
            //dtgProveedores.DataMember = "Proveedores";
        }


 


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ACCIONCURSO obj = new ACCIONCURSO();
            obj.cls.Grado = txtGrado.Text.Trim();
            obj.cls.Seccion = txtSeccion.Text.Trim();
            obj.cls.Aula = Convert.ToInt32(txtAula.Text.Trim());

            if (String.IsNullOrEmpty(lblCodigo.Text))
            {
                obj.operacion = 0;
                //MessageBox.Show("Entro por aqui");
            }
            else
            {
                obj.cls.Codigo = Convert.ToInt32(lblCodigo.Text);
                obj.operacion = 1;
            }
            /*else
            {
                obj.operacion = 2;
            }
            */
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

        private void Curso_Load(object sender, EventArgs e)
        {
            dtgCurso.Columns.Add("Codigo", "Codigo");
            dtgCurso.Columns.Add("Grado", "Grado");
            dtgCurso.Columns.Add("Sccion", "Seccion");
            dtgCurso.Columns.Add("Aula", "Aula");
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
            txtGrado.Text = "";
            txtSeccion.Text = "";
            txtAula.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oper = "Eliminar";
            obj.cls.Codigo = Convert.ToInt32(lblCodigo.Text);
            obj.operacion = 2;
            if (obj.Ejecutar())
            {
                MessageBox.Show("Operacion satisfactoria");
                CargaProveedores();
            }
        }


        private void dtgCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                        /*
            string valor = "";
            valor = dtgProveedores.Rows[dtgProveedores.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("El valor es "+valor);
            String Nombre = dtgProveedores.CurrentRow.Cells[1].Value.ToString();
            //            MessageBox.Show(dtgProveedores.CurrentCell.Value);
            MessageBox.Show(Nombre);
            */
            lblCodigo.Text = dtgCurso.CurrentRow.Cells[0].Value.ToString();
            txtGrado.Text = dtgCurso.CurrentRow.Cells[1].Value.ToString();
            txtSeccion.Text = dtgCurso.CurrentRow.Cells[2].Value.ToString();
            txtAula.Text = dtgCurso.CurrentRow.Cells[3].Value.ToString();
            oper = "Modi";
        }

    }
}
