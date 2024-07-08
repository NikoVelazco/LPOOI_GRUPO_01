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
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.dtpHoraInicioCompetencia = new System.Windows.Forms.DateTimePicker();
            this.grpHoraInicioCompetencia = new System.Windows.Forms.GroupBox();
            this.grpHoraFinCompetencia = new System.Windows.Forms.GroupBox();
            this.dtpHoraFinCompetencia = new System.Windows.Forms.DateTimePicker();
            this.pnlInscripcionEvento = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAtletas.SuspendLayout();
            this.grpCompetencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.grpHoraInicioCompetencia.SuspendLayout();
            this.grpHoraFinCompetencia.SuspendLayout();
            this.pnlInscripcionEvento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAtletas
            // 
            this.grpAtletas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAtletas.Controls.Add(this.cmbListaAtletas);
            this.grpAtletas.Location = new System.Drawing.Point(3, 139);
            this.grpAtletas.Name = "grpAtletas";
            this.grpAtletas.Size = new System.Drawing.Size(230, 50);
            this.grpAtletas.TabIndex = 0;
            this.grpAtletas.TabStop = false;
            this.grpAtletas.Text = "Atletas";
            // 
            // cmbListaAtletas
            // 
            this.cmbListaAtletas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbListaAtletas.FormattingEnabled = true;
            this.cmbListaAtletas.Location = new System.Drawing.Point(6, 19);
            this.cmbListaAtletas.Name = "cmbListaAtletas";
            this.cmbListaAtletas.Size = new System.Drawing.Size(218, 21);
            this.cmbListaAtletas.TabIndex = 1;
            // 
            // grpCompetencias
            // 
            this.grpCompetencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCompetencias.Controls.Add(this.cmbListaCompetencias);
            this.grpCompetencias.Location = new System.Drawing.Point(239, 139);
            this.grpCompetencias.Name = "grpCompetencias";
            this.grpCompetencias.Size = new System.Drawing.Size(230, 50);
            this.grpCompetencias.TabIndex = 2;
            this.grpCompetencias.TabStop = false;
            this.grpCompetencias.Text = "Competencias";
            // 
            // cmbListaCompetencias
            // 
            this.cmbListaCompetencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbListaCompetencias.FormattingEnabled = true;
            this.cmbListaCompetencias.Location = new System.Drawing.Point(6, 19);
            this.cmbListaCompetencias.Name = "cmbListaCompetencias";
            this.cmbListaCompetencias.Size = new System.Drawing.Size(218, 21);
            this.cmbListaCompetencias.TabIndex = 1;
            this.cmbListaCompetencias.SelectedIndexChanged += new System.EventHandler(this.cmbListaCompetencias_SelectedIndexChanged);
            // 
            // btnRegistrarEvento
            // 
            this.btnRegistrarEvento.AutoSize = true;
            this.btnRegistrarEvento.Location = new System.Drawing.Point(475, 156);
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
            this.dgvEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(3, 3);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(594, 130);
            this.dgvEvento.TabIndex = 5;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.AutoSize = true;
            this.btnEliminarEvento.Location = new System.Drawing.Point(332, 83);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarEvento.TabIndex = 6;
            this.btnEliminarEvento.Text = "Anular Inscripción";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // dtpHoraInicioCompetencia
            // 
            this.dtpHoraInicioCompetencia.Location = new System.Drawing.Point(6, 19);
            this.dtpHoraInicioCompetencia.Name = "dtpHoraInicioCompetencia";
            this.dtpHoraInicioCompetencia.Size = new System.Drawing.Size(188, 20);
            this.dtpHoraInicioCompetencia.TabIndex = 7;
            // 
            // grpHoraInicioCompetencia
            // 
            this.grpHoraInicioCompetencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHoraInicioCompetencia.Controls.Add(this.dtpHoraInicioCompetencia);
            this.grpHoraInicioCompetencia.Location = new System.Drawing.Point(239, 205);
            this.grpHoraInicioCompetencia.Name = "grpHoraInicioCompetencia";
            this.grpHoraInicioCompetencia.Size = new System.Drawing.Size(230, 50);
            this.grpHoraInicioCompetencia.TabIndex = 3;
            this.grpHoraInicioCompetencia.TabStop = false;
            this.grpHoraInicioCompetencia.Text = "Hora Inicio Competencia";
            // 
            // grpHoraFinCompetencia
            // 
            this.grpHoraFinCompetencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHoraFinCompetencia.Controls.Add(this.dtpHoraFinCompetencia);
            this.grpHoraFinCompetencia.Location = new System.Drawing.Point(3, 205);
            this.grpHoraFinCompetencia.Name = "grpHoraFinCompetencia";
            this.grpHoraFinCompetencia.Size = new System.Drawing.Size(230, 50);
            this.grpHoraFinCompetencia.TabIndex = 8;
            this.grpHoraFinCompetencia.TabStop = false;
            this.grpHoraFinCompetencia.Text = "Hora Fin Competencia";
            // 
            // dtpHoraFinCompetencia
            // 
            this.dtpHoraFinCompetencia.Location = new System.Drawing.Point(6, 19);
            this.dtpHoraFinCompetencia.Name = "dtpHoraFinCompetencia";
            this.dtpHoraFinCompetencia.Size = new System.Drawing.Size(188, 20);
            this.dtpHoraFinCompetencia.TabIndex = 7;
            // 
            // pnlInscripcionEvento
            // 
            this.pnlInscripcionEvento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInscripcionEvento.Controls.Add(this.dgvEvento);
            this.pnlInscripcionEvento.Controls.Add(this.grpHoraFinCompetencia);
            this.pnlInscripcionEvento.Controls.Add(this.grpCompetencias);
            this.pnlInscripcionEvento.Controls.Add(this.grpAtletas);
            this.pnlInscripcionEvento.Controls.Add(this.grpHoraInicioCompetencia);
            this.pnlInscripcionEvento.Controls.Add(this.btnRegistrarEvento);
            this.pnlInscripcionEvento.Location = new System.Drawing.Point(12, 12);
            this.pnlInscripcionEvento.Name = "pnlInscripcionEvento";
            this.pnlInscripcionEvento.Size = new System.Drawing.Size(600, 260);
            this.pnlInscripcionEvento.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnEliminarEvento);
            this.panel1.Location = new System.Drawing.Point(12, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 150);
            this.panel1.TabIndex = 10;
            // 
            // FrmInscripcionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInscripcionEvento);
            this.Name = "FrmInscripcionEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInscripcionEvento";
            this.Load += new System.EventHandler(this.FrmInscripcionEvento_Load);
            this.grpAtletas.ResumeLayout(false);
            this.grpCompetencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.grpHoraInicioCompetencia.ResumeLayout(false);
            this.grpHoraFinCompetencia.ResumeLayout(false);
            this.pnlInscripcionEvento.ResumeLayout(false);
            this.pnlInscripcionEvento.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAtletas;
        private System.Windows.Forms.ComboBox cmbListaAtletas;
        private System.Windows.Forms.GroupBox grpCompetencias;
        private System.Windows.Forms.ComboBox cmbListaCompetencias;
        private System.Windows.Forms.Button btnRegistrarEvento;
        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioCompetencia;
        private System.Windows.Forms.GroupBox grpHoraInicioCompetencia;
        private System.Windows.Forms.GroupBox grpHoraFinCompetencia;
        private System.Windows.Forms.DateTimePicker dtpHoraFinCompetencia;
        private System.Windows.Forms.Panel pnlInscripcionEvento;
        private System.Windows.Forms.Panel panel1;
    }
}