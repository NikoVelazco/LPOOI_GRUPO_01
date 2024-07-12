namespace Vistas
{
    partial class FrmGestionEvento
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
            this.grpInformacionAtletaAnularInscripcion = new System.Windows.Forms.GroupBox();
            this.lblInformacionAtletaAnularInscripcion = new System.Windows.Forms.Label();
            this.grpBuscarAtletaPorDniAnularInscripcion = new System.Windows.Forms.GroupBox();
            this.txtBuscarAtleta = new System.Windows.Forms.TextBox();
            this.dgvAnularInscripcion = new System.Windows.Forms.DataGridView();
            this.tabControlEvento = new System.Windows.Forms.TabControl();
            this.tpRegistrarInscripcionEvento = new System.Windows.Forms.TabPage();
            this.tpAnularInscripcionEvento = new System.Windows.Forms.TabPage();
            this.tpRegistrarAcreditacionEvento = new System.Windows.Forms.TabPage();
            this.grpInformacionAtletaAcreditarInscripcion = new System.Windows.Forms.GroupBox();
            this.lblInformacionAtletaRegistrarAcreditacion = new System.Windows.Forms.Label();
            this.btnRegistrarAcreditacionEvento = new System.Windows.Forms.Button();
            this.dgvRegistrarAcreditacion = new System.Windows.Forms.DataGridView();
            this.grpBuscarAtletaAcreditacion = new System.Windows.Forms.GroupBox();
            this.txtBuscarAtletaAcredicacion = new System.Windows.Forms.TextBox();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.lblTitleUser = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.grpAtletas.SuspendLayout();
            this.grpCompetencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.grpHoraInicioCompetencia.SuspendLayout();
            this.grpHoraFinCompetencia.SuspendLayout();
            this.pnlRegistrarInscripcionEvento.SuspendLayout();
            this.pnlAnularInscripcionEvento.SuspendLayout();
            this.grpInformacionAtletaAnularInscripcion.SuspendLayout();
            this.grpBuscarAtletaPorDniAnularInscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnularInscripcion)).BeginInit();
            this.tabControlEvento.SuspendLayout();
            this.tpRegistrarInscripcionEvento.SuspendLayout();
            this.tpAnularInscripcionEvento.SuspendLayout();
            this.tpRegistrarAcreditacionEvento.SuspendLayout();
            this.grpInformacionAtletaAcreditarInscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAcreditacion)).BeginInit();
            this.grpBuscarAtletaAcreditacion.SuspendLayout();
            this.pnlEventos.SuspendLayout();
            this.lblTitleUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAtletas
            // 
            this.grpAtletas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpAtletas.Controls.Add(this.cmbListaAtletas);
            this.grpAtletas.Location = new System.Drawing.Point(3, 6);
            this.grpAtletas.Name = "grpAtletas";
            this.grpAtletas.Size = new System.Drawing.Size(307, 50);
            this.grpAtletas.TabIndex = 0;
            this.grpAtletas.TabStop = false;
            this.grpAtletas.Text = "Atletas";
            // 
            // cmbListaAtletas
            // 
            this.cmbListaAtletas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbListaAtletas.ForeColor = System.Drawing.SystemColors.WindowText;
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
            this.grpCompetencias.Location = new System.Drawing.Point(3, 62);
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
            this.btnRegistrarEvento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarEvento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEvento.Location = new System.Drawing.Point(460, 207);
            this.btnRegistrarEvento.Name = "btnRegistrarEvento";
            this.btnRegistrarEvento.Size = new System.Drawing.Size(123, 23);
            this.btnRegistrarEvento.TabIndex = 3;
            this.btnRegistrarEvento.Text = "Registrar Inscripción";
            this.btnRegistrarEvento.UseVisualStyleBackColor = false;
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
            this.dgvEvento.Location = new System.Drawing.Point(3, 29);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(594, 110);
            this.dgvEvento.TabIndex = 5;
            // 
            // btnAnularInscripcionEvento
            // 
            this.btnAnularInscripcionEvento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAnularInscripcionEvento.AutoSize = true;
            this.btnAnularInscripcionEvento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAnularInscripcionEvento.ForeColor = System.Drawing.Color.White;
            this.btnAnularInscripcionEvento.Location = new System.Drawing.Point(482, 207);
            this.btnAnularInscripcionEvento.Name = "btnAnularInscripcionEvento";
            this.btnAnularInscripcionEvento.Size = new System.Drawing.Size(101, 23);
            this.btnAnularInscripcionEvento.TabIndex = 6;
            this.btnAnularInscripcionEvento.Text = "Anular Inscripción";
            this.btnAnularInscripcionEvento.UseVisualStyleBackColor = false;
            this.btnAnularInscripcionEvento.Click += new System.EventHandler(this.btnAnularInscripcionEvento_Click);
            // 
            // grpHoraInicioCompetencia
            // 
            this.grpHoraInicioCompetencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpHoraInicioCompetencia.Controls.Add(this.txtFechaInicioCompetencia);
            this.grpHoraInicioCompetencia.Controls.Add(this.txtHoraInicioCompetencia);
            this.grpHoraInicioCompetencia.Location = new System.Drawing.Point(3, 118);
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
            this.grpHoraFinCompetencia.Location = new System.Drawing.Point(3, 174);
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
            this.pnlRegistrarInscripcionEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.btnRegistrarEvento);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpHoraFinCompetencia);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpCompetencias);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpAtletas);
            this.pnlRegistrarInscripcionEvento.Controls.Add(this.grpHoraInicioCompetencia);
            this.pnlRegistrarInscripcionEvento.Location = new System.Drawing.Point(3, 3);
            this.pnlRegistrarInscripcionEvento.Name = "pnlRegistrarInscripcionEvento";
            this.pnlRegistrarInscripcionEvento.Size = new System.Drawing.Size(586, 233);
            this.pnlRegistrarInscripcionEvento.TabIndex = 9;
            // 
            // pnlAnularInscripcionEvento
            // 
            this.pnlAnularInscripcionEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pnlAnularInscripcionEvento.Controls.Add(this.grpInformacionAtletaAnularInscripcion);
            this.pnlAnularInscripcionEvento.Controls.Add(this.grpBuscarAtletaPorDniAnularInscripcion);
            this.pnlAnularInscripcionEvento.Controls.Add(this.dgvAnularInscripcion);
            this.pnlAnularInscripcionEvento.Controls.Add(this.btnAnularInscripcionEvento);
            this.pnlAnularInscripcionEvento.Location = new System.Drawing.Point(3, 3);
            this.pnlAnularInscripcionEvento.Name = "pnlAnularInscripcionEvento";
            this.pnlAnularInscripcionEvento.Size = new System.Drawing.Size(586, 233);
            this.pnlAnularInscripcionEvento.TabIndex = 10;
            // 
            // grpInformacionAtletaAnularInscripcion
            // 
            this.grpInformacionAtletaAnularInscripcion.Controls.Add(this.lblInformacionAtletaAnularInscripcion);
            this.grpInformacionAtletaAnularInscripcion.Location = new System.Drawing.Point(296, 3);
            this.grpInformacionAtletaAnularInscripcion.Name = "grpInformacionAtletaAnularInscripcion";
            this.grpInformacionAtletaAnularInscripcion.Size = new System.Drawing.Size(290, 54);
            this.grpInformacionAtletaAnularInscripcion.TabIndex = 12;
            this.grpInformacionAtletaAnularInscripcion.TabStop = false;
            this.grpInformacionAtletaAnularInscripcion.Text = "Atleta";
            // 
            // lblInformacionAtletaAnularInscripcion
            // 
            this.lblInformacionAtletaAnularInscripcion.BackColor = System.Drawing.SystemColors.Control;
            this.lblInformacionAtletaAnularInscripcion.Location = new System.Drawing.Point(6, 19);
            this.lblInformacionAtletaAnularInscripcion.Name = "lblInformacionAtletaAnularInscripcion";
            this.lblInformacionAtletaAnularInscripcion.Size = new System.Drawing.Size(278, 20);
            this.lblInformacionAtletaAnularInscripcion.TabIndex = 8;
            this.lblInformacionAtletaAnularInscripcion.Text = "Nombre y Apellido";
            this.lblInformacionAtletaAnularInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBuscarAtletaPorDniAnularInscripcion
            // 
            this.grpBuscarAtletaPorDniAnularInscripcion.Controls.Add(this.txtBuscarAtleta);
            this.grpBuscarAtletaPorDniAnularInscripcion.Location = new System.Drawing.Point(3, 3);
            this.grpBuscarAtletaPorDniAnularInscripcion.Name = "grpBuscarAtletaPorDniAnularInscripcion";
            this.grpBuscarAtletaPorDniAnularInscripcion.Size = new System.Drawing.Size(290, 54);
            this.grpBuscarAtletaPorDniAnularInscripcion.TabIndex = 9;
            this.grpBuscarAtletaPorDniAnularInscripcion.TabStop = false;
            this.grpBuscarAtletaPorDniAnularInscripcion.Text = "Buscar atleta por DNI";
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
            this.tpRegistrarAcreditacionEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
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
            // 
            // grpInformacionAtletaAcreditarInscripcion
            // 
            this.grpInformacionAtletaAcreditarInscripcion.Controls.Add(this.lblInformacionAtletaRegistrarAcreditacion);
            this.grpInformacionAtletaAcreditarInscripcion.Location = new System.Drawing.Point(299, 6);
            this.grpInformacionAtletaAcreditarInscripcion.Name = "grpInformacionAtletaAcreditarInscripcion";
            this.grpInformacionAtletaAcreditarInscripcion.Size = new System.Drawing.Size(290, 54);
            this.grpInformacionAtletaAcreditarInscripcion.TabIndex = 11;
            this.grpInformacionAtletaAcreditarInscripcion.TabStop = false;
            this.grpInformacionAtletaAcreditarInscripcion.Text = "Atleta";
            // 
            // lblInformacionAtletaRegistrarAcreditacion
            // 
            this.lblInformacionAtletaRegistrarAcreditacion.BackColor = System.Drawing.SystemColors.Control;
            this.lblInformacionAtletaRegistrarAcreditacion.Location = new System.Drawing.Point(6, 19);
            this.lblInformacionAtletaRegistrarAcreditacion.Name = "lblInformacionAtletaRegistrarAcreditacion";
            this.lblInformacionAtletaRegistrarAcreditacion.Size = new System.Drawing.Size(278, 20);
            this.lblInformacionAtletaRegistrarAcreditacion.TabIndex = 9;
            this.lblInformacionAtletaRegistrarAcreditacion.Text = "Nombre y Apellido";
            this.lblInformacionAtletaRegistrarAcreditacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarAcreditacionEvento
            // 
            this.btnRegistrarAcreditacionEvento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRegistrarAcreditacionEvento.AutoSize = true;
            this.btnRegistrarAcreditacionEvento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarAcreditacionEvento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAcreditacionEvento.Location = new System.Drawing.Point(465, 210);
            this.btnRegistrarAcreditacionEvento.Name = "btnRegistrarAcreditacionEvento";
            this.btnRegistrarAcreditacionEvento.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrarAcreditacionEvento.TabIndex = 12;
            this.btnRegistrarAcreditacionEvento.Text = "Registrar Acreditación";
            this.btnRegistrarAcreditacionEvento.UseVisualStyleBackColor = false;
            this.btnRegistrarAcreditacionEvento.Click += new System.EventHandler(this.btnRegistrarAcreditacionEvento_Click);
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
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.dgvEvento);
            this.pnlEventos.Location = new System.Drawing.Point(12, 12);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(600, 143);
            this.pnlEventos.TabIndex = 10;
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(109)))));
            this.lblTitleUser.Controls.Add(this.lblGestion);
            this.lblTitleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleUser.Location = new System.Drawing.Point(0, 0);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(624, 31);
            this.lblTitleUser.TabIndex = 11;
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
            this.lblGestion.Text = "GESTIÓN DE EVENTOS";
            // 
            // FrmGestionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.tabControlEvento);
            this.Name = "FrmGestionEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Eventos";
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
            this.grpInformacionAtletaAnularInscripcion.ResumeLayout(false);
            this.grpBuscarAtletaPorDniAnularInscripcion.ResumeLayout(false);
            this.grpBuscarAtletaPorDniAnularInscripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnularInscripcion)).EndInit();
            this.tabControlEvento.ResumeLayout(false);
            this.tpRegistrarInscripcionEvento.ResumeLayout(false);
            this.tpAnularInscripcionEvento.ResumeLayout(false);
            this.tpRegistrarAcreditacionEvento.ResumeLayout(false);
            this.tpRegistrarAcreditacionEvento.PerformLayout();
            this.grpInformacionAtletaAcreditarInscripcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAcreditacion)).EndInit();
            this.grpBuscarAtletaAcreditacion.ResumeLayout(false);
            this.grpBuscarAtletaAcreditacion.PerformLayout();
            this.pnlEventos.ResumeLayout(false);
            this.lblTitleUser.ResumeLayout(false);
            this.lblTitleUser.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBuscarAtletaPorDniAnularInscripcion;
        private System.Windows.Forms.Button btnRegistrarAcreditacionEvento;
        private System.Windows.Forms.DataGridView dgvRegistrarAcreditacion;
        private System.Windows.Forms.GroupBox grpBuscarAtletaAcreditacion;
        private System.Windows.Forms.TextBox txtBuscarAtletaAcredicacion;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.GroupBox grpInformacionAtletaAcreditarInscripcion;
        private System.Windows.Forms.GroupBox grpInformacionAtletaAnularInscripcion;
        private System.Windows.Forms.Label lblInformacionAtletaAnularInscripcion;
        private System.Windows.Forms.Label lblInformacionAtletaRegistrarAcreditacion;
        private System.Windows.Forms.Panel lblTitleUser;
        private System.Windows.Forms.Label lblGestion;
    }
}