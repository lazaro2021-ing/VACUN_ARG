using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VACUN_ARG2.Center;

namespace VACUN_ARG2.Vaccine
{
    public partial class AssignVaccineForm : BaseForm
    {
        private List<VaccineClass> list_vaccine;
        private List<CenterVaccine> list_center;
        public AssignVaccineForm()
        {
            InitializeComponent();
            base.setErrorProvider = this.errorProvider1;
            this.viewVaccinesCbox();
            this.viewCentersCbox();
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
        public void viewCentersCbox()
        {
            CenterVaccine all_center = new CenterVaccine();

            this.list_center = all_center.getAll();

            foreach (var center in this.list_center)
            {
                this.center_cbox.Items.Add(center.Nombre);
            }

        }

        private void add_dosis_btn_Click(object sender, EventArgs e)
        {
            if (this.validateAll())
            {
                int index_vaccine = this.vaccine_cbox.SelectedIndex;
                int index_center = this.center_cbox.SelectedIndex;
                list_vaccine[index_vaccine].AssignDosis(this.list_center[index_center].Id, Int32.Parse(this.cantidad.Text));
            }
            
            
        }

        private void center_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.validComboBox(this.center_cbox);

        }

        private void vaccine_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.validComboBox(this.vaccine_cbox);
        }

        private bool validateAll()
        {
            List<bool> validate_list = new List<bool>();
            validate_list.Add(base.validInputTextBox_Number(this.cantidad));
            validate_list.Add(base.validComboBox(this.center_cbox));
            validate_list.Add(base.validComboBox(this.vaccine_cbox));

            return validate_list.All(x => x == true);

        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {
            this.validInputTextBox_Number(this.cantidad);
        }
    }
}
