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
using Vistas.ViewUser;



namespace Vistas.Views
{
    public partial class AddOrUpdateUserForm : Form
    {
        public bool isEdit ;
        public User user = new User();
        public string idUser;
        public UserForm userForm = new UserForm();


        public AddOrUpdateUserForm(UserForm users)
        {
            InitializeComponent();
            loadRoles();
            userForm = users;

        }
        public AddOrUpdateUserForm(User u, bool edit, UserForm users)
        {

            InitializeComponent();
            user = u;
            isEdit = edit;
            setUserForm(user);
            loadRoles();
            userForm = users;

        }

        private void loadRoles()
        {
            comboBoxRol.DisplayMember = "rol_descripcion";
            comboBoxRol.ValueMember = "rol_id";          
            comboBoxRol.DataSource = WorkUser.getAllRoles();
        }
      

        private void clear()
        {
            textBoxApeNom.Clear();
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            comboBoxRol.Text = "";
        }

        private void setUserForm(User user)
        {
            
            textBoxUserName.Text = user.Username;
            textBoxPassword.Text= user.Password;
            textBoxApeNom.Text = user.LastName;
            
        }

     

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (validateField())
            {
                if (isEdit == false)
                {
                    var result = MessageBox.Show("¿Desea registrar al usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        user.Username = textBoxUserName.Text;
                        user.Password = textBoxPassword.Text;
                        user.LastName = textBoxApeNom.Text;
                        user.RolCode = (int)comboBoxRol.SelectedValue;
                        WorkUser.addUser(user);
                        MessageBox.Show("USUARIO: " + user.Username + "  PASSWORD: " + user.Password + "APELLIDO Y NOMBRE: " + user.LastName + " ROL: " + user.RolCode, "Datos del usuario Cargados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                if (isEdit == true)
                {
                    var result = MessageBox.Show("¿Desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        user.Username = textBoxUserName.Text;
                        user.Password = textBoxPassword.Text;
                        user.LastName = textBoxApeNom.Text;
                        //combo valor
                        user.RolCode = (int)comboBoxRol.SelectedValue;

                        //MessageBox.Show((String)cmbRol.SelectedValue);

                        WorkUser.updateUser(user);

                        MessageBox.Show("Se actualizo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();
                        isEdit = false;
                    }


                }
                userForm.loadUsers();
                userForm.Show();
                clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Campos en Blancos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguto que quieres salir ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                clear();
                this.Hide();
            }
            
           
        }

        //validaciones
        private bool validateField()
        {
            bool validate = true;
            Validations.whiteSpace(textBoxUserName, ref validate, "Ingrese nombre usuario", pictureBox2, errorProvider1);
            Validations.whiteSpace(textBoxPassword, ref validate, "Ingrese nombre Contrasenia", pictureBox1, errorProvider1);
            Validations.whiteSpace(textBoxApeNom, ref validate, "Ingrese Apellido y Nombre", pictureBox3, errorProvider1);
            
            return validate;
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox2, "");
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox1, "");
        }

        private void textBoxApeNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox3, "");
        }
    }


   
}
