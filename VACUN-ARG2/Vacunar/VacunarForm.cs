using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VACUN_ARG2.Vaccine;

namespace VACUN_ARG2.Vacunar
{
    public partial class VacunarForm : BaseForm
    {
        private int id_people;
        public VacunarForm()
        {
            InitializeComponent();
            base.setErrorProvider = this.errorProvider1;
            this.vaccine_cbox.DisplayMember = "Text";
            this.vaccine_cbox.ValueMember = "Value";
            this.viewVaccines();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if(base.validInputTextBox_Number(this.dni_numero)==true && base.validComboBox(this.dni_type_cbox) == true)
            {
                People people = new People();
                bool result = people.findByDNI(Int32.Parse(this.dni_numero.Text), this.dni_type_cbox.Text);
                if (result)
                {

                    this.id_people = people.Id;
                    people.findVaccineAplicadas();
                    this.dosis_textbox.Text = (people.Vaccine_list.Count + 1).ToString();
                    if (people.Vaccine_list.Count > 0)
                    {


                        using (PeopleDosisForm form = new PeopleDosisForm(people))
                            form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show($"{people.Name} no registra ninguna dosis aplicada.");
                    }

                }
            }

            base.validInputTextBox_Number(this.dni_numero);
            base.validComboBox(this.dni_type_cbox);

        }

        public void viewVaccines()
        {
            VaccineClass all_vaccine = new VaccineClass();

            base.config.getMacAddres();
            base.config.getIdCenter();
            List<VaccineClass> list_vaccine = all_vaccine.getAllInCenter(base.config.id_center);
           

            foreach (VaccineClass vaccine in list_vaccine)
            {

                this.vaccine_cbox.Items.Add(new { Text = vaccine.Name, Value = vaccine.Id });

            }

            
        }

        private void vacunar_Click(object sender, EventArgs e)
        {
            if (this.validateAll())
            {
                base.config.getMacAddres();
                base.config.getIdCenter();
                int id_vaccine = (this.vaccine_cbox.SelectedItem as dynamic).Value;
                int dosis = Int32.Parse(this.dosis_textbox.Text.ToString());
                VaccineClass vaccine = new VaccineClass();
                vaccine.getVaccineById(id_vaccine);
                vaccine.Vacunar(this.id_people, base.config.id_center, dosis);
            }
           

        }

        private void vaccine_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.validComboBox(this.vaccine_cbox);
        }

        private void dni_numero_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.dni_numero);
        }

        private void dosis_textbox_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.dosis_textbox);
        }

        private void dni_type_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.validComboBox(this.dni_type_cbox);
        }
        private bool validateAll()
        {
            List<bool> validate_list = new List<bool>();
            validate_list.Add(base.validComboBox(this.vaccine_cbox));
            validate_list.Add(base.validInputTextBox_Number(this.dni_numero));
            validate_list.Add(base.validInputTextBox_Number(this.dosis_textbox));
            validate_list.Add(base.validComboBox(this.dni_type_cbox));

            return validate_list.All(x => x == true);

        }
    }
}
