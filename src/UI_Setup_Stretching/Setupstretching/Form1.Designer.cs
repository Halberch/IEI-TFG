namespace Setupstretching
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarConexion = new System.Windows.Forms.ProgressBar();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxEstiramiento = new System.Windows.Forms.GroupBox();
            this.labelVvelocidad = new System.Windows.Forms.Label();
            this.labelVmmestirado = new System.Windows.Forms.Label();
            this.labelVnestiramientos = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.labelmmestirados = new System.Windows.Forms.Label();
            this.labelnumerodeveces = new System.Windows.Forms.Label();
            this.buttonEstirar = new System.Windows.Forms.Button();
            this.numericUpDownVvelocidad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMmestirados = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNestiramientos = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIzq = new System.Windows.Forms.GroupBox();
            this.labelvizq = new System.Windows.Forms.Label();
            this.numericUpDownIzq = new System.Windows.Forms.NumericUpDown();
            this.buttonIzq = new System.Windows.Forms.Button();
            this.groupBoxDer = new System.Windows.Forms.GroupBox();
            this.labelvder = new System.Windows.Forms.Label();
            this.numericUpDownDer = new System.Windows.Forms.NumericUpDown();
            this.buttonDer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxEstiramiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVvelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMmestirados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNestiramientos)).BeginInit();
            this.groupBoxIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIzq)).BeginInit();
            this.groupBoxDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.progressBarConexion);
            this.groupBox1.Controls.Add(this.buttonRefrescar);
            this.groupBox1.Controls.Add(this.buttonConectar);
            this.groupBox1.Controls.Add(this.comboBoxBaud);
            this.groupBox1.Controls.Add(this.comboBoxPuerto);
            this.groupBox1.Controls.Add(this.labelBaud);
            this.groupBox1.Controls.Add(this.labelPuerto);
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión Serial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Setupstretching.Properties.Resources.UGR_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarConexion
            // 
            this.progressBarConexion.Location = new System.Drawing.Point(43, 269);
            this.progressBarConexion.Name = "progressBarConexion";
            this.progressBarConexion.Size = new System.Drawing.Size(135, 23);
            this.progressBarConexion.TabIndex = 1;
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(43, 211);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(135, 35);
            this.buttonRefrescar.TabIndex = 5;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(43, 170);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(135, 35);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(43, 116);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(135, 24);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxPuerto
            // 
            this.comboBoxPuerto.FormattingEnabled = true;
            this.comboBoxPuerto.Location = new System.Drawing.Point(43, 59);
            this.comboBoxPuerto.Name = "comboBoxPuerto";
            this.comboBoxPuerto.Size = new System.Drawing.Size(135, 24);
            this.comboBoxPuerto.TabIndex = 1;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(40, 97);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(74, 16);
            this.labelBaud.TabIndex = 2;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(40, 40);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(129, 16);
            this.labelPuerto.TabIndex = 1;
            this.labelPuerto.Text = "Communication Port:";
            // 
            // groupBoxEstiramiento
            // 
            this.groupBoxEstiramiento.Controls.Add(this.labelVvelocidad);
            this.groupBoxEstiramiento.Controls.Add(this.labelVmmestirado);
            this.groupBoxEstiramiento.Controls.Add(this.labelVnestiramientos);
            this.groupBoxEstiramiento.Controls.Add(this.labelVelocidad);
            this.groupBoxEstiramiento.Controls.Add(this.labelmmestirados);
            this.groupBoxEstiramiento.Controls.Add(this.labelnumerodeveces);
            this.groupBoxEstiramiento.Controls.Add(this.buttonEstirar);
            this.groupBoxEstiramiento.Controls.Add(this.numericUpDownVvelocidad);
            this.groupBoxEstiramiento.Controls.Add(this.numericUpDownMmestirados);
            this.groupBoxEstiramiento.Controls.Add(this.numericUpDownNestiramientos);
            this.groupBoxEstiramiento.Location = new System.Drawing.Point(254, 31);
            this.groupBoxEstiramiento.Name = "groupBoxEstiramiento";
            this.groupBoxEstiramiento.Size = new System.Drawing.Size(562, 127);
            this.groupBoxEstiramiento.TabIndex = 1;
            this.groupBoxEstiramiento.TabStop = false;
            this.groupBoxEstiramiento.Text = "Estiramiento";
            this.groupBoxEstiramiento.Enter += new System.EventHandler(this.groupBoxEstiramiento_Enter);
            // 
            // labelVvelocidad
            // 
            this.labelVvelocidad.AutoSize = true;
            this.labelVvelocidad.Location = new System.Drawing.Point(401, 40);
            this.labelVvelocidad.Name = "labelVvelocidad";
            this.labelVvelocidad.Size = new System.Drawing.Size(28, 16);
            this.labelVvelocidad.TabIndex = 14;
            this.labelVvelocidad.Text = "600";
            this.labelVvelocidad.UseMnemonic = false;
            // 
            // labelVmmestirado
            // 
            this.labelVmmestirado.AutoSize = true;
            this.labelVmmestirado.Location = new System.Drawing.Point(276, 40);
            this.labelVmmestirado.Name = "labelVmmestirado";
            this.labelVmmestirado.Size = new System.Drawing.Size(39, 16);
            this.labelVmmestirado.TabIndex = 13;
            this.labelVmmestirado.Text = "0 mm";
            this.labelVmmestirado.UseMnemonic = false;
            // 
            // labelVnestiramientos
            // 
            this.labelVnestiramientos.AutoSize = true;
            this.labelVnestiramientos.Location = new System.Drawing.Point(134, 40);
            this.labelVnestiramientos.Name = "labelVnestiramientos";
            this.labelVnestiramientos.Size = new System.Drawing.Size(14, 16);
            this.labelVnestiramientos.TabIndex = 12;
            this.labelVnestiramientos.Text = "0";
            this.labelVnestiramientos.UseMnemonic = false;
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Location = new System.Drawing.Point(323, 40);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(72, 16);
            this.labelVelocidad.TabIndex = 11;
            this.labelVelocidad.Text = "Velocidad:";
            this.labelVelocidad.UseMnemonic = false;
            // 
            // labelmmestirados
            // 
            this.labelmmestirados.AutoSize = true;
            this.labelmmestirados.Location = new System.Drawing.Point(179, 40);
            this.labelmmestirados.Name = "labelmmestirados";
            this.labelmmestirados.Size = new System.Drawing.Size(91, 16);
            this.labelmmestirados.TabIndex = 10;
            this.labelmmestirados.Text = "mm estirados:";
            this.labelmmestirados.UseMnemonic = false;
            // 
            // labelnumerodeveces
            // 
            this.labelnumerodeveces.AutoSize = true;
            this.labelnumerodeveces.Location = new System.Drawing.Point(25, 40);
            this.labelnumerodeveces.Name = "labelnumerodeveces";
            this.labelnumerodeveces.Size = new System.Drawing.Size(108, 16);
            this.labelnumerodeveces.TabIndex = 9;
            this.labelnumerodeveces.Text = "Nº estiramientos:";
            this.labelnumerodeveces.UseMnemonic = false;
            // 
            // buttonEstirar
            // 
            this.buttonEstirar.Location = new System.Drawing.Point(468, 73);
            this.buttonEstirar.Name = "buttonEstirar";
            this.buttonEstirar.Size = new System.Drawing.Size(85, 25);
            this.buttonEstirar.TabIndex = 8;
            this.buttonEstirar.Text = "Estirar";
            this.buttonEstirar.UseVisualStyleBackColor = true;
            this.buttonEstirar.Click += new System.EventHandler(this.buttonEstirar_Click);
            // 
            // numericUpDownVvelocidad
            // 
            this.numericUpDownVvelocidad.Location = new System.Drawing.Point(326, 73);
            this.numericUpDownVvelocidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVvelocidad.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownVvelocidad.Name = "numericUpDownVvelocidad";
            this.numericUpDownVvelocidad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVvelocidad.TabIndex = 7;
            this.numericUpDownVvelocidad.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownVvelocidad.ValueChanged += new System.EventHandler(this.numericUpDownVvelocidad_ValueChanged);
            // 
            // numericUpDownMmestirados
            // 
            this.numericUpDownMmestirados.Location = new System.Drawing.Point(182, 73);
            this.numericUpDownMmestirados.Maximum = new decimal(new int[] {
            310,
            0,
            0,
            0});
            this.numericUpDownMmestirados.Name = "numericUpDownMmestirados";
            this.numericUpDownMmestirados.Size = new System.Drawing.Size(133, 22);
            this.numericUpDownMmestirados.TabIndex = 6;
            this.numericUpDownMmestirados.ValueChanged += new System.EventHandler(this.numericUpDownMmestirados_ValueChanged);
            // 
            // numericUpDownNestiramientos
            // 
            this.numericUpDownNestiramientos.Location = new System.Drawing.Point(28, 73);
            this.numericUpDownNestiramientos.Name = "numericUpDownNestiramientos";
            this.numericUpDownNestiramientos.Size = new System.Drawing.Size(145, 22);
            this.numericUpDownNestiramientos.TabIndex = 5;
            this.numericUpDownNestiramientos.ValueChanged += new System.EventHandler(this.numericUpDownNestiramientos_ValueChanged);
            // 
            // groupBoxIzq
            // 
            this.groupBoxIzq.Controls.Add(this.labelvizq);
            this.groupBoxIzq.Controls.Add(this.numericUpDownIzq);
            this.groupBoxIzq.Controls.Add(this.buttonIzq);
            this.groupBoxIzq.Location = new System.Drawing.Point(254, 168);
            this.groupBoxIzq.Name = "groupBoxIzq";
            this.groupBoxIzq.Size = new System.Drawing.Size(278, 194);
            this.groupBoxIzq.TabIndex = 2;
            this.groupBoxIzq.TabStop = false;
            this.groupBoxIzq.Text = "Izquierda";
            // 
            // labelvizq
            // 
            this.labelvizq.AutoSize = true;
            this.labelvizq.Location = new System.Drawing.Point(191, 74);
            this.labelvizq.Name = "labelvizq";
            this.labelvizq.Size = new System.Drawing.Size(39, 16);
            this.labelvizq.TabIndex = 0;
            this.labelvizq.Text = "0 mm";
            this.labelvizq.UseMnemonic = false;
            // 
            // numericUpDownIzq
            // 
            this.numericUpDownIzq.Location = new System.Drawing.Point(28, 72);
            this.numericUpDownIzq.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownIzq.Name = "numericUpDownIzq";
            this.numericUpDownIzq.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIzq.TabIndex = 4;
            this.numericUpDownIzq.ValueChanged += new System.EventHandler(this.numericUpDownIzq_ValueChanged);
            // 
            // buttonIzq
            // 
            this.buttonIzq.Location = new System.Drawing.Point(99, 134);
            this.buttonIzq.Name = "buttonIzq";
            this.buttonIzq.Size = new System.Drawing.Size(85, 25);
            this.buttonIzq.TabIndex = 3;
            this.buttonIzq.Text = "Izquierda";
            this.buttonIzq.UseVisualStyleBackColor = true;
            this.buttonIzq.Click += new System.EventHandler(this.buttonIzq_Click);
            // 
            // groupBoxDer
            // 
            this.groupBoxDer.Controls.Add(this.labelvder);
            this.groupBoxDer.Controls.Add(this.numericUpDownDer);
            this.groupBoxDer.Controls.Add(this.buttonDer);
            this.groupBoxDer.Location = new System.Drawing.Point(538, 168);
            this.groupBoxDer.Name = "groupBoxDer";
            this.groupBoxDer.Size = new System.Drawing.Size(278, 194);
            this.groupBoxDer.TabIndex = 3;
            this.groupBoxDer.TabStop = false;
            this.groupBoxDer.Text = "Derecha";
            // 
            // labelvder
            // 
            this.labelvder.AutoSize = true;
            this.labelvder.Location = new System.Drawing.Point(172, 74);
            this.labelvder.Name = "labelvder";
            this.labelvder.Size = new System.Drawing.Size(39, 16);
            this.labelvder.TabIndex = 5;
            this.labelvder.Text = "0 mm";
            this.labelvder.UseMnemonic = false;
            // 
            // numericUpDownDer
            // 
            this.numericUpDownDer.Location = new System.Drawing.Point(16, 72);
            this.numericUpDownDer.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDer.Name = "numericUpDownDer";
            this.numericUpDownDer.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDer.TabIndex = 5;
            this.numericUpDownDer.ValueChanged += new System.EventHandler(this.numericUpDownDer_ValueChanged);
            // 
            // buttonDer
            // 
            this.buttonDer.Location = new System.Drawing.Point(87, 134);
            this.buttonDer.Name = "buttonDer";
            this.buttonDer.Size = new System.Drawing.Size(85, 25);
            this.buttonDer.TabIndex = 4;
            this.buttonDer.Text = "Derecha";
            this.buttonDer.UseVisualStyleBackColor = true;
            this.buttonDer.Click += new System.EventHandler(this.buttonDer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alberto García Cruz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Banco de estiramiento y flexión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TFG Curso 2021-2022";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grado en Ingeniería Electrónica Industrial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDer);
            this.Controls.Add(this.groupBoxIzq);
            this.Controls.Add(this.groupBoxEstiramiento);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Setup Stretching";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxEstiramiento.ResumeLayout(false);
            this.groupBoxEstiramiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVvelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMmestirados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNestiramientos)).EndInit();
            this.groupBoxIzq.ResumeLayout(false);
            this.groupBoxIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIzq)).EndInit();
            this.groupBoxDer.ResumeLayout(false);
            this.groupBoxDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBarConexion;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPuerto;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPuerto;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxEstiramiento;
        private System.Windows.Forms.GroupBox groupBoxIzq;
        private System.Windows.Forms.Button buttonIzq;
        private System.Windows.Forms.GroupBox groupBoxDer;
        private System.Windows.Forms.Button buttonDer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownIzq;
        private System.Windows.Forms.Label labelvizq;
        private System.Windows.Forms.Label labelvder;
        private System.Windows.Forms.NumericUpDown numericUpDownDer;
        private System.Windows.Forms.Label labelVvelocidad;
        private System.Windows.Forms.Label labelVmmestirado;
        private System.Windows.Forms.Label labelVnestiramientos;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label labelmmestirados;
        private System.Windows.Forms.Label labelnumerodeveces;
        private System.Windows.Forms.Button buttonEstirar;
        private System.Windows.Forms.NumericUpDown numericUpDownVvelocidad;
        private System.Windows.Forms.NumericUpDown numericUpDownMmestirados;
        private System.Windows.Forms.NumericUpDown numericUpDownNestiramientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

