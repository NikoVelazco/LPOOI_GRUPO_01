using System;
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
    public partial class FrmGestionAtleta : Form
    {
        private int idSeleccionado;
        private string currentPattern = "";
        private string currentOrder = "DNI"; // Valor predeterminado

        public FrmGestionAtleta()
        {
            InitializeComponent();
            loadAtleta();
        }

        /**
         * Carga la lista de Atleta
         * */
        private void loadAtleta()
        {
            //dataGridAtleta.DataSource = TrabajarAtleta.listAtleta();
            //dataGridAtleta.Columns["Atl_ID"].Visible = false;
            dataGridAtleta.DataSource = TrabajarAtleta.listarAtletas(currentOrder, currentPattern);
            dataGridAtleta.Columns["Atl_ID"].Visible = false;
            
        }

        /**
         * Carga la lista de atleta desde el inicio
         * */
        private void FormEditAtleta_Load(object sender, EventArgs e)
        {
            loadAtleta();
           
        }
        /**
         * Copia los datos de la grilla a los textboxs
         * */

        private void dataGridAtleta_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridAtleta.SelectedRows.Count > 0 && !dataGridAtleta.CurrentRow.IsNewRow)
            {
                txtApellido.Text = dataGridAtleta.CurrentRow.Cells["Apellido"].Value.ToString();
                txtName.Text = dataGridAtleta.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDni.Text = dataGridAtleta.CurrentRow.Cells["DNI"].Value.ToString();
                txtNacionalidad.Text = dataGridAtleta.CurrentRow.Cells["Nacionalidad"].Value.ToString();
                txtDir.Text = dataGridAtleta.CurrentRow.Cells["Direccion"].Value.ToString();
                txtGenero.Text = dataGridAtleta.CurrentRow.Cells["Genero"].Value.ToString();
                txtPeso.Text = dataGridAtleta.CurrentRow.Cells["Peso"].Value.ToString();
                txtAltura.Text = dataGridAtleta.CurrentRow.Cells["Altura"].Value.ToString();
                txtEmail.Text = dataGridAtleta.CurrentRow.Cells["Email"].Value.ToString();
                txtEntrenador.Text = dataGridAtleta.CurrentRow.Cells["Entrenador"].Value.ToString();
                txtFechaNac.Text = dataGridAtleta.CurrentRow.Cells["Fecha Nacimiento"].Value.ToString();
                idSeleccionado = (int)dataGridAtleta.CurrentRow.Cells["Atl_ID"].Value;

                btnAgregarAtl.Enabled = false;
                btnEditarAtl.Enabled = true;
            }
        }
        /**
         * modifica el atleta y lo almacena
         * */
        private Atleta editAtleta()
        {
            Atleta atletaModificado = new Atleta();
            atletaModificado.Atl_Altura = double.Parse(txtAltura.Text);
            atletaModificado.Atl_Apellido = txtApellido.Text;
            atletaModificado.Atl_Direccion = txtDir.Text;
            atletaModificado.Atl_DNI = txtDni.Text;
            atletaModificado.Atl_Email = txtEmail.Text;
            atletaModificado.Atl_Entrenador = txtEntrenador.Text;
            atletaModificado.Atl_FechaNac = DateTime.Parse(txtFechaNac.Text);
            atletaModificado.Atl_Genero = txtGenero.Text;
            atletaModificado.Atl_Nacionalidad = txtNacionalidad.Text;
            atletaModificado.Atl_Nombre = txtName.Text;
            atletaModificado.Atl_Peso = double.Parse(txtPeso.Text);
            return atletaModificado;
        }
        /**
         * Edita atleta
         * */

        private void btnEditarAtl_Click(object sender, EventArgs e)
        {
            if (Util.textBoxEmpty(panelContenedor))
            {
                MessageBox.Show("Tiene que seleccionar el atleta a modificar");
                loadAtleta();
            }
            else
            {
                string dniSeleccionado = txtDni.Text;
                int atletaIDExistente = TrabajarAtleta.searchAtletaByDNI(dniSeleccionado);
                if (atletaIDExistente != -1 && atletaIDExistente != idSeleccionado)
                {
                    MessageBox.Show("El DNI ingresado ya está asociado a otro atleta. No se puede modificar.");
                }
                else
                {
                    DialogResult mensaje = MessageBox.Show("¿Estás seguro que quieres modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mensaje == DialogResult.Yes)
                    {
                        TrabajarAtleta.editAtleta(editAtleta(), idSeleccionado);
                        Util.clearTextBox(panelContenedor);
                        loadAtleta();
                    }
                    else
                    {
                        Util.clearTextBox(panelContenedor);
                    }
                }
            }
        }

        /**
         * Ordena por dni o Apellido
         */
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbtnDni.Checked)
            {
                currentOrder = "DNI";
            }
            else if (rbtnApellido.Checked)
            {
                currentOrder = "Apellido";
            }

           // dataGridAtleta.DataSource = TrabajarAtleta.listarAtletas(currentOrder, currentPattern);
           // dataGridAtleta.Columns["Atl_ID"].Visible = false;
            loadAtleta();
        }

        /**
        * guarda al atleta en el objeto
        * */
        private Atleta saveAtleta()
        {
            Atleta atleta = new Atleta();
            atleta.Atl_Nombre = txtName.Text;
            atleta.Atl_Apellido = txtApellido.Text;
            atleta.Atl_DNI = txtDni.Text;
            atleta.Atl_Nacionalidad = txtNacionalidad.Text;
            atleta.Atl_Entrenador = txtEntrenador.Text;
            atleta.Atl_Genero = txtGenero.Text;
            atleta.Atl_Altura = Double.Parse(txtAltura.Text);
            atleta.Atl_Peso = Double.Parse(txtPeso.Text);
            atleta.Atl_Direccion = txtDir.Text;
            atleta.Atl_FechaNac = txtFechaNac.Value.Date;
            atleta.Atl_Email = txtEmail.Text;
            return atleta;
        }


        private void btnAgregarAtl_Click(object sender, EventArgs e)
        {
            if ((Util.textBoxEmpty(panelContenedor) || txtGenero.Text == "" ))
            {
                MessageBox.Show("No se permite campos en blanco");
            }
            else
            {
                if (TrabajarAtleta.searchAtletaByDNI(txtDni.Text) == -1)
                {
                    DialogResult mensaje = MessageBox.Show("¿Estás seguro que quieres cargar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mensaje == DialogResult.Yes)
                    {
                        TrabajarAtleta.addAtleta(saveAtleta());
                        loadAtleta();
                        Util.clearTextBox(panelContenedor);
                    }
                    else
                    {
                        Util.clearTextBox(panelContenedor);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe el DNI: " + txtDni.Text);
                }
            }
        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
           // txtBusqueda.Text = "";
           // loadAtleta();
           // currentPattern = "";
            txtBusqueda.Text = "";
            currentPattern = "";
            loadAtleta();
        }

        private void btnDeleteAtleta_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                DialogResult mensaje = MessageBox.Show("¿Estás seguro quieres eliminar al atleta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje == DialogResult.Yes)
                {
                    TrabajarAtleta.deleteAtleta(idSeleccionado);
                    loadAtleta();
                    txtBusqueda.Text = "";
                    idSeleccionado = 0;
                }
                else
                {
                    loadAtleta();
                    idSeleccionado = 0;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario (fila) a eliminar", "Error");
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            currentPattern = txtBusqueda.Text;
            loadAtleta();
           /** if (!string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                currentPattern = txtBusqueda.Text;
                dataGridAtleta.DataSource = TrabajarAtleta.listarAtletas(currentOrder, currentPattern);
                dataGridAtleta.Columns["Atl_ID"].Visible = false;
                dataGridAtleta.DataSource = TrabajarAtleta.searchAtletaByName(txtBusqueda.Text);
            }
            else
            {
                txtBusqueda.Text = "";
                loadAtleta();
            }**/
        }
    }
}
