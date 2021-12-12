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
    public partial class AddVaccineForm : BaseForm
    {
        private List<VaccineClass> list_vaccine;
        public AddVaccineForm()
        {
            InitializeComponent();
            base.setErrorProvider = this.errorProvider1;
            viewVaccinesCbox();
        }


        public void viewVaccinesCbox()
        {
            VaccineClass all_vaccine = new VaccineClass();

            this.list_vaccine = all_vaccine.getAll();


            foreach (var vaccine in this.list_vaccine)
            {
                this.vaccine_cbox.Items.Add(vaccine.Name);
            }

        }

        private void add_dosis_btn_Click(object sender, EventArgs e)
        {
            if (this.validateAll()) { 
                int index = this.vaccine_cbox.SelectedIndex;
                list_vaccine[index].AddDosis(Int32.Parse(this.cantidad.Text));
            }
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.cantidad);
        }

        private bool validateAll()
        {
            List<bool> validate_list = new List<bool>();
            validate_list.Add(base.validInputTextBox_Number(this.cantidad));
            validate_list.Add(base.validComboBox(this.vaccine_cbox));

            return validate_list.All(x => x == true);

        }

        private void vaccine_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.validComboBox(this.vaccine_cbox);
            this.cantidad.Text = "";
        }
    }
}
