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

namespace VACUN_ARG2
{
    public partial class ConfigForm : BaseForm
    {
        private int index_center;
        private List<CenterVaccine> list_center;
        public ConfigForm()
        {
            InitializeComponent();
            base.config.getMacAddres();
            this.mac_address.Text = base.config.macAddress;

            CenterVaccine all_center = new CenterVaccine();
            
            list_center = all_center.getAll();

            foreach (var center in list_center)
            {
                this.comboBox_centros.Items.Add(center.Nombre);
            }
        }

        private void comboBox_centros_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index_center = this.comboBox_centros.SelectedIndex;
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            CenterVaccine center = new CenterVaccine();
            bool result=center.setMacAddress(this.list_center[this.index_center].Id, this.mac_address.Text);
            if (result) { 
                MessageBox.Show("Configuración exitosa.");
            }else
            {
               MessageBox.Show("Error de configuración.");
            }
}
    }
}
