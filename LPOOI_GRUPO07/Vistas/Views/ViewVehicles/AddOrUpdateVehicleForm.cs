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

namespace Vistas.Views.ViewVehicles
{
    public partial class AddOrUpdateVehicleForm : Form
    {
        public string idVehicle;
        public bool isEdit = false;
        VehicleForm vForm;
        public AddOrUpdateVehicleForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateVehicleForm(VehicleForm form)
        {
            
            InitializeComponent();
            vForm = form;
        }

        private void AddOrUpdateVehicleForm_Load(object sender, EventArgs e)
        {
            loadTypesOfVehicles();
            loadVehiclesClass();

        }

       

        private void cleanFields()
        {
            textEnrollment.Text = "";
            comboBoxBrands.Text = "Seleccione marca";
            comboBoxLine.Text = "Seleccione linea";
            textBoxModel.Text = "";
            textBoxColor.Text = "";
            comboBoxDoors.Text = "Seleccione cantidad";
            comboBoxType.Text = "Seleccione tipo";
            comboBoxClass.Text = "Seleccione clase";
            textBoxPrice.Text = "";
        }

        


        private void iconButtonTv_Click(object sender, EventArgs e)
        {
            TypeOfVehicleForm tvForm = new TypeOfVehicleForm(this);
            tvForm.ShowDialog();
           // this.Hide();
            
        }

        private void iconButtonCv_Click(object sender, EventArgs e)
        {
            VehicleClassForm vehicleClassForm = new VehicleClassForm(this);
            vehicleClassForm.ShowDialog();
            //this.Hide();
            
        }

        public void loadTypesOfVehicles()
        {
            comboBoxType.DisplayMember = "Descripcion";
            comboBoxType.ValueMember = "Id";
            comboBoxType.DataSource = WorkTypeOfVehicle.getAllTypesOfVehcles();
        }

        public void loadVehiclesClass()
        {
            comboBoxClass.DisplayMember = "Descripcion";
            comboBoxClass.ValueMember = "Id";
            comboBoxClass.DataSource = WorkVehicleClass.getAllVehiclesClass();
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
            Validations.whiteSpace(textEnrollment, ref validate, "Ingrese Matricula", pictureBox1, errorProvider1);
            Validations.whiteSpace(textBoxModel, ref validate, "Ingrese Modelo", pictureBox2, errorProvider1);
            Validations.whiteSpace(textBoxColor, ref validate, "Ingrese Color", pictureBox4, errorProvider1);
            Validations.whiteSpace(textBoxPrice, ref validate, "Ingrese Precio", pictureBox3, errorProvider1);
            Validations.validateComboBox(comboBoxBrands, ref validate, "Seleccione una Marca", "Seleccione marca", errorProvider1);
            Validations.validateComboBox(comboBoxLine, ref validate, "Seleccione una Linea", "Seleccione linea", errorProvider1);
            Validations.validateComboBox(comboBoxDoors, ref validate, "Seleccione una Cantidad", "Seleccione cantidad", errorProvider1);

            return validate;
        }


        private void btnRegisterUser_Click(object sender, EventArgs e)
        {

            VehicleForm vehicleForm = new VehicleForm();
            Vehicle vehicle = new Vehicle();
            if (validateField())
            {
                if (!WorkVehicle.getVehiculeByEnrollment(textEnrollment.Text))
                {
                    if (isEdit == false)
                    {
                        var result = MessageBox.Show("¿Desea registrar el vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            vehicle.Enrollment = textEnrollment.Text;
                            vehicle.Brand = comboBoxBrands.Text;
                            vehicle.VehicleLine = comboBoxLine.Text;
                            vehicle.Model = int.Parse(textBoxModel.Text);
                            vehicle.Colour = textBoxColor.Text;
                            vehicle.NumberOfDoors = int.Parse(comboBoxDoors.Text);
                            vehicle.Gps = radioButton1.Checked;
                            vehicle.idType = Convert.ToInt32(comboBoxType.SelectedValue);
                            vehicle.idClassVehicle = Convert.ToInt32(comboBoxClass.SelectedValue);
                            vehicle.Price = decimal.Parse(textBoxPrice.Text);

                            //WorkVehicle.addVehicle(vehicle);
                            WorkVehicle.addVehicleSP(vehicle);
                            MessageBox.Show("MATRICULA: " + vehicle.Enrollment + "  MARCA: " + vehicle.Brand + "LINEA: " + vehicle.VehicleLine +
                                " MODELO: " + vehicle.Model + " COLOR: " + vehicle.Colour + " PUERTAS: " + vehicle.NumberOfDoors +
                                " GPS: " + vehicle.showGps() + " TIPO: " + vehicle.Type + " CLASE: " + vehicle.ClassVehicle
                                + " PRECIO: " + vehicle.Price, "Datos del Vehiculo cargados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            //loadVehicles();
                            vehicleForm.loadVehiclesSP();
                            cleanFields();
                        }
                    }
                    //update Vehicle
                    if (isEdit == true)
                    {
                        var result = MessageBox.Show("¿Desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            vehicle.Id = Convert.ToInt32(idVehicle);
                            vehicle.Enrollment = textEnrollment.Text;
                            vehicle.Brand = comboBoxBrands.Text;
                            vehicle.VehicleLine = comboBoxLine.Text;
                            vehicle.Model = int.Parse(textBoxModel.Text);
                            vehicle.Colour = textBoxColor.Text;
                            vehicle.NumberOfDoors = int.Parse(comboBoxDoors.Text);
                            vehicle.Gps = radioButton1.Checked;
                            vehicle.idType = Convert.ToInt32(comboBoxType.SelectedValue);
                            vehicle.idClassVehicle = Convert.ToInt32(comboBoxClass.SelectedValue);
                            vehicle.Price = decimal.Parse(textBoxPrice.Text);

                            //WorkVehicle.updateVehicle(vehicle);
                            WorkVehicle.updateVehicleSP(vehicle);

                            //loadVehicles();
                            vehicleForm.loadVehiclesSP();
                            cleanFields();
                            isEdit = false;
                            MessageBox.Show("Se actualizo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    vForm.loadVehiclesSP();
                    this.Hide();

                }
                else
                    MessageBox.Show("La matricula: " + textEnrollment.Text + " ya está registrada, intente otra matricula");
            }
            else
            {
                MessageBox.Show("Campos en Blancos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textEnrollment_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox1, "");
        }

        private void textBoxColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox4, "");
        }

        private void textBoxModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.validateNumber(e, pictureBox2, errorProvider1);
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.validateNumber(e, pictureBox3, errorProvider1);
        }

        private void comboBoxBrands_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxBrands, "");
        }

        private void comboBoxLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxLine, "");
        }

        private void comboBoxDoors_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxDoors, "");
        }

        private void comboBoxLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxDoors_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
