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
    public partial class AulaSetting : Form
    {
        //Variables y objetos
        N_Edificio n_Edificio = new N_Edificio();
        N_Aula n_Aula = new N_Aula();
        bool boolnueva = false;
        bool booleditar = false;
        String idAula = "";
        List<E_Aula> lista = new List<E_Aula>();
        E_Aula listar = new E_Aula();
        E_Aula e_Aula = new E_Aula();
        

        public AulaSetting()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Evento que se ejecuta al cargar el form
        private void AulaSetting_Load(object sender, EventArgs e)
        {//Data source que almacena la lista de edificios area de insertar
            cboEdificio.DataSource = n_Edificio.listarEdificiosGN();
            cboEdificio.ValueMember = "IdEdificio";
            cboEdificio.DisplayMember = "IdEdificio";
            //Data source que almacena la lista de edificios area de buscar
            cbEdificioBusca.DataSource = n_Edificio.listarEdificiosGN();
            cbEdificioBusca.ValueMember = "IdEdificio";
            cbEdificioBusca.DisplayMember = "IdEdificio";
            listarAulaId("");
            bloquearCampos();
            rbCodigo.Checked = true;
           
        }
        //limpia campos
        public void limpiarCampos()
        {
            txtCodigoAula.Text = "";
            cboEdificio.Text = "";
        }
        //bloquea campos
        public void bloquearCampos()
        {
            txtCodigoAula.Enabled = false;
            cboEdificio.Enabled = false;
            btnGuardar.Enabled = false;
            groupBox1.Text = "Datos del Aula";
        }
        //desbloquea campos
        public void desbloquearCampos()
        {
            txtCodigoAula.Enabled = true;
            cboEdificio.Enabled = true;
            btnGuardar.Enabled = true;
     
            //devuelve la lista agragandola a un data source por id
        }
        public void listarAulaId(String buscar)
        {
            dataGridView1.DataSource = n_Aula.listarPorIdN(buscar);
        }
        //devuelve la lista agragandola a un data source por edificio
        public void listarAulaEdi(int buscar)
        {
            dataGridView1.DataSource = n_Aula.listarPorEdificioN(buscar);
        }

      
        //Acciones para btn nuevo
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            limpiarCampos();
            boolnueva = true;
            booleditar = false;
            groupBox1.Text="Nueva Aula";
        }
        //Acciones para btnEditar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idAula.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una fila para Editar");
               
            }
            else
            {
                groupBox1.Text = "Editar Aula";
                desbloquearCampos();
                booleditar = true;
                boolnueva = false;
            }
            

          
        }
        //Acciones al seleccionar una celda del datagridview(Tabla)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idAula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtCodigoAula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cboEdificio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
        //Verifica si hay algun campo vacio
        public bool isEmpty()
        {
            if (txtCodigoAula.Text.Equals(""))
            {
                MessageBox.Show("El campo Codigo del Aula no puede estar vacio");
                return false;
            }
            else if (cboEdificio.Text.Equals(""))
            {
                MessageBox.Show("El campo Edificio de edificio no puede estar vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        //Acciones paara btnGuardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (boolnueva)
            {
                if (isEmpty())
                {
                    //comprobar si el id introducido en txtCodEdificio esta en la tabla edificio
                    lista = n_Aula.listarPorIdN(txtCodigoAula.Text);
                    //ALMACENANDO EL DATO ENCONTRADO EN UN OBJETO DE TIPO E_Edificio
                    listar = lista.SingleOrDefault(p => p.IdAula == txtCodigoAula.Text);
                    if (listar == null)
                    {
                            e_Aula.IdAula = txtCodigoAula.Text;
                            e_Aula.Edificio = int.Parse(cboEdificio.Text);
                            n_Aula.insertAulaN(e_Aula);
                            MessageBox.Show("Aula agregada correctamente");
                            limpiarCampos();
                            bloquearCampos();
                            listarAulaId("");
                    }
                    else
                    {
                        MessageBox.Show("El codigo introducido ya esta en la base de datos, intente con otro");

                    }
                }

            }
            else if (booleditar)
            {
                //comprobar si el id introducido en txtCodEdificio esta en la tabla edificio
                lista = n_Aula.listarPorIdN(txtCodigoAula.Text);
                //ALMACENANDO EL DATO ENCONTRADO EN UN OBJETO DE TIPO E_Edificio
                listar = lista.SingleOrDefault(p => p.IdAula == txtCodigoAula.Text);
                if (listar == null||idAula.Equals(txtCodigoAula.Text))
                {
                    e_Aula.IdAula = txtCodigoAula.Text;
                    e_Aula.Edificio = int.Parse(cboEdificio.Text);
                    n_Aula.updateAulaN(e_Aula, idAula);
                    MessageBox.Show("Aula editada correctamente");
                    limpiarCampos();
                    bloquearCampos();
                    listarAulaId("");
                    idAula = "";

                }
                else
                {
                    MessageBox.Show("El codigo introducido ya esta en la base de datos, intente con otro");

                }
            }

        }

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
                String codigo= txtBuscar.Text;
                listarAulaId(codigo);
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {      
                txtBuscar.Enabled = true;
                cbEdificioBusca.Enabled = false;
                listarAulaId("");
        }

        private void rbEdificio_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            cbEdificioBusca.Enabled = true;
            listarAulaId("");

        }

        private void cbEdificioBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(cbEdificioBusca.Text);
                listarAulaEdi(codigo);
            }
            catch (Exception)
            {

             
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idAula.Equals(""))
            {
                MessageBox.Show("Debe seleccionar la fila a eliminar");
            }
            else
            {
                e_Aula.IdAula = idAula;
                n_Aula.deleteAulaN(e_Aula);
                MessageBox.Show("Aula eliminada");
                listarAulaId("");
                limpiarCampos();
                idAula = "";
            }
        }
    }
}
