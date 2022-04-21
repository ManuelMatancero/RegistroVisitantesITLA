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
    public partial class Settings : Form
    {
        UsuarioSettings usuarioSt = new UsuarioSettings();
        AulaSetting aulaSt = new AulaSetting();
        EdificioSetting edificioSt = new EdificioSetting();

        public Settings()
        {
            InitializeComponent();
            usuarioSt.MdiParent = this;
            usuarioSt.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            edificioSt.Hide();
            aulaSt.Hide();
            usuarioSt.MdiParent = this;
            usuarioSt.Show();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            edificioSt.Hide();
            usuarioSt.Hide();
            aulaSt.MdiParent = this;
            aulaSt.Show();
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            usuarioSt.Hide();
            aulaSt.Hide();
            edificioSt.MdiParent = this;
            edificioSt.Show();

        }
    }
}
