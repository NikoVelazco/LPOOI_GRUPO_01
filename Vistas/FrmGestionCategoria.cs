﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmGestionCategoria : Form
    {
        private TrabajarCategoria trabajarCategoria;
        public FrmGestionCategoria()
        {
            InitializeComponent();
            trabajarCategoria = new TrabajarCategoria();
        }

        private void loadListOfCategories()
        {
            dataGridCategoria.DataSource = TrabajarCategoria.getListOfCategories();
            dataGridCategoria.Columns["Id"].Visible = false;
        }

        /**
         * Carga las categorías en la grilla
         * */
        private void FrmGestionCategoria_Load(object sender, EventArgs e)
        {
            loadListOfCategories();
            btnEditCategoria.Enabled = false;
        }

        /**
         * Agrega una categoría
         * */
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (!Util.textBoxEmpty(panelContenedor))
            {
                Util.startSound("alerta.mp3");
                DialogResult message = Util.messageYesNo("¿Deseas registrar una Categoria?", "Alta Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    trabajarCategoria.addCategory(
                        txtNombre.Text,
                        txtDescripcion.Text
                    );
                    Util.startSound("sound-correct.mp3");
                    Util.messageYesNo("Categoría agregada correctamente", "Alta de Categoría", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Util.clearTextBox(panelContenedor);
                    loadListOfCategories();
                }
                else
                {
                    Util.clearTextBox(panelContenedor);
                }
            }
            else
            {
                Util.startSound("alerta.mp3");
                Util.messageYesNo("No se permite campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /**
         * Carga los datos de la grilla
         * en el form de categoría
         * */
        /*private void dataGridCategoria_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridCategoria.CurrentRow != null)
            {
                txtNombre.Text = dataGridCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
                btnGuardarCategoria.Enabled = false;
                btnEditCategoria.Enabled = true;
            }
        }*/

        /**
         * Edita una categoría
         * */
        private void btnEditCategoria_Click(object sender, EventArgs e)
        {
            if (!Util.textBoxEmpty(panelContenedor))
            {
                Util.startSound("alerta.mp3");
                DialogResult message = Util.messageYesNo("¿Deseas modificar una Categoria?", "Modificar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    trabajarCategoria.updateCategory(
                        int.Parse(dataGridCategoria.CurrentRow.Cells["Id"].Value.ToString()),
                        txtNombre.Text,
                        txtDescripcion.Text
                    );
                    Util.startSound("sound-correct.mp3");
                    Util.messageYesNo("Categoría actualizada correctamente", "Modificar Categoría", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Util.clearTextBox(panelContenedor);
                    loadListOfCategories();
                }
                else
                {
                    Util.clearTextBox(panelContenedor);
                }
            }
            else
            {
                Util.startSound("alerta.mp3");
                Util.messageYesNo("Debe seleccionar la fila a editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /**
         * Elimina una categoría
         * */
        private void btnDeleteCategoria_Click(object sender, EventArgs e)
        {
            if (!Util.textBoxEmpty(panelContenedor))
            {
                Util.startSound("alerta.mp3");
                DialogResult message = Util.messageYesNo("¿Deseas eliminar una Categoria?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Util.startSound("alerta.mp3");
                if (message == DialogResult.Yes)
                {
                    trabajarCategoria.deleteCategory(
                        int.Parse(dataGridCategoria.CurrentRow.Cells["Id"].Value.ToString())
                    );
                    Util.startSound("sound-correct.mp3");
                    Util.messageYesNo("Categoría eliminada correctamente", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.None);
                    loadListOfCategories();
                }
            }
            else 
            {
                Util.startSound("alerta.mp3");
                Util.messageYesNo("Debe seleccionar la fila a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Util.clearTextBox(panelContenedor);
            btnEditCategoria.Enabled = false;
            btnGuardarCategoria.Enabled = true;
        }

        private void dataGridCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCategoria.SelectedRows.Count > 0 && !dataGridCategoria.CurrentRow.IsNewRow)
            {
                txtNombre.Text = dataGridCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
                btnGuardarCategoria.Enabled = false;
                btnEditCategoria.Enabled = true;
            }
        }


    }
}