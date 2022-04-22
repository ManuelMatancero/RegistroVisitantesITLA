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
    public partial class Registro : Form
    {
        E_Visitantes e_Visitantes = new E_Visitantes();
        N_Visitante n_Visitante = new N_Visitante();
        N_Edificio n_Edificio = new N_Edificio();
        N_Aula n_Aula = new N_Aula();


        public Registro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //Populando los combo box del formulario
            comboBoxEdificio.DataSource = n_Edificio.listarEdificiosGN();
            comboBoxEdificio.ValueMember = "IdEdificio";
            comboBoxEdificio.DisplayMember = "IdEdificio";
            
            //Darle formato al DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
        }
        //Accion que se efectuara cuando se seleccione una opcion del comboBoxEdificio
        private void comboBoxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAula.DataSource = n_Aula.listarPorEdificioN(comboBoxEdificio.SelectedIndex + 1);
            comboBoxAula.ValueMember = "IdAula";
            comboBoxAula.DisplayMember = "IdAula";
        }
        //Acciones para el btnRegistrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                e_Visitantes.Nombre = txtNombre.Text;
                e_Visitantes.Apellido =txtApellido.Text;
                e_Visitantes.Carrera =comboBoxCarrera.Text;
                e_Visitantes.Edificio =int.Parse(comboBoxEdificio.Text);
                e_Visitantes.IdAula = comboBoxAula.Text;
                e_Visitantes.HoraSalida =DateTime.Parse(dateTimePicker1.Text);
             e_Visitantes.MotivoVisita =txtMotivoVisita.Text;
                n_Visitante.insertVisitanteN(e_Visitantes);           
                MessageBox.Show("Visitante Registrado CORRECTAMENTE");
                limpiarCampos();
                txtNombre.Focus();
            }
          

        }
        //Verifica que algunos campos no esten vacios
        private bool isEmpty()
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string carrera = comboBoxCarrera.Text;
            string edificio = comboBoxEdificio.Text.ToString();
            string aula = comboBoxAula.Text;

            if (string.IsNullOrEmpty(nombre))
            {
               
                MessageBox.Show("El campo Nombre no puede estar vacio");
                txtNombre.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(apellido))
            {
               
                MessageBox.Show("El campo Apellido no puede estar vacio");
                txtApellido.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(carrera))
            {
              
                MessageBox.Show("El campo Carrera no puede estar vacio");
                comboBoxCarrera.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(edificio))
            {
                MessageBox.Show("El campo Edificio no puede estar vacio");
                comboBoxEdificio.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(aula))
            {
                MessageBox.Show("El campo Aula no puede estar vacio");
                comboBoxAula.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //Limpia los campos
        private void limpiarCampos()
        {
            txtNombre.Text="";
            txtApellido.Text="";
            comboBoxCarrera.Text="";
            txtMotivoVisita.Text="";
        }
    }
}
