using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace VACUN_ARG2.Center

{
    public partial class AddCenterForm : BaseForm
    {
       
        private string selected_provincia;
        private string selected_departamento;
        public AddCenterForm()
        {

            InitializeComponent();


            base.setErrorProvider = this.errorProvider1;


            this.provincias_cbox.DisplayMember = "Text";
            this.provincias_cbox.ValueMember = "Value";


            foreach (var provincia in base.data_geo.provincias)
            {
                this.provincias_cbox.Items.Add(new { Text = provincia.Value, Value = provincia.Key });
            }


        }


        private void provincias_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //si se cambia la provincia se limpian los items de los departamentos y localidades
            this.departamentos_cbox.Items.Clear();
            this.localidades_cbox.Items.Clear();

            //si se cambia la provincia se limpian el seleccionado de los departamentos y localidades
            this.departamentos_cbox.Text = "";
            this.localidades_cbox.Text = "";

            this.departamentos_cbox.DisplayMember = "Text";
            this.departamentos_cbox.ValueMember = "Value";


            this.selected_provincia = (this.provincias_cbox.SelectedItem as dynamic).Value;
          
            foreach (var row in base.data_geo.deptos[selected_provincia])
            {
                this.departamentos_cbox.Items.Add(new { Text = row.nombre, Value = row.id });

            }


            base.validComboBox(this.provincias_cbox);



        }

        private void departamentos_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si se cambia el departamento se limpian la localidad
            this.localidades_cbox.Items.Clear();
            this.localidades_cbox.Text = "";

            this.selected_departamento = (this.departamentos_cbox.SelectedItem as dynamic).Value;

            foreach (var row in base.data_geo.localidades[selected_provincia])
            {
                if (row.id_departamento== this.selected_departamento)
                {
                    this.localidades_cbox.Items.Add(row.nombre);
                }
                

            }

            base.validComboBox(this.departamentos_cbox);



        }

        private void localidad_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.validComboBox(this.localidades_cbox);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_TextWithSpace(this.nombre);

        }

        private void createCenter_Click(object sender, EventArgs e)
        {

            if (this.validateAll())
            {
                string nombre = this.nombre.Text;
                //string calle = this.calle.Text;
                //string numero = this.numero.Text;
                //string cp = this.numero.Text;
                string provincia = this.provincias_cbox.Text;
                string departamento = this.departamentos_cbox.Text;
                string localidad = this.localidades_cbox.SelectedItem.ToString();
                CenterVaccine center = new CenterVaccine(nombre, provincia, departamento, localidad);
                bool status = center.Crear();
                if (status)
                {
                    MessageBox.Show("Centro de vacunación creado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al crear el centro.");
                }
            }

        }


        //valida todos los input del form los add a una lista y verifica que todos sean true para habilitar el btn de
        //crear centro
        private bool validateAll()
        {
            List<bool> validate_list = new List<bool>();
            validate_list.Add(base.validInputTextBox_TextWithSpace(this.nombre));
            validate_list.Add(base.validComboBox(this.provincias_cbox));
            validate_list.Add(base.validComboBox(this.departamentos_cbox));
            validate_list.Add(base.validComboBox(this.localidades_cbox));

            return validate_list.All(x => x == true);


        }


        


     
    }
}

