using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Acciones para el btnCerrarSesion
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
        //Acciones para el btnConsultas
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
        }
        //acciones para btnConsultas verifica si el usuario es Admin o General
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            String tipoUser = Form1.e_Usuario1.TipoUsuario;
            if (tipoUser.Equals("ADMINISTRADOR"))
            {
                Settings settings = new Settings();
                settings.Show();
            }
            else
            {
                MessageBox.Show("Usuario general no puede acceder a esta opcion");
            }

            
        }
        //Acciones para btnRegistro
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }
    }
}
