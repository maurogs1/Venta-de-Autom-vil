using ClasesBase.DataAccess;
using ClasesBase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Util;
using Vistas.Views.ViewVehicles;

namespace Vistas
{
    public partial class VehicleForm : Form
    {
        private string idVehicle;

        public VehicleForm()
        {
            InitializeComponent();
        }
        private void VehicleForm_Load(object sender, EventArgs e)
        {
            loadVehiclesSP();
        }
       
        public void loadVehiclesSP()
        {
            grdVehicles.DataSource = WorkVehicle.getAllVehiclesSP();
        }
      


        /*private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarVehiculo.Text != "")
            {
                grdVehicles.DataSource = WorkVehicle.searchVehicle(txtBuscarVehiculo.Text);
            }
            else
            {
                if (txtBuscarVehiculo.Text == "")
                    loadVehiclesSP();
            }
        }*/
        private void establecerValorRadioButtonGPS()
        {
            AddOrUpdateVehicleForm form = new AddOrUpdateVehicleForm();

            if (grdVehicles.CurrentRow.Cells["GPS"].Value.Equals(true))
            {
                form.radioButton1.Checked = true;
                form.radioButton2.Checked = false;
            }
            else
            {
                form.radioButton1.Checked = false;
                form.radioButton2.Checked = true;
            }

        }
       

      

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            loadVehiclesSP();
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            AddOrUpdateVehicleForm form = new AddOrUpdateVehicleForm(this);
            form.ShowDialog();
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (grdVehicles.SelectedRows.Count > 0)
            {
                AddOrUpdateVehicleForm form = new AddOrUpdateVehicleForm(this);
                form.isEdit = true;
                form.titleVehicle.Text = "Modificar Vehiculo";
                form.textEnrollment.Text = grdVehicles.CurrentRow.Cells["Matricula"].Value.ToString();
                form.comboBoxBrands.Text = grdVehicles.CurrentRow.Cells["Marca"].Value.ToString();
                form.comboBoxLine.Text = grdVehicles.CurrentRow.Cells["Linea"].Value.ToString();
                form.textBoxModel.Text = grdVehicles.CurrentRow.Cells["Modelo"].Value.ToString();
                form.textBoxColor.Text = grdVehicles.CurrentRow.Cells["Color"].Value.ToString();
                form.comboBoxDoors.Text = grdVehicles.CurrentRow.Cells["Puertas"].Value.ToString();
                establecerValorRadioButtonGPS();
                form.comboBoxType.Text = grdVehicles.CurrentRow.Cells["Tipo"].Value.ToString();
                form.comboBoxClass.Text = grdVehicles.CurrentRow.Cells["Clase"].Value.ToString();
                form.textBoxPrice.Text = grdVehicles.CurrentRow.Cells["Precio"].Value.ToString();
                form.idVehicle = grdVehicles.CurrentRow.Cells["Id"].Value.ToString();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (grdVehicles.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar el Vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        idVehicle = grdVehicles.CurrentRow.Cells["Id"].Value.ToString();
                        WorkVehicle.deleteVehicleSP(idVehicle);
                        MessageBox.Show("Se elimino correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadVehiclesSP();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo eliminar!!!. Tiene una venta asociada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnSee_Click(object sender, EventArgs e)
        //{
        //    if (radioBtnMarca.Checked == true)
        //    {
        //        grdVehicles.DataSource = WorkVehicle.getAllVehicleBrand();
        //    }
     
     

        private void radioBtnMarca_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtnMarca.Checked == true)
            {
                grdVehicles.DataSource = WorkVehicle.getAllVehicleBrand();
            }
        }

        private void radioBtnLinea_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnLinea.Checked == true)
            {
                grdVehicles.DataSource = WorkVehicle.getAllVehicleLine();
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
            printer.SubTitleSpacing = 15;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Ventas Jujuy";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(grdVehicles);
        }
    }
}
