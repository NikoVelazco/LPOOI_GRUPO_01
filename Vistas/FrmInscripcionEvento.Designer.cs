namespace Vistas
{
    partial class FrmInscripcionEvento
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
            this.grpAtletas = new System.Windows.Forms.GroupBox();
            this.cmbListaAtletas = new System.Windows.Forms.ComboBox();
            this.grpCompetencias = new System.Windows.Forms.GroupBox();
            this.cmbListaCompetencias = new System.Windows.Forms.ComboBox();
            this.btnRegistrarEvento = new System.Windows.Forms.Button();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.btnAnularInscripcionEvento = new System.Windows.Forms.Button();
            this.grpHoraInicioCompetencia = new System.Windows.Forms.GroupBox();
            this.txtFechaInicioCompetencia = new System.Windows.Forms.TextBox();
            this.txtHoraInicioCompetencia = new System.Windows.Forms.TextBox();
            this.grpHoraFinCompetencia = new System.Windows.Forms.GroupBox();
            this.txtFechaFinCompetencia = new System.Windows.Forms.TextBox();
            this.txtHoraFinCompetencia = new System.Windows.Forms.TextBox();
            this.pnlRegistrarInscripcionEvento = new System.Windows.Forms.Panel();
            this.pnlAnularInscripcionEvento = new System.Windows.Forms.Panel();
            this.dgvAnularInscripcion = new System.Windows.Forms.DataGridView();
            this.txtBuscarAtleta = new System.Windows.Forms.TextBox();
            this.tabControlEvento = new System.Windows.Forms.TabControl();
            this.tpRegistrarInscripcionEvento = new System.Windows.Forms.TabPage();
            this.tpAnularInscripcionEvento = new System.Windows.Forms.TabPage();
            this.tpRegistrarAcreditacionEvento = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBuscarAtletaAcreditacion = new System.Windows.Forms.GroupBox();
            this.txtBuscarAtletaAcredicacion = new System.Windows.Forms.TextBox();
            this.dgvRegistrarAcreditacion = new System.Windows.Forms.DataGridView();
            this.btnRegistrarAcreditacionEvento = new System.Windows.Forms.Button();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInformacionAtletaAcreditarInscripcion = new System.Windows.Forms.GroupBox();
            this.txtInformacionAtletaAcreditarInscripcion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInformacionAtletaAnularInscripcion = new System.Windows.Forms.TextBox();
            this.lblAtletaRegistrado = new System.Windows.Forms.Label();
            this.lblFechaCompetenciaIncorrecta = new System.Windows.Forms.Label();
            this.grpAtletas.SuspendLayout();
            this.grpCompetencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.grpHoraInicioCompetencia.SuspendLayout();
            this.grpHoraFinCompetencia.SuspendLayout();
            this.pnlRegistrarInscripcionEvento.SuspendLayout();
            this.pnlAnularInscripcionEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnularInscripcion)).BeginInit();
            this.tabControlEvento.SuspendLayout();
            this.tpRegistrarInscripcionEvento.SuspendLayout();
            this.tpAnularInscripcionEvento.SuspendLayout();
            this.tpRegistrarAcreditacionEvento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBuscarAtletaAcreditacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAcreditacion)).BeginInit();
            this.pnlEventos.SuspendLayout();
            this.grpInformacionAtletaAcreditarInscripcion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAtletas
            // 
            this.grpAtletas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpAtletas.Controls.Add(this.cmbListaAtletas);
            this.grpAtletas.Location = new System.Drawing.Point(3, 3);
            this.grpAtletas.Name = "grpAtletas";
            this.grpAtletas.Size = new System.Drawing.Size(307, 50);
            this.grpAtletas.TabIndex = 0;
            this.grpAtletas.TabStop = false;
            this.grpAtletas.Text = "Atletas";
            // 
            // cmbListaAtletas
            // 
            this.cmbListaAtletas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbListaAtletas.FormattingEnabled = true;
            this.cmbListaAtletas.Location = new System.Drawing.Point(6, 19);
            this.cmbListaAtletas.Name = "cmbListaAtletas";
            this.cmbListaAtletas.Size = new System.Drawing.Size(295, 21);
            this.cmbListaAtletas.TabIndex = 1;
            // 
            // grpCompetencias
            // 
            this.grpCompetencias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpCompetencias.Controls.Add(this.cmbListaCompetencias);
            this.grpCompetencias.Location = new System.Drawing.Point(3, 59);
            this.grpCompetencias.Name = "grpCompetencias";
            this.grpCompetencias.Size = new System.Drawing.Size(307, 50);
            this.grpCompetencias.TabIndex = 2;
            this.grpCompetencias.TabStop = false;
            this.grpCompetencias.Text = "Competencias";
            // 
            // cmbListaCompetencias
            // 
            this.cmbListaCompetencias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbListaCompetencias.FormattingEnabled = true;
            this.cmbListaCompetencias.Location = new System.Drawing.Point(6, 19);
            this.cmbListaCompetencias.Name = "cmbListaCompetencias";
            this.cmbListaCompetencias.Size = new System.Drawing.Size(295, 21);
            this.cmbListaCompetencias.TabIndex = 1;
            this.cmbListaCompetencias.SelectedIndexChanged += new System.EventHandler(this.cmbListaCompetencias_SelectedIndexChanged);
            // 
            // btnRegistrarEvento
            // 
            this.btnRegistrarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarEvento.AutoSize = true;
            this.btnRegistrarEvento.Location = new System.Drawing.Point(464, 201);
            this.btnRegistrarEvento.Name = "btnRegistrarEvento";
            this.btnRegistrarEvento.Size = new System.Drawing.Size(113, 23);
            this.btnRegistrarEvento.TabIndex = 3;
            this.btnRegistrarEvento.Text = "Registrar Inscripción";
            this.btnRegistrarEvento.UseVisualStyleBackColor = true;
            this.btnRegistrarEvento.Click += new System.EventHandler(this.btnRegistrarEvento_Click);
            // 
            // dgvEvento
            // 
            this.dgvEvento.AllowUserToAddRows = false;
            this.dgvEvento.AllowUserToResizeColumns = false;
            this.dgvEvento.AllowUserToResizeRows = false;
            this.dgvEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(0, 29);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(597, 110);
            this.dgvEvento.TabIndex = 5;
            // 
            // btnAnularInscripcionEvento
            // 
            this.btnAnularInscripcionEvento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAnularInscripcionEvento.AutoSize = true;
            this.btnAnularInscripcionEvento.Location = new System.Drawing.Point(482, 207);
            this.btnAnularInscripcionEvento.Name = "btnAnularInscripcionEvento";
            this.btnAnularInscripcionEvento.Size = new System.Drawing.Size(101, 23);
            this.btnAnularInscripcionEvento.TabIndex = 6;
            this.btnAnularInscripcionEvento.Text = "Anular Inscripción";
            this.btnAnularInscripcionEvento.UseVisualStyleBackColor = true;
            this.btnAnularInscripcionEvento.Click += new System.EventHandler(this.btnAnularInscripcionEvento_Click);
            // 
            // grpHoraInicioCompetencia
            // 
            this.grpHoraInicioCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpHoraInicioCompetencia.Controls.Add(this.txtFechaInicioCompetencia);
            this.grpHoraInicioCompetencia.Controls.Add(this.txtHoraInicioCompetencia);
            this.grpHoraInicioCompetencia.Location = new System.Drawing.Point(3, 115);
            this.grpHoraInicioCompetencia.Name = "grpHoraInicioCompetencia";
            this.grpHoraInicioCompetencia.Size = new System.Drawing.Size(307, 50);
            this.grpHoraInicioCompetencia.TabIndex = 3;
            this.grpHoraInicioCompetencia.TabStop = false;
            this.grpHoraInicioCompetencia.Text = "Inicio Competencia";
            // 
            // txtFechaInicioCompetencia
            // 
            this.txtFechaInicioCompetencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFechaInicioCompetencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFechaInicioCompetencia.Location = new System.Drawing.Point(6, 19);
            this.txtFechaInicioCompetencia.Name = "txtFechaInicioCompetencia";
            this.txtFechaInicioCompetencia.ReadOnly = true;
            this.txtFechaInicioCompetencia.Size = new System.Drawing.Size(144, 20);
            this.txtFechaInicioCompetencia.TabIndex = 11;
            this.txtFechaInicioCompetencia.Text = "Fecha";
            this.txtFechaInicioCompetencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoraInicioCompetencia
            // 
            this.txtHoraInicioCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoraInicioCompetencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHoraInicioCompetencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtHoraInicioCompetencia.Location = new System.Drawing.Point(156, 19);
            this.txtHoraInicioCompetencia.Name = "txtHoraInicioCompetencia";
            this.txtHoraInicioCompetencia.ReadOnly = true;
            this.txtHoraInicioCompetencia.Size = new System.Drawing.Size(138, 20);
            this.txtHoraInicioCompetencia.TabIndex = 9;
            this.txtHoraInicioCompetencia.Text = "Hora";
            this.txtHoraInicioCompetencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpHoraFinCompetencia
            // 
            this.grpHoraFinCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpHoraFinCompetencia.Controls.Add(this.txtFechaFinCompetencia);
            this.grpHoraFinCompetencia.Controls.Add(this.txtHoraFinCompetencia);
            this.grpHoraFinCompetencia.Location = new System.Drawing.Point(3, 171);
            this.grpHoraFinCompetencia.Name = "grpHoraFinCompetencia";
            this.grpHoraFinCompetencia.Size = new System.Drawing.Size(307, 50);
            this.grpHoraFinCompetencia.TabIndex = 8;
            this.grpHoraFinCompetencia.TabStop = false;
            this.grpHoraFinCompetencia.Text = "Fin Competencia";
            // 
            // txtFechaFinCompetencia
            // 
            this.txtFechaFinCompetencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFechaFinCompetencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFechaFinCompetencia.Location = new System.Drawing.Point(6, 19);
            this.txtFechaFinCompetencia.Name = "txtFechaFinCompetencia";
            this.txtFechaFinCompetencia.ReadOnly = true;
            this.txtFechaFinCompetencia.Size = new System.Drawing.Size(144, 20);
            this.txtFechaFinCompetencia.TabIndex = 12;
            this.txtFechaFinCompetencia.Text = "Fecha";
            this.txtFechaFinCompetencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoraFinCompetencia
            // 
            this.txtHoraFinCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoraFinCompetencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHoraFinCompetencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtHoraFinCompetencia.Location = new System.Drawing.Point(156, 19);
            this.txtHoraFinCompetencia.Name = "txtHoraFinCompetencia";
            this.txtHoraFinCompetencia.ReadOnly = true;
            this.txtHoraFinCompetencia.Size = new System.Drawing.Size(138, 20);
            this.txtHoraFinCompetencia.TabIndex = 10;
            this.txtHoraFinCompetencia.Text = "Hora";
            this.txtHoraFinCompetencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlRegistrarInscripcionEvento
            // 
            this.pnlRegistrarInscripcionEvento.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.lblFechaCompetenciaIncorrecta);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.lblAtletaRegistrado);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.btnRegistrarEvento);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpHoraFinCompetencia);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpCompetencias);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpAtletas);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpHoraInicioCompetencia);
            this.pnlRegistrarInscripcionEvento.Location = new System.Drawing.Point(6, 6);
            this.pnlRegistrarInscripcionEvento.Name = "pnlRegistrarInscripcionEvento";
            this.pnlRegistrarInscripcionEvento.Size = new System.Drawing.Size(580, 227);
            this.pnlRegistrarInscripcionEvento.TabIndex = 9;
            // 
            // pnlAnularInscripcionEvento
            // 
            this.pnlAnularInscripcionEvento.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAnularInscripcionEvento.Controls.Add(this.groupBox2);
            this.pnlAnularInscripcionEvento.Controls.Add(this.groupBox1);
            this.pnlAnularInscripcionEvento.Controls.Add(this.dgvAnularInscripcion);
            this.pnlAnularInscripcionEvento.Controls.Add(this.btnAnularInscripcionEvento);
            this.pnlAnularInscripcionEvento.Location = new System.Drawing.Point(3, 3);
            this.pnlAnularInscripcionEvento.Name = "pnlAnularInscripcionEvento";
            this.pnlAnularInscripcionEvento.Size = new System.Drawing.Size(586, 233);
            this.pnlAnularInscripcionEvento.TabIndex = 10;
            // 
            // dgvAnularInscripcion
            // 
            this.dgvAnularInscripcion.AllowUserToAddRows = false;
            this.dgvAnularInscripcion.AllowUserToResizeColumns = false;
            this.dgvAnularInscripcion.AllowUserToResizeRows = false;
            this.dgvAnularInscripcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnularInscripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAnularInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnularInscripcion.Location = new System.Drawing.Point(3, 63);
            this.dgvAnularInscripcion.Name = "dgvAnularInscripcion";
            this.dgvAnularInscripcion.Size = new System.Drawing.Size(580, 138);
            this.dgvAnularInscripcion.TabIndex = 8;
            // 
            // txtBuscarAtleta
            // 
            this.txtBuscarAtleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscarAtleta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscarAtleta.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarAtleta.Name = "txtBuscarAtleta";
            this.txtBuscarAtleta.Size = new System.Drawing.Size(278, 20);
            this.txtBuscarAtleta.TabIndex = 7;
            this.txtBuscarAtleta.Text = "DNI";
            this.txtBuscarAtleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarAtleta.TextChanged += new System.EventHandler(this.txtBuscarAtleta_TextChanged);
            this.txtBuscarAtleta.Enter += new System.EventHandler(this.txtBuscarAtleta_Enter);
            this.txtBuscarAtleta.Leave += new System.EventHandler(this.txtBuscarAtleta_Leave);
            // 
            // tabControlEvento
            // 
            this.tabControlEvento.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlEvento.Controls.Add(this.tpRegistrarInscripcionEvento);
            this.tabControlEvento.Controls.Add(this.tpAnularInscripcionEvento);
            this.tabControlEvento.Controls.Add(this.tpRegistrarAcreditacionEvento);
            this.tabControlEvento.Location = new System.Drawing.Point(12, 161);
            this.tabControlEvento.Name = "tabControlEvento";
            this.tabControlEvento.SelectedIndex = 0;
            this.tabControlEvento.Size = new System.Drawing.Size(600, 268);
            this.tabControlEvento.TabIndex = 9;
            // 
            // tpRegistrarInscripcionEvento
            // 
            this.tpRegistrarInscripcionEvento.Controls.Add(this.pnlRegistrarInscripcionEvento);
            this.tpRegistrarInscripcionEvento.Location = new System.Drawing.Point(4, 25);
            this.tpRegistrarInscripcionEvento.Name = "tpRegistrarInscripcionEvento";
            this.tpRegistrarInscripcionEvento.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrarInscripcionEvento.Size = new System.Drawing.Size(592, 239);
            this.tpRegistrarInscripcionEvento.TabIndex = 0;
            this.tpRegistrarInscripcionEvento.Text = "Registrar inscripción";
            this.tpRegistrarInscripcionEvento.UseVisualStyleBackColor = true;
            // 
            // tpAnularInscripcionEvento
            // 
            this.tpAnularInscripcionEvento.Controls.Add(this.pnlAnularInscripcionEvento);
            this.tpAnularInscripcionEvento.Location = new System.Drawing.Point(4, 25);
            this.tpAnularInscripcionEvento.Name = "tpAnularInscripcionEvento";
            this.tpAnularInscripcionEvento.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnularInscripcionEvento.Size = new System.Drawing.Size(592, 239);
            this.tpAnularInscripcionEvento.TabIndex = 1;
            this.tpAnularInscripcionEvento.Text = "Anular inscripción";
            this.tpAnularInscripcionEvento.UseVisualStyleBackColor = true;
            // 
            // tpRegistrarAcreditacionEvento
            // 
            this.tpRegistrarAcreditacionEvento.Controls.Add(this.grpInformacionAtletaAcreditarInscripcion);
            this.tpRegistrarAcreditacionEvento.Controls.Add(this.btnRegistrarAcreditacionEvento);
            this.tpRegistrarAcreditacionEvento.Controls.Add(this.dgvRegistrarAcreditacion);
            this.tpRegistrarAcreditacionEvento.Controls.Add(this.grpBuscarAtletaAcreditacion);
            this.tpRegistrarAcreditacionEvento.Location = new System.Drawing.Point(4, 25);
            this.tpRegistrarAcreditacionEvento.Name = "tpRegistrarAcreditacionEvento";
            this.tpRegistrarAcreditacionEvento.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrarAcreditacionEvento.Size = new System.Drawing.Size(592, 239);
            this.tpRegistrarAcreditacionEvento.TabIndex = 2;
            this.tpRegistrarAcreditacionEvento.Text = "Registrar acreditación";
            this.tpRegistrarAcreditacionEvento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarAtleta);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 54);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar atleta por DNI";
            // 
            // grpBuscarAtletaAcreditacion
            // 
            this.grpBuscarAtletaAcreditacion.Controls.Add(this.txtBuscarAtletaAcredicacion);
            this.grpBuscarAtletaAcreditacion.Location = new System.Drawing.Point(6, 6);
            this.grpBuscarAtletaAcreditacion.Name = "grpBuscarAtletaAcreditacion";
            this.grpBuscarAtletaAcreditacion.Size = new System.Drawing.Size(290, 54);
            this.grpBuscarAtletaAcreditacion.TabIndex = 10;
            this.grpBuscarAtletaAcreditacion.TabStop = false;
            this.grpBuscarAtletaAcreditacion.Text = "Buscar atleta por DNI";
            // 
            // txtBuscarAtletaAcredicacion
            // 
            this.txtBuscarAtletaAcredicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarAtletaAcredicacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscarAtletaAcredicacion.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarAtletaAcredicacion.Name = "txtBuscarAtletaAcredicacion";
            this.txtBuscarAtletaAcredicacion.Size = new System.Drawing.Size(278, 20);
            this.txtBuscarAtletaAcredicacion.TabIndex = 7;
            this.txtBuscarAtletaAcredicacion.Text = "DNI";
            this.txtBuscarAtletaAcredicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarAtletaAcredicacion.TextChanged += new System.EventHandler(this.txtBuscarAtletaAcredicacion_TextChanged);
            this.txtBuscarAtletaAcredicacion.Enter += new System.EventHandler(this.txtBuscarAtletaAcredicacion_Enter);
            this.txtBuscarAtletaAcredicacion.Leave += new System.EventHandler(this.txtBuscarAtletaAcredicacion_Leave);
            // 
            // dgvRegistrarAcreditacion
            // 
            this.dgvRegistrarAcreditacion.AllowUserToAddRows = false;
            this.dgvRegistrarAcreditacion.AllowUserToResizeColumns = false;
            this.dgvRegistrarAcreditacion.AllowUserToResizeRows = false;
            this.dgvRegistrarAcreditacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrarAcreditacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistrarAcreditacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarAcreditacion.Location = new System.Drawing.Point(6, 66);
            this.dgvRegistrarAcreditacion.Name = "dgvRegistrarAcreditacion";
            this.dgvRegistrarAcreditacion.Size = new System.Drawing.Size(580, 138);
            this.dgvRegistrarAcreditacion.TabIndex = 11;
            // 
            // btnRegistrarAcreditacionEvento
            // 
            this.btnRegistrarAcreditacionEvento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRegistrarAcreditacionEvento.AutoSize = true;
            this.btnRegistrarAcreditacionEvento.Location = new System.Drawing.Point(465, 210);
            this.btnRegistrarAcreditacionEvento.Name = "btnRegistrarAcreditacionEvento";
            this.btnRegistrarAcreditacionEvento.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrarAcreditacionEvento.TabIndex = 12;
            this.btnRegistrarAcreditacionEvento.Text = "Registrar Acreditación";
            this.btnRegistrarAcreditacionEvento.UseVisualStyleBackColor = true;
            this.btnRegistrarAcreditacionEvento.Click += new System.EventHandler(this.btnRegistrarAcreditacionEvento_Click);
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.label1);
            this.pnlEventos.Controls.Add(this.dgvEvento);
            this.pnlEventos.Location = new System.Drawing.Point(12, 12);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(600, 143);
            this.pnlEventos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eventos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInformacionAtletaAcreditarInscripcion
            // 
            this.grpInformacionAtletaAcreditarInscripcion.Controls.Add(this.txtInformacionAtletaAcreditarInscripcion);
            this.grpInformacionAtletaAcreditarInscripcion.Location = new System.Drawing.Point(299, 6);
            this.grpInformacionAtletaAcreditarInscripcion.Name = "grpInformacionAtletaAcreditarInscripcion";
            this.grpInformacionAtletaAcreditarInscripcion.Size = new System.Drawing.Size(290, 54);
            this.grpInformacionAtletaAcreditarInscripcion.TabIndex = 11;
            this.grpInformacionAtletaAcreditarInscripcion.TabStop = false;
            this.grpInformacionAtletaAcreditarInscripcion.Text = "Atleta";
            // 
            // txtInformacionAtletaAcreditarInscripcion
            // 
            this.txtInformacionAtletaAcreditarInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformacionAtletaAcreditarInscripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInformacionAtletaAcreditarInscripcion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtInformacionAtletaAcreditarInscripcion.Location = new System.Drawing.Point(6, 19);
            this.txtInformacionAtletaAcreditarInscripcion.Name = "txtInformacionAtletaAcreditarInscripcion";
            this.txtInformacionAtletaAcreditarInscripcion.ReadOnly = true;
            this.txtInformacionAtletaAcreditarInscripcion.Size = new System.Drawing.Size(278, 20);
            this.txtInformacionAtletaAcreditarInscripcion.TabIndex = 7;
            this.txtInformacionAtletaAcreditarInscripcion.Text = "Nombre y Apellido";
            this.txtInformacionAtletaAcreditarInscripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInformacionAtletaAnularInscripcion);
            this.groupBox2.Location = new System.Drawing.Point(296, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atleta";
            // 
            // txtInformacionAtletaAnularInscripcion
            // 
            this.txtInformacionAtletaAnularInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformacionAtletaAnularInscripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInformacionAtletaAnularInscripcion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtInformacionAtletaAnularInscripcion.Location = new System.Drawing.Point(6, 19);
            this.txtInformacionAtletaAnularInscripcion.Name = "txtInformacionAtletaAnularInscripcion";
            this.txtInformacionAtletaAnularInscripcion.ReadOnly = true;
            this.txtInformacionAtletaAnularInscripcion.Size = new System.Drawing.Size(278, 20);
            this.txtInformacionAtletaAnularInscripcion.TabIndex = 7;
            this.txtInformacionAtletaAnularInscripcion.Text = "Nombre y Apellido";
            this.txtInformacionAtletaAnularInscripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAtletaRegistrado
            // 
            this.lblAtletaRegistrado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAtletaRegistrado.Location = new System.Drawing.Point(332, 20);
            this.lblAtletaRegistrado.Name = "lblAtletaRegistrado";
            this.lblAtletaRegistrado.Size = new System.Drawing.Size(229, 23);
            this.lblAtletaRegistrado.TabIndex = 9;
            this.lblAtletaRegistrado.Text = "Error Atleta Inscripto";
            this.lblAtletaRegistrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAtletaRegistrado.Visible = false;
            // 
            // lblFechaCompetenciaIncorrecta
            // 
            this.lblFechaCompetenciaIncorrecta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFechaCompetenciaIncorrecta.Location = new System.Drawing.Point(332, 76);
            this.lblFechaCompetenciaIncorrecta.Name = "lblFechaCompetenciaIncorrecta";
            this.lblFechaCompetenciaIncorrecta.Size = new System.Drawing.Size(229, 23);
            this.lblFechaCompetenciaIncorrecta.TabIndex = 10;
            this.lblFechaCompetenciaIncorrecta.Text = "Error Fecha Competencia Incompatible";
            this.lblFechaCompetenciaIncorrecta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFechaCompetenciaIncorrecta.Visible = false;
            // 
            // FrmInscripcionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.tabControlEvento);
            this.Name = "FrmInscripcionEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInscripcionEvento";
            this.Load += new System.EventHandler(this.FrmInscripcionEvento_Load);
            this.grpAtletas.ResumeLayout(false);
            this.grpCompetencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.grpHoraInicioCompetencia.ResumeLayout(false);
            this.grpHoraInicioCompetencia.PerformLayout();
            this.grpHoraFinCompetencia.ResumeLayout(false);
            this.grpHoraFinCompetencia.PerformLayout();
            this.pnlRegistrarInscripcionEvento.ResumeLayout(false);
            this.pnlRegistrarInscripcionEvento.PerformLayout();
            this.pnlAnularInscripcionEvento.ResumeLayout(false);
            this.pnlAnularInscripcionEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnularInscripcion)).EndInit();
            this.tabControlEvento.ResumeLayout(false);
            this.tpRegistrarInscripcionEvento.ResumeLayout(false);
            this.tpAnularInscripcionEvento.ResumeLayout(false);
            this.tpRegistrarAcreditacionEvento.ResumeLayout(false);
            this.tpRegistrarAcreditacionEvento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBuscarAtletaAcreditacion.ResumeLayout(false);
            this.grpBuscarAtletaAcreditacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAcreditacion)).EndInit();
            this.pnlEventos.ResumeLayout(false);
            this.grpInformacionAtletaAcreditarInscripcion.ResumeLayout(false);
            this.grpInformacionAtletaAcreditarInscripcion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAtletas;
        private System.Windows.Forms.ComboBox cmbListaAtletas;
        private System.Windows.Forms.GroupBox grpCompetencias;
        private System.Windows.Forms.ComboBox cmbListaCompetencias;
        private System.Windows.Forms.Button btnRegistrarEvento;
        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.Button btnAnularInscripcionEvento;
        private System.Windows.Forms.GroupBox grpHoraInicioCompetencia;
        private System.Windows.Forms.GroupBox grpHoraFinCompetencia;
        private System.Windows.Forms.Panel pnlRegistrarInscripcionEvento;
        private System.Windows.Forms.Panel pnlAnularInscripcionEvento;
        private System.Windows.Forms.DataGridView dgvAnularInscripcion;
        private System.Windows.Forms.TextBox txtBuscarAtleta;
        private System.Windows.Forms.TabControl tabControlEvento;
        private System.Windows.Forms.TabPage tpRegistrarInscripcionEvento;
        private System.Windows.Forms.TabPage tpAnularInscripcionEvento;
        private System.Windows.Forms.TabPage tpRegistrarAcreditacionEvento;
        private System.Windows.Forms.TextBox txtHoraInicioCompetencia;
        private System.Windows.Forms.TextBox txtFechaInicioCompetencia;
        private System.Windows.Forms.TextBox txtFechaFinCompetencia;
        private System.Windows.Forms.TextBox txtHoraFinCompetencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarAcreditacionEvento;
        private System.Windows.Forms.DataGridView dgvRegistrarAcreditacion;
        private System.Windows.Forms.GroupBox grpBuscarAtletaAcreditacion;
        private System.Windows.Forms.TextBox txtBuscarAtletaAcredicacion;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpInformacionAtletaAcreditarInscripcion;
        private System.Windows.Forms.TextBox txtInformacionAtletaAcreditarInscripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInformacionAtletaAnularInscripcion;
        private System.Windows.Forms.Label lblFechaCompetenciaIncorrecta;
        private System.Windows.Forms.Label lblAtletaRegistrado;
    }
}