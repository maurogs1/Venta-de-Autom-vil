using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesBase.Model
{
    public class Validations
    {

        public static void validateNumber(KeyPressEventArgs e, PictureBox pictureBox, ErrorProvider errorProvider1)
        {
            errorProvider1.SetError(pictureBox, "");
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(pictureBox, "Ingrese solo numeros");
            }
        }
        public static void validateComboBox(ComboBox comboBox, ref bool validate, string messeger, string description, ErrorProvider errorProvider1)
        {
            if (comboBox.Text == description)
            {
                validate = false;
                errorProvider1.SetError(comboBox, messeger);
                errorProvider1.SetIconPadding(comboBox, 2);
            }
        }

        public static void whiteSpace(TextBox textBox, ref bool validate, string messeger, PictureBox pictureBox, ErrorProvider errorProvider1)
        {
            if (textBox.Text == "")
            {
                validate = false;
                errorProvider1.SetError(pictureBox, messeger);
                errorProvider1.SetIconPadding(pictureBox, 2);
            }
        }
    }
}



