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
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
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
            this.cmbAtletas.Location = new System.Drawing.Point(27, 142);
            this.cmbAtletas.Name = "cmbAtletas";
            this.cmbAtletas.Size = new System.Drawing.Size(193, 21);
            this.cmbAtletas.TabIndex = 0;
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(27, 232);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(205, 21);
            this.cmbCompetencias.TabIndex = 1;
            // 
            // lblAtletas
            // 
            this.lblAtletas.AutoSize = true;
            this.lblAtletas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAtletas.Location = new System.Drawing.Point(24, 126);
            this.lblAtletas.Name = "lblAtletas";
            this.lblAtletas.Size = new System.Drawing.Size(37, 13);
            this.lblAtletas.TabIndex = 2;
            this.lblAtletas.Text = "Atleta:";
            // 
            // lblCompetencias
            // 
            this.lblCompetencias.AutoSize = true;
            this.lblCompetencias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCompetencias.Location = new System.Drawing.Point(24, 216);
            this.lblCompetencias.Name = "lblCompetencias";
            this.lblCompetencias.Size = new System.Drawing.Size(74, 13);
            this.lblCompetencias.TabIndex = 3;
            this.lblCompetencias.Text = "Competencias";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(6, 340);
            this.txtHora.MaxLength = 2;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(73, 20);
            this.txtHora.TabIndex = 4;
            this.txtHora.UseWaitCursor = true;
            // 
            // txtMinuto
            // 
            this.txtMinuto.Location = new System.Drawing.Point(96, 340);
            this.txtMinuto.MaxLength = 2;
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(73, 20);
            this.txtMinuto.TabIndex = 5;
            this.txtMinuto.UseWaitCursor = true;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(185, 340);
            this.txtSegundo.MaxLength = 2;
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(73, 20);
            this.txtSegundo.TabIndex = 6;
            this.txtSegundo.UseWaitCursor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(5, 313);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMinutos.Location = new System.Drawing.Point(93, 313);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 8;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSegundos.Location = new System.Drawing.Point(182, 313);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 9;
            this.lblSegundos.Text = "Segundos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(6, 400);
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
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.btnGuardar);
            this.panelContenedor.Controls.Add(this.lblSegundos);
            this.panelContenedor.Controls.Add(this.cmbAtletas);
            this.panelContenedor.Controls.Add(this.lblMinutos);
            this.panelContenedor.Controls.Add(this.lblAtletas);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.cmbCompetencias);
            this.panelContenedor.Controls.Add(this.txtSegundo);
            this.panelContenedor.Controls.Add(this.lblCompetencias);
            this.panelContenedor.Controls.Add(this.txtMinuto);
            this.panelContenedor.Controls.Add(this.txtHora);
            this.panelContenedor.Location = new System.Drawing.Point(676, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(269, 453);
            this.panelContenedor.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 21);
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
            this.dataGridAtletas.Size = new System.Drawing.Size(406, 144);
            this.dataGridAtletas.TabIndex = 50;
            this.dataGridAtletas.SelectionChanged += new System.EventHandler(this.dataGridAtletas_SelectionChanged);
            // 
            // dataGridCompetencia
            // 
            this.dataGridCompetencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompetencia.Location = new System.Drawing.Point(3, 365);
            this.dataGridCompetencia.Name = "dataGridCompetencia";
            this.dataGridCompetencia.Size = new System.Drawing.Size(406, 140);
            this.dataGridCompetencia.TabIndex = 51;
            this.dataGridCompetencia.SelectionChanged += new System.EventHandler(this.dataGridCompetencia_SelectionChanged);
            // 
            // lblListaAtletas
            // 
            this.lblListaAtletas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListaAtletas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblListaAtletas.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaAtletas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblListaAtletas.Location = new System.Drawing.Point(0, 155);
            this.lblListaAtletas.Margin = new System.Windows.Forms.Padding(4);
            this.lblListaAtletas.Name = "lblListaAtletas";
            this.lblListaAtletas.Size = new System.Drawing.Size(325, 21);
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
            this.lblListaCompetencias.Location = new System.Drawing.Point(0, 337);
            this.lblListaCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.lblListaCompetencias.Name = "lblListaCompetencias";
            this.lblListaCompetencias.Size = new System.Drawing.Size(325, 21);
            this.lblListaCompetencias.TabIndex = 53;
            this.lblListaCompetencias.Text = "LISTA DE COMPETENCIAS";
            this.lblListaCompetencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCronometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(957, 502);
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
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinuto;
        private System.Windows.Forms.TextBox txtSegundo;
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
    }
}