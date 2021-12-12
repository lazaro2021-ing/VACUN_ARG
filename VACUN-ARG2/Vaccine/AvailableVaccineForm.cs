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
    public partial class AvailableVaccineForm : BaseForm
    {
        public AvailableVaccineForm()
        {
            InitializeComponent();
            viewVaccines();
        }
        
        public void viewVaccines()
        {
            VaccineClass all_vaccine = new VaccineClass();

            List<VaccineClass> list_vaccine = all_vaccine.getAll();


            foreach (VaccineClass vaccine in list_vaccine)
            {
                int n = this.data_vaccine.Rows.Add();
                this.data_vaccine.Rows[n].Cells[0].Value = vaccine.Id.ToString();
                this.data_vaccine.Rows[n].Cells[1].Value = vaccine.Name;
                this.data_vaccine.Rows[n].Cells[2].Value = vaccine.Pais;
                this.data_vaccine.Rows[n].Cells[3].Value = vaccine.Temp.ToString();
                this.data_vaccine.Rows[n].Cells[4].Value = vaccine.Dosis.ToString();
                this.data_vaccine.Rows[n].Cells[5].Value = vaccine.Aplicadas.ToString();
                this.data_vaccine.Rows[n].Cells[6].Value = vaccine.Disponibles.ToString();

            }

            this.data_vaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
     
    }
}
