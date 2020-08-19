using ClasesBase.DataAccess;
using ClasesBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Views;
using Vistas.Views.ViewCustomers;

namespace Vistas.ViewUser
{
    public partial class UserForm : Form
    {
        //verifica si vamos a ingresar o editar un usuario
        //private bool isEdit = false;
        private string idUser;

        

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            
            loadUsers();
        }

        //private void loadRoles()
        //{
        //    comboBoxRol.DisplayMember = "rol_descripcion";
        //    comboBoxRol.ValueMember = "rol_id";
        //    comboBoxRol.DataSource = WorkUser.getAllRoles();
        //}

        public void loadUsers()
        {
            dgwUsers.DataSource = WorkUser.getAllUsers();
        }

        //private void btnRegisterUser_Click(object sender, EventArgs e)
        //{
        //    User user = new User();
        //    //insert user
        //    if (isEdit == false)
        //    {
        //        var result = MessageBox.Show("¿Desea registrar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
                    
        //            user.Username = textBoxUserName.Text;
        //            user.Password = textBoxPassword.Text;
        //            user.LastName = textBoxApeNom.Text;
        //            user.RolCode = (int)comboBoxRol.SelectedValue;

        //            WorkUser.addUser(user);
        //            MessageBox.Show("USUARIO: " + user.Username + "  PASSWORD: " + user.Password + "APELLIDO Y NOMBRE: " + user.LastName + " ROL: " + user.RolCode, "Datos del usuario Cargados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //            loadUsers();
        //            clear();
        //        }
        //    }

        //    //update user
        //    if (isEdit == true)
        //    {
        //        user.Id = Convert.ToInt32(idUser);
        //        user.Username= textBoxUserName.Text;
        //        user.Password = textBoxPassword.Text;
        //        user.LastName = textBoxApeNom.Text;
        //        //combo valor
        //        user.RolCode = (int)comboBoxRol.SelectedValue;

        //        //MessageBox.Show((String)cmbRol.SelectedValue);

        //        WorkUser.updateUser(user);
        //        loadUsers();
        //        MessageBox.Show("Se actualizo correctamente","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
        //        clear();
        //        isEdit = false;

        //    }
            
           
                

        //}

        //private void btnEditUsers_Click(object sender, EventArgs e)
        //{
        //    if (dgwUsers.SelectedRows.Count > 0)
        //    {
        //        isEdit = true;
        //        titleUser.Text = "Modificar Datos Usuarios";
        //        textBoxApeNom.Text = dgwUsers.CurrentRow.Cells["Nombre Completo"].Value.ToString();
        //        textBoxUserName.Text = dgwUsers.CurrentRow.Cells["Usuario"].Value.ToString();
        //        textBoxPassword.Text = dgwUsers.CurrentRow.Cells["Contraseña"].Value.ToString();
        //        comboBoxRol.Text = dgwUsers.CurrentRow.Cells["Rol"].Value.ToString();
        //        idUser = dgwUsers.CurrentRow.Cells["Id"].Value.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    idUser = dgwUsers.CurrentRow.Cells["Id"].Value.ToString();
                    WorkUser.deleteUser(idUser);
                    MessageBox.Show("Se elimino correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUsers();
                }
                  
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            if (textBoxSearchUsers.Text != "")
            {
                dgwUsers.DataSource = WorkUser.searchUser(textBoxSearchUsers.Text);
            }
            else
            {
                if(textBoxSearchUsers.Text =="")
                loadUsers();
            }
        }

        //private void clear()
        //{
        //    textBoxApeNom.Clear();
        //    textBoxUserName.Clear();
        //    textBoxPassword.Clear();
        //    comboBoxRol.Text = "";
        //}

        private void btnUsers_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddOrUpdateUserForm form = new AddOrUpdateUserForm(this);
            form.Show();
        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count > 0)
            {
                User u = new User();               
                
            //  userD.lblCustomer.Text = "Modificar Datos Clientes";
               u.Id = Convert.ToInt16(dgwUsers.CurrentRow.Cells["Id"].Value);
               u.LastName = dgwUsers.CurrentRow.Cells["Nombre Completo"].Value.ToString();
               u.Username = dgwUsers.CurrentRow.Cells["Usuario"].Value.ToString();
               u.Password = dgwUsers.CurrentRow.Cells["Contraseña"].Value.ToString();
               u.RolCode =WorkUser.getRolByName(dgwUsers.CurrentRow.Cells[4].Value.ToString());
               AddOrUpdateUserForm form = new AddOrUpdateUserForm(u,true,this);
               form.Show();
    
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
