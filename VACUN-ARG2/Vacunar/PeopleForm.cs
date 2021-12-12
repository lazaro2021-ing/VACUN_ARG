using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VACUN_ARG2.Center;

namespace VACUN_ARG2.Vacunar
{
    public partial class PeopleForm : BaseForm
    {
      

        private string selected_provincia;
        private string selected_departamento;
      
        public PeopleForm()
        {

            InitializeComponent();


            base.setErrorProvider = this.errorProvider1;

            //this.crear_btn.Enabled = false;

            this.provincias_cbox.DisplayMember = "Text";
            this.provincias_cbox.ValueMember = "Value";


            foreach (var provincia in this.data_geo.provincias)
            {
                this.provincias_cbox.Items.Add(new { Text = provincia.Value, Value = provincia.Key });
            }

            foreach (var row in this.data_geo.paises["countries"])
            {
                this.nacionalidad_cbox.Items.Add(row.name_es);
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
                if (row.id_departamento == this.selected_departamento)
                {
                    this.localidades_cbox.Items.Add(row.nombre);
                }


            }
            base.validComboBox(this.departamentos_cbox);


        }

        private void localidad_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Text(this.nombre);
        }

       


        //valida todos los input del form los add a una lista y verifica que todos sean true para habilitar el btn de
        private bool validateAll()
        {
            List<bool> validate_list = new List<bool>();
            validate_list.Add(base.validInputTextBox_TextWithSpace(this.nombre));
            validate_list.Add(base.validComboBox(this.dni_type));
            validate_list.Add(base.validInputTextBox_Number(this.dni));
            validate_list.Add(base.validInputTextBox_Number(this.cp_textbox));
            validate_list.Add(base.validInputTextBox_TextWithSpace(this.calle_textbox));
            validate_list.Add(base.validInputTextBox_Number(this.numero_textbox));
            validate_list.Add(base.validInputTextBox_Number(this.cp_textbox));
            validate_list.Add(base.validInputTextBox_Number(this.tel_emergencias_textbox));
            validate_list.Add(base.validInputTextBox_Number(this.tel_personal_textbox));
            validate_list.Add(base.validComboBox(this.provincias_cbox));
            validate_list.Add(base.validComboBox(this.departamentos_cbox));
            validate_list.Add(base.validComboBox(this.localidades_cbox));
            validate_list.Add(base.validComboBox(this.nacionalidad_cbox));
            validate_list.Add(this.validEmail(this.email_textbox));

            return validate_list.All(x => x == true);
            
        }

        //carga desde resourse los datos de las provincias,departamentos y localidades.
      

        private void calle_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Text(this.calle_textbox);
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.numero_textbox);
        }

        private void cp_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.cp_textbox);
        }

        private void crear_btn_Click(object sender, EventArgs e)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            if (this.validateAll()){
                string nombre = myTI.ToTitleCase(this.nombre.Text);
                string dni_type = this.dni_type.SelectedItem.ToString();
                string dni_numero = this.dni.Text;
                string nacionalidad = this.nacionalidad_cbox.SelectedItem.ToString();
                string fecha_nacimiento = this.nacimiento_datetime.Text;
                string dir_calle = myTI.ToTitleCase(this.calle_textbox.Text);
                string dir_num = this.numero_textbox.Text;
                string dir_cp = this.cp_textbox.Text;
                string provincia = this.provincias_cbox.Text;
                string departamento = this.departamentos_cbox.Text;
                string localidad = this.localidades_cbox.SelectedItem.ToString();
                string tel_personal = this.tel_personal_textbox.Text;
                string tel_emergencias = this.tel_emergencias_textbox.Text;
                string email = this.email_textbox.Text;

                People people = new People(nombre);
                people.setDocumentInfo(dni_type, dni_numero, nacionalidad, fecha_nacimiento);
                people.setAddress(dir_calle, dir_num, dir_cp);
                people.setLocalidad(provincia, departamento, localidad);
                people.setInfo(tel_personal, tel_emergencias, email);

                bool status=people.crear();
                if (status)
                {
                    MessageBox.Show("Registro de persona exitoso.");
                }
                else
                {
                    MessageBox.Show("Error al registrar persona.");
                }
            }

        }

        private void nombre_TextChanged_1(object sender, EventArgs e)
        {
            base.validInputTextBox_TextWithSpace(this.nombre);
        }


        private void dniNumero_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.dni);
        }


        private void calle_textbox_TextChanged(object sender, EventArgs e)
        {

            base.validInputTextBox_TextWithSpace(this.calle_textbox);
        }

        private void numero_textbox_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.numero_textbox);
        }

        private void cp_textbox_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.cp_textbox);
        }

        private void tel_personal_textbox_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.numero_textbox);
        }

        private void tel_emergencias_textbox_TextChanged(object sender, EventArgs e)
        {
            base.validInputTextBox_Number(this.tel_emergencias_textbox);
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            this.validEmail(this.email_textbox);
        }

        public bool validEmail(System.Windows.Forms.TextBox element)
        {
            string text = element.Text;

            if (text.IndexOf("@")>0 && text.IndexOf(".") > 0 && text.IndexOf("@")<text.IndexOf("."))
            {
                this.errorProvider1.SetError(element, "");
                return true;
            }
            else
            {
                
                this.errorProvider1.SetError(element, "Email no valido.");
                
                return false;
            }
        }

        private void dni_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.validComboBox(this.dni_type);
        }

        private void nacionalidad_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.validComboBox(this.nacionalidad_cbox);
        }
    }





}

