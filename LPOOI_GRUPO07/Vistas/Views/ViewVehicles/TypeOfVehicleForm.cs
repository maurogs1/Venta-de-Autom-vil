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
    public partial class TypeOfVehicleForm : Form
    {
        private bool isEdit = false;
        private string idTypeOfVehicle;
        AddOrUpdateVehicleForm vehicleForm;
        public TypeOfVehicleForm()
        {
            InitializeComponent();

        }

        public TypeOfVehicleForm(AddOrUpdateVehicleForm form)
        {
            InitializeComponent();
            vehicleForm = form;
        }

        private void TypeOfVehicleForm_Load(object sender, EventArgs e)
        {
            loadTypesOfVehicles();
        }

        private void loadTypesOfVehicles()
        {
            dataGridViewTypes.DataSource = WorkTypeOfVehicle.getAllTypesOfVehcles();
        }

       

        private void clear()
        {
            textDescripcion.Clear();

        }

      

    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TypeOfVehicle typeOfVehicle = new TypeOfVehicle();
            if (validateField())
            {
                if (isEdit == false)
                {
                    var result = MessageBox.Show("¿Desea registrar el tipo de vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        typeOfVehicle.Description = textDescripcion.Text;
                        WorkTypeOfVehicle.addTypeOfVehicle(typeOfVehicle);
                        loadTypesOfVehicles();
                        clear();
                    }
                }

                if (isEdit == true)
                {
                    typeOfVehicle.Id = Convert.ToInt32(idTypeOfVehicle);
                    typeOfVehicle.Description = textDescripcion.Text;
                    WorkTypeOfVehicle.updateTypeOfVehicle(typeOfVehicle);
                    loadTypesOfVehicles();
                    MessageBox.Show("Se actualizo correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    isEdit = false;

                }

            }
            else
            {
                MessageBox.Show("Campos en Blancos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /* this.Hide();
             vehicleForm.loadTypesOfVehicles();
             vehicleForm.loadVehiclesClass();
             vehicleForm.Show();*/

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count > 0)
            {
                isEdit = true;
               // lblTitle.Text = "Modifica Tipo de Vehiculo";
                textDescripcion.Text = dataGridViewTypes.CurrentRow.Cells["Descripcion"].Value.ToString();
                idTypeOfVehicle = dataGridViewTypes.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar el tipo de vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    idTypeOfVehicle = dataGridViewTypes.CurrentRow.Cells["Id"].Value.ToString();
                    WorkTypeOfVehicle.deleteTypeOfVehicle(idTypeOfVehicle);
                    MessageBox.Show("Se elimino correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTypesOfVehicles();
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
            vehicleForm.loadTypesOfVehicles();
            //AddOrUpdateVehicleForm addOrUpdateVehicleForm = new AddOrUpdateVehicleForm();
            //addOrUpdateVehicleForm.Show();
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

