using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VACUN_ARG2.Center
{
    public partial class ViewCenterForm : BaseForm
    {
        
        public ViewCenterForm()
        {
            InitializeComponent();
            viewDataCenters();
        }

        public void viewDataCenters()
        {

            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();

            this.data_centers.Columns.Add(imageCol);


            CenterVaccine all_centers = new CenterVaccine();

            //crea una lista con todos los centros de vacunacion
            List<CenterVaccine> list_centers = all_centers.getAll();

            //setea los datos de la datagrid
            foreach (CenterVaccine center in list_centers)
            {
                int n = this.data_centers.Rows.Add();
                center.getCountVaccine();
                this.data_centers.Rows[n].Cells[0].Value = center.Id.ToString();
                this.data_centers.Rows[n].Cells[1].Value = center.Nombre;
                this.data_centers.Rows[n].Cells[2].Value = center.Provincia;
                this.data_centers.Rows[n].Cells[3].Value = center.Departamento;
                this.data_centers.Rows[n].Cells[4].Value = center.Localidad;
                this.data_centers.Rows[n].Cells[5].Value = center.Aplicadas.ToString() ;
                this.data_centers.Rows[n].Cells[6].Value = center.Disponibles.ToString();
                this.data_centers.Rows[n].Cells[7].Value = new Bitmap(Properties.Resources.vacuna, new Size(20, 20));
                
            }

            //para que las columnas se ajusten al contenido
            this.data_centers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       

        private void data_centers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                using (ViewAvailableVaccineForm form = new ViewAvailableVaccineForm(Int32.Parse( this.data_centers.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    form.ShowDialog();
                
            }
        }
    }
}
