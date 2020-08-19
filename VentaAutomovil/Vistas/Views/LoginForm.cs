using ClasesBase.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using ClasesBase;
using System.Collections.Generic;
using ClasesBase.DataAccess;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class LoginForm : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //   (
        //       int nLeftRect,     // x-coordinate of upper-left corner
        //       int nTopRect,      // y-coordinate of upper-left corner
        //       int nRightRect,    // x-coordinate of lower-right corner
        //       int nBottomRect,   // y-coordinate of lower-right corner
        //       int nWidthEllipse, // height of ellipse
        //       int nHeightEllipse // width of ellipse
        //   );

        private bool getMenu = false;
      


        private User currentUser = new User();
        private const string usernamePlacheHolder = "usuario";
        private const string passwordPlaceHolder = "contraseña";
        private Button copiaBtnLogin = new Button();
        //private string role;
        //private string name;
        //private string userName;
        //private string password;
        //private const string usernamePlacheHolder = "usuario";
        //private const string passwordPlaceHolder = "contraseña";
        //private Button copiaBtnLogin = new Button();

        public LoginForm()
        {
            InitializeComponent();
            //saveColorSizeBtn();

            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 16, 16));

            findSavedUser();
        }



        //public void saveColorSizeBtn()
        //{
        //    copiaBtnLogin.BackColor = btnLogin.BackColor;
        //    copiaBtnLogin.Size = btnLogin.Size;
        //}



        private void userLogged ()
        {
            MainMenuForm mainForm = new MainMenuForm(currentUser,this);
            mainForm.Show();
            this.Hide();
            
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {
           
         
            
        
        }

        ///// <summary>
        ///// Quita el placeholder de un textbox y lo deja vacío
        ///// A la fuente le cambia de color
        ///// </summary>
        ///// <param name="txt">Es un textbox al que queremos quitar el placeholder</param>
        ///// <param name="placeholder">Es el texto que tiene el txt al que vamos a dejar vacío</param>
        /////         /// <param name="isPassword">Es una opción opcional para cuando el textbox es de tipo password </param>
        //private void removePlaceHolder(TextBox txt, string placeholder, bool isPassword = false)
        //{
        //    if (isPassword)
        //        txt.PasswordChar = '*';
        //    if (txt.Text == placeholder)
        //    {
        //        txt.Text = "";
        //        txt.ForeColor = Color.White;
        //    }
        //}


        ///// <summary>
        ///// Agrega un placeholder a un textbox
        ///// A la fuente le cambia de color
        ///// </summary>
        ///// <param name="txt">Es un textbox al que queremos agregar un placeholder</param>
        ///// <param name="placeholder">Texto que tendra el placeholder del textbox </param>
        ///// <param name="isPassword">Es una opción opcional para cuando el textbox es de tipo password </param>
        //private void setPlaceHolder(TextBox txt, string placeholder, bool isPassword =false)
        //{
        //    if (isPassword && txt.Text == "")
        //        txt.PasswordChar = '\0';
        //    if (txt.Text == "")
        //    {
        //        txt.Text = placeholder;
        //        txt.ForeColor = Color.White;
        //    }
        //}

        //private void usernamePlaceHolder(object sender, System.EventArgs e)
        //{
        //    setPlaceHolder(txtUsername, usernamePlacheHolder);
        //}

        //private void removeUsernamePlaceHolder(object sender, System.EventArgs e)
        //{
        //    removePlaceHolder(txtUsername, usernamePlacheHolder);
        //}

        //private void removePasswordPlaceHolder(object sender, System.EventArgs e)
        //{
        //    removePlaceHolder(txtPassword, passwordPlaceHolder, true);
        //}

        //private void addPassowrdPlaceHolder(object sender, System.EventArgs e)
        //{
        //    setPlaceHolder(txtPassword, passwordPlaceHolder,true);
        //}

        private void loginError()
        {
            MessageBox.Show("Nombre de Usuario o Contraseña incorrecta","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            txtPassword.Text = "";
            txtUsername.Text = "";
            //txtPassword.PasswordChar = '\0';
            //txtUsername.ForeColor = Color.White;
            //txtPassword.ForeColor = Color.White;
        }
        private void loginSucces()
        {
            MessageBox.Show("Sesión Iniciada","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //txtPassword.Text = passwordPlaceHolder;
            //txtUsername.Text = usernamePlacheHolder;
            //txtPassword.PasswordChar = '\0';
            //txtUsername.ForeColor = Color.White;
            //txtPassword.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Ingrese Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataRowCollection dataUser = WorkLogin.loginUser(txtUsername.Text, txtPassword.Text).Rows;
                if (dataUser.Count > 0)
                {
                    loginSucces();
                    foreach (DataRow row in dataUser)
                    {
                        currentUser.LastName = row["usu_apellido_nombre"].ToString();
                        currentUser.RolCode = Convert.ToInt16(row["role_id"]);
                        currentUser.Id = Convert.ToInt16(row["usu_id"]);
                        currentUser.Username = row["usu_nombre"].ToString();
                        currentUser.Password = row["usu_password"].ToString();
                        currentUser.SaveUser = Convert.ToBoolean(row["usu_recordar_usuario"] is DBNull ? false : row["usu_recordar_usuario"]);
                    }
                    
                    saveUserConnection(currentUser);
                    userLogged();
                    txtPassword.ResetText();
                }
                else
                {
                    loginError();
                }
            }
        }

        

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(41, 70, 151);
            
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.DimGray;
        }
        //private void btnLogin_MouseHover(object sender, System.EventArgs e)
        //{
        //    btnLogin.BackColor = Color.LightGray;
        //}

        //private void btnLogin_MouseLeave(object sender, System.EventArgs e)
        //{
        //    btnLogin.BackColor = copiaBtnLogin.BackColor;

        //}



        private void pressedKey(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtPassword.Text != "" && txtUsername.Text != "") 
                btnLogin.PerformClick();
        }




        public void findSavedUser()
        {
            User savedUser = WorkLogin.getUserSaved();
            if (savedUser.SaveUser)            {
                txtPassword.Text = savedUser.Password;
                txtUsername.Text = savedUser.Username;
                cbxSaveUser.Checked = true;
                txtPassword.isPassword = true;
                getMenu = true;
                btnLogin.PerformClick();
            }

        }

        private void saveUserConnection(User user)
        {


            if (cbxSaveUser.Checked)
            {
                user.SaveUser = true;
                WorkUser.updateUser(user,true);
            }
            else
            {
                user.SaveUser = false;
                WorkUser.updateUser(user,true);
            }
                
        }

        public void removeConnection(User user)
        {
            user.SaveUser = false;
            WorkUser.updateUser(user, true);
        }

        private void getMenuForSaved(object sender, EventArgs e)
        {
            if (getMenu)
                btnLogin.PerformClick();
        }
    }


}