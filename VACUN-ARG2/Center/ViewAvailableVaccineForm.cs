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

namespace VACUN_ARG2.Center
{
    public partial class ViewAvailableVaccineForm : BaseForm
    {
        public ViewAvailableVaccineForm(int _id)
        {
            InitializeComponent();
            dataGridView(_id);
        }

        private void dataGridView(int _id)
        {
           
            CenterVaccine all_centers = new CenterVaccine();

            //crea una lista con todos los centros de vacunacion
            List<VaccineClass> list_vaccine = all_centers.getAllAvailableVaccine(_id);

            //setea los datos de la datagrid
            foreach (VaccineClass vaccine in list_vaccine)
            {
                int n = this.vaccineGridView.Rows.Add();
            
                this.vaccineGridView.Rows[n].Cells[0].Value = vaccine.Id.ToString();
                this.vaccineGridView.Rows[n].Cells[1].Value = vaccine.Name;
                this.vaccineGridView.Rows[n].Cells[2].Value = vaccine.Dosis;
                this.vaccineGridView.Rows[n].Cells[3].Value = vaccine.Disponibles;
                this.vaccineGridView.Rows[n].Cells[4].Value = vaccine.Aplicadas;


            }

            //para que las columnas se ajusten al contenido
            this.vaccineGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
        }
    }
}
