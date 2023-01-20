namespace Pid
{
    partial class Diseño
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
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.MuestraDatos = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtIntegral = new System.Windows.Forms.TextBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Fre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SetPoint = new System.Windows.Forms.NumericUpDown();
            this.Ki = new System.Windows.Forms.NumericUpDown();
            this.Kd = new System.Windows.Forms.NumericUpDown();
            this.Kp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDerivada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Verifica = new System.Windows.Forms.Timer(this.components);
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SetPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.txtVelocidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidad.Location = new System.Drawing.Point(19, 67);
            this.txtVelocidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(114, 26);
            this.txtVelocidad.TabIndex = 0;
            this.txtVelocidad.Text = "250000";
            this.txtVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVelocidad.TextChanged += new System.EventHandler(this.txtVelocidad_TextChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.txtSerie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(19, 130);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(114, 26);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.Text = "COM2";
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // MuestraDatos
            // 
            this.MuestraDatos.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.MuestraDatos.Enabled = false;
            this.MuestraDatos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuestraDatos.Location = new System.Drawing.Point(357, 33);
            this.MuestraDatos.Margin = new System.Windows.Forms.Padding(4);
            this.MuestraDatos.Name = "MuestraDatos";
            this.MuestraDatos.Size = new System.Drawing.Size(112, 26);
            this.MuestraDatos.TabIndex = 2;
            this.MuestraDatos.TextChanged += new System.EventHandler(this.MuestraDatos_TextChanged);
            // 
            // txtError
            // 
            this.txtError.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.txtError.Enabled = false;
            this.txtError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(357, 231);
            this.txtError.Margin = new System.Windows.Forms.Padding(4);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(112, 26);
            this.txtError.TabIndex = 3;
            this.txtError.TextChanged += new System.EventHandler(this.txtError_TextChanged);
            // 
            // txtPotencia
            // 
            this.txtPotencia.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.txtPotencia.Enabled = false;
            this.txtPotencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotencia.Location = new System.Drawing.Point(357, 84);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(112, 26);
            this.txtPotencia.TabIndex = 4;
            this.txtPotencia.TextChanged += new System.EventHandler(this.txtPotencia_TextChanged);
            // 
            // txtIntegral
            // 
            this.txtIntegral.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.txtIntegral.Enabled = false;
            this.txtIntegral.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegral.Location = new System.Drawing.Point(357, 140);
            this.txtIntegral.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntegral.Name = "txtIntegral";
            this.txtIntegral.Size = new System.Drawing.Size(112, 26);
            this.txtIntegral.TabIndex = 5;
            this.txtIntegral.TextChanged += new System.EventHandler(this.txtIntegral_TextChanged);
            // 
            // btnActivar
            // 
            this.btnActivar.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.btnActivar.Enabled = false;
            this.btnActivar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(576, 218);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(112, 72);
            this.btnActivar.TabIndex = 8;
            this.btnActivar.Text = "Activar control";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.btnAbrir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(21, 164);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(112, 44);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "Abrir Puerto";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(21, 216);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 41);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar Puerto";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Fre
            // 
            this.Fre.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.Fre.Enabled = false;
            this.Fre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fre.FormattingEnabled = true;
            this.Fre.Items.AddRange(new object[] {
            "0.25 Hz",
            "0.5   Hz",
            "1      Hz",
            "5      Hz",
            "10    Hz"});
            this.Fre.Location = new System.Drawing.Point(357, 276);
            this.Fre.Margin = new System.Windows.Forms.Padding(4);
            this.Fre.Name = "Fre";
            this.Fre.Size = new System.Drawing.Size(112, 27);
            this.Fre.TabIndex = 11;
            this.Fre.Text = "1    Hz";
            this.Fre.SelectedIndexChanged += new System.EventHandler(this.Fre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Velocidad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Puerto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(435, 4);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 19);
            this.linkLabel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Temperatura:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Error:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Potencia:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Integral:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "SetPoint:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ki:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SetPoint
            // 
            this.SetPoint.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.SetPoint.Enabled = false;
            this.SetPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPoint.Location = new System.Drawing.Point(576, 184);
            this.SetPoint.Margin = new System.Windows.Forms.Padding(4);
            this.SetPoint.Name = "SetPoint";
            this.SetPoint.Size = new System.Drawing.Size(112, 26);
            this.SetPoint.TabIndex = 21;
            this.SetPoint.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.SetPoint.ValueChanged += new System.EventHandler(this.SetPoint_ValueChanged);
            // 
            // Ki
            // 
            this.Ki.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.Ki.DecimalPlaces = 2;
            this.Ki.Enabled = false;
            this.Ki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ki.Location = new System.Drawing.Point(576, 140);
            this.Ki.Margin = new System.Windows.Forms.Padding(4);
            this.Ki.Name = "Ki";
            this.Ki.Size = new System.Drawing.Size(112, 26);
            this.Ki.TabIndex = 22;
            this.Ki.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.Ki.ValueChanged += new System.EventHandler(this.Ki_ValueChanged);
            // 
            // Kd
            // 
            this.Kd.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.Kd.DecimalPlaces = 2;
            this.Kd.Enabled = false;
            this.Kd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Kd.Location = new System.Drawing.Point(576, 84);
            this.Kd.Margin = new System.Windows.Forms.Padding(4);
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(112, 26);
            this.Kd.TabIndex = 23;
            this.Kd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Kd.ValueChanged += new System.EventHandler(this.Kd_ValueChanged);
            // 
            // Kp
            // 
            this.Kp.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.Kp.DecimalPlaces = 2;
            this.Kp.Enabled = false;
            this.Kp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Kp.Location = new System.Drawing.Point(576, 33);
            this.Kp.Margin = new System.Windows.Forms.Padding(4);
            this.Kp.Name = "Kp";
            this.Kp.Size = new System.Drawing.Size(112, 26);
            this.Kp.TabIndex = 24;
            this.Kp.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Kp.ValueChanged += new System.EventHandler(this.Kp_ValueChanged);
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(518, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kd:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(518, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Kp:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtDerivada
            // 
            this.txtDerivada.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.txtDerivada.Enabled = false;
            this.txtDerivada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDerivada.Location = new System.Drawing.Point(357, 183);
            this.txtDerivada.Margin = new System.Windows.Forms.Padding(4);
            this.txtDerivada.Name = "txtDerivada";
            this.txtDerivada.Size = new System.Drawing.Size(112, 26);
            this.txtDerivada.TabIndex = 27;
            this.txtDerivada.TextChanged += new System.EventHandler(this.txtDerivada_TextChanged);
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 190);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Derivada: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Verifica
            // 
            this.Verifica.Tick += new System.EventHandler(this.Verifica_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 95);
            this.label12.TabIndex = 29;
            this.label12.Text = "    Sistemas de Control \r\nM. en IB Luis J. Varela Lara \r\n  Luis Uriel Sánchez Lóp" +
    "ez \r\n      PID AUTOMATICO\r\n\r\n";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Frecuencia de Muestro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pid.Properties.Resources.luzio;
            this.pictureBox1.Location = new System.Drawing.Point(12, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pid.Properties.Resources.Logo_UV;
            this.pictureBox2.Location = new System.Drawing.Point(550, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // Diseño
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(705, 328);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDerivada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Kp);
            this.Controls.Add(this.Kd);
            this.Controls.Add(this.Ki);
            this.Controls.Add(this.SetPoint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fre);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.txtIntegral);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.MuestraDatos);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtVelocidad);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Diseño";
            this.Load += new System.EventHandler(this.txtVelocidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SetPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox MuestraDatos;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtIntegral;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox Fre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown SetPoint;
        private System.Windows.Forms.NumericUpDown Ki;
        private System.Windows.Forms.NumericUpDown Kd;
        private System.Windows.Forms.NumericUpDown Kp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDerivada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer Verifica;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

