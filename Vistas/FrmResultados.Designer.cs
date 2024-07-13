namespace Vistas
{
    partial class FrmResultados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblListaResultados = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbListaCompetenciasParaResultados = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblValorCantidadDescalificados = new System.Windows.Forms.Label();
            this.lblCantidadDescalificados = new System.Windows.Forms.Label();
            this.lblValorCantidadParticipantes = new System.Windows.Forms.Label();
            this.lblValorCantidadAbandonos = new System.Windows.Forms.Label();
            this.lblCantidadAbandonos = new System.Windows.Forms.Label();
            this.lblCantidadParticipantes = new System.Windows.Forms.Label();
            this.lblTitleUser = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lblTitleUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.lblTitleUser);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 220);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblListaResultados);
            this.panel2.Controls.Add(this.dgvResultados);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 180);
            this.panel2.TabIndex = 1;
            // 
            // lblListaResultados
            // 
            this.lblListaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListaResultados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblListaResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListaResultados.Location = new System.Drawing.Point(0, 0);
            this.lblListaResultados.Name = "lblListaResultados";
            this.lblListaResultados.Size = new System.Drawing.Size(600, 23);
            this.lblListaResultados.TabIndex = 12;
            this.lblListaResultados.Text = "Listado";
            this.lblListaResultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(0, 26);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(600, 154);
            this.dgvResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbListaCompetenciasParaResultados);
            this.groupBox1.Location = new System.Drawing.Point(303, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Competencia";
            // 
            // cmbListaCompetenciasParaResultados
            // 
            this.cmbListaCompetenciasParaResultados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbListaCompetenciasParaResultados.BackColor = System.Drawing.SystemColors.Window;
            this.cmbListaCompetenciasParaResultados.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbListaCompetenciasParaResultados.FormattingEnabled = true;
            this.cmbListaCompetenciasParaResultados.Location = new System.Drawing.Point(6, 19);
            this.cmbListaCompetenciasParaResultados.Name = "cmbListaCompetenciasParaResultados";
            this.cmbListaCompetenciasParaResultados.Size = new System.Drawing.Size(288, 21);
            this.cmbListaCompetenciasParaResultados.TabIndex = 2;
            this.cmbListaCompetenciasParaResultados.SelectedIndexChanged += new System.EventHandler(this.cmbListaCompetenciasParaResultados_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.groupBox2.Controls.Add(this.lblValorCantidadDescalificados);
            this.groupBox2.Controls.Add(this.lblCantidadDescalificados);
            this.groupBox2.Controls.Add(this.lblValorCantidadParticipantes);
            this.groupBox2.Controls.Add(this.lblValorCantidadAbandonos);
            this.groupBox2.Controls.Add(this.lblCantidadAbandonos);
            this.groupBox2.Controls.Add(this.lblCantidadParticipantes);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atletas";
            // 
            // lblValorCantidadDescalificados
            // 
            this.lblValorCantidadDescalificados.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblValorCantidadDescalificados.Location = new System.Drawing.Point(6, 131);
            this.lblValorCantidadDescalificados.Name = "lblValorCantidadDescalificados";
            this.lblValorCantidadDescalificados.Size = new System.Drawing.Size(288, 23);
            this.lblValorCantidadDescalificados.TabIndex = 5;
            this.lblValorCantidadDescalificados.Text = "- - - -";
            this.lblValorCantidadDescalificados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadDescalificados
            // 
            this.lblCantidadDescalificados.Location = new System.Drawing.Point(6, 108);
            this.lblCantidadDescalificados.Name = "lblCantidadDescalificados";
            this.lblCantidadDescalificados.Size = new System.Drawing.Size(288, 23);
            this.lblCantidadDescalificados.TabIndex = 4;
            this.lblCantidadDescalificados.Text = "Cantidad de descalificados";
            this.lblCantidadDescalificados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorCantidadParticipantes
            // 
            this.lblValorCantidadParticipantes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblValorCantidadParticipantes.Location = new System.Drawing.Point(6, 39);
            this.lblValorCantidadParticipantes.Name = "lblValorCantidadParticipantes";
            this.lblValorCantidadParticipantes.Size = new System.Drawing.Size(288, 23);
            this.lblValorCantidadParticipantes.TabIndex = 3;
            this.lblValorCantidadParticipantes.Text = "- - - -";
            this.lblValorCantidadParticipantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorCantidadAbandonos
            // 
            this.lblValorCantidadAbandonos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblValorCantidadAbandonos.Location = new System.Drawing.Point(6, 85);
            this.lblValorCantidadAbandonos.Name = "lblValorCantidadAbandonos";
            this.lblValorCantidadAbandonos.Size = new System.Drawing.Size(288, 23);
            this.lblValorCantidadAbandonos.TabIndex = 2;
            this.lblValorCantidadAbandonos.Text = "- - - -";
            this.lblValorCantidadAbandonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadAbandonos
            // 
            this.lblCantidadAbandonos.Location = new System.Drawing.Point(6, 62);
            this.lblCantidadAbandonos.Name = "lblCantidadAbandonos";
            this.lblCantidadAbandonos.Size = new System.Drawing.Size(288, 23);
            this.lblCantidadAbandonos.TabIndex = 1;
            this.lblCantidadAbandonos.Text = "Cantidad de abandonos";
            this.lblCantidadAbandonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidadParticipantes
            // 
            this.lblCantidadParticipantes.Location = new System.Drawing.Point(6, 16);
            this.lblCantidadParticipantes.Name = "lblCantidadParticipantes";
            this.lblCantidadParticipantes.Size = new System.Drawing.Size(288, 23);
            this.lblCantidadParticipantes.TabIndex = 0;
            this.lblCantidadParticipantes.Text = "Cantidad de participantes";
            this.lblCantidadParticipantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(109)))));
            this.lblTitleUser.Controls.Add(this.lblGestion);
            this.lblTitleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleUser.Location = new System.Drawing.Point(0, 0);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(600, 31);
            this.lblTitleUser.TabIndex = 15;
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.Gold;
            this.lblGestion.Location = new System.Drawing.Point(257, 5);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(110, 22);
            this.lblGestion.TabIndex = 18;
            this.lblGestion.Text = "RESULTADOS";
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Resultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.lblTitleUser.ResumeLayout(false);
            this.lblTitleUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.ComboBox cmbListaCompetenciasParaResultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblValorCantidadDescalificados;
        private System.Windows.Forms.Label lblCantidadDescalificados;
        private System.Windows.Forms.Label lblValorCantidadParticipantes;
        private System.Windows.Forms.Label lblValorCantidadAbandonos;
        private System.Windows.Forms.Label lblCantidadAbandonos;
        private System.Windows.Forms.Label lblCantidadParticipantes;
        private System.Windows.Forms.Label lblListaResultados;
        private System.Windows.Forms.Panel lblTitleUser;
        private System.Windows.Forms.Label lblGestion;
    }
}