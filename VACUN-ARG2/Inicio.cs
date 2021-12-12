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
using VACUN_ARG2.Statistics;
using VACUN_ARG2.Vaccine;
using VACUN_ARG2.Vacunar;

namespace VACUN_ARG2
{
    public partial class Inicio : BaseForm
    {
        public Inicio()
        {
            InitializeComponent();

            base.config.getMacAddres();

            base.config.getIdCenter();

            if (base.config.id_center > 0) {
                CenterVaccine centro = new CenterVaccine();
                centro.getNameById(base.config.id_center);
                centro.getCountVaccine();
                this.label_centro.Text += centro.Nombre;
                this.label_aplicadas.Text += centro.Aplicadas.ToString();
                this.label_disponibles.Text += centro.Disponibles.ToString();
            }
        }

        private void AddCenterFormMenu_Click(object sender, EventArgs e)
        {
            using (AddCenterForm add_centro_form = new AddCenterForm())
                add_centro_form.ShowDialog();
        }

        private void ViewCenterFormMenu_Click(object sender, EventArgs e)
        {
            using (ViewCenterForm form = new ViewCenterForm())
                form.ShowDialog();
        }

        private void AddVaccineFormMenu_Click(object sender, EventArgs e)
        {
            using (AddVaccineForm form = new AddVaccineForm())
                form.ShowDialog();
        }

        private void AssignVaccineFormMenu_Click(object sender, EventArgs e)
        {
            using (AssignVaccineForm form = new AssignVaccineForm())
                form.ShowDialog();
        }
        private void AvailableVaccineFormMenu_Click(object sender, EventArgs e)
        {
            using (AvailableVaccineForm form = new AvailableVaccineForm())
                form.ShowDialog();
        }

        private void CreateVaccineFormMenu_Click(object sender, EventArgs e)
        {
            using (CreateVaccineForm form = new CreateVaccineForm())
                form.ShowDialog();
        }

        private void vacunarMenu_Click(object sender, EventArgs e)
        {
            using (VacunarForm form = new VacunarForm())
                form.ShowDialog();
        }

        private void registarPersonaMenu_Click(object sender, EventArgs e)
        {
            using (PeopleForm form = new PeopleForm())
                form.ShowDialog();
        }

        private void verEstadisticas_Click(object sender, EventArgs e)
        {
            using (StatisticsForm form = new StatisticsForm())
                form.ShowDialog();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ConfigForm form = new ConfigForm())
                form.ShowDialog();
        }
    }
}
