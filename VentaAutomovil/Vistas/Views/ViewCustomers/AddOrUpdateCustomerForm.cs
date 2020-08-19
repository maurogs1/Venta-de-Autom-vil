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

namespace Vistas.Views.ViewCustomers
{
    public partial class AddOrUpdateCustomerForm : Form
    {
        public bool isEdit = false;
        public string idCustomer;
        public CustomerForm customerForm = new CustomerForm();
        public Customer customer = new Customer();



        public AddOrUpdateCustomerForm(CustomerForm cus)
        {
            InitializeComponent();
            customerForm = cus;
        }


        //public AddOrUpdateCustomerForm(CustomerForm customers)
        //{
        //    InitializeComponent();
        //    customerForm = customers;

        //}
        //public AddOrUpdateCustomerForm(Customer c, bool edit, CustomerForm customers)
        //{

        //    InitializeComponent();
        //    customer = c;
        //    isEdit = edit;
        //    setCustomerForm(customer);
        //    customerForm = customers;

        //}

        private void setCustomerForm(Customer customer)
        {
            txtDni.Text = customer.DNI;
            txtNombre.Text = customer.Name;
            txtApellido.Text = customer.LastName;
            txtDireccion.Text = customer.Address;
            txtTelefono.Text = customer.Phone;
            
        }

        private void cleanFields()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateField())
            {
                if (isEdit == false)
                {

                    var result = MessageBox.Show("¿Desea registrar al cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        customer.DNI = txtDni.Text;
                        customer.Name = txtNombre.Text;
                        customer.LastName = txtApellido.Text;
                        customer.Address = txtDireccion.Text;
                        customer.Phone = txtTelefono.Text;
                        WorkCustomer.addCustomer(customer);


                        MessageBox.Show("DNI: " + customer.DNI + "   Apellido: " + customer.LastName + "  Nombre: " + customer.Name + "  Direccion: " + customer.Address + "  Telefono: " + customer.Phone, "Datos del Cliente Cargados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    }
                }
                //update
                if (isEdit == true)
                {
                    var result = MessageBox.Show("¿Desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        customer.Id = Convert.ToInt32(idCustomer);
                        customer.DNI = txtDni.Text;
                        customer.Name = txtNombre.Text;
                        customer.LastName = txtApellido.Text;
                        customer.Address = txtDireccion.Text;
                        customer.Phone = txtTelefono.Text;

                        WorkCustomer.updateCustomer(customer);
                        MessageBox.Show("Se actualizo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        isEdit = false;
                    }


                }

                customerForm.loadCostumers();
                customerForm.Show();
                cleanFields();
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
                cleanFields();
                this.Hide();
            }
        }

        //validaciones
        private bool validateField()
        {
            bool validate = true;
            Validations.whiteSpace(txtDni, ref validate, "Ingrese DNI", pictureBox2, errorProvider1);
            Validations.whiteSpace(txtNombre, ref validate, "Ingrese Nombre", pictureBox1, errorProvider1);
            Validations.whiteSpace(txtApellido, ref validate, "Ingrese Apellido", pictureBox3, errorProvider1);
            Validations.whiteSpace(txtDireccion, ref validate, "Ingrese Direccion", pictureBox4, errorProvider1);
            Validations.whiteSpace(txtTelefono, ref validate, "Ingrese Telefono", pictureBox5, errorProvider1);

            return validate;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.validateNumber(e, pictureBox2, errorProvider1);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.validateNumber(e, pictureBox5, errorProvider1);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox1, "");
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox3, "");
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox4, "");
        }
    }

}
