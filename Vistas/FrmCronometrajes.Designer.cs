namespace Vistas
{
    partial class FrmCronometrajes
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
            this.gtpListaAtletas = new System.Windows.Forms.GroupBox();
            this.cmbListaAtletas = new System.Windows.Forms.ComboBox();
            this.grpListaCompetencias = new System.Windows.Forms.GroupBox();
            this.cmbListaCompetencias = new System.Windows.Forms.ComboBox();
            this.pnlInicioEvento = new System.Windows.Forms.Panel();
            this.pnlRegistroCronometrajeHoraFin = new System.Windows.Forms.Panel();
            this.grpFinalizarEvento = new System.Windows.Forms.GroupBox();
            this.lblValorFechaFinEvento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorHoraFinEvento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFinalizarEvento = new System.Windows.Forms.Button();
            this.grpIniciarEvento = new System.Windows.Forms.GroupBox();
            this.lblValorFechaInicioEvento = new System.Windows.Forms.Label();
            this.lblFechaInicioEvento = new System.Windows.Forms.Label();
            this.lblValorHoraInicioEvento = new System.Windows.Forms.Label();
            this.lblHoraInicioEvento = new System.Windows.Forms.Label();
            this.btnIniciarEvento = new System.Windows.Forms.Button();
            this.lblGestionCronometrajes = new System.Windows.Forms.Label();
            this.btnBuscarEvento = new System.Windows.Forms.Button();
            this.pnlRegistroCronometrajeHoraInicio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEventoSegunAtletaCompetencia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUltimoParticipante = new System.Windows.Forms.Label();
            this.gtpListaAtletas.SuspendLayout();
            this.grpListaCompetencias.SuspendLayout();
            this.pnlInicioEvento.SuspendLayout();
            this.pnlRegistroCronometrajeHoraFin.SuspendLayout();
            this.grpFinalizarEvento.SuspendLayout();
            this.grpIniciarEvento.SuspendLayout();
            this.pnlRegistroCronometrajeHoraInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventoSegunAtletaCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // gtpListaAtletas
            // 
            this.gtpListaAtletas.Controls.Add(this.cmbListaAtletas);
            this.gtpListaAtletas.Location = new System.Drawing.Point(3, 26);
            this.gtpListaAtletas.Name = "gtpListaAtletas";
            this.gtpListaAtletas.Size = new System.Drawing.Size(290, 50);
            this.gtpListaAtletas.TabIndex = 1;
            this.gtpListaAtletas.TabStop = false;
            this.gtpListaAtletas.Text = "Atleta";
            // 
            // cmbListaAtletas
            // 
            this.cmbListaAtletas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbListaAtletas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbListaAtletas.FormattingEnabled = true;
            this.cmbListaAtletas.Location = new System.Drawing.Point(6, 19);
            this.cmbListaAtletas.Name = "cmbListaAtletas";
            this.cmbListaAtletas.Size = new System.Drawing.Size(278, 21);
            this.cmbListaAtletas.TabIndex = 4;
            this.cmbListaAtletas.Text = "Seleccione una Atleta";
            // 
            // grpListaCompetencias
            // 
            this.grpListaCompetencias.Controls.Add(this.cmbListaCompetencias);
            this.grpListaCompetencias.Location = new System.Drawing.Point(307, 26);
            this.grpListaCompetencias.Name = "grpListaCompetencias";
            this.grpListaCompetencias.Size = new System.Drawing.Size(290, 50);
            this.grpListaCompetencias.TabIndex = 2;
            this.grpListaCompetencias.TabStop = false;
            this.grpListaCompetencias.Text = "Competencia";
            // 
            // cmbListaCompetencias
            // 
            this.cmbListaCompetencias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbListaCompetencias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbListaCompetencias.FormattingEnabled = true;
            this.cmbListaCompetencias.Location = new System.Drawing.Point(6, 19);
            this.cmbListaCompetencias.Name = "cmbListaCompetencias";
            this.cmbListaCompetencias.Size = new System.Drawing.Size(278, 21);
            this.cmbListaCompetencias.TabIndex = 5;
            this.cmbListaCompetencias.Text = "Seleccione una Competencia";
            // 
            // pnlInicioEvento
            // 
            this.pnlInicioEvento.Controls.Add(this.pnlRegistroCronometrajeHoraFin);
            this.pnlInicioEvento.Controls.Add(this.grpIniciarEvento);
            this.pnlInicioEvento.Controls.Add(this.lblGestionCronometrajes);
            this.pnlInicioEvento.Location = new System.Drawing.Point(12, 12);
            this.pnlInicioEvento.Name = "pnlInicioEvento";
            this.pnlInicioEvento.Size = new System.Drawing.Size(600, 125);
            this.pnlInicioEvento.TabIndex = 3;
            // 
            // pnlRegistroCronometrajeHoraFin
            // 
            this.pnlRegistroCronometrajeHoraFin.Controls.Add(this.grpFinalizarEvento);
            this.pnlRegistroCronometrajeHoraFin.Location = new System.Drawing.Point(236, 25);
            this.pnlRegistroCronometrajeHoraFin.Name = "pnlRegistroCronometrajeHoraFin";
            this.pnlRegistroCronometrajeHoraFin.Size = new System.Drawing.Size(364, 100);
            this.pnlRegistroCronometrajeHoraFin.TabIndex = 13;
            this.pnlRegistroCronometrajeHoraFin.Visible = false;
            // 
            // grpFinalizarEvento
            // 
            this.grpFinalizarEvento.Controls.Add(this.lblUltimoParticipante);
            this.grpFinalizarEvento.Controls.Add(this.lblValorFechaFinEvento);
            this.grpFinalizarEvento.Controls.Add(this.label4);
            this.grpFinalizarEvento.Controls.Add(this.lblValorHoraFinEvento);
            this.grpFinalizarEvento.Controls.Add(this.label6);
            this.grpFinalizarEvento.Controls.Add(this.btnFinalizarEvento);
            this.grpFinalizarEvento.Location = new System.Drawing.Point(134, 0);
            this.grpFinalizarEvento.Name = "grpFinalizarEvento";
            this.grpFinalizarEvento.Size = new System.Drawing.Size(230, 103);
            this.grpFinalizarEvento.TabIndex = 14;
            this.grpFinalizarEvento.TabStop = false;
            this.grpFinalizarEvento.Text = "Finalizar Evento";
            // 
            // lblValorFechaFinEvento
            // 
            this.lblValorFechaFinEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorFechaFinEvento.Location = new System.Drawing.Point(109, 45);
            this.lblValorFechaFinEvento.Name = "lblValorFechaFinEvento";
            this.lblValorFechaFinEvento.Size = new System.Drawing.Size(100, 23);
            this.lblValorFechaFinEvento.TabIndex = 4;
            this.lblValorFechaFinEvento.Text = "- - - -";
            this.lblValorFechaFinEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de fin:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorHoraFinEvento
            // 
            this.lblValorHoraFinEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorHoraFinEvento.Location = new System.Drawing.Point(109, 20);
            this.lblValorHoraFinEvento.Name = "lblValorHoraFinEvento";
            this.lblValorHoraFinEvento.Size = new System.Drawing.Size(100, 23);
            this.lblValorHoraFinEvento.TabIndex = 2;
            this.lblValorHoraFinEvento.Text = "- - - -";
            this.lblValorHoraFinEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora de fin:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarEvento
            // 
            this.btnFinalizarEvento.AutoSize = true;
            this.btnFinalizarEvento.Enabled = false;
            this.btnFinalizarEvento.Location = new System.Drawing.Point(6, 71);
            this.btnFinalizarEvento.Name = "btnFinalizarEvento";
            this.btnFinalizarEvento.Size = new System.Drawing.Size(92, 23);
            this.btnFinalizarEvento.TabIndex = 0;
            this.btnFinalizarEvento.Text = "Finalizar Evento";
            this.btnFinalizarEvento.UseVisualStyleBackColor = true;
            this.btnFinalizarEvento.Click += new System.EventHandler(this.lblFinalizarEvento_Click);
            // 
            // grpIniciarEvento
            // 
            this.grpIniciarEvento.Controls.Add(this.lblValorFechaInicioEvento);
            this.grpIniciarEvento.Controls.Add(this.lblFechaInicioEvento);
            this.grpIniciarEvento.Controls.Add(this.lblValorHoraInicioEvento);
            this.grpIniciarEvento.Controls.Add(this.lblHoraInicioEvento);
            this.grpIniciarEvento.Controls.Add(this.btnIniciarEvento);
            this.grpIniciarEvento.Location = new System.Drawing.Point(0, 26);
            this.grpIniciarEvento.Name = "grpIniciarEvento";
            this.grpIniciarEvento.Size = new System.Drawing.Size(230, 100);
            this.grpIniciarEvento.TabIndex = 2;
            this.grpIniciarEvento.TabStop = false;
            this.grpIniciarEvento.Text = "Iniciar Evento";
            // 
            // lblValorFechaInicioEvento
            // 
            this.lblValorFechaInicioEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorFechaInicioEvento.Location = new System.Drawing.Point(109, 45);
            this.lblValorFechaInicioEvento.Name = "lblValorFechaInicioEvento";
            this.lblValorFechaInicioEvento.Size = new System.Drawing.Size(100, 23);
            this.lblValorFechaInicioEvento.TabIndex = 4;
            this.lblValorFechaInicioEvento.Text = "- - - -";
            this.lblValorFechaInicioEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaInicioEvento
            // 
            this.lblFechaInicioEvento.Location = new System.Drawing.Point(3, 45);
            this.lblFechaInicioEvento.Name = "lblFechaInicioEvento";
            this.lblFechaInicioEvento.Size = new System.Drawing.Size(100, 23);
            this.lblFechaInicioEvento.TabIndex = 3;
            this.lblFechaInicioEvento.Text = "Fecha de inicio:";
            this.lblFechaInicioEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorHoraInicioEvento
            // 
            this.lblValorHoraInicioEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorHoraInicioEvento.Location = new System.Drawing.Point(109, 20);
            this.lblValorHoraInicioEvento.Name = "lblValorHoraInicioEvento";
            this.lblValorHoraInicioEvento.Size = new System.Drawing.Size(100, 23);
            this.lblValorHoraInicioEvento.TabIndex = 2;
            this.lblValorHoraInicioEvento.Text = "- - - -";
            this.lblValorHoraInicioEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraInicioEvento
            // 
            this.lblHoraInicioEvento.Location = new System.Drawing.Point(3, 20);
            this.lblHoraInicioEvento.Name = "lblHoraInicioEvento";
            this.lblHoraInicioEvento.Size = new System.Drawing.Size(100, 23);
            this.lblHoraInicioEvento.TabIndex = 1;
            this.lblHoraInicioEvento.Text = "Hora de inicio:";
            this.lblHoraInicioEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciarEvento
            // 
            this.btnIniciarEvento.AutoSize = true;
            this.btnIniciarEvento.Location = new System.Drawing.Point(6, 71);
            this.btnIniciarEvento.Name = "btnIniciarEvento";
            this.btnIniciarEvento.Size = new System.Drawing.Size(82, 23);
            this.btnIniciarEvento.TabIndex = 0;
            this.btnIniciarEvento.Text = "Iniciar Evento";
            this.btnIniciarEvento.UseVisualStyleBackColor = true;
            this.btnIniciarEvento.Click += new System.EventHandler(this.btnIniciarEvento_Click);
            // 
            // lblGestionCronometrajes
            // 
            this.lblGestionCronometrajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestionCronometrajes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGestionCronometrajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGestionCronometrajes.Location = new System.Drawing.Point(0, 0);
            this.lblGestionCronometrajes.Name = "lblGestionCronometrajes";
            this.lblGestionCronometrajes.Size = new System.Drawing.Size(600, 23);
            this.lblGestionCronometrajes.TabIndex = 12;
            this.lblGestionCronometrajes.Text = "Cronometrajes";
            this.lblGestionCronometrajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarEvento
            // 
            this.btnBuscarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscarEvento.AutoSize = true;
            this.btnBuscarEvento.Location = new System.Drawing.Point(257, 105);
            this.btnBuscarEvento.Name = "btnBuscarEvento";
            this.btnBuscarEvento.Size = new System.Drawing.Size(87, 23);
            this.btnBuscarEvento.TabIndex = 3;
            this.btnBuscarEvento.Text = "Buscar Evento";
            this.btnBuscarEvento.UseVisualStyleBackColor = true;
            this.btnBuscarEvento.Click += new System.EventHandler(this.btnBuscarEvento_Click);
            // 
            // pnlRegistroCronometrajeHoraInicio
            // 
            this.pnlRegistroCronometrajeHoraInicio.Controls.Add(this.label2);
            this.pnlRegistroCronometrajeHoraInicio.Controls.Add(this.dgvEventoSegunAtletaCompetencia);
            this.pnlRegistroCronometrajeHoraInicio.Controls.Add(this.grpListaCompetencias);
            this.pnlRegistroCronometrajeHoraInicio.Controls.Add(this.label1);
            this.pnlRegistroCronometrajeHoraInicio.Controls.Add(this.gtpListaAtletas);
            this.pnlRegistroCronometrajeHoraInicio.Controls.Add(this.btnBuscarEvento);
            this.pnlRegistroCronometrajeHoraInicio.Location = new System.Drawing.Point(12, 144);
            this.pnlRegistroCronometrajeHoraInicio.Name = "pnlRegistroCronometrajeHoraInicio";
            this.pnlRegistroCronometrajeHoraInicio.Size = new System.Drawing.Size(600, 285);
            this.pnlRegistroCronometrajeHoraInicio.TabIndex = 13;
            this.pnlRegistroCronometrajeHoraInicio.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Evento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEventoSegunAtletaCompetencia
            // 
            this.dgvEventoSegunAtletaCompetencia.AllowUserToAddRows = false;
            this.dgvEventoSegunAtletaCompetencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEventoSegunAtletaCompetencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventoSegunAtletaCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventoSegunAtletaCompetencia.Location = new System.Drawing.Point(129, 134);
            this.dgvEventoSegunAtletaCompetencia.Name = "dgvEventoSegunAtletaCompetencia";
            this.dgvEventoSegunAtletaCompetencia.ReadOnly = true;
            this.dgvEventoSegunAtletaCompetencia.Size = new System.Drawing.Size(350, 150);
            this.dgvEventoSegunAtletaCompetencia.TabIndex = 14;
            this.dgvEventoSegunAtletaCompetencia.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEventoSegunAtletaCompetencia_RowStateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registro de tiempos de llegada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUltimoParticipante
            // 
            this.lblUltimoParticipante.Location = new System.Drawing.Point(109, 72);
            this.lblUltimoParticipante.Name = "lblUltimoParticipante";
            this.lblUltimoParticipante.Size = new System.Drawing.Size(100, 23);
            this.lblUltimoParticipante.TabIndex = 5;
            this.lblUltimoParticipante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCronometrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pnlInicioEvento);
            this.Controls.Add(this.pnlRegistroCronometrajeHoraInicio);
            this.Name = "FrmCronometrajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Cronometrajes";
            this.Load += new System.EventHandler(this.FrmCronometrajes_Load);
            this.gtpListaAtletas.ResumeLayout(false);
            this.grpListaCompetencias.ResumeLayout(false);
            this.pnlInicioEvento.ResumeLayout(false);
            this.pnlRegistroCronometrajeHoraFin.ResumeLayout(false);
            this.grpFinalizarEvento.ResumeLayout(false);
            this.grpFinalizarEvento.PerformLayout();
            this.grpIniciarEvento.ResumeLayout(false);
            this.grpIniciarEvento.PerformLayout();
            this.pnlRegistroCronometrajeHoraInicio.ResumeLayout(false);
            this.pnlRegistroCronometrajeHoraInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventoSegunAtletaCompetencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gtpListaAtletas;
        private System.Windows.Forms.GroupBox grpListaCompetencias;
        private System.Windows.Forms.Panel pnlInicioEvento;
        private System.Windows.Forms.Button btnBuscarEvento;
        private System.Windows.Forms.GroupBox grpIniciarEvento;
        private System.Windows.Forms.Label lblValorFechaInicioEvento;
        private System.Windows.Forms.Label lblFechaInicioEvento;
        private System.Windows.Forms.Label lblValorHoraInicioEvento;
        private System.Windows.Forms.Label lblHoraInicioEvento;
        private System.Windows.Forms.Button btnIniciarEvento;
        private System.Windows.Forms.Label lblGestionCronometrajes;
        private System.Windows.Forms.Panel pnlRegistroCronometrajeHoraInicio;
        private System.Windows.Forms.ComboBox cmbListaAtletas;
        private System.Windows.Forms.ComboBox cmbListaCompetencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEventoSegunAtletaCompetencia;
        private System.Windows.Forms.Panel pnlRegistroCronometrajeHoraFin;
        private System.Windows.Forms.GroupBox grpFinalizarEvento;
        private System.Windows.Forms.Label lblValorFechaFinEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorHoraFinEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinalizarEvento;
        private System.Windows.Forms.Label lblUltimoParticipante;
    }
}