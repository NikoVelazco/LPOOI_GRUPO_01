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
            this.panelConsultaUser = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGestorUser = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rbtnDesc = new System.Windows.Forms.RadioButton();
            this.rbtnAsc = new System.Windows.Forms.RadioButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblTitleUser.SuspendLayout();
            this.panelGestorUser.SuspendLayout();
            this.panelConsultaUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblGestion.Size = new System.Drawing.Size(180, 22);
            this.lblGestion.TabIndex = 18;
            this.lblGestion.Text = "GESTIÓN DE USARIO";
            // 
            // panelGestorUser
            // 
            this.panelGestorUser.Controls.Add(this.lblGestorUser);
            this.panelGestorUser.Location = new System.Drawing.Point(383, 37);
            this.panelGestorUser.Name = "panelGestorUser";
            this.panelGestorUser.Size = new System.Drawing.Size(330, 388);
            this.panelGestorUser.TabIndex = 1;
            // 
            // panelConsultaUser
            // 
            this.panelConsultaUser.Controls.Add(this.lblFiltro);
            this.panelConsultaUser.Controls.Add(this.rbtnDesc);
            this.panelConsultaUser.Controls.Add(this.txtBusqueda);
            this.panelConsultaUser.Controls.Add(this.rbtnAsc);
            this.panelConsultaUser.Controls.Add(this.lblConsulta);
            this.panelConsultaUser.Location = new System.Drawing.Point(5, 37);
            this.panelConsultaUser.Name = "panelConsultaUser";
            this.panelConsultaUser.Size = new System.Drawing.Size(372, 72);
            this.panelConsultaUser.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 274);
            this.dataGridView1.TabIndex = 3;
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
            this.lblGestorUser.Size = new System.Drawing.Size(329, 21);
            this.lblGestorUser.TabIndex = 8;
            this.lblGestorUser.Text = "FORMULARIO USUARIO";
            this.lblGestorUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConsulta
            // 
            this.lblConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblConsulta.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblConsulta.Location = new System.Drawing.Point(2, 1);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(369, 21);
            this.lblConsulta.TabIndex = 9;
            this.lblConsulta.Text = "CONSULTA";
            this.lblConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(131, 26);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(238, 20);
            this.txtBusqueda.TabIndex = 24;
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
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFiltro.Location = new System.Drawing.Point(9, 21);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(120, 45);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtrar Por Nombre de Usuario";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelConsultaUser);
            this.Controls.Add(this.panelGestorUser);
            this.Controls.Add(this.lblTitleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionUsuario";
            this.Opacity = 0.95D;
            this.Text = "FrmGestionUsuario";
            this.lblTitleUser.ResumeLayout(false);
            this.lblTitleUser.PerformLayout();
            this.panelGestorUser.ResumeLayout(false);
            this.panelConsultaUser.ResumeLayout(false);
            this.panelConsultaUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTitleUser;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Panel panelGestorUser;
        private System.Windows.Forms.Panel panelConsultaUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblGestorUser;
        public System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rbtnDesc;
        private System.Windows.Forms.RadioButton rbtnAsc;
        public System.Windows.Forms.Label lblFiltro;
    }
}