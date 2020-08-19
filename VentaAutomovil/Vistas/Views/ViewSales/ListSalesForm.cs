using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase.DataAccess;
using ClasesBase.Model;
using Vistas.Util;
namespace Vistas.Views
{
    public partial class ListSalesForm : Form
    {
        public DateTime MinDate = new DateTime(2015, 1, 1);
        public DateTime MaxDate = DateTime.Today;
        public ListSalesForm()
        {
            InitializeComponent();
        }

        private void ListSalesForm_Load(object sender, EventArgs e)
        {
            DataRowCollection dataUser = WorkSales.getUsersByRol().Rows;
            foreach (DataRow row in dataUser)
            {
               cmbVendedor.Items.Add(row["usu_apellido_nombre"].ToString());
            }
            grdSales.DataSource = WorkSales.getAllSalesSP();
            SetDataTimePicker();
            comboBoxListSearch.Text = "Buscar por";

            setCmbCustomer();
            showSalesInfo();
            disableControlls();

        }

        public void disableControlls()
        {
            dateTimePickerFirst.Enabled = false;
            dateTimePickerLast.Enabled = false;
            cmbBrand.Enabled = false;
            cmbVendedor.Enabled = false;
            cmbClientes.Enabled = false;
        }



        private void SetDataTimePicker()
        {
           
            dateTimePickerFirst.MinDate = MinDate;
           
            dateTimePickerLast.Value = MinDate;

           
            dateTimePickerLast.MinDate = MinDate;

           
            dateTimePickerLast.MaxDate = MaxDate;

           
            dateTimePickerFirst.MaxDate = MaxDate;
           
            dateTimePickerFirst.Format = DateTimePickerFormat.Custom;
            //dtpFirstDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFirst.CustomFormat = "dd/MM/yyyy";
            //dtpLastDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerLast.Format = DateTimePickerFormat.Custom;
            //dtpLastDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerLast.CustomFormat = "dd/MM/yyyy";
        }

        private void cmbListSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListSearch.SelectedItem.ToString() == "Fecha")
            {
                //setItemsFechaStatus();
                lblTitleFilter.Text = "Selecciona Fechas";
                dateTimePickerFirst.Enabled = true;
                dateTimePickerLast.Enabled = true;
                cmbBrand.Enabled = false;
                cmbVendedor.Enabled = false;
                cmbClientes.Enabled = false;
            }
            if (comboBoxListSearch.SelectedItem.ToString() == "Marca")
            {
                //setItemsMarcaStatus();
                lblTitleFilter.Text = "Selecciona Marca";
                cmbBrand.Enabled = true;
                cmbVendedor.Enabled = false;
                cmbClientes.Enabled = false;
                dateTimePickerFirst.Enabled = false;
                dateTimePickerLast.Enabled = false;
            }
            if (comboBoxListSearch.SelectedItem.ToString() == "Vendedor")
            {
                //setItemsVendedorStatus();
                lblTitleFilter.Text = "Selecciona Vendedor";
                cmbVendedor.Enabled = true;
                dateTimePickerFirst.Enabled = false;
                dateTimePickerLast.Enabled = false;
                cmbBrand.Enabled = false;
                cmbClientes.Enabled = false;
            }
            if (comboBoxListSearch.SelectedItem.ToString() == "Cliente")
            {
                //setItemsCustomerStatus();
                lblTitleFilter.Text = "Selecciona Cliente";
                cmbClientes.Enabled = true;
                cmbVendedor.Enabled = false;
                dateTimePickerFirst.Enabled = false;
                dateTimePickerLast.Enabled = false;
                cmbBrand.Enabled = false;
            }

        }

            

        private void setItemsMarcaStatus()
        {
            cmbClientes.Visible = false;
            lblTitleFilter.Visible = true;
            lblTitleFilter.Text = "Seleccione un tipo de marca para realizar su búsqueda";
            dateTimePickerFirst.Visible = false;
            dateTimePickerLast.Visible = false;
            cmbVendedor.Visible = false;
            cmbBrand.Visible = true;
            cmbBrand.Location = dateTimePickerFirst.Location;
            btnSearch.Enabled = true;
        }

        private void setItemsFechaStatus()
        {
            lblTitleFilter.Visible = true;

            lblTitleFilter.Text = "Seleccione dos tipos de fechas para realizar su búsqueda";
            dateTimePickerFirst.Visible = true;
            dateTimePickerLast.Visible = true;
            cmbVendedor.Visible = false;
            cmbClientes.Visible = false;
            cmbBrand.Visible = false;
            btnSearch.Enabled = true;

        }

        private void setItemsVendedorStatus()
        {
            cmbClientes.Visible = false;
            lblTitleFilter.Visible = true;
            lblTitleFilter.Text = "Seleccione un vendedor para realizar su búsqueda";
            //dtpFirstDate.Visible = false;
            //dtpLastDate.Visible = false;

            dateTimePickerFirst.Visible = false;
            dateTimePickerLast.Visible = false;
            cmbBrand.Visible = false;
            cmbVendedor.Visible = true;
            cmbVendedor.Location = dateTimePickerFirst.Location;
            btnSearch.Enabled = true;
        }
        private void setItemsCustomerStatus()
        {
            lblTitleFilter.Visible = true;
            lblTitleFilter.Text = "Seleccione un cliente para realizar su búsqueda";
            //dtpFirstDate.Visible = false;
            //dtpLastDate.Visible = false;
            dateTimePickerFirst.Visible = false;
            dateTimePickerLast.Visible = false;
            cmbBrand.Visible = false;
            cmbVendedor.Visible = false;
            cmbClientes.Visible = true;
            cmbClientes.Location = dateTimePickerFirst.Location;
            btnSearch.Enabled = true;
        }
        private void setAllItemsStatus()
        {
            lblTitleFilter.Text = "";

            lblTitleFilter.Visible = false;
            //dtpFirstDate.Visible = false;
            //dtpLastDate.Visible = false;
            dateTimePickerFirst.Visible = false;
            dateTimePickerLast.Visible = false;
            cmbBrand.Visible = false;
            cmbVendedor.Visible = false;
            cmbClientes.Visible = false;
        }

        private void setCmbCustomer()
        {
            DataRowCollection dataUser = WorkCustomer.getAllCustomers().Rows;
            foreach (DataRow row in dataUser)
            {
               cmbClientes.Items.Add(row[3].ToString());
            }
        }

        private void controlDateTimePicker(object sender, EventArgs e)
        {
            //dtpLastDate.MinDate = dtpFirstDate.Value;
            dateTimePickerLast.MinDate = dateTimePickerFirst.Value;
            //dtpFirstDate.MaxDate = dtpLastDate.Value;
            dateTimePickerFirst.MaxDate = dateTimePickerLast.Value;

        }
        public void showSalesInfo()
        {
          
            labelCountSales.Visible = true;
            labelCountSales.Text = "Ventas Realizadas: " + WorkSales.getAllSalesQuantity();
            labelCountAnuladas.Visible = true;
            labelCountAnuladas.Text= "Ventas Anuladas: " + WorkSales.getAllSalesStateQuantity("ANULADA");
            labelCountAcitves.Visible = true;
            labelCountAcitves.Text= "Ventas Activas: " + WorkSales.getAllSalesStateQuantity("ACTIVA");
            labelImportTotal.Visible = true;
            labelImportTotal.Text= "Importe Total: $" + WorkSales.getSalesImportTotal();
            labelImportTotalAnuladas.Visible = true;
            labelImportTotalAnuladas.Text= "Importe Total Ventas Anulada: $" + WorkSales.getSalesStateImportTotal("ANULADA");
            labelImportTotalAcitve.Visible = true;
            labelImportTotalAcitve.Text= "Importe Total Ventas Activas: $" + WorkSales.getSalesStateImportTotal("ACTIVA"); 
        }


        public void showSalesDateInfo(DateTime dtpFirstDate, DateTime dtpLastDate)
        {
            hideSalesInfo();
            labelCountSales.Visible = true;
            labelCountSales.Text = "Cantidad de Ventas: " + WorkSales.getCountSaleByDate(dtpFirstDate, dtpLastDate);
            labelImportTotal.Visible = true;
            labelImportTotal.Text = "Total Importe: $" + WorkSales.getImportTotalSaleByDate(dtpFirstDate, dtpLastDate);
        }

        public void showSalesBrandInfo(string brand)
        {
            hideSalesInfo();
            labelCountSales.Visible = true;
            labelCountSales.Text = "Cantidad de Ventas: " + WorkSales.getCountSaleByBrand(brand);
            labelImportTotal.Visible = true;
            labelImportTotal.Text = "Total Importe: $" + WorkSales.getImportTotalSaleByBrand(brand);
        }

        public void showSalesCustomerInfo(string customer)
        {
            hideSalesInfo();
            labelCountSales.Visible = true;
            labelCountSales.Text = "Cantidad de Compras del Cliente: " + WorkSales.getCountSaleByCustomer(customer);
            labelImportTotal.Visible = true;
            labelImportTotal.Text = "Total Importe: $" + WorkSales.getImportTotalSaleByCustomer(customer);
        }

        public void showSalesUserInfo(string userName)
        {
            hideSalesInfo();
            labelCountSales.Visible = true;
            labelCountSales.Text = "Cantidad de Ventas: " + WorkSales.getCountSaleByUser(userName);
            labelImportTotal.Visible = true;
            labelImportTotal.Text = "Total Importe: " + WorkSales.getImportTotalSaleByUser(userName);
        }

        private void hideSalesInfo()
        {
            labelCountAcitves.Visible = false;
            labelCountAnuladas.Visible = false;
            labelCountSales.Visible = false;
            labelImportTotal.Visible = false;
            labelImportTotalAcitve.Visible = false;
            labelImportTotalAnuladas.Visible = false;
        }
        

        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxListSearch.SelectedItem.ToString() == "Fecha")
            {
           
                grdSales.DataSource = WorkSales.getSaleByDate(dateTimePickerFirst.Value, dateTimePickerLast.Value);
                showSalesDateInfo(dateTimePickerFirst.Value, dateTimePickerLast.Value);
            }

            if (comboBoxListSearch.SelectedItem.ToString() == "Marca")
            {
                
                grdSales.DataSource = WorkSales.getSaleByBrand(cmbBrand.SelectedItem.ToString());
                showSalesBrandInfo(cmbBrand.SelectedItem.ToString());
            }


            if (comboBoxListSearch.SelectedItem.ToString() == "Vendedor")
            {
                
                 grdSales.DataSource = WorkSales.getSaleByUser(cmbVendedor.SelectedItem.ToString());
                 showSalesUserInfo(cmbVendedor.SelectedItem.ToString());
            }

            if (comboBoxListSearch.SelectedItem.ToString() == "Cliente")
            {
                
                grdSales.DataSource = WorkSales.getSaleByCustomer(cmbClientes.SelectedItem.ToString());
                showSalesCustomerInfo(cmbClientes.SelectedItem.ToString());
            }
        }

        private void btnSeeAllSales_Click(object sender, EventArgs e)
        {
            grdSales.DataSource = WorkSales.getAllSalesSP();
            comboBoxListSearch.Text = "Buscar por";
            btnSearch.Enabled = false;
            //setAllItemsStatus();
            disableControlls();
            showSalesInfo();

        }

        private void buttonFilterState_Click(object sender, EventArgs e)
        {
            labelCountAnuladas.Visible = false;
            labelCountAcitves.Visible = false;
            labelImportTotalAcitve.Visible = false;
            labelImportTotalAnuladas.Visible = false;
            labelCountSales.Visible = true;
            labelImportTotal.Visible = true;

            if (cmbStateFilter.SelectedItem.ToString() == "Activa")
            {
                grdSales.DataSource = WorkSales.getAllSalesState("ACTIVA");

                labelCountSales.Text = "Cantidad de Ventas: " + WorkSales.getAllSalesStateQuantity("ACTIVA");

                labelImportTotal.Text = "Importe Total: $" + WorkSales.getSalesStateImportTotal("ACTIVA");
            }

            if (cmbStateFilter.SelectedItem.ToString() == "Anulado")
            {
                grdSales.DataSource = WorkSales.getAllSalesState("ANULADA");
                labelCountSales.Text = "Cantidad de Ventas: " + WorkSales.getAllSalesStateQuantity("ANULADA");
                labelImportTotal.Text = "Importe Total: $" + WorkSales.getSalesStateImportTotal("ANULADA");
            }
        }

        private void buttonCancelSale_Click(object sender, EventArgs e)
        {
            int id;
            if (txtNumericSale.Text != "")
            {
                var result = MessageBox.Show("¿Desea anular Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    id = Convert.ToInt32(txtNumericSale.Text);
                    WorkSales.updateStateSale(id);
                    grdSales.DataSource = WorkSales.getAllSalesSP();
                    txtNumericSale.Text = "";
                }
            }
            else
            {
                if (grdSales.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("¿Desea anular Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(grdSales.CurrentRow.Cells["Id de la Venta"].Value.ToString());
                        WorkSales.updateStateSale(id);
                        grdSales.DataSource = WorkSales.getAllSalesSP();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Lista de Ventas";
            printer.SubTitle = "Generadas el día " + DateTime.Now.ToString("yyyy/MM/dd");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.SubTitleSpacing = 15;
            printer.Footer = "Ventas Jujuy";
            printer.FooterSpacing = 15;
            grdSales.Columns["Estado"].Visible = false;
            MessageBox.Show("Se recomienda que en esta sección se imprima de modo HORIZONTAL, ya que los datos sobrepasan el tamaño en vertical.");
            printer.PrintDataGridView(grdSales);
            grdSales.Columns["Estado"].Visible = true;

        }
    }


  

}
