namespace Vistas
{
    partial class FrmGestionUsuario
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
            this.lblTitleUser = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.panelGestorUser = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnGuardarUser = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.imgUserNew = new System.Windows.Forms.PictureBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.txtApellidoNomb = new System.Windows.Forms.TextBox();
            this.lblGestorUser = new System.Windows.Forms.Label();
            this.panelConsultaUser = new System.Windows.Forms.Panel();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.rbtnDesc = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rbtnAsc = new System.Windows.Forms.RadioButton();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblTitleUser.SuspendLayout();
            this.panelGestorUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserNew)).BeginInit();
            this.panelConsultaUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(109)))));
            this.lblTitleUser.Controls.Add(this.lblGestion);
            this.lblTitleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleUser.Location = new System.Drawing.Point(0, 0);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(720, 31);
            this.lblTitleUser.TabIndex = 0;
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.Gold;
            this.lblGestion.Location = new System.Drawing.Point(257, 5);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(190, 22);
            this.lblGestion.TabIndex = 18;
            this.lblGestion.Text = "GESTIÓN DE USUARIO";
            // 
            // panelGestorUser
            // 
            this.panelGestorUser.Controls.Add(this.btnLimpiar);
            this.panelGestorUser.Controls.Add(this.btnDeleteUser);
            this.panelGestorUser.Controls.Add(this.btnEditUser);
            this.panelGestorUser.Controls.Add(this.btnGuardarUser);
            this.panelGestorUser.Controls.Add(this.btnLoadImage);
            this.panelGestorUser.Controls.Add(this.imgUserNew);
            this.panelGestorUser.Controls.Add(this.lblImagen);
            this.panelGestorUser.Controls.Add(this.label1);
            this.panelGestorUser.Controls.Add(this.lblApellido);
            this.panelGestorUser.Controls.Add(this.lblPassword);
            this.panelGestorUser.Controls.Add(this.lblNameUser);
            this.panelGestorUser.Controls.Add(this.lblRol);
            this.panelGestorUser.Controls.Add(this.txtRol);
            this.panelGestorUser.Controls.Add(this.txtEmail);
            this.panelGestorUser.Controls.Add(this.txtPassword);
            this.panelGestorUser.Controls.Add(this.txtNameUser);
            this.panelGestorUser.Controls.Add(this.txtApellidoNomb);
            this.panelGestorUser.Controls.Add(this.lblGestorUser);
            this.panelGestorUser.Location = new System.Drawing.Point(383, 37);
            this.panelGestorUser.Name = "panelGestorUser";
            this.panelGestorUser.Size = new System.Drawing.Size(330, 388);
            this.panelGestorUser.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(124, 349);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(210, 349);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteUser.TabIndex = 41;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(210, 313);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(80, 30);
            this.btnEditUser.TabIndex = 40;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnGuardarUser
            // 
            this.btnGuardarUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUser.FlatAppearance.BorderSize = 0;
            this.btnGuardarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUser.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUser.Location = new System.Drawing.Point(124, 313);
            this.btnGuardarUser.Name = "btnGuardarUser";
            this.btnGuardarUser.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarUser.TabIndex = 38;
            this.btnGuardarUser.Text = "Guardar";
            this.btnGuardarUser.UseVisualStyleBackColor = false;
            this.btnGuardarUser.Click += new System.EventHandler(this.btnGuardarUser_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoadImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadImage.FlatAppearance.BorderSize = 0;
            this.btnLoadImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnLoadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.Location = new System.Drawing.Point(220, 235);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(92, 48);
            this.btnLoadImage.TabIndex = 37;
            this.btnLoadImage.Text = "Cargar Imagen";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // imgUserNew
            // 
            this.imgUserNew.Location = new System.Drawing.Point(143, 226);
            this.imgUserNew.Name = "imgUserNew";
            this.imgUserNew.Size = new System.Drawing.Size(66, 72);
            this.imgUserNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUserNew.TabIndex = 36;
            this.imgUserNew.TabStop = false;
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblImagen.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblImagen.Location = new System.Drawing.Point(68, 248);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(68, 21);
            this.lblImagen.TabIndex = 35;
            this.lblImagen.Text = "Imagen:";
            this.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(68, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Email:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblApellido.Location = new System.Drawing.Point(8, 149);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(128, 38);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Apellido y Nombre";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPassword.Location = new System.Drawing.Point(36, 120);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 21);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameUser
            // 
            this.lblNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblNameUser.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNameUser.Location = new System.Drawing.Point(5, 83);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(4);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(131, 21);
            this.lblNameUser.TabIndex = 31;
            this.lblNameUser.Text = "Nombre Usuario:";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblRol.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRol.Location = new System.Drawing.Point(77, 44);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(59, 21);
            this.lblRol.TabIndex = 30;
            this.lblRol.Text = "Rol:";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRol
            // 
            this.txtRol.FormattingEnabled = true;
            this.txtRol.Location = new System.Drawing.Point(143, 45);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(169, 21);
            this.txtRol.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(143, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(143, 83);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(169, 20);
            this.txtNameUser.TabIndex = 26;
            // 
            // txtApellidoNomb
            // 
            this.txtApellidoNomb.Location = new System.Drawing.Point(143, 159);
            this.txtApellidoNomb.Name = "txtApellidoNomb";
            this.txtApellidoNomb.Size = new System.Drawing.Size(169, 20);
            this.txtApellidoNomb.TabIndex = 25;
            // 
            // lblGestorUser
            // 
            this.lblGestorUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestorUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblGestorUser.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestorUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGestorUser.Location = new System.Drawing.Point(1, 1);
            this.lblGestorUser.Margin = new System.Windows.Forms.Padding(4);
            this.lblGestorUser.Name = "lblGestorUser";
            this.lblGestorUser.Size = new System.Drawing.Size(325, 21);
            this.lblGestorUser.TabIndex = 8;
            this.lblGestorUser.Text = "FORMULARIO USUARIO";
            this.lblGestorUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelConsultaUser
            // 
            this.panelConsultaUser.Controls.Add(this.dataGridUser);
            this.panelConsultaUser.Controls.Add(this.lblFiltro);
            this.panelConsultaUser.Controls.Add(this.rbtnDesc);
            this.panelConsultaUser.Controls.Add(this.txtBusqueda);
            this.panelConsultaUser.Controls.Add(this.rbtnAsc);
            this.panelConsultaUser.Controls.Add(this.lblConsulta);
            this.panelConsultaUser.Location = new System.Drawing.Point(5, 37);
            this.panelConsultaUser.Name = "panelConsultaUser";
            this.panelConsultaUser.Size = new System.Drawing.Size(372, 386);
            this.panelConsultaUser.TabIndex = 2;
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(12, 105);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(351, 274);
            this.dataGridUser.TabIndex = 32;
            this.dataGridUser.SelectionChanged += new System.EventHandler(this.dataGridUser_SelectionChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFiltro.Location = new System.Drawing.Point(9, 22);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(120, 45);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtrar Por Nombre de Usuario";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnDesc
            // 
            this.rbtnDesc.AutoSize = true;
            this.rbtnDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDesc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtnDesc.Location = new System.Drawing.Point(190, 47);
            this.rbtnDesc.Name = "rbtnDesc";
            this.rbtnDesc.Size = new System.Drawing.Size(53, 22);
            this.rbtnDesc.TabIndex = 31;
            this.rbtnDesc.TabStop = true;
            this.rbtnDesc.Text = "Des";
            this.rbtnDesc.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(131, 26);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(238, 20);
            this.txtBusqueda.TabIndex = 24;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // rbtnAsc
            // 
            this.rbtnAsc.AutoSize = true;
            this.rbtnAsc.Checked = true;
            this.rbtnAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAsc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtnAsc.Location = new System.Drawing.Point(133, 47);
            this.rbtnAsc.Name = "rbtnAsc";
            this.rbtnAsc.Size = new System.Drawing.Size(51, 22);
            this.rbtnAsc.TabIndex = 30;
            this.rbtnAsc.TabStop = true;
            this.rbtnAsc.Text = "Asc";
            this.rbtnAsc.UseVisualStyleBackColor = true;
            this.rbtnAsc.CheckedChanged += new System.EventHandler(this.rbtnAsc_CheckedChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblConsulta.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblConsulta.Location = new System.Drawing.Point(2, 2);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(369, 21);
            this.lblConsulta.TabIndex = 9;
            this.lblConsulta.Text = "CONSULTA";
            this.lblConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.panelConsultaUser);
            this.Controls.Add(this.panelGestorUser);
            this.Controls.Add(this.lblTitleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionUsuario";
            this.Opacity = 0.95D;
            this.Text = "FrmGestionUsuario";
            this.Load += new System.EventHandler(this.FrmGestionUsuario_Load);
            this.lblTitleUser.ResumeLayout(false);
            this.lblTitleUser.PerformLayout();
            this.panelGestorUser.ResumeLayout(false);
            this.panelGestorUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserNew)).EndInit();
            this.panelConsultaUser.ResumeLayout(false);
            this.panelConsultaUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTitleUser;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Panel panelGestorUser;
        private System.Windows.Forms.Panel panelConsultaUser;
        public System.Windows.Forms.Label lblGestorUser;
        public System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rbtnDesc;
        private System.Windows.Forms.RadioButton rbtnAsc;
        public System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtApellidoNomb;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox txtRol;
        public System.Windows.Forms.Label lblNameUser;
        public System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblApellido;
        public System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox imgUserNew;
        public System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnGuardarUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridUser;
    }
}