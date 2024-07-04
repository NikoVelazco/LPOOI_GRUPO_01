namespace Vistas
{
    partial class FrmGestionDisciplina
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
            this.lblGestionDisc = new System.Windows.Forms.Label();
            this.pnlConsultaDisc = new System.Windows.Forms.Panel();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBusquedaDisc = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.dgvDisciplina = new System.Windows.Forms.DataGridView();
            this.lblNombreDis = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescipcionDisc = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlGestion = new System.Windows.Forms.Panel();
            this.lblTitleUser.SuspendLayout();
            this.pnlConsultaDisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            this.pnlGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(109)))));
            this.lblTitleUser.Controls.Add(this.lblGestionDisc);
            this.lblTitleUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleUser.Location = new System.Drawing.Point(0, 0);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(720, 31);
            this.lblTitleUser.TabIndex = 1;
            // 
            // lblGestionDisc
            // 
            this.lblGestionDisc.AutoSize = true;
            this.lblGestionDisc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionDisc.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionDisc.Location = new System.Drawing.Point(257, 5);
            this.lblGestionDisc.Name = "lblGestionDisc";
            this.lblGestionDisc.Size = new System.Drawing.Size(220, 22);
            this.lblGestionDisc.TabIndex = 18;
            this.lblGestionDisc.Text = "GESTIÓN DE DISCIPLINA";
            // 
            // pnlConsultaDisc
            // 
            this.pnlConsultaDisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pnlConsultaDisc.Controls.Add(this.lblFiltro);
            this.pnlConsultaDisc.Controls.Add(this.txtBusquedaDisc);
            this.pnlConsultaDisc.Controls.Add(this.lblConsulta);
            this.pnlConsultaDisc.Location = new System.Drawing.Point(0, 30);
            this.pnlConsultaDisc.Name = "pnlConsultaDisc";
            this.pnlConsultaDisc.Size = new System.Drawing.Size(372, 72);
            this.pnlConsultaDisc.TabIndex = 3;
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblFiltro.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFiltro.Location = new System.Drawing.Point(4, 26);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(120, 45);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtrar Por Nombre ";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusquedaDisc
            // 
            this.txtBusquedaDisc.Location = new System.Drawing.Point(131, 38);
            this.txtBusquedaDisc.Name = "txtBusquedaDisc";
            this.txtBusquedaDisc.Size = new System.Drawing.Size(238, 20);
            this.txtBusquedaDisc.TabIndex = 24;
            this.txtBusquedaDisc.TextChanged += new System.EventHandler(this.txtBusquedaDisc_TextChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblConsulta.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblConsulta.Location = new System.Drawing.Point(0, 0);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(369, 21);
            this.lblConsulta.TabIndex = 9;
            this.lblConsulta.Text = "CONSULTA";
            this.lblConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplina.Location = new System.Drawing.Point(0, 103);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.Size = new System.Drawing.Size(372, 274);
            this.dgvDisciplina.TabIndex = 4;
            this.dgvDisciplina.CurrentCellChanged += new System.EventHandler(this.dgvDisciplina_CurrentCellChanged);
            // 
            // lblNombreDis
            // 
            this.lblNombreDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblNombreDis.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreDis.Location = new System.Drawing.Point(108, 4);
            this.lblNombreDis.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombreDis.Name = "lblNombreDis";
            this.lblNombreDis.Size = new System.Drawing.Size(143, 45);
            this.lblNombreDis.TabIndex = 32;
            this.lblNombreDis.Text = "Nombre Disciplina";
            this.lblNombreDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // lblDescipcionDisc
            // 
            this.lblDescipcionDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescipcionDisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblDescipcionDisc.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescipcionDisc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescipcionDisc.Location = new System.Drawing.Point(108, 116);
            this.lblDescipcionDisc.Margin = new System.Windows.Forms.Padding(4);
            this.lblDescipcionDisc.Name = "lblDescipcionDisc";
            this.lblDescipcionDisc.Size = new System.Drawing.Size(143, 45);
            this.lblDescipcionDisc.TabIndex = 33;
            this.lblDescipcionDisc.Text = "Descripción";
            this.lblDescipcionDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(60, 168);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 20);
            this.txtDescripcion.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(596, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(438, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 30);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(438, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(596, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiar.TabIndex = 45;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // pnlGestion
            // 
            this.pnlGestion.Controls.Add(this.lblNombreDis);
            this.pnlGestion.Controls.Add(this.txtNombre);
            this.pnlGestion.Controls.Add(this.lblDescipcionDisc);
            this.pnlGestion.Controls.Add(this.txtDescripcion);
            this.pnlGestion.Location = new System.Drawing.Point(378, 37);
            this.pnlGestion.Name = "pnlGestion";
            this.pnlGestion.Size = new System.Drawing.Size(342, 205);
            this.pnlGestion.TabIndex = 46;
            // 
            // FrmGestionDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.pnlGestion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvDisciplina);
            this.Controls.Add(this.pnlConsultaDisc);
            this.Controls.Add(this.lblTitleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionDisciplina";
            this.Text = "FrmGestionDisciplina";
            this.Load += new System.EventHandler(this.FrmGestionDisciplina_Load);
            this.lblTitleUser.ResumeLayout(false);
            this.lblTitleUser.PerformLayout();
            this.pnlConsultaDisc.ResumeLayout(false);
            this.pnlConsultaDisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            this.pnlGestion.ResumeLayout(false);
            this.pnlGestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTitleUser;
        private System.Windows.Forms.Label lblGestionDisc;
        private System.Windows.Forms.Panel pnlConsultaDisc;
        public System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtBusquedaDisc;
        public System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridView dgvDisciplina;
        public System.Windows.Forms.Label lblNombreDis;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblDescipcionDisc;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlGestion;
    }
}