
namespace EjCalcularEdad
{
    partial class CalculadoraEdades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraEdades));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcularE = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblSDatos = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMVividos = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblMVividosT = new System.Windows.Forms.Label();
            this.lblDiasVT = new System.Windows.Forms.Label();
            this.lblDiasV = new System.Windows.Forms.Label();
            this.lblEdadT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 356);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 39);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcularE
            // 
            this.btnCalcularE.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularE.Location = new System.Drawing.Point(230, 375);
            this.btnCalcularE.Name = "btnCalcularE";
            this.btnCalcularE.Size = new System.Drawing.Size(137, 63);
            this.btnCalcularE.TabIndex = 2;
            this.btnCalcularE.Text = "Calcular edad";
            this.btnCalcularE.UseVisualStyleBackColor = true;
            this.btnCalcularE.Click += new System.EventHandler(this.btnCalcularE_Click);
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.LightGray;
            this.lblBienvenidos.Location = new System.Drawing.Point(212, 10);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(374, 25);
            this.lblBienvenidos.TabIndex = 3;
            this.lblBienvenidos.Text = "Bienvenido a la calculadora de edades.";
            // 
            // lblSDatos
            // 
            this.lblSDatos.AutoSize = true;
            this.lblSDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblSDatos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDatos.ForeColor = System.Drawing.Color.LightGray;
            this.lblSDatos.Location = new System.Drawing.Point(252, 37);
            this.lblSDatos.Name = "lblSDatos";
            this.lblSDatos.Size = new System.Drawing.Size(281, 25);
            this.lblSDatos.TabIndex = 4;
            this.lblSDatos.Text = "Ingresa los siguientes datos:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.LightGray;
            this.lblDatos.Location = new System.Drawing.Point(239, 84);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(307, 25);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Nombres y fecha de nacimiento";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.BackColor = System.Drawing.Color.Transparent;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnio.Location = new System.Drawing.Point(341, 177);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(41, 19);
            this.lblAnio.TabIndex = 6;
            this.lblAnio.Text = "Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMes.Location = new System.Drawing.Point(410, 216);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(40, 19);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDia.Location = new System.Drawing.Point(484, 254);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(35, 19);
            this.lblDia.TabIndex = 8;
            this.lblDia.Text = "Día";
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAnio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.Location = new System.Drawing.Point(390, 174);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(61, 27);
            this.txtAnio.TabIndex = 9;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // txtMes
            // 
            this.txtMes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(459, 213);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(61, 27);
            this.txtMes.TabIndex = 10;
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtDia
            // 
            this.txtDia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(533, 251);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(61, 27);
            this.txtDia.TabIndex = 11;
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(291, 129);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(283, 27);
            this.txtNombres.TabIndex = 13;
            this.txtNombres.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombres.Location = new System.Drawing.Point(207, 132);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(79, 19);
            this.lblNombres.TabIndex = 12;
            this.lblNombres.Text = "Nombres";
            this.lblNombres.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMVividos
            // 
            this.lblMVividos.AutoSize = true;
            this.lblMVividos.BackColor = System.Drawing.Color.Transparent;
            this.lblMVividos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMVividos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMVividos.Location = new System.Drawing.Point(188, 304);
            this.lblMVividos.Name = "lblMVividos";
            this.lblMVividos.Size = new System.Drawing.Size(113, 19);
            this.lblMVividos.TabIndex = 14;
            this.lblMVividos.Text = "Meses vividos";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEdad.Location = new System.Drawing.Point(188, 268);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(51, 19);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad";
            // 
            // lblMVividosT
            // 
            this.lblMVividosT.AutoSize = true;
            this.lblMVividosT.BackColor = System.Drawing.Color.Transparent;
            this.lblMVividosT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMVividosT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMVividosT.Location = new System.Drawing.Point(307, 304);
            this.lblMVividosT.Name = "lblMVividosT";
            this.lblMVividosT.Size = new System.Drawing.Size(0, 19);
            this.lblMVividosT.TabIndex = 17;
            // 
            // lblDiasVT
            // 
            this.lblDiasVT.AutoSize = true;
            this.lblDiasVT.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasVT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasVT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDiasVT.Location = new System.Drawing.Point(307, 341);
            this.lblDiasVT.Name = "lblDiasVT";
            this.lblDiasVT.Size = new System.Drawing.Size(0, 19);
            this.lblDiasVT.TabIndex = 19;
            // 
            // lblDiasV
            // 
            this.lblDiasV.AutoSize = true;
            this.lblDiasV.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDiasV.Location = new System.Drawing.Point(188, 341);
            this.lblDiasV.Name = "lblDiasV";
            this.lblDiasV.Size = new System.Drawing.Size(99, 19);
            this.lblDiasV.TabIndex = 18;
            this.lblDiasV.Text = "Dias vividos";
            // 
            // lblEdadT
            // 
            this.lblEdadT.AutoSize = true;
            this.lblEdadT.BackColor = System.Drawing.Color.Transparent;
            this.lblEdadT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEdadT.Location = new System.Drawing.Point(307, 268);
            this.lblEdadT.Name = "lblEdadT";
            this.lblEdadT.Size = new System.Drawing.Size(0, 19);
            this.lblEdadT.TabIndex = 16;
            // 
            // CalculadoraEdades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiasVT);
            this.Controls.Add(this.lblDiasV);
            this.Controls.Add(this.lblMVividosT);
            this.Controls.Add(this.lblEdadT);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblMVividos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblSDatos);
            this.Controls.Add(this.lblBienvenidos);
            this.Controls.Add(this.btnCalcularE);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "CalculadoraEdades";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculadora de edades";
            this.Load += new System.EventHandler(this.CalculadoraEdades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcularE;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblSDatos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMVividos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblMVividosT;
        private System.Windows.Forms.Label lblDiasVT;
        private System.Windows.Forms.Label lblDiasV;
        private System.Windows.Forms.Label lblEdadT;
    }
}

