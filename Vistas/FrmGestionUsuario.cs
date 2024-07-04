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
    public partial class FrmGestionUsuario : Form
    {
        private int idSeleccionado = 0;
        private int rolCodigo = 0;
        private string userSeleccionado = "";
        public FrmGestionUsuario()
        {
            InitializeComponent();
        }

        /**
         * Carga la lista de roles
         * */
        private void loadListRoles()
        {
            txtRol.DisplayMember = "Rol_Descripcion";
            txtRol.ValueMember = "Rol_Codigo";
            txtRol.DataSource = TrabajarUsuario.getListRoles();
        }

        /**
         * Carga a los usuarios en la grilla
         * */
        private void loadUsers()
        {
            dataGridUser.DataSource = TrabajarUsuario.listUser();
            dataGridUser.Columns["Usu_ID"].Visible = false;
            dataGridUser.Columns["Contraseña"].Visible = false;
            dataGridUser.Columns["Rol_Codigo"].Visible = false;
            dataGridUser.Columns["Imagen"].Visible = false;
        }

        /**
         * Formulario estado inicial
         * */
        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            loadListRoles();
            loadUsers();
            btnEditUser.Enabled = false;
        }

        /**
         * Cargar Imagen
         * desde computadora
         * */
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                imgUserNew.Image = new Bitmap(of.FileName);
            }
            //cargoImg = true;
        }

        /**
         * Retorna un Usuario
         * Guarda los valores en el objeto
         * */
        private Usuario saveUser()
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Codigo = (int)txtRol.SelectedValue;
            oUser.Usu_ApellidoNombre = txtApellidoNomb.Text;
            oUser.Usu_NombreUsuario = txtNameUser.Text;
            oUser.Usu_Contrasenia = txtPassword.Text;
            oUser.Usu_Email = txtEmail.Text;
            oUser.Usu_Imagen = imgUserNew.Image;
            return oUser;
        }

        /***
         * ALTA DE USUARIO
         * */
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            if (Util.textBoxEmpty(panelGestorUser) || imgUserNew.Image == null)
            {
                Util.messageYesNo("No puede haber campos vacios", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (TrabajarUsuario.getRolCodigo(txtNameUser.Text) == -1)
                {
                    if (TrabajarUsuario.buscarPorCorreo(txtEmail.Text).Rows.Count  < 1)
                    {
                        if (txtEmail.Text.Contains('@'))
                        {
                            Util.startSound("alerta.mp3");
                            if (Util.messageYesNo("¿Estás Seguro que queres guardar los datos?", "Alta de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                TrabajarUsuario.addUser(saveUser());
                                Util.clearTextBox(panelGestorUser);
                                imgUserNew.Image = null;
                                Util.startSound("sound-correct.mp3");
                                Util.messageYesNo("Usuario registrado correctamente", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.None);
                                loadUsers();
                            }
                            else
                            {
                                Util.clearTextBox(panelGestorUser);
                                imgUserNew.Image = null;
                            }
                        }
                        else
                        {
                            Util.messageYesNo("Debe ingresar un formato de email válido", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        Util.messageYesNo("El email: " + txtEmail.Text + " ya corresponde a un usuario registrado", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Util.messageYesNo("El nombre de usuario: "+txtNameUser.Text+" no esta disponible", "Alta de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbtnAsc.Checked == true)
                dataGridUser.DataSource = TrabajarUsuario.buscarUsuariosPorNombre(txtBusqueda.Text);
            else if (rbtnDesc.Checked == true)
                dataGridUser.DataSource = TrabajarUsuario.buscarUsuariosPorNombreDesc(txtBusqueda.Text);

            dataGridUser.Columns["Usu_ID"].Visible = false;
            dataGridUser.Columns["Contraseña"].Visible = false;
            dataGridUser.Columns["Rol_Codigo"].Visible = false;
            dataGridUser.Columns["Imagen"].Visible = false;
            dataGridUser.Refresh();
        }

        private void rbtnAsc_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda_TextChanged(sender, e);
        }

        private void dataGridUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0 && !dataGridUser.CurrentRow.IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridUser.SelectedRows[0];
                idSeleccionado = (int)selectedRow.Cells["Usu_ID"].Value;
                rolCodigo = (int)selectedRow.Cells["Rol_Codigo"].Value;
                userSeleccionado = selectedRow.Cells["Usuario"].Value.ToString();
                txtRol.SelectedValue = dataGridUser.CurrentRow.Cells["Rol_Codigo"].Value.ToString();
                txtApellidoNomb.Text = dataGridUser.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                txtNameUser.Text = dataGridUser.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dataGridUser.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtEmail.Text = dataGridUser.CurrentRow.Cells["Email"].Value.ToString();
                imgUserNew.Image = UtilImagen.ByteToImage((byte[])dataGridUser.CurrentRow.Cells["Imagen"].Value);
                btnGuardarUser.Enabled = false;
                btnEditUser.Enabled = true;
            }
        }

        /**
         * Elimina un usuario
         * */
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                if (rolCodigo == 1)
                {
                    Util.messageYesNo("No se puede eliminar un usuario administrador", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Util.startSound("alerta.mp3");
                    if (Util.messageYesNo("Estas seguro que quieres eliminar a "+userSeleccionado, "Eliminar Usuario",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TrabajarUsuario.deleteUser(idSeleccionado);
                        loadUsers();
                        txtBusqueda.Text = "";
                        idSeleccionado = 0;
                        rolCodigo = 0;
                    }
                    else
                    {
                        loadUsers();
                        idSeleccionado = 0;
                        rolCodigo = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario (fila) a eliminar", "Error");
            }
        }

        /***
         * Modifica un usuario
         * */
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string nuevoNombreUsuario = txtNameUser.Text;
            int rolCodigoExistente = TrabajarUsuario.getRolCodigo(nuevoNombreUsuario);
            string nombreUsuarioActual = dataGridUser.CurrentRow.Cells["Usuario"].Value.ToString();
            if (Util.textBoxEmpty(panelGestorUser))
            {
                Util.messageYesNo("Tenes que seleccionar un usuario", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loadUsers();
            }
            else
            {
                if (nuevoNombreUsuario != nombreUsuarioActual && rolCodigoExistente != -1)
                {
                    Util.messageYesNo("Ya existe el usuario "+nuevoNombreUsuario, "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Util.clearTextBox(panelGestorUser);
                    imgUserNew.Image = null;
                }
                else
                {
                    Util.startSound("alerta.mp3");
                    if (Util.messageYesNo("¿Seguro que queres modificar los datos?", "Modificar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        TrabajarUsuario.editUser(saveUser(), idSeleccionado);
                        Util.clearTextBox(panelGestorUser);
                        idSeleccionado = 0;
                        imgUserNew.Image = null;
                        loadUsers();
                    }
                    else
                    {
                        Util.clearTextBox(panelGestorUser);
                        imgUserNew.Image = null;
                    }
                }
            }
        }

        /**
         * Limpia los input
         * */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Util.clearTextBox(panelGestorUser);
            imgUserNew.Image = null;
            btnEditUser.Enabled = false;
            btnGuardarUser.Enabled = true;
        }




    }
}
