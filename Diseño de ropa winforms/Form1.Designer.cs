namespace Diseño_de_ropa_winforms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnDiseñarPrenda = new System.Windows.Forms.Button();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblTpPrenda = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTejido = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.cbTalla = new System.Windows.Forms.ComboBox();
            this.cbTpPrenda = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbTejido = new System.Windows.Forms.ComboBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.gbPersonalizar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbPersonalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 99);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(12, 58);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(93, 23);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(210, 58);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(105, 20);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(210, 99);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(105, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Tag = "";
            this.txtContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDiseñarPrenda
            // 
            this.btnDiseñarPrenda.Location = new System.Drawing.Point(24, 606);
            this.btnDiseñarPrenda.Name = "btnDiseñarPrenda";
            this.btnDiseñarPrenda.Size = new System.Drawing.Size(153, 78);
            this.btnDiseñarPrenda.TabIndex = 4;
            this.btnDiseñarPrenda.Text = "Diseñar Prenda";
            this.btnDiseñarPrenda.UseVisualStyleBackColor = true;
            this.btnDiseñarPrenda.Click += new System.EventHandler(this.btnDiseñarPrenda_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(1191, 606);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(147, 76);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Text = "Vista previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFoto.Location = new System.Drawing.Point(337, 40);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(984, 511);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(146, 62);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(58, 16);
            this.lblCorreo.TabIndex = 13;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContraseña.Location = new System.Drawing.Point(114, 103);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(90, 16);
            this.lblContraseña.TabIndex = 14;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.BackColor = System.Drawing.Color.Transparent;
            this.lblTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTalla.Location = new System.Drawing.Point(34, 30);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(47, 16);
            this.lblTalla.TabIndex = 15;
            this.lblTalla.Text = "Talla:";
            // 
            // lblTpPrenda
            // 
            this.lblTpPrenda.AutoSize = true;
            this.lblTpPrenda.BackColor = System.Drawing.Color.Transparent;
            this.lblTpPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpPrenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTpPrenda.Location = new System.Drawing.Point(6, 71);
            this.lblTpPrenda.Name = "lblTpPrenda";
            this.lblTpPrenda.Size = new System.Drawing.Size(118, 16);
            this.lblTpPrenda.TabIndex = 16;
            this.lblTpPrenda.Text = "Tipo de prenda:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColor.Location = new System.Drawing.Point(16, 110);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 16);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color:";
            // 
            // lblTejido
            // 
            this.lblTejido.AutoSize = true;
            this.lblTejido.BackColor = System.Drawing.Color.Transparent;
            this.lblTejido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTejido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTejido.Location = new System.Drawing.Point(6, 152);
            this.lblTejido.Name = "lblTejido";
            this.lblTejido.Size = new System.Drawing.Size(56, 16);
            this.lblTejido.TabIndex = 18;
            this.lblTejido.Text = "Tejido:";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetalles.Location = new System.Drawing.Point(4, 194);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(69, 16);
            this.lblDetalles.TabIndex = 19;
            this.lblDetalles.Text = "Detalles:";
            // 
            // cbTalla
            // 
            this.cbTalla.FormattingEnabled = true;
            this.cbTalla.Items.AddRange(new object[] {
            "L",
            "XL",
            "XXL"});
            this.cbTalla.Location = new System.Drawing.Point(99, 25);
            this.cbTalla.Name = "cbTalla";
            this.cbTalla.Size = new System.Drawing.Size(143, 27);
            this.cbTalla.TabIndex = 20;
            this.cbTalla.SelectedIndexChanged += new System.EventHandler(this.cbTalla_SelectedIndexChanged);
            // 
            // cbTpPrenda
            // 
            this.cbTpPrenda.FormattingEnabled = true;
            this.cbTpPrenda.Items.AddRange(new object[] {
            "Camisa",
            "Chaqueta",
            "Pantalon"});
            this.cbTpPrenda.Location = new System.Drawing.Point(142, 71);
            this.cbTpPrenda.Name = "cbTpPrenda";
            this.cbTpPrenda.Size = new System.Drawing.Size(100, 27);
            this.cbTpPrenda.TabIndex = 21;
            this.cbTpPrenda.SelectedIndexChanged += new System.EventHandler(this.cbTpPrenda_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Blanco"});
            this.cbColor.Location = new System.Drawing.Point(72, 109);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(170, 27);
            this.cbColor.TabIndex = 22;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbTejido
            // 
            this.cbTejido.FormattingEnabled = true;
            this.cbTejido.Items.AddRange(new object[] {
            "Algodon",
            "Seda",
            "Lana "});
            this.cbTejido.Location = new System.Drawing.Point(72, 151);
            this.cbTejido.Name = "cbTejido";
            this.cbTejido.Size = new System.Drawing.Size(170, 27);
            this.cbTejido.TabIndex = 23;
            this.cbTejido.SelectedIndexChanged += new System.EventHandler(this.cbTejido_SelectedIndexChanged);
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(74, 194);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(168, 25);
            this.txtDetalles.TabIndex = 25;
            this.txtDetalles.TextChanged += new System.EventHandler(this.txtDetalles_TextChanged);
            // 
            // gbPersonalizar
            // 
            this.gbPersonalizar.Controls.Add(this.txtDetalles);
            this.gbPersonalizar.Controls.Add(this.lblDetalles);
            this.gbPersonalizar.Controls.Add(this.cbTejido);
            this.gbPersonalizar.Controls.Add(this.lblTpPrenda);
            this.gbPersonalizar.Controls.Add(this.cbColor);
            this.gbPersonalizar.Controls.Add(this.cbTpPrenda);
            this.gbPersonalizar.Controls.Add(this.cbTalla);
            this.gbPersonalizar.Controls.Add(this.lblTejido);
            this.gbPersonalizar.Controls.Add(this.lblColor);
            this.gbPersonalizar.Controls.Add(this.lblTalla);
            this.gbPersonalizar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonalizar.Location = new System.Drawing.Point(33, 227);
            this.gbPersonalizar.Name = "gbPersonalizar";
            this.gbPersonalizar.Size = new System.Drawing.Size(272, 273);
            this.gbPersonalizar.TabIndex = 26;
            this.gbPersonalizar.TabStop = false;
            this.gbPersonalizar.Text = "Personalizar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Diseño_de_ropa_winforms.Properties.Resources.Logo_Monastery_Couture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.gbPersonalizar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.btnDiseñarPrenda);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRegistrar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbPersonalizar.ResumeLayout(false);
            this.gbPersonalizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnDiseñarPrenda;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblTpPrenda;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTejido;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.ComboBox cbTalla;
        private System.Windows.Forms.ComboBox cbTpPrenda;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbTejido;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.GroupBox gbPersonalizar;
    }
}

