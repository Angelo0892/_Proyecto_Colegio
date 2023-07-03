using EDUCACION;
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
    public partial class Materia : Form
    {
        ACCION obj = new ACCION();
        string oper = "Nuevo";
        public Materia()
        {
            InitializeComponent();
        }
        private void CargaProveedores()
        {

            dtgMateria.Rows.Clear();

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
            obj = new ACCION();
            if (obj.Listar().Count > 0)
            {
                obj.Listar().ForEach((prov) =>
                {
                    dtgMateria.Rows.Add(prov.Codigo, prov.Nombre, prov.Descripcion);
                });

            }
            else
            {
                MessageBox.Show("No se tiene datos!!!");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ACCION obj = new ACCION();
            obj.cls.Nombre = txtNombre.Text.Trim();
            obj.cls.Descripcion = txtDescripcion.Text.Trim();

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
        private void Materia_Load(object sender, EventArgs e)
        {
            dtgMateria.Columns.Add("Codigo", "Codigo");
            dtgMateria.Columns.Add("Nombre", "Nombre");
            dtgMateria.Columns.Add("Descripcion", "Descripcion");
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
            txtNombre.Text = "";
            txtDescripcion.Text = "";
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

        private void dtgMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string valor = "";
            valor = dtgProveedores.Rows[dtgProveedores.CurrentRow.Index].Cells[1].Value.ToString();
            MessageBox.Show("El valor es "+valor);
            String Nombre = dtgProveedores.CurrentRow.Cells[1].Value.ToString();
            //            MessageBox.Show(dtgProveedores.CurrentCell.Value);
            MessageBox.Show(Nombre);
            */
            lblCodigo.Text = dtgMateria.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgMateria.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgMateria.CurrentRow.Cells[2].Value.ToString();
            oper = "Modi";
        }
    }
}
