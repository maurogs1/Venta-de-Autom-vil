




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
using Vistas.Views.ViewSales;

namespace Vistas.Views
{
    public partial class SalesForm : Form
    {
        User currentUser = new User();
        public SalesForm()
        {
            InitializeComponent();
        }
        public SalesForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            loadCustomers();
            loadVehicles();
            loadPayMethods();
            txtUsuario.Text = currentUser.LastName;
            txtUsuario.Enabled = false;
            dateTimePickerDate.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loadCustomers()
        {
            comboBoxCustomer.DisplayMember = "Dni";
            comboBoxCustomer.ValueMember = "Id";
            comboBoxCustomer.DataSource = WorkSales.getAllCustomers();
        }

        public void loadVehicles()
        {
            comboBoxVehicle.DisplayMember = "Matricula";
            comboBoxVehicle.ValueMember = "Id";
            comboBoxVehicle.DataSource = WorkSales.getAllVehicles();
        }

        public void loadPayMethods()
        {
            comboBoxPaymentMethod.DisplayMember = "Descripcion";
            comboBoxPaymentMethod.ValueMember = "Id";
            comboBoxPaymentMethod.DataSource = WorkSales.getAllWaysToPays();

            /*var items = new[] {
            new { Text = "Efectivo", Value = "Efectivo" },
            new { Text = "Tarjeta", Value = "Tarjeta" },
            new { Text = "Cheque", Value = "Cheque" }
            };

            comboBoxPaymentMethod.DataSource = items;*/

        }

       

        private void clear()
        {
            textBoxPriceTotal.Clear();
            
        }

        private void changeFieldsCustomer(object sender, EventArgs e)
        {
            DataRowView dataCustomers = (DataRowView)comboBoxCustomer.SelectedItem;
            labelName.Text = "Nombre: " + dataCustomers.Row[2].ToString();
            labelLastName.Text = "Apellido: " + dataCustomers.Row[3].ToString();
            labelAddress.Text = "Direccion: " + dataCustomers.Row[4].ToString();
            labelPhone.Text = "Telefono: " + dataCustomers.Row[5].ToString();

        }

        private void changeFields(object sender, EventArgs e)
        {
            DataRowView dataVehicles = (DataRowView)comboBoxVehicle.SelectedItem;
            textBoxPriceTotal.Text = dataVehicles.Row[10].ToString();
            lblBrand.Text = "Marca: " + dataVehicles.Row[2].ToString();
            lblLine.Text = "Linea: " + dataVehicles.Row[3].ToString();
            lblModel.Text = "Modelo: " + dataVehicles.Row[4].ToString();
            lblType.Text = "Tipo de Vehiculo: " + dataVehicles.Row[8].ToString();
            lblClass.Text = "Clase: " + dataVehicles.Row[9].ToString();
            lblColour.Text = "Color: " + dataVehicles.Row[5].ToString();
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDate.MaxDate = DateTime.Today;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonFp_Click(object sender, EventArgs e)
        {
            WayToPayForm wayToPayForm = new WayToPayForm(this);
            //this.Hide();
            wayToPayForm.ShowDialog();
           
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

       

        private void btnInsertSale_Click(object sender, EventArgs e)
        {

            Sale sale = new Sale();
            var result = MessageBox.Show("¿Desea registrar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sale.Date = dateTimePickerDate.Value;
                //sale.PaymentMethod = (string)comboBoxPaymentMethod.SelectedValue;
                sale.idPaymentMethod = Convert.ToInt32(comboBoxPaymentMethod.SelectedValue);
                sale.FinalPrice = Convert.ToDecimal(textBoxPriceTotal.Text);
                sale.CustomerID = Convert.ToInt32(comboBoxCustomer.SelectedValue);
                sale.VehicleID = Convert.ToInt32(comboBoxVehicle.SelectedValue);
                sale.UserId = currentUser.Id;
                sale.State = "ACTIVA";
                WorkSales.insertarVenta(sale);
                WorkVehicle.updateVehicleState(sale.VehicleID);
                MessageBox.Show("Se registro correctamente la venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                this.Hide();
            }
        }
    }
}

