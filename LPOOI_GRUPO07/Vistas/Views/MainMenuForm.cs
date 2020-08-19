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
using Vistas.ViewUser;

namespace Vistas
{
    public partial class MainMenuForm : Form
    {
        private string lastname;
        User currentUSer = new User();
        User removeConnection;
        LoginForm log;

        public MainMenuForm()
        {
            InitializeComponent();
            customizeDesing();

        }
        public MainMenuForm(LoginForm login, User user)
        {
            InitializeComponent();
            customizeDesing();
            log = login;
            removeConnection = user;
        }

        private void customizeDesing()
        {
            this.pnlSubmenuUsers.Visible = false;
            this.pnlSubmenuCustomers.Visible = false;
            this.pnlSubmenuVehicle.Visible = false;
            this.pnlSubmenuSales.Visible = false;
        }

        private void hideSubmenu()
        {
            if (pnlSubmenuUsers.Visible == true)
            {
                pnlSubmenuUsers.Visible = false;
            }

            if (pnlSubmenuCustomers.Visible == true)
            {
                pnlSubmenuCustomers.Visible = false;
            }

            if (pnlSubmenuVehicle.Visible == true)
            {
                pnlSubmenuVehicle.Visible = false;
            }

            if (pnlSubmenuSales.Visible == true)
            {
                pnlSubmenuSales.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        
        private void btnOptionInsert_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
            hideSubmenu(); 
        }

        private Form formularioActivo = null;

        private void OpenChildForm(Form frmHijo)
        {
             if (formularioActivo == null)
             {
                formularioActivo = frmHijo; 
                frmHijo.TopLevel = false;
                frmHijo.FormBorderStyle = FormBorderStyle.None; 
                frmHijo.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(frmHijo);
                pnlContainer.Tag = frmHijo;
                frmHijo.BringToFront();
                frmHijo.Show();
            }
            else
            {
                formularioActivo.Close();
                formularioActivo = frmHijo;
                frmHijo.TopLevel = false;
                frmHijo.FormBorderStyle = FormBorderStyle.None;
                frmHijo.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(frmHijo);
                pnlContainer.Tag = frmHijo;
                frmHijo.BringToFront();
                frmHijo.Show();
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }



        public MainMenuForm(User user)
        {
            InitializeComponent();
            currentUSer = user;
            lastname = user.LastName;
            lblLastName.Text = "Usuario: "+ user.LastName;
            lblLastName.AutoSize = true;
            if (user.RolCode == 1)
            {
                iconBtnUsers.Visible = true;
                iconBtnManageUsers.Visible = true;
                iconBtnVehicle.Visible = true;
                iconBtnManageVehicle.Visible = true;
                iconBtnCustomers.Visible = false;
                iconBtnManageCustomers.Visible = false;
                iconBtnSales.Visible = false;
                iconBtnMangeSales.Visible = false;
                /*btnVehicles.Visible = true;
                btnCustomers.Visible = false;
                btnSale.Visible = false;*/
            }
            else
            {
                if (user.RolCode == 2)
                {
                    iconBtnCustomers.Visible = true;
                    iconBtnManageCustomers.Visible = true;
                    iconBtnSales.Visible = true;
                    iconBtnMangeSales.Visible = true;
                    iconBtnUsers.Visible = false;
                    iconBtnManageUsers.Visible = false;
                    iconBtnVehicle.Visible = false;
                    iconBtnManageVehicle.Visible = false;

                    /*btnVehicles.Visible = false;
                    btnCustomers.Visible = true;
                    btnSale.Visible = true;*/
                }
                else
                {
                    if(user.RolCode == 3)
                    {
                        iconBtnCustomers.Visible = true;
                        iconBtnManageCustomers.Visible = true;
                        iconBtnSales.Visible = true;
                        iconBtnMangeSales.Visible = true;
                        iconBtnUsers.Visible = true;
                        iconBtnManageUsers.Visible = true;
                        iconBtnVehicle.Visible = true;
                        iconBtnManageVehicle.Visible = true;
                    }
                }
            }
        }

        public MainMenuForm(User user,LoginForm prueba)
        {
            InitializeComponent();
            currentUSer = user;
            log = prueba;
            lastname = user.LastName;
            lblLastName.Text = "Usuario: " + user.LastName;
            lblLastName.AutoSize = true;
            if (user.RolCode == 1)
            {
                iconBtnUsers.Visible = true;
                iconBtnManageUsers.Visible = true;
                iconBtnVehicle.Visible = true;
                iconBtnManageVehicle.Visible = true;
                iconBtnCustomers.Visible = false;
                iconBtnManageCustomers.Visible = false;
                iconBtnSales.Visible = false;
                iconBtnMangeSales.Visible = false;
                /*btnVehicles.Visible = true;
                btnCustomers.Visible = false;
                btnSale.Visible = false;*/
            }
            else
            {
                if (user.RolCode == 2)
                {
                    iconBtnCustomers.Visible = true;
                    iconBtnManageCustomers.Visible = true;
                    iconBtnSales.Visible = true;
                    iconBtnMangeSales.Visible = true;
                    iconBtnUsers.Visible = false;
                    iconBtnManageUsers.Visible = false;
                    iconBtnVehicle.Visible = false;
                    iconBtnManageVehicle.Visible = false;

                    /*btnVehicles.Visible = false;
                    btnCustomers.Visible = true;
                    btnSale.Visible = true;*/
                }
                else
                {
                    if (user.RolCode == 3)
                    {
                        iconBtnCustomers.Visible = true;
                        iconBtnManageCustomers.Visible = true;
                        iconBtnSales.Visible = true;
                        iconBtnMangeSales.Visible = true;
                        iconBtnUsers.Visible = true;
                        iconBtnManageUsers.Visible = true;
                        iconBtnVehicle.Visible = true;
                        iconBtnManageVehicle.Visible = true;
                    }
                }
            }
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleForm());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
        }

        

    

        
      
        
        
        

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void iconBtnUsers_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuUsers);
        }

        private void iconBtnManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
            hideSubmenu();
        }

        private void iconBtnCustomers_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuCustomers);
           //LoginForm loginForm = new LoginForm();
           // log.Show();
           // log.removeConnection(currentUSer);
           // this.Close();

//            <<<<<<< HEAD
//            showSubmenu(pnlSubmenuCustomers);
//=======
//            //LoginForm loginForm = new LoginForm();
//            log.Show();
//            log.removeConnection(currentUSer);
//            this.Close();
//>>>>>>> final-agregado
        }

        private void iconBtnManageCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
            hideSubmenu();
        }

        private void iconBtnVehicle_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuVehicle);
        }

        private void iconBtnManageVehicle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleForm());
            hideSubmenu();
        }

        private void iconBtnSales_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuSales);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListSalesForm());
        }

        private void iconBtnMangeSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm(currentUSer));
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            log.Show();
            log.removeConnection(currentUSer);
            //  loginForm.Show();
            this.Close();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maximizar.Visible = true;
            restaurar.Visible = false;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
