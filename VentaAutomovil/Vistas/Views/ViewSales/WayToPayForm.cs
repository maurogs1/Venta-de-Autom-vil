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

namespace Vistas.Views.ViewSales
{
    public partial class WayToPayForm : Form
    {
        private bool isEdit = false;
        private string idWayToPay;
        SalesForm salesForm;
        public WayToPayForm()
        {
            InitializeComponent();
        }
        public WayToPayForm(SalesForm form)
        {

            InitializeComponent();
            salesForm = form;
        }

        private void WayToPayForm_Load(object sender, EventArgs e)
        {
            loadWayToPays();
        }

        private void loadWayToPays()
        {
            dataGridViewWayToPay.DataSource = WorkWayToPay.getAllWayToPays();
        }

        private void clear()
        {
            textDescripcion.Clear();

        }

      

        
     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WayToPay wayToPay = new WayToPay();
            if (isEdit == false)
            {
                var result = MessageBox.Show("¿Desea registrar forma de pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    wayToPay.Description = textDescripcion.Text;
                    WorkWayToPay.addWayToPay(wayToPay);

                    loadWayToPays();

                    clear();
                }
            }

            if (isEdit == true)
            {
                var result = MessageBox.Show("¿Desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    wayToPay.Id = Convert.ToInt32(idWayToPay);
                    wayToPay.Description = textDescripcion.Text;
                    WorkWayToPay.updateWayToPay(wayToPay);
                    loadWayToPays();
                    MessageBox.Show("Cambios actualizados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    isEdit = false;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesForm.loadPayMethods();
            //salesForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewWayToPay.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar forma de pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    idWayToPay = dataGridViewWayToPay.CurrentRow.Cells["Id"].Value.ToString();
                    WorkWayToPay.deleteWayToPay(idWayToPay);
                    MessageBox.Show("Se elimino correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadWayToPays();
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewWayToPay.SelectedRows.Count > 0)
            {
                isEdit = true;
                //title.Text = "Modificar Forma de Pago";
                textDescripcion.Text = dataGridViewWayToPay.CurrentRow.Cells["Descripcion"].Value.ToString();
                idWayToPay = dataGridViewWayToPay.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
