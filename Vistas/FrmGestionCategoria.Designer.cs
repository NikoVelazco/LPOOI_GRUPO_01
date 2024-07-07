namespace Vistas
{
    partial class FrmGestionCategoria
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
            this.lblTitleCategoria = new System.Windows.Forms.Panel();
            this.lblGestionCategoria = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDeleteCategoria = new System.Windows.Forms.Button();
            this.btnEditCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblGestorCategoria = new System.Windows.Forms.Label();
            this.dataGridCategoria = new System.Windows.Forms.DataGridView();
            this.lblTitleCategoria.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleCategoria
            // 
            this.lblTitleCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(109)))));
            this.lblTitleCategoria.Controls.Add(this.lblGestionCategoria);
            this.lblTitleCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCategoria.Location = new System.Drawing.Point(0, 0);
            this.lblTitleCategoria.Name = "lblTitleCategoria";
            this.lblTitleCategoria.Size = new System.Drawing.Size(720, 31);
            this.lblTitleCategoria.TabIndex = 1;
            // 
            // lblGestionCategoria
            // 
            this.lblGestionCategoria.AutoSize = true;
            this.lblGestionCategoria.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCategoria.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionCategoria.Location = new System.Drawing.Point(257, 5);
            this.lblGestionCategoria.Name = "lblGestionCategoria";
            this.lblGestionCategoria.Size = new System.Drawing.Size(210, 22);
            this.lblGestionCategoria.TabIndex = 18;
            this.lblGestionCategoria.Text = "GESTIÓN DE CATEGORÍA";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.btnLimpiar);
            this.panelContenedor.Controls.Add(this.btnDeleteCategoria);
            this.panelContenedor.Controls.Add(this.btnEditCategoria);
            this.panelContenedor.Controls.Add(this.btnGuardarCategoria);
            this.panelContenedor.Controls.Add(this.lblDescripcion);
            this.panelContenedor.Controls.Add(this.lblNombre);
            this.panelContenedor.Controls.Add(this.txtDescripcion);
            this.panelContenedor.Controls.Add(this.txtNombre);
            this.panelContenedor.Controls.Add(this.lblGestorCategoria);
            this.panelContenedor.Location = new System.Drawing.Point(357, 37);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(356, 390);
            this.panelContenedor.TabIndex = 2;
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
            this.btnLimpiar.Location = new System.Drawing.Point(124, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Reiniciar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDeleteCategoria
            // 
            this.btnDeleteCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteCategoria.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategoria.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnDeleteCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategoria.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategoria.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategoria.Location = new System.Drawing.Point(210, 220);
            this.btnDeleteCategoria.Name = "btnDeleteCategoria";
            this.btnDeleteCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteCategoria.TabIndex = 45;
            this.btnDeleteCategoria.Text = "Eliminar";
            this.btnDeleteCategoria.UseVisualStyleBackColor = false;
            this.btnDeleteCategoria.Click += new System.EventHandler(this.btnDeleteCategoria_Click);
            // 
            // btnEditCategoria
            // 
            this.btnEditCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCategoria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCategoria.FlatAppearance.BorderSize = 0;
            this.btnEditCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEditCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategoria.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEditCategoria.Location = new System.Drawing.Point(210, 184);
            this.btnEditCategoria.Name = "btnEditCategoria";
            this.btnEditCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnEditCategoria.TabIndex = 44;
            this.btnEditCategoria.Text = "Editar";
            this.btnEditCategoria.UseVisualStyleBackColor = false;
            this.btnEditCategoria.Click += new System.EventHandler(this.btnEditCategoria_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarCategoria.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCategoria.FlatAppearance.BorderSize = 0;
            this.btnGuardarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCategoria.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCategoria.Location = new System.Drawing.Point(124, 184);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarCategoria.TabIndex = 43;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = false;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 132);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(130, 22);
            this.lblDescripcion.TabIndex = 29;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombre.Location = new System.Drawing.Point(85, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(171, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 23);
            this.txtDescripcion.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(171, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 23);
            this.txtNombre.TabIndex = 25;
            // 
            // lblGestorCategoria
            // 
            this.lblGestorCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestorCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.lblGestorCategoria.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestorCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGestorCategoria.Location = new System.Drawing.Point(3, 1);
            this.lblGestorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.lblGestorCategoria.Name = "lblGestorCategoria";
            this.lblGestorCategoria.Size = new System.Drawing.Size(352, 21);
            this.lblGestorCategoria.TabIndex = 9;
            this.lblGestorCategoria.Text = "FORMULARIO CATEGORÍA";
            this.lblGestorCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoria.Location = new System.Drawing.Point(12, 37);
            this.dataGridCategoria.Name = "dataGridCategoria";
            this.dataGridCategoria.Size = new System.Drawing.Size(327, 249);
            this.dataGridCategoria.TabIndex = 3;
            this.dataGridCategoria.SelectionChanged += new System.EventHandler(this.dataGridCategoria_SelectionChanged);
            // 
            // FrmGestionCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(720, 435);
            this.Controls.Add(this.dataGridCategoria);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.lblTitleCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionCategoria";
            this.Opacity = 0.95D;
            this.Text = "FrmGestionCategoria";
            this.Load += new System.EventHandler(this.FrmGestionCategoria_Load);
            this.lblTitleCategoria.ResumeLayout(false);
            this.lblTitleCategoria.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTitleCategoria;
        private System.Windows.Forms.Label lblGestionCategoria;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dataGridCategoria;
        public System.Windows.Forms.Label lblGestorCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDeleteCategoria;
        private System.Windows.Forms.Button btnEditCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
    }
}