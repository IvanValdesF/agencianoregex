namespace agencia
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpVehiculo = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.gbxAutobus = new System.Windows.Forms.GroupBox();
            this.nudPrecioKilometro = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKilometrajeFinal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudKilometrajeInicial = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxTractor = new System.Windows.Forms.GroupBox();
            this.nudPrecioDia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dtgVehiculo = new System.Windows.Forms.DataGridView();
            this.Alquilado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KilometrajeActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.grpVehiculo.SuspendLayout();
            this.gbxAutobus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioKilometro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometrajeFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometrajeInicial)).BeginInit();
            this.gbxTractor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPlaca.Location = new System.Drawing.Point(16, 65);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(203, 27);
            this.txtPlaca.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "Placa";
            // 
            // grpVehiculo
            // 
            this.grpVehiculo.Controls.Add(this.btnBuscar);
            this.grpVehiculo.Controls.Add(this.label5);
            this.grpVehiculo.Controls.Add(this.label4);
            this.grpVehiculo.Controls.Add(this.cbxTipo);
            this.grpVehiculo.Controls.Add(this.txtPlaca);
            this.grpVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grpVehiculo.Location = new System.Drawing.Point(31, 39);
            this.grpVehiculo.Name = "grpVehiculo";
            this.grpVehiculo.Size = new System.Drawing.Size(332, 188);
            this.grpVehiculo.TabIndex = 66;
            this.grpVehiculo.TabStop = false;
            this.grpVehiculo.Text = "Vehiculo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = global::agencia.Properties.Resources.Visualpharm_Must_Have_Search;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(237, 55);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 42);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Text = ".";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 22);
            this.label5.TabIndex = 74;
            this.label5.Text = "Seleccione el tipo de vehiculo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Tractor",
            "Autobus"});
            this.cbxTipo.Location = new System.Drawing.Point(16, 133);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(203, 32);
            this.cbxTipo.TabIndex = 73;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // gbxAutobus
            // 
            this.gbxAutobus.Controls.Add(this.nudPrecioKilometro);
            this.gbxAutobus.Controls.Add(this.label2);
            this.gbxAutobus.Controls.Add(this.nudKilometrajeFinal);
            this.gbxAutobus.Controls.Add(this.label1);
            this.gbxAutobus.Controls.Add(this.nudKilometrajeInicial);
            this.gbxAutobus.Controls.Add(this.label6);
            this.gbxAutobus.Enabled = false;
            this.gbxAutobus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbxAutobus.Location = new System.Drawing.Point(31, 233);
            this.gbxAutobus.Name = "gbxAutobus";
            this.gbxAutobus.Size = new System.Drawing.Size(332, 275);
            this.gbxAutobus.TabIndex = 75;
            this.gbxAutobus.TabStop = false;
            this.gbxAutobus.Text = "Autobus";
            // 
            // nudPrecioKilometro
            // 
            this.nudPrecioKilometro.AutoSize = true;
            this.nudPrecioKilometro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.nudPrecioKilometro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrecioKilometro.DecimalPlaces = 2;
            this.nudPrecioKilometro.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.nudPrecioKilometro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudPrecioKilometro.Location = new System.Drawing.Point(16, 67);
            this.nudPrecioKilometro.Margin = new System.Windows.Forms.Padding(49, 46, 49, 46);
            this.nudPrecioKilometro.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioKilometro.Name = "nudPrecioKilometro";
            this.nudPrecioKilometro.Size = new System.Drawing.Size(177, 30);
            this.nudPrecioKilometro.TabIndex = 73;
            this.nudPrecioKilometro.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 72;
            this.label2.Text = "Precio por kilómetro";
            // 
            // nudKilometrajeFinal
            // 
            this.nudKilometrajeFinal.AutoSize = true;
            this.nudKilometrajeFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.nudKilometrajeFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudKilometrajeFinal.DecimalPlaces = 2;
            this.nudKilometrajeFinal.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.nudKilometrajeFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudKilometrajeFinal.Location = new System.Drawing.Point(16, 209);
            this.nudKilometrajeFinal.Margin = new System.Windows.Forms.Padding(49, 46, 49, 46);
            this.nudKilometrajeFinal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudKilometrajeFinal.Name = "nudKilometrajeFinal";
            this.nudKilometrajeFinal.Size = new System.Drawing.Size(177, 30);
            this.nudKilometrajeFinal.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 70;
            this.label1.Text = "Kilometros finales";
            // 
            // nudKilometrajeInicial
            // 
            this.nudKilometrajeInicial.AutoSize = true;
            this.nudKilometrajeInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.nudKilometrajeInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudKilometrajeInicial.DecimalPlaces = 2;
            this.nudKilometrajeInicial.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.nudKilometrajeInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudKilometrajeInicial.Location = new System.Drawing.Point(16, 135);
            this.nudKilometrajeInicial.Margin = new System.Windows.Forms.Padding(49, 46, 49, 46);
            this.nudKilometrajeInicial.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudKilometrajeInicial.Name = "nudKilometrajeInicial";
            this.nudKilometrajeInicial.Size = new System.Drawing.Size(177, 30);
            this.nudKilometrajeInicial.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "Kilometros iniciales";
            // 
            // gbxTractor
            // 
            this.gbxTractor.Controls.Add(this.nudPrecioDia);
            this.gbxTractor.Controls.Add(this.label3);
            this.gbxTractor.Enabled = false;
            this.gbxTractor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbxTractor.Location = new System.Drawing.Point(31, 514);
            this.gbxTractor.Name = "gbxTractor";
            this.gbxTractor.Size = new System.Drawing.Size(332, 119);
            this.gbxTractor.TabIndex = 76;
            this.gbxTractor.TabStop = false;
            this.gbxTractor.Text = "Tractor";
            // 
            // nudPrecioDia
            // 
            this.nudPrecioDia.AutoSize = true;
            this.nudPrecioDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.nudPrecioDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrecioDia.DecimalPlaces = 2;
            this.nudPrecioDia.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.nudPrecioDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudPrecioDia.Location = new System.Drawing.Point(16, 65);
            this.nudPrecioDia.Margin = new System.Windows.Forms.Padding(49, 46, 49, 46);
            this.nudPrecioDia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrecioDia.Name = "nudPrecioDia";
            this.nudPrecioDia.Size = new System.Drawing.Size(177, 30);
            this.nudPrecioDia.TabIndex = 73;
            this.nudPrecioDia.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 72;
            this.label3.Text = "Precio por día";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.AutoSize = true;
            this.btnAlquilar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlquilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlquilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquilar.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnAlquilar.ForeColor = System.Drawing.Color.White;
            this.btnAlquilar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlquilar.Location = new System.Drawing.Point(382, 640);
            this.btnAlquilar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(139, 46);
            this.btnAlquilar.TabIndex = 77;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = false;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.AutoSize = true;
            this.btnDevolver.BackColor = System.Drawing.Color.Crimson;
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDevolver.Location = new System.Drawing.Point(529, 640);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(139, 46);
            this.btnDevolver.TabIndex = 78;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dtgVehiculo
            // 
            this.dtgVehiculo.AllowUserToAddRows = false;
            this.dtgVehiculo.AllowUserToDeleteRows = false;
            this.dtgVehiculo.AllowUserToResizeColumns = false;
            this.dtgVehiculo.AllowUserToResizeRows = false;
            this.dtgVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dtgVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVehiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alquilado,
            this.Placa,
            this.Vehiculo,
            this.KilometrajeActual});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVehiculo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVehiculo.Location = new System.Drawing.Point(382, 50);
            this.dtgVehiculo.MultiSelect = false;
            this.dtgVehiculo.Name = "dtgVehiculo";
            this.dtgVehiculo.ReadOnly = true;
            this.dtgVehiculo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVehiculo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgVehiculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVehiculo.ShowCellErrors = false;
            this.dtgVehiculo.ShowCellToolTips = false;
            this.dtgVehiculo.ShowEditingIcon = false;
            this.dtgVehiculo.ShowRowErrors = false;
            this.dtgVehiculo.Size = new System.Drawing.Size(827, 583);
            this.dtgVehiculo.TabIndex = 79;
            this.dtgVehiculo.SelectionChanged += new System.EventHandler(this.dtgVehiculo_SelectionChanged);
            // 
            // Alquilado
            // 
            this.Alquilado.HeaderText = "Alquilado";
            this.Alquilado.Name = "Alquilado";
            this.Alquilado.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vehiculo
            // 
            this.Vehiculo.HeaderText = "Vehiculo";
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            this.Vehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KilometrajeActual
            // 
            this.KilometrajeActual.FillWeight = 120F;
            this.KilometrajeActual.HeaderText = "Cantidad de kilómetros iniciales";
            this.KilometrajeActual.Name = "KilometrajeActual";
            this.KilometrajeActual.ReadOnly = true;
            this.KilometrajeActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnAñadir
            // 
            this.btnAñadir.AutoSize = true;
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAñadir.Location = new System.Drawing.Point(676, 640);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(214, 46);
            this.btnAñadir.TabIndex = 80;
            this.btnAñadir.Text = "Añadir vehículo";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 722);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dtgVehiculo);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.gbxTractor);
            this.Controls.Add(this.gbxAutobus);
            this.Controls.Add(this.grpVehiculo);
            this.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpVehiculo.ResumeLayout(false);
            this.grpVehiculo.PerformLayout();
            this.gbxAutobus.ResumeLayout(false);
            this.gbxAutobus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioKilometro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometrajeFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometrajeInicial)).EndInit();
            this.gbxTractor.ResumeLayout(false);
            this.gbxTractor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.GroupBox gbxAutobus;
        private System.Windows.Forms.NumericUpDown nudKilometrajeInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrecioKilometro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudKilometrajeFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxTractor;
        private System.Windows.Forms.NumericUpDown nudPrecioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgVehiculo;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Alquilado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KilometrajeActual;
    }
}

