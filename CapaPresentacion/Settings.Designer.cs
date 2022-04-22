
namespace CapaPresentacion
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdificio = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAulas = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.pictureBox4);
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1203, 32);
            this.topPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Settings";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.icons8_registry_editor_50;
            this.pictureBox4.Location = new System.Drawing.Point(3, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.icons8_subtract_30;
            this.pictureBox2.Location = new System.Drawing.Point(1131, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.icons8_close_30;
            this.pictureBox1.Location = new System.Drawing.Point(1170, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.btnEdificio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAulas);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 474);
            this.panel2.TabIndex = 1;
            // 
            // btnEdificio
            // 
            this.btnEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnEdificio.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnEdificio.colorActive = System.Drawing.Color.MediumBlue;
            this.btnEdificio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnEdificio.ForeColor = System.Drawing.Color.White;
            this.btnEdificio.Image = global::CapaPresentacion.Properties.Resources.icons8_buildings_100;
            this.btnEdificio.ImagePosition = 20;
            this.btnEdificio.ImageZoom = 50;
            this.btnEdificio.LabelPosition = 41;
            this.btnEdificio.LabelText = "Edificios";
            this.btnEdificio.Location = new System.Drawing.Point(0, 339);
            this.btnEdificio.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdificio.Name = "btnEdificio";
            this.btnEdificio.Size = new System.Drawing.Size(140, 129);
            this.btnEdificio.TabIndex = 8;
            this.btnEdificio.Click += new System.EventHandler(this.btnEdificio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Configuracion";
            // 
            // btnAulas
            // 
            this.btnAulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnAulas.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnAulas.colorActive = System.Drawing.Color.MediumBlue;
            this.btnAulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnAulas.ForeColor = System.Drawing.Color.White;
            this.btnAulas.Image = global::CapaPresentacion.Properties.Resources.icons8_room_100__1_;
            this.btnAulas.ImagePosition = 20;
            this.btnAulas.ImageZoom = 50;
            this.btnAulas.LabelPosition = 41;
            this.btnAulas.LabelText = "Aulas";
            this.btnAulas.Location = new System.Drawing.Point(0, 209);
            this.btnAulas.Margin = new System.Windows.Forms.Padding(6);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(140, 129);
            this.btnAulas.TabIndex = 2;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnUsuarios.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnUsuarios.colorActive = System.Drawing.Color.MediumBlue;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::CapaPresentacion.Properties.Resources.icons8_users_100__1_;
            this.btnUsuarios.ImagePosition = 20;
            this.btnUsuarios.ImageZoom = 50;
            this.btnUsuarios.LabelPosition = 41;
            this.btnUsuarios.LabelText = "Usuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(0, 79);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(140, 129);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.icons8_settings_64;
            this.pictureBox3.Location = new System.Drawing.Point(6, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_registry_editor_50;
            this.ClientSize = new System.Drawing.Size(1203, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Settings";
            this.Text = "Settings";
         
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuTileButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuTileButton btnAulas;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnEdificio;
    }
}