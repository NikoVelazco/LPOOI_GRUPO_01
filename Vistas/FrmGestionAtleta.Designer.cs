namespace Vistas
{
    partial class FrmGestionAtleta
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
            this.lblTitleCategoria = new System.Windows.Forms.Panel();
            this.lblAtleta = new System.Windows.Forms.Label();
            this.dataGridAtleta = new System.Windows.Forms.DataGridView();
            this.lblEditAtleta = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnDeleteAtleta = new System.Windows.Forms.Button();
            this.btnAgregarAtl = new System.Windows.Forms.Button();
            this.btnBorrarFiltro = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rbtnDni = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarAtl = new System.Windows.Forms.Button();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEntrenador = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTitleCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtleta)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleCategoria
            // 
            this.lblTitleCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(109)))));
            this.lblTitleCategoria.Controls.Add(this.lblAtleta);
            this.lblTitleCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCategoria.Location = new System.Drawing.Point(0, 0);
            this.lblTitleCategoria.Name = "lblTitleCategoria";
            this.lblTitleCategoria.Size = new System.Drawing.Size(768, 31);
            this.lblTitleCategoria.TabIndex = 1;
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.ForeColor = System.Drawing.Color.Gold;
            this.lblAtleta.Location = new System.Drawing.Point(257, 5);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(150, 22);
            this.lblAtleta.TabIndex = 18;
            this.lblAtleta.Text = "GESTION ATLETA";
            // 
            // dataGridAtleta
            // 
            this.dataGridAtleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAtleta.Location = new System.Drawing.Point(28, 65);
            this.dataGridAtleta.Name = "dataGridAtleta";
            this.dataGridAtleta.Size = new System.Drawing.Size(639, 97);
            this.dataGridAtleta.TabIndex = 3;
            this.dataGridAtleta.SelectionChanged += new System.EventHandler(this.dataGridAtleta_SelectionChanged);
            // 
            // lblEditAtleta
            // 
            this.lblEditAtleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblEditAtleta.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAtleta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEditAtleta.Location = new System.Drawing.Point(199, 47);
            this.lblEditAtleta.Margin = new System.Windows.Forms.Padding(4);
            this.lblEditAtleta.Name = "lblEditAtleta";
            this.lblEditAtleta.Size = new System.Drawing.Size(400, 21);
            this.lblEditAtleta.TabIndex = 47;
            this.lblEditAtleta.Text = "LISTADO DE ATLETAS";
            this.lblEditAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.txtFechaNac);
            this.panelContenedor.Controls.Add(this.txtDir);
            this.panelContenedor.Controls.Add(this.txtEmail);
            this.panelContenedor.Controls.Add(this.lblEmail);
            this.panelContenedor.Controls.Add(this.lblDireccion);
            this.panelContenedor.Controls.Add(this.lblFechaNac);
            this.panelContenedor.Controls.Add(this.txtGenero);
            this.panelContenedor.Controls.Add(this.txtPeso);
            this.panelContenedor.Controls.Add(this.txtAltura);
            this.panelContenedor.Controls.Add(this.txtNacionalidad);
            this.panelContenedor.Controls.Add(this.txtEntrenador);
            this.panelContenedor.Controls.Add(this.txtDni);
            this.panelContenedor.Controls.Add(this.txtName);
            this.panelContenedor.Controls.Add(this.txtApellido);
            this.panelContenedor.Controls.Add(this.lblApellido);
            this.panelContenedor.Controls.Add(this.lblName);
            this.panelContenedor.Controls.Add(this.lblNacionalidad);
            this.panelContenedor.Controls.Add(this.lblEntrenador);
            this.panelContenedor.Controls.Add(this.lblPeso);
            this.panelContenedor.Controls.Add(this.lblGenero);
            this.panelContenedor.Controls.Add(this.lblAltura);
            this.panelContenedor.Controls.Add(this.lblDni);
            this.panelContenedor.Location = new System.Drawing.Point(28, 168);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(615, 181);
            this.panelContenedor.TabIndex = 48;
            // 
            // btnDeleteAtleta
            // 
            this.btnDeleteAtleta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteAtleta.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteAtleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAtleta.FlatAppearance.BorderSize = 0;
            this.btnDeleteAtleta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteAtleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAtleta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAtleta.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAtleta.Location = new System.Drawing.Point(359, 358);
            this.btnDeleteAtleta.Name = "btnDeleteAtleta";
            this.btnDeleteAtleta.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteAtleta.TabIndex = 70;
            this.btnDeleteAtleta.Text = "Eliminar";
            this.btnDeleteAtleta.UseVisualStyleBackColor = false;
            this.btnDeleteAtleta.Click += new System.EventHandler(this.btnDeleteAtleta_Click);
            // 
            // btnAgregarAtl
            // 
            this.btnAgregarAtl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarAtl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarAtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAtl.FlatAppearance.BorderSize = 0;
            this.btnAgregarAtl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarAtl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregarAtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAtl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAtl.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAtl.Location = new System.Drawing.Point(563, 358);
            this.btnAgregarAtl.Name = "btnAgregarAtl";
            this.btnAgregarAtl.Size = new System.Drawing.Size(80, 30);
            this.btnAgregarAtl.TabIndex = 69;
            this.btnAgregarAtl.Text = "Agregar";
            this.btnAgregarAtl.UseVisualStyleBackColor = false;
            this.btnAgregarAtl.Click += new System.EventHandler(this.btnAgregarAtl_Click);
            // 
            // btnBorrarFiltro
            // 
            this.btnBorrarFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrarFiltro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarFiltro.FlatAppearance.BorderSize = 0;
            this.btnBorrarFiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnBorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnBorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFiltro.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnBorrarFiltro.Location = new System.Drawing.Point(216, 380);
            this.btnBorrarFiltro.Name = "btnBorrarFiltro";
            this.btnBorrarFiltro.Size = new System.Drawing.Size(105, 31);
            this.btnBorrarFiltro.TabIndex = 68;
            this.btnBorrarFiltro.Text = "Borrar Filtro";
            this.btnBorrarFiltro.UseVisualStyleBackColor = false;
            this.btnBorrarFiltro.Click += new System.EventHandler(this.btnBorrarFiltro_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBusqueda.Location = new System.Drawing.Point(30, 394);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(133, 14);
            this.lblBusqueda.TabIndex = 67;
            this.lblBusqueda.Text = "Filtre por Nombre:";
            this.lblBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(28, 417);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(293, 23);
            this.txtBusqueda.TabIndex = 50;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // rbtnDni
            // 
            this.rbtnDni.AutoSize = true;
            this.rbtnDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnDni.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.rbtnDni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnDni.Location = new System.Drawing.Point(273, 358);
            this.rbtnDni.Name = "rbtnDni";
            this.rbtnDni.Size = new System.Drawing.Size(45, 18);
            this.rbtnDni.TabIndex = 65;
            this.rbtnDni.TabStop = true;
            this.rbtnDni.Text = "DNI";
            this.rbtnDni.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.rbtnApellido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnApellido.Location = new System.Drawing.Point(186, 358);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(81, 18);
            this.rbtnApellido.TabIndex = 64;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrdenar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOrdenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnOrdenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(30, 355);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(80, 24);
            this.btnOrdenar.TabIndex = 63;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "DATOS DEL ATLETA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarAtl
            // 
            this.btnEditarAtl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditarAtl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarAtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAtl.FlatAppearance.BorderSize = 0;
            this.btnEditarAtl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditarAtl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditarAtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAtl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAtl.ForeColor = System.Drawing.Color.White;
            this.btnEditarAtl.Location = new System.Drawing.Point(465, 358);
            this.btnEditarAtl.Name = "btnEditarAtl";
            this.btnEditarAtl.Size = new System.Drawing.Size(80, 30);
            this.btnEditarAtl.TabIndex = 61;
            this.btnEditarAtl.Text = "Editar";
            this.btnEditarAtl.UseVisualStyleBackColor = false;
            this.btnEditarAtl.Click += new System.EventHandler(this.btnEditarAtl_Click);
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNac.Location = new System.Drawing.Point(417, 29);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(191, 20);
            this.txtFechaNac.TabIndex = 60;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(125, 131);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(191, 20);
            this.txtDir.TabIndex = 59;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(417, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 58;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(353, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 17);
            this.lblEmail.TabIndex = 57;
            this.lblEmail.Text = "Email:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDireccion.Location = new System.Drawing.Point(30, 133);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(88, 17);
            this.lblDireccion.TabIndex = 56;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaNac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFechaNac.Location = new System.Drawing.Point(321, 29);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(88, 17);
            this.lblFechaNac.TabIndex = 55;
            this.lblFechaNac.Text = "Fecha Nac:";
            // 
            // txtGenero
            // 
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.txtGenero.Location = new System.Drawing.Point(417, 79);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(191, 21);
            this.txtGenero.TabIndex = 54;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(417, 106);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(191, 20);
            this.txtPeso.TabIndex = 53;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(124, 105);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(191, 20);
            this.txtAltura.TabIndex = 52;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(125, 79);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(191, 20);
            this.txtNacionalidad.TabIndex = 51;
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.Location = new System.Drawing.Point(124, 157);
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.Size = new System.Drawing.Size(191, 20);
            this.txtEntrenador.TabIndex = 50;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(125, 29);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(191, 20);
            this.txtDni.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(417, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 20);
            this.txtName.TabIndex = 48;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(124, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 20);
            this.txtApellido.TabIndex = 47;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblApellido.Location = new System.Drawing.Point(36, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 17);
            this.lblApellido.TabIndex = 46;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(345, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 17);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Nombre:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblNacionalidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNacionalidad.Location = new System.Drawing.Point(7, 79);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(112, 17);
            this.lblNacionalidad.TabIndex = 44;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblEntrenador
            // 
            this.lblEntrenador.AutoSize = true;
            this.lblEntrenador.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblEntrenador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEntrenador.Location = new System.Drawing.Point(22, 157);
            this.lblEntrenador.Name = "lblEntrenador";
            this.lblEntrenador.Size = new System.Drawing.Size(96, 17);
            this.lblEntrenador.TabIndex = 43;
            this.lblEntrenador.Text = "Entrenador:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPeso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPeso.Location = new System.Drawing.Point(363, 106);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(48, 17);
            this.lblPeso.TabIndex = 42;
            this.lblPeso.Text = "Peso:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGenero.Location = new System.Drawing.Point(347, 79);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 17);
            this.lblGenero.TabIndex = 41;
            this.lblGenero.Text = "Género:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblAltura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAltura.Location = new System.Drawing.Point(54, 105);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(64, 17);
            this.lblAltura.TabIndex = 40;
            this.lblAltura.Text = "Altura:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblDni.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDni.Location = new System.Drawing.Point(78, 29);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(40, 17);
            this.lblDni.TabIndex = 39;
            this.lblDni.Text = "DNI:";
            // 
            // FormEditAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(768, 475);
            this.Controls.Add(this.rbtnDni);
            this.Controls.Add(this.btnDeleteAtleta);
            this.Controls.Add(this.rbtnApellido);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregarAtl);
            this.Controls.Add(this.lblEditAtleta);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnEditarAtl);
            this.Controls.Add(this.btnBorrarFiltro);
            this.Controls.Add(this.dataGridAtleta);
            this.Controls.Add(this.lblTitleCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditAtleta";
            this.Opacity = 0.95D;
            this.Text = "FrmGestionCategoria";
            this.lblTitleCategoria.ResumeLayout(false);
            this.lblTitleCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtleta)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblTitleCategoria;
        private System.Windows.Forms.Label lblAtleta;
        private System.Windows.Forms.DataGridView dataGridAtleta;
        public System.Windows.Forms.Label lblEditAtleta;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnEditarAtl;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.ComboBox txtGenero;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtEntrenador;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEntrenador;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblDni;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDni;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnBorrarFiltro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnAgregarAtl;
        private System.Windows.Forms.Button btnDeleteAtleta;
    }
}