using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class UsuarioSettings : Form
    {   
        //variables
        int  idUsuario = 0;
        E_Usuarios e_Usuario = new E_Usuarios();
        N_Usuario n_Usuario = new N_Usuario();
        bool boolNuevo = false;
        bool boolEditar = false;
        String codEliminarUser;


        public UsuarioSettings()
        {
            InitializeComponent();
        }
        //Accion para cerrar por el PictureBox X
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        //Accion al seleccionar una celda de la tabla(DatagridView)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                idUsuario = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
               txtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               txtApellido.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
               dateTimePicker.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               cbTipoUsuario.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
               txtContrasena.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
               txtConfContrasena.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               txtCodUsuario.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               codEliminarUser = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
        }
        //Buscar usuarios por nombre
        private void mostrarUsuarios(String buscar)
        {
            dataGridView1.DataSource = n_Usuario.listarUsPornombreN(buscar);
        }

        //Buscar usuario por codigo
        private void mostrarUsuariosPC(String buscar)
        {
            dataGridView1.DataSource = n_Usuario.listarUsPorcodigoN(buscar);
        }
        //Acciones al cargar el formulario
        private void UsuarioSettings_Load(object sender, EventArgs e)
        {   
            rbNombre.Checked = true;
            mostrarUsuarios("");
            bloquearCampos();
            dataGridView1.Columns["IdUsuario"].Visible = false;
        }
        //Acciones para btnNuevo
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            idUsuario = 0;
            desploquearCampos();
            boolNuevo = true;
            boolEditar = false;
            groupBox1.Text = "Nuevo Usuario";
            limpiarCampos();

        }
        //Editar los usuarios
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(idUsuario != 0)
            {
                desploquearCampos();
                boolNuevo = false;
                boolEditar = true;
                groupBox1.Text = "Editar Usuario";
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
           
        }
        //Limpia los campos
        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateTimePicker.Text = "";
            cbTipoUsuario.Text = "";
            txtContrasena.Text = "";
            txtConfContrasena.Text = "";
        }
        //Bloquea los campos
        public void bloquearCampos()
        {
            txtNombre.Enabled=false;
            txtApellido.Enabled = false;
            dateTimePicker.Enabled = false;
            cbTipoUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtConfContrasena.Enabled = false;
            groupBox1.Text = "Datos del Usuario";
            btnGuardar.Enabled = false;
        }
        //Desbloquea los campos
        public void desploquearCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dateTimePicker.Enabled = true;
            cbTipoUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtConfContrasena.Enabled = true;
            btnGuardar.Enabled = true;
        }
        //Acciones para btnGuardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boolNuevo)
            {
                if (isEmpty())
                {
                    e_Usuario.Nombre = txtNombre.Text;
                    e_Usuario.Apellido = txtApellido.Text;
                    e_Usuario.FechaNacimiento = DateTime.Parse(dateTimePicker.Text);
                    e_Usuario.TipoUsuario = cbTipoUsuario.Text;
                    if (confirmarContra())
                    {
                        e_Usuario.Password = txtContrasena.Text;
                        n_Usuario.insertUsuarioN(e_Usuario);
                        MessageBox.Show("Usuario Agregado Correctamente");
                        mostrarUsuarios("");
                        limpiarCampos();
                    }
                }
               
                        
            }
            else if (boolEditar)
            {
                e_Usuario.CodUsuario = txtCodUsuario.Text;
                e_Usuario.Nombre = txtNombre.Text;
                e_Usuario.Apellido = txtApellido.Text;
                e_Usuario.FechaNacimiento = DateTime.Parse(dateTimePicker.Text);
                e_Usuario.TipoUsuario = cbTipoUsuario.Text;
                if (confirmarContra())
                {
                    e_Usuario.Password = txtContrasena.Text;
                    n_Usuario.updateUsuarioN(e_Usuario);
                    MessageBox.Show("Usuario Editado Correctamente");
                    mostrarUsuarios("");
                    limpiarCampos();
                    bloquearCampos();
                    idUsuario = 0;
                }       
            }
        }
        //Confirmar si la contrasenas en los txt son guales
        public bool confirmarContra()
        {
            
            if (txtContrasena.Text.Equals("") || txtConfContrasena.Text.Equals(""))
            {
                MessageBox.Show("Los campos Contraseña o Confirmar Contraseña no pueden estar vacios");
                return false;                
            }
            else if (txtContrasena.Text.Length <= 4)
            {
                MessageBox.Show("La Contraseña debe contener mas de CUATRO Caracteres");
                return false;              
            }
            else if (txtContrasena.Text.Equals(txtConfContrasena.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Las Contraseñas no son iguales");
                return false;
            }
        }
        //Acciones para btnEliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuario != 0)
            {
                e_Usuario.CodUsuario = codEliminarUser;
                n_Usuario.deleteusuarioN(e_Usuario);
                MessageBox.Show("Usualio ELIMINADO");
                idUsuario = 0;
                limpiarCampos();
                mostrarUsuarios("");
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }
        //Acciones para el txtBuscar cuando su valor sea cambiado
        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked)
            {
                mostrarUsuarios(txtBuscar.Text);
            }
            else if (rbCodigo.Checked)
            {
                mostrarUsuariosPC(txtBuscar.Text);
            }
        }

        //Confirma si hay algun campo vacio
        private bool isEmpty()
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String tipoUser = cbTipoUsuario.Text;
            

            if (nombre.Equals(""))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio");
                return false;
            }
            else if (apellido.Equals(""))
            {
                MessageBox.Show("El campo Apellido no puede estar vacio");
                return false;
            }
            else if(tipoUser.Equals(""))
            {
                MessageBox.Show("El campo Tipo Usuario no puede estar vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            mostrarUsuarios("");
        }
    }                            
}                                
