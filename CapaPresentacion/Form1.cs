using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        N_Usuario n_Usuario = new N_Usuario();
        public static E_Usuarios e_Usuario1 = new E_Usuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Acciones para el btnAcceder
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("El campo Usuario no puede estar vacio");
                txtUsuario.Focus();
            }
            else if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("El campo Password no puede estar vacio");
                txtPassword.Focus();
            }
            else
            {
                String usuario = txtUsuario.Text;
                String contrasena = txtPassword.Text;
                e_Usuario1 = n_Usuario.usuarioLoginN(usuario, contrasena);
                String usuarioDb = e_Usuario1.CodUsuario;
                String contrasenaDb = e_Usuario1.Password;

                if (usuario.Equals(usuarioDb) && contrasena.Equals(contrasenaDb))
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Las Credenciales no son correctas");
                }
            }

        
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            
        }
    }
}
