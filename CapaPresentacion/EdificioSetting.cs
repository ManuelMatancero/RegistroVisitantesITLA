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
    public partial class EdificioSetting : Form
    {
        bool boolNuevo = false;
        bool boolEditar = false;
        N_Edificio n_Edificio = new N_Edificio();
        E_Edificio e_Edificio = new E_Edificio();
        int idEdificio = 0;
        List<E_Edificio> lista = new List<E_Edificio>();
        E_Edificio listar = new E_Edificio();

        public EdificioSetting()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boolNuevo)
            {
                if (isEmpty())
                {
                    //comprobar si el id introducido en txtCodEdificio esta en la tabla edificio
                    lista = n_Edificio.listarEdificiosN(int.Parse(txtCodEdificio.Text));
                    //ALMACENANDO EL DATO ENCONTRADO EN UN OBJETO DE TIPO E_Edificio
                    listar = lista.SingleOrDefault(p => p.IdEdificio == int.Parse(txtCodEdificio.Text));
                    if (listar == null)
                    {
                        e_Edificio.IdEdificio = int.Parse(txtCodEdificio.Text);
                        e_Edificio.DescripcionEdificio = txtDescripcionEdi.Text;
                        n_Edificio.insertEdificioN(e_Edificio);
                        MessageBox.Show("Edificio agregado correctamente");
                        limpiarCampos();
                        bloquearCampos();
                        mostrarLista();
                        groupBox1.Text = "Datos del Edificio";

                    }
                    else
                    {
                        MessageBox.Show("El codigo introducido ya esta en la base de datos, intente con otro");

                    }
                }  
                           
            }
            else if (boolEditar)
            {
                if (isEmpty())
                {
                    //comprobar si el id introducido en txtCodEdificio esta en la tabla edificio
                    lista = n_Edificio.listarEdificiosN(int.Parse(txtCodEdificio.Text));
                    //ALMACENANDO EL DATO ENCONTRADO EN UN OBJETO DE TIPO E_Edificio
                    listar = lista.SingleOrDefault(p => p.IdEdificio == int.Parse(txtCodEdificio.Text));
                    if (lista == null || idEdificio == int.Parse(txtCodEdificio.Text))
                    {
                        e_Edificio.IdEdificio = int.Parse(txtCodEdificio.Text);
                        e_Edificio.DescripcionEdificio = txtDescripcionEdi.Text;
                        n_Edificio.updateEdificioN(e_Edificio, idEdificio);
                        MessageBox.Show("Edificio editado correctamente");
                        limpiarCampos();
                        bloquearCampos();
                        mostrarLista();
                        idEdificio = 0;
                        groupBox1.Text = "Datos del Edificio";
                    }
                    else
                    {
                        MessageBox.Show("El codigo introducido ya esta en la base de datos, intente con otro");

                    }
                }
                

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
            desbloquearCampos();
            boolNuevo = true;
            boolEditar = false;
            groupBox1.Text = "Nuevo Edificio";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idEdificio != 0)
            {
               
                desbloquearCampos();
                boolEditar = true;
                boolNuevo = false;
                groupBox1.Text = "Editar Edificio";
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idEdificio = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtCodEdificio.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtDescripcionEdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        public void mostrarBusquedaPD(int buscar)
        {
            dataGridView1.DataSource = n_Edificio.listarEdificiosN(buscar);
        }

        public void mostrarLista()
        {
           dataGridView1.DataSource= n_Edificio.listarEdificiosGN();
        }

        private void EdificioSetting_Load(object sender, EventArgs e)
        {
            
            mostrarLista();
            bloquearCampos();
        }

        public void limpiarCampos()
        {
            txtCodEdificio.Text = "";
            txtDescripcionEdi.Text = "";
        }
        public void bloquearCampos()
        {
            txtCodEdificio.Enabled = false;
            txtDescripcionEdi.Enabled = false;
            btnGuardar.Enabled = false;
        }
        public void desbloquearCampos()
        {
           
            txtCodEdificio.Enabled = true;
            txtDescripcionEdi.Enabled = true;
            btnGuardar.Enabled = true;
            groupBox1.Text = "Datos del Edificio";
        }

        public bool isEmpty()
        {
            if (txtCodEdificio.Text.Equals(""))
            {
                MessageBox.Show("El campo codigo de edificio no puede estar vacio");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
