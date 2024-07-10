namespace Vistas
{
    partial class FrmCronometraje
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
            this.cmbAtletas = new System.Windows.Forms.ComboBox();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblAtletas = new System.Windows.Forms.Label();
            this.lblCompetencias = new System.Windows.Forms.Label();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.txtMinutoFinal = new System.Windows.Forms.TextBox();
            this.txtSegundoFinal = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnAutoCompletarFinal = new System.Windows.Forms.Button();
            this.btnAutoCompletarInicio = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendarInicial = new System.Windows.Forms.MonthCalendar();
            this.lblSegundosInicial = new System.Windows.Forms.Label();
            this.lblMinutosInicial = new System.Windows.Forms.Label();
            this.lblHoraInicial = new System.Windows.Forms.Label();
            this.txtSegundoInicial = new System.Windows.Forms.TextBox();
            this.txtMinutoInicial = new System.Windows.Forms.TextBox();
            this.txtHoraInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarFinal = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAtletas = new System.Windows.Forms.DataGridView();
            this.dataGridCompetencia = new System.Windows.Forms.DataGridView();
            this.lblListaAtletas = new System.Windows.Forms.Label();
            this.lblListaCompetencias = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAtletas
            // 
            this.cmbAtletas.FormattingEnabled = true;
            this.cmbAtletas.Location = new System.Drawing.Point(16, 65);
            this.cmbAtletas.Name = "cmbAtletas";
            this.cmbAtletas.Size = new System.Drawing.Size(205, 21);
            this.cmbAtletas.TabIndex = 0;
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(350, 65);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(205, 21);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // lblAtletas
            // 
            this.lblAtletas.AutoSize = true;
            this.lblAtletas.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtletas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAtletas.Location = new System.Drawing.Point(13, 44);
            this.lblAtletas.Name = "lblAtletas";
            this.lblAtletas.Size = new System.Drawing.Size(64, 18);
            this.lblAtletas.TabIndex = 2;
            this.lblAtletas.Text = "Atleta:";
            // 
            // lblCompetencias
            // 
            this.lblCompetencias.AutoSize = true;
            this.lblCompetencias.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCompetencias.Location = new System.Drawing.Point(350, 44);
            this.lblCompetencias.Name = "lblCompetencias";
            this.lblCompetencias.Size = new System.Drawing.Size(104, 18);
            this.lblCompetencias.TabIndex = 3;
            this.lblCompetencias.Text = "Competencias";
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(312, 363);
            this.txtHoraFinal.MaxLength = 2;
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(73, 20);
            this.txtHoraFinal.TabIndex = 4;
            this.txtHoraFinal.UseWaitCursor = true;
            // 
            // txtMinutoFinal
            // 
            this.txtMinutoFinal.Location = new System.Drawing.Point(402, 363);
            this.txtMinutoFinal.MaxLength = 2;
            this.txtMinutoFinal.Name = "txtMinutoFinal";
            this.txtMinutoFinal.Size = new System.Drawing.Size(73, 20);
            this.txtMinutoFinal.TabIndex = 5;
            this.txtMinutoFinal.UseWaitCursor = true;
            // 
            // txtSegundoFinal
            // 
            this.txtSegundoFinal.Location = new System.Drawing.Point(491, 363);
            this.txtSegundoFinal.MaxLength = 2;
            this.txtSegundoFinal.Name = "txtSegundoFinal";
            this.txtSegundoFinal.Size = new System.Drawing.Size(73, 20);
            this.txtSegundoFinal.TabIndex = 6;
            this.txtSegundoFinal.UseWaitCursor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(311, 336);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(40, 18);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMinutos.Location = new System.Drawing.Point(399, 336);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(64, 18);
            this.lblMinutos.TabIndex = 8;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSegundos.Location = new System.Drawing.Point(488, 336);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(72, 18);
            this.lblSegundos.TabIndex = 9;
            this.lblSegundos.Text = "Segundos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(4, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 46);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelContenedor.Controls.Add(this.btnAutoCompletarFinal);
            this.panelContenedor.Controls.Add(this.btnAutoCompletarInicio);
            this.panelContenedor.Controls.Add(this.cmbEstado);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.calendarInicial);
            this.panelContenedor.Controls.Add(this.lblSegundosInicial);
            this.panelContenedor.Controls.Add(this.lblMinutosInicial);
            this.panelContenedor.Controls.Add(this.lblHoraInicial);
            this.panelContenedor.Controls.Add(this.txtSegundoInicial);
            this.panelContenedor.Controls.Add(this.txtMinutoInicial);
            this.panelContenedor.Controls.Add(this.txtHoraInicial);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.calendarFinal);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.btnGuardar);
            this.panelContenedor.Controls.Add(this.lblSegundos);
            this.panelContenedor.Controls.Add(this.cmbAtletas);
            this.panelContenedor.Controls.Add(this.lblMinutos);
            this.panelContenedor.Controls.Add(this.lblAtletas);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.cmbCompetencias);
            this.panelContenedor.Controls.Add(this.txtSegundoFinal);
            this.panelContenedor.Controls.Add(this.lblCompetencias);
            this.panelContenedor.Controls.Add(this.txtMinutoFinal);
            this.panelContenedor.Controls.Add(this.txtHoraFinal);
            this.panelContenedor.Location = new System.Drawing.Point(534, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(619, 523);
            this.panelContenedor.TabIndex = 49;
            // 
            // btnAutoCompletarFinal
            // 
            this.btnAutoCompletarFinal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAutoCompletarFinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutoCompletarFinal.Location = new System.Drawing.Point(557, 165);
            this.btnAutoCompletarFinal.Name = "btnAutoCompletarFinal";
            this.btnAutoCompletarFinal.Size = new System.Drawing.Size(62, 68);
            this.btnAutoCompletarFinal.TabIndex = 64;
            this.btnAutoCompletarFinal.Text = "Auto\r\nCompletar";
            this.btnAutoCompletarFinal.UseVisualStyleBackColor = false;
            this.btnAutoCompletarFinal.Click += new System.EventHandler(this.btnAutoCompletarFinal_Click);
            // 
            // btnAutoCompletarInicio
            // 
            this.btnAutoCompletarInicio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAutoCompletarInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutoCompletarInicio.Location = new System.Drawing.Point(250, 165);
            this.btnAutoCompletarInicio.Name = "btnAutoCompletarInicio";
            this.btnAutoCompletarInicio.Size = new System.Drawing.Size(62, 68);
            this.btnAutoCompletarInicio.TabIndex = 63;
            this.btnAutoCompletarInicio.Text = "Auto\r\nCompletar";
            this.btnAutoCompletarInicio.UseVisualStyleBackColor = false;
            this.btnAutoCompletarInicio.Click += new System.EventHandler(this.btnAutoCompletarInicio_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Inscripto",
            "Acreditado",
            "Anulado",
            "Abandono",
            "Descalificado"});
            this.cmbEstado.Location = new System.Drawing.Point(3, 423);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(75, 21);
            this.cmbEstado.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(4, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "ESTADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "FECHA Y HORA INICIAL\r\n";
            // 
            // calendarInicial
            // 
            this.calendarInicial.Location = new System.Drawing.Point(4, 165);
            this.calendarInicial.Name = "calendarInicial";
            this.calendarInicial.TabIndex = 58;
            // 
            // lblSegundosInicial
            // 
            this.lblSegundosInicial.AutoSize = true;
            this.lblSegundosInicial.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundosInicial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSegundosInicial.Location = new System.Drawing.Point(181, 336);
            this.lblSegundosInicial.Name = "lblSegundosInicial";
            this.lblSegundosInicial.Size = new System.Drawing.Size(72, 18);
            this.lblSegundosInicial.TabIndex = 57;
            this.lblSegundosInicial.Text = "Segundos";
            // 
            // lblMinutosInicial
            // 
            this.lblMinutosInicial.AutoSize = true;
            this.lblMinutosInicial.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutosInicial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMinutosInicial.Location = new System.Drawing.Point(92, 336);
            this.lblMinutosInicial.Name = "lblMinutosInicial";
            this.lblMinutosInicial.Size = new System.Drawing.Size(64, 18);
            this.lblMinutosInicial.TabIndex = 56;
            this.lblMinutosInicial.Text = "Minutos";
            // 
            // lblHoraInicial
            // 
            this.lblHoraInicial.AutoSize = true;
            this.lblHoraInicial.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHoraInicial.Location = new System.Drawing.Point(4, 336);
            this.lblHoraInicial.Name = "lblHoraInicial";
            this.lblHoraInicial.Size = new System.Drawing.Size(40, 18);
            this.lblHoraInicial.TabIndex = 55;
            this.lblHoraInicial.Text = "Hora";
            // 
            // txtSegundoInicial
            // 
            this.txtSegundoInicial.Location = new System.Drawing.Point(184, 363);
            this.txtSegundoInicial.MaxLength = 2;
            this.txtSegundoInicial.Name = "txtSegundoInicial";
            this.txtSegundoInicial.Size = new System.Drawing.Size(73, 20);
            this.txtSegundoInicial.TabIndex = 54;
            this.txtSegundoInicial.UseWaitCursor = true;
            // 
            // txtMinutoInicial
            // 
            this.txtMinutoInicial.Location = new System.Drawing.Point(95, 363);
            this.txtMinutoInicial.MaxLength = 2;
            this.txtMinutoInicial.Name = "txtMinutoInicial";
            this.txtMinutoInicial.Size = new System.Drawing.Size(73, 20);
            this.txtMinutoInicial.TabIndex = 53;
            this.txtMinutoInicial.UseWaitCursor = true;
            // 
            // txtHoraInicial
            // 
            this.txtHoraInicial.Location = new System.Drawing.Point(5, 363);
            this.txtHoraInicial.MaxLength = 2;
            this.txtHoraInicial.Name = "txtHoraInicial";
            this.txtHoraInicial.Size = new System.Drawing.Size(73, 20);
            this.txtHoraInicial.TabIndex = 52;
            this.txtHoraInicial.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(311, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "FECHA Y HORA FINAL";
            // 
            // calendarFinal
            // 
            this.calendarFinal.Location = new System.Drawing.Point(311, 165);
            this.calendarFinal.Name = "calendarFinal";
            this.calendarFinal.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "DATOS DEL EVENTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridAtletas
            // 
            this.dataGridAtletas.AllowUserToOrderColumns = true;
            this.dataGridAtletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAtletas.Location = new System.Drawing.Point(3, 183);
            this.dataGridAtletas.Name = "dataGridAtletas";
            this.dataGridAtletas.Size = new System.Drawing.Size(453, 144);
            this.dataGridAtletas.TabIndex = 50;
            this.dataGridAtletas.SelectionChanged += new System.EventHandler(this.dataGridAtletas_SelectionChanged);
            // 
            // dataGridCompetencia
            // 
            this.dataGridCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompetencia.Location = new System.Drawing.Point(3, 365);
            this.dataGridCompetencia.Name = "dataGridCompetencia";
            this.dataGridCompetencia.Size = new System.Drawing.Size(453, 140);
            this.dataGridCompetencia.TabIndex = 51;
            this.dataGridCompetencia.SelectionChanged += new System.EventHandler(this.dataGridCompetencia_SelectionChanged);
            // 
            // lblListaAtletas
            // 
            this.lblListaAtletas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListaAtletas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblListaAtletas.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaAtletas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblListaAtletas.Location = new System.Drawing.Point(0, 165);
            this.lblListaAtletas.Margin = new System.Windows.Forms.Padding(4);
            this.lblListaAtletas.Name = "lblListaAtletas";
            this.lblListaAtletas.Size = new System.Drawing.Size(517, 21);
            this.lblListaAtletas.TabIndex = 52;
            this.lblListaAtletas.Text = "LISTA DE ATLETAS";
            this.lblListaAtletas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaCompetencias
            // 
            this.lblListaCompetencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListaCompetencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblListaCompetencias.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCompetencias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblListaCompetencias.Location = new System.Drawing.Point(0, 347);
            this.lblListaCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.lblListaCompetencias.Name = "lblListaCompetencias";
            this.lblListaCompetencias.Size = new System.Drawing.Size(517, 21);
            this.lblListaCompetencias.TabIndex = 53;
            this.lblListaCompetencias.Text = "LISTA DE COMPETENCIAS";
            this.lblListaCompetencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCronometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1155, 523);
            this.Controls.Add(this.lblListaCompetencias);
            this.Controls.Add(this.lblListaAtletas);
            this.Controls.Add(this.dataGridCompetencia);
            this.Controls.Add(this.dataGridAtletas);
            this.Controls.Add(this.panelContenedor);
            this.Name = "FrmCronometraje";
            this.Text = "FrmCronometraje";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAtletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompetencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAtletas;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblAtletas;
        private System.Windows.Forms.Label lblCompetencias;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.TextBox txtMinutoFinal;
        private System.Windows.Forms.TextBox txtSegundoFinal;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAtletas;
        private System.Windows.Forms.DataGridView dataGridCompetencia;
        public System.Windows.Forms.Label lblListaAtletas;
        public System.Windows.Forms.Label lblListaCompetencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendarFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarInicial;
        private System.Windows.Forms.Label lblSegundosInicial;
        private System.Windows.Forms.Label lblMinutosInicial;
        private System.Windows.Forms.Label lblHoraInicial;
        private System.Windows.Forms.TextBox txtSegundoInicial;
        private System.Windows.Forms.TextBox txtMinutoInicial;
        private System.Windows.Forms.TextBox txtHoraInicial;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAutoCompletarFinal;
        private System.Windows.Forms.Button btnAutoCompletarInicio;
    }
}