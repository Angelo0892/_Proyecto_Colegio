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
    public partial class Alumno : Form
    {
        ACCCIONUSUARIO obj = new ACCCIONUSUARIO();
        string oper = "Nuevo";
        String Tip;
        public Alumno()
        {
            InitializeComponent();
        }
        private void CargaProveedores()
        {

            dtgUsuario.Rows.Clear();

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
            obj = new ACCCIONUSUARIO();
            if (obj.Listar().Count > 0)
            {
                obj.Listar().ForEach((prov) =>
                {
                    dtgUsuario.Rows.Add(prov.CI, prov.Nombres, prov.ApellidoP, prov.ApellidoM, prov.Domicilio, prov.Tipo, prov.Celular, prov.CorreoE);
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
        private void CargaUsuarioDataTable()
        {
            dtgUsuario.DataSource = obj.ListarDataTable();
            //dtgProveedores.DataMember = "Proveedores";
        }

        private void CargaUusarioDataTable()
        {
            dtgUsuario.DataSource = obj.ListarDataTable();
            //dtgProveedores.DataMember = "Proveedores";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            ACCCIONUSUARIO obj = new ACCCIONUSUARIO();
            obj.cls.CI = lblCodigo.Text.Trim();
            obj.cls.Nombres = txtNombre.Text.Trim();
            obj.cls.ApellidoP = txtPaterno.Text.Trim();
            obj.cls.ApellidoM = txtMaterno.Text.Trim();
            obj.cls.Domicilio = txtDireccion.Text.Trim();
            obj.cls.Tipo = txtTipo.Text.Trim();
            obj.cls.Celular = Convert.ToInt32(txtCelular.Text.Trim());
            obj.cls.CorreoE = txtCorreo.Text.Trim();

            if (String.IsNullOrEmpty(lblCodigo.Text))
            {
                MessageBox.Show("Nesesitamos que introdusca su CI");

                //MessageBox.Show("Entro por aqui");
            }
            if (obj.Verificar(lblCodigo.Text))
            {
                obj.cls.CI = lblCodigo.Text;
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

        private void Alumno_Load(object sender, EventArgs e)
        {
            dtgUsuario.Columns.Add("CI", "CI");
            dtgUsuario.Columns.Add("Nombres", "Nombres");
            dtgUsuario.Columns.Add("ApellidoP", "ApellidoP");
            dtgUsuario.Columns.Add("ApellidoM", "ApellidoM");
            dtgUsuario.Columns.Add("Domicilio", "Domicilio");
            dtgUsuario.Columns.Add("Tipo", "Tipo");
            dtgUsuario.Columns.Add("Celular", "Celular");
            dtgUsuario.Columns.Add("CorreoE", "CorreoE");
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
            lblCodigo.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDireccion.Text = "";
            txtTipo.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oper = "Eliminar";
            obj.cls.CI = lblCodigo.Text;
            obj.operacion = 2;
            if (obj.Ejecutar())
            {
                MessageBox.Show("Operacion satisfactoria");
                CargaProveedores();
            }
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            lblCodigo.Text = dtgUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgUsuario.CurrentRow.Cells[1].Value.ToString();
            txtPaterno.Text = dtgUsuario.CurrentRow.Cells[2].Value.ToString();
            txtMaterno.Text = dtgUsuario.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgUsuario.CurrentRow.Cells[4].Value.ToString();
            txtTipo.Text = dtgUsuario.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dtgUsuario.CurrentRow.Cells[6].Value.ToString();
            txtCorreo.Text = dtgUsuario.CurrentRow.Cells[7].Value.ToString();
            oper = "Modi";
        }

        private void rdEstudiante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

            if (rdEstudiante.Checked == true)
            {
                Tip = "Estudiante";
                txtTipo.Text = Tip;
            }
            else
            {
                if (rdAdmin.Checked == true)
                {
                    Tip = "Administrador";
                    txtTipo.Text = Tip;

                }
                else
                {
                    if (rdProfesor.Checked == true)
                    {
                        Tip = "Profesor";
                        txtTipo.Text = Tip;
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un Tipo");
                    }
                }
            }
        }

    }
}
