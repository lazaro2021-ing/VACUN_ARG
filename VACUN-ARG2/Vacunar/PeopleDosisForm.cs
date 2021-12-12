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
     internal partial class PeopleDosisForm : BaseForm
    {
        
        public PeopleDosisForm(People people)
        {
            InitializeComponent();
            this.nombre_label.Text += people.Name;
            this.dni_type_label.Text += people.Dni_type;
            this.dni_numero_label.Text += people.Dni_numero.ToString();
            this.nacionalidad_label.Text += people.Nacionalidad;
            this.dosis_label.Text += people.vaccine_dosis.Count.ToString();
            for (int i = 0; i < people.Vaccine_list.Count; i++)
            {
            
                int n = this.dosis_grid.Rows.Add();
                this.dosis_grid.Rows[n].Cells[0].Value = people.vaccine_dosis[i].ToString();
                this.dosis_grid.Rows[n].Cells[1].Value = people.Vaccine_list[i].Name;
                this.dosis_grid.Rows[n].Cells[2].Value = people.vaccine_fecha[i].ToString();


            }
            //para que las columnas se ajusten al contenido
            this.dosis_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

    
    }
}
