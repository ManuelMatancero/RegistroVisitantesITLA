using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogicaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CapaPresentacion
{
    public partial class Consulta : Form
    {
        E_Visitantes e_Visitantes = new E_Visitantes();
        N_Visitante n_Visitante = new N_Visitante();
        N_Edificio n_Edificio = new N_Edificio();
        public Consulta()
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
        //Al cargarse el formulario Consulta
        private void Consulta_Load(object sender, EventArgs e)
        {
            buscarPorNombre("");
            dataGridView1.Columns["idVisitante"].Visible = false;
            dataGridView1.Columns["Nombre"].HeaderText = "NOMBRE";
            dataGridView1.Columns["Apellido"].HeaderText = "APELLIDO";
            dataGridView1.Columns["Carrera"].HeaderText = "CARRERA";
            dataGridView1.Columns["Edificio"].HeaderText = "EDIFICIO";
            dataGridView1.Columns["HoraSalida"].HeaderText = "SALIDA";
            dataGridView1.Columns["MotivoVisita"].HeaderText = "MOTIVO";
            dataGridView1.Columns["IdAula"].HeaderText = "AULA";
            dataGridView1.Columns["HoraEntrada"].HeaderText = "ENTRADA";
            //Popular el combo box comlos edificios que hay
            comboBox1.DataSource= n_Edificio.listarEdificiosGN();
            comboBox1.ValueMember = "IdEdificio";
            comboBox1.DisplayMember = "IdEdificio";
            //Checkar radioButton nombre
            radioButton1.Checked = true;
        }
        //Buscar por nombre
        private void buscarPorNombre(string buscar)
        {
            dataGridView1.DataSource = n_Visitante.listarVisitasPorNombN(buscar);
        }
        //Buscar por edificio
        private void buscarPorEdificio(int buscar)
        {
            dataGridView1.DataSource = n_Visitante.listarVisitasPorEdifN(buscar);
        }
        //Al cambiar el valor en txtNombre
        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            buscarPorNombre(txtNombre.Text);
        }
        //radiobutton1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            comboBox1.Enabled = false;
            buscarPorNombre("");
        }
        //radiobutton2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            comboBox1.Enabled = true;
            buscarPorNombre("");
        }
        //Al cambiar el elemento de combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarPorEdificio(comboBox1.SelectedIndex + 1);
        }
        //Acciones para el btnPDF que imprime la lista
        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (.pdf)|.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible guardar los datos en el disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Datos exportados correctamente!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hubo datos para guardar !!!", "Info");
            }
        }
    }
}
