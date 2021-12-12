using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VACUN_ARG2.Vaccine
{
    public partial class CreateVaccineForm : BaseForm
    {
        public CreateVaccineForm()
        {
            InitializeComponent();
            base.setErrorProvider = this.errorProvider1;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (this.validateAll()) { 
                VaccineClass vaccine = new VaccineClass();
                bool status=vaccine.Crear(this.nombre.Text,Int32.Parse(this.cantidad.Text),this.pais.Text, Int32.Parse(this.temperatura.Text));
                if (status)
                {
                    MessageBox.Show("Vacuna creada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al crear la vacuna.");
                }
            }

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Text(this.nombre);
        }

        private void pais_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Text(this.pais);
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.cantidad);
        }

        private void temperatura_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.temperatura);
        }

        private bool validateAll()
        {
            List<bool> validate_list = new List<bool>();
            validate_list.Add(base.validInputTextBox_Text(this.nombre));
            validate_list.Add(base.validInputTextBox_Text(this.pais));
            validate_list.Add(base.validInputTextBox_Number(this.cantidad));
            validate_list.Add(base.validInputTextBox_Number(this.temperatura));

            return validate_list.All(x => x == true);

        }

       
    }
}
