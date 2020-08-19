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
using Vistas.Views.ViewCustomers;

namespace Vistas
{
    public partial class CustomerForm : Form
    {
        private string idCustomer;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadCostumers();
        }

       
        

        public void loadCostumers()
        {
            grdCostumers.DataSource = WorkCustomer.getAllCustomers();
        }
        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Close();
        }

      

    

        private void grdCostumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      


        private void btnSearchCostumers_Click(object sender, EventArgs e)
        {

            if (txtSearchCustomers.Text != "")
            {
                grdCostumers.DataSource = WorkCustomer.searchCustomer(txtSearchCustomers.Text);
            }
            else
            {
                if (txtSearchCustomers.Text == "")
                    loadCostumers();
            }
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            AddOrUpdateCustomerForm form = new AddOrUpdateCustomerForm(this);
            form.ShowDialog();
        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {
            if (grdCostumers.SelectedRows.Count > 0)
            {
                AddOrUpdateCustomerForm form = new AddOrUpdateCustomerForm(this);

                form.isEdit = true;
                form.lblCustomer.Text = "Modificar Datos";
                form.txtDni.Text = grdCostumers.CurrentRow.Cells["DNI"].Value.ToString();
                form.txtNombre.Text = grdCostumers.CurrentRow.Cells["Nombre"].Value.ToString();
                form.txtApellido.Text = grdCostumers.CurrentRow.Cells["Apellido"].Value.ToString();
                form.txtDireccion.Text = grdCostumers.CurrentRow.Cells["Direccion"].Value.ToString();
                form.txtTelefono.Text = grdCostumers.CurrentRow.Cells["Telefono"].Value.ToString();
                form.idCustomer = grdCostumers.CurrentRow.Cells["Id"].Value.ToString();
                form.Show();

            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {

            if (grdCostumers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    idCustomer = grdCostumers.CurrentRow.Cells["Id"].Value.ToString();
                    try
                    {
                        WorkCustomer.deleteCustomer(idCustomer);
                        MessageBox.Show("Se elimino correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadCostumers();
                    }
                    catch 
                    {
                        MessageBox.Show("El cliente tiene compras actualemente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            loadCostumers();
        }

        private void OrderLasName_Click(object sender, EventArgs e)
        {
            grdCostumers.DataSource = WorkCustomer.getAllCustomersOrderLastName();
        }
    }
}
