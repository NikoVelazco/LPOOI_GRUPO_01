namespace Vistas
{
    partial class FrmGestionCompetencia
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
            this.panelGestorCompetencia = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteCompetencia = new System.Windows.Forms.Button();
            this.btnEditCompetencia = new System.Windows.Forms.Button();
            this.btnGuardarCompetencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtOrganizador = new System.Windows.Forms.TextBox();
            this.lblGestorUser = new System.Windows.Forms.Label();
            this.dataGridCompetencia = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSponsors = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblTitleUser.SuspendLayout();
            this.panelGestorCompetencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompetencia)).BeginInit();
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
            this.lblTitleUser.TabIndex = 1;
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.Gold;
            this.lblGestion.Location = new System.Drawing.Point(257, 5);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(230, 22);
            this.lblGestion.TabIndex = 18;
            this.lblGestion.Text = "GESTIÓN DE COMPETENCIA";
            // 
            // panelGestorCompetencia
            // 
            this.panelGestorCompetencia.Controls.Add(this.cmbDisciplina);
            this.panelGestorCompetencia.Controls.Add(this.label7);
            this.panelGestorCompetencia.Controls.Add(this.cmbCategoria);
            this.panelGestorCompetencia.Controls.Add(this.label6);
            this.panelGestorCompetencia.Controls.Add(this.cmbEstado);
            this.panelGestorCompetencia.Controls.Add(this.label5);
            this.panelGestorCompetencia.Controls.Add(this.txtSponsors);
            this.panelGestorCompetencia.Controls.Add(this.label4);
            this.panelGestorCompetencia.Controls.Add(this.dtpFechaFin);
            this.panelGestorCompetencia.Controls.Add(this.label3);
            this.panelGestorCompetencia.Controls.Add(this.dtpFechaInicio);
            this.panelGestorCompetencia.Controls.Add(this.label2);
            this.panelGestorCompetencia.Controls.Add(this.btnReset);
            this.panelGestorCompetencia.Controls.Add(this.btnDeleteCompetencia);
            this.panelGestorCompetencia.Controls.Add(this.btnEditCompetencia);
            this.panelGestorCompetencia.Controls.Add(this.btnGuardarCompetencia);
            this.panelGestorCompetencia.Controls.Add(this.label1);
            this.panelGestorCompetencia.Controls.Add(this.lblApellido);
            this.panelGestorCompetencia.Controls.Add(this.lblPassword);
            this.panelGestorCompetencia.Controls.Add(this.lblNameUser);
            this.panelGestorCompetencia.Controls.Add(this.txtUbicacion);
            this.panelGestorCompetencia.Controls.Add(this.txtDescripcion);
            this.panelGestorCompetencia.Controls.Add(this.txtNombre);
            this.panelGestorCompetencia.Controls.Add(this.txtOrganizador);
            this.panelGestorCompetencia.Controls.Add(this.lblGestorUser);
            this.panelGestorCompetencia.Location = new System.Drawing.Point(378, 37);
            this.panelGestorCompetencia.Name = "panelGestorCompetencia";
            this.panelGestorCompetencia.Size = new System.Drawing.Size(330, 388);
            this.panelGestorCompetencia.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(124, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteCompetencia
            // 
            this.btnDeleteCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteCompetencia.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCompetencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCompetencia.FlatAppearance.BorderSize = 0;
            this.btnDeleteCompetencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteCompetencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompetencia.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompetencia.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCompetencia.Location = new System.Drawing.Point(210, 349);
            this.btnDeleteCompetencia.Name = "btnDeleteCompetencia";
            this.btnDeleteCompetencia.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteCompetencia.TabIndex = 41;
            this.btnDeleteCompetencia.Text = "Eliminar";
            this.btnDeleteCompetencia.UseVisualStyleBackColor = false;
            this.btnDeleteCompetencia.Click += new System.EventHandler(this.btnDeleteCompetencia_Click);
            // 
            // btnEditCompetencia
            // 
            this.btnEditCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCompetencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditCompetencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCompetencia.FlatAppearance.BorderSize = 0;
            this.btnEditCompetencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditCompetencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCompetencia.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompetencia.ForeColor = System.Drawing.Color.White;
            this.btnEditCompetencia.Location = new System.Drawing.Point(210, 313);
            this.btnEditCompetencia.Name = "btnEditCompetencia";
            this.btnEditCompetencia.Size = new System.Drawing.Size(80, 30);
            this.btnEditCompetencia.TabIndex = 40;
            this.btnEditCompetencia.Text = "Editar";
            this.btnEditCompetencia.UseVisualStyleBackColor = false;
            this.btnEditCompetencia.Click += new System.EventHandler(this.btnEditCompetencia_Click);
            // 
            // btnGuardarCompetencia
            // 
            this.btnGuardarCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarCompetencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCompetencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCompetencia.FlatAppearance.BorderSize = 0;
            this.btnGuardarCompetencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarCompetencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCompetencia.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCompetencia.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCompetencia.Location = new System.Drawing.Point(124, 313);
            this.btnGuardarCompetencia.Name = "btnGuardarCompetencia";
            this.btnGuardarCompetencia.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarCompetencia.TabIndex = 38;
            this.btnGuardarCompetencia.Text = "Guardar";
            this.btnGuardarCompetencia.UseVisualStyleBackColor = false;
            this.btnGuardarCompetencia.Click += new System.EventHandler(this.btnGuardarCompetencia_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(41, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ubicación:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblApellido.Location = new System.Drawing.Point(24, 72);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(111, 38);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Organizador:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblPassword.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPassword.Location = new System.Drawing.Point(25, 55);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 21);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Descripción:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameUser
            // 
            this.lblNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblNameUser.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNameUser.Location = new System.Drawing.Point(4, 30);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(4);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(131, 21);
            this.lblNameUser.TabIndex = 31;
            this.lblNameUser.Text = "Nombre:";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(142, 108);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(169, 20);
            this.txtUbicacion.TabIndex = 28;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(142, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(169, 20);
            this.txtDescripcion.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // txtOrganizador
            // 
            this.txtOrganizador.Location = new System.Drawing.Point(142, 82);
            this.txtOrganizador.Name = "txtOrganizador";
            this.txtOrganizador.Size = new System.Drawing.Size(169, 20);
            this.txtOrganizador.TabIndex = 25;
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
            this.lblGestorUser.Text = "FORMULARIO COMPETENCIA";
            this.lblGestorUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridCompetencia
            // 
            this.dataGridCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompetencia.Location = new System.Drawing.Point(6, 67);
            this.dataGridCompetencia.Name = "dataGridCompetencia";
            this.dataGridCompetencia.Size = new System.Drawing.Size(366, 274);
            this.dataGridCompetencia.TabIndex = 4;
            this.dataGridCompetencia.SelectionChanged += new System.EventHandler(this.dataGridCompetencia_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(30, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fec. Inicio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(142, 134);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaInicio.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fec. Fin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(142, 163);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaFin.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(30, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Sponsors:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSponsors
            // 
            this.txtSponsors.Location = new System.Drawing.Point(142, 192);
            this.txtSponsors.Name = "txtSponsors";
            this.txtSponsors.Size = new System.Drawing.Size(169, 20);
            this.txtSponsors.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label5.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(30, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Estado:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "programado",
            "postergado",
            "reprogramado",
            "cancelado"});
            this.cmbEstado.Location = new System.Drawing.Point(142, 218);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(169, 21);
            this.cmbEstado.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label6.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(30, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Categoria:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(142, 245);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(169, 21);
            this.cmbCategoria.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label7.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(30, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Disciplina:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(142, 272);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(169, 21);
            this.cmbDisciplina.TabIndex = 54;
            // 
            // FrmGestionCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.dataGridCompetencia);
            this.Controls.Add(this.panelGestorCompetencia);
            this.Controls.Add(this.lblTitleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionCompetencia";
            this.Opacity = 0.95D;
            this.Text = "FrmGestionCompetencia";
            this.Load += new System.EventHandler(this.FrmGestionCompetencia_Load);
            this.lblTitleUser.ResumeLayout(false);
            this.lblTitleUser.PerformLayout();
            this.panelGestorCompetencia.ResumeLayout(false);
            this.panelGestorCompetencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompetencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTitleUser;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Panel panelGestorCompetencia;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeleteCompetencia;
        private System.Windows.Forms.Button btnEditCompetencia;
        private System.Windows.Forms.Button btnGuardarCompetencia;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblApellido;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtOrganizador;
        public System.Windows.Forms.Label lblGestorUser;
        private System.Windows.Forms.DataGridView dataGridCompetencia;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtSponsors;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        public System.Windows.Forms.Label label7;
    }
}