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
    public partial class VehicleClassForm : Form
    {
        private bool isEdit = false;
        private string idVehicleClass;
        AddOrUpdateVehicleForm vehicleForm;

        public VehicleClassForm()
        {
            InitializeComponent();
        }
        public VehicleClassForm(AddOrUpdateVehicleForm form)
        {
            InitializeComponent();
            vehicleForm = form;
        }

        private void VehicleClassForm_Load(object sender, EventArgs e)
        {
            loadVehicleClass();
        }

        private void loadVehicleClass()
        {
            dataGridViewVehiclesClass.DataSource = WorkVehicleClass.getAllVehiclesClass(); 
        }


        private void clear()
        {
            textDescripcion.Text = "";

        }

    

        private void buttonNext_Click(object sender, EventArgs e)
        {
        }

     
     

        private void btnAcept_Click(object sender, EventArgs e)
        {
            VehicleClass vehicleClass = new VehicleClass();
            if (validateField())
            {
                if (isEdit == false)
                {
                    var result = MessageBox.Show("¿Desea registrar la clase de vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleClass.Description = textDescripcion.Text;
                        WorkVehicleClass.addVehicleClass(vehicleClass);
                        loadVehicleClass();
                        clear();
                    }
                }

                if (isEdit == true)
                {
                    vehicleClass.Id = Convert.ToInt32(idVehicleClass);
                    vehicleClass.Description = textDescripcion.Text;
                    WorkVehicleClass.updateVehicleClass(vehicleClass);
                    loadVehicleClass();
                    MessageBox.Show("Se actualizo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    isEdit = false;

                }
                vehicleForm.loadVehiclesClass();
                vehicleForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Campos en Blancos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dataGridViewVehiclesClass.SelectedRows.Count > 0)
            {
                isEdit = true;
                //title.Text = "Modificar clase";
                textDescripcion.Text = dataGridViewVehiclesClass.CurrentRow.Cells["Descripcion"].Value.ToString();
                idVehicleClass = dataGridViewVehiclesClass.CurrentRow.Cells["Id"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiclesClass.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar clase de vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    idVehicleClass = dataGridViewVehiclesClass.CurrentRow.Cells["Id"].Value.ToString();
                    WorkVehicleClass.deleteVehicleClass(idVehicleClass);
                    MessageBox.Show("Se elimino correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadVehicleClass();
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            vehicleForm.loadVehiclesClass();
            //vehicleForm.loadTypesOfVehicles();
            //vehicleForm.Show();
            
        }

        //validacion
        private bool validateField()
        {
            bool validate = true;
            Validations.whiteSpace(textDescripcion, ref validate, "Ingrese una Descripcion", pictureBox1, errorProvider1);
            return validate;
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(pictureBox1, "");
        }
    }
    }

