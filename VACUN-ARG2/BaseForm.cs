using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VACUN_ARG2.Center;
using VACUN_ARG2.Configuracion;

namespace VACUN_ARG2
{
    

    public class BaseForm : Form
    {
        private ErrorProvider errorProvider;

        public Config_class config = new Config_class();

        public DataGeo data_geo = new DataGeo();

        

        public BaseForm()
        {
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         
            data_geo.loadResources();
            
        }

        public ErrorProvider setErrorProvider {set { this.errorProvider = value; }}

        public bool validInputTextBox_TextWithSpace(System.Windows.Forms.TextBox element)
        {
            string text = element.Text.Replace(" ", "");

            if (text.Trim() != string.Empty && text.All(char.IsLetter))
            {
                this.errorProvider.SetError(element, "");
                return true;
            }
            else
            {
                if (!element.Text.All(char.IsLetter))
                {
                    this.errorProvider.SetError(element, "Solo debe contener letras.");
                }
                else
                {
                    this.errorProvider.SetError(element, "Obligatorio.");

                }
                return false;
            }
        }


        //valida que el contenido de un input box no este vacio y todos sus caracteres sean letras
        public bool validInputTextBox_Text(System.Windows.Forms.TextBox element)
        {

            
            if (element.Text.Trim() != string.Empty && element.Text.All(char.IsLetter))
            {
                this.errorProvider.SetError(element, "");
                return true;
            }
            else
            {
                if (!element.Text.All(char.IsLetter))
                {
                    this.errorProvider.SetError(element, "Solo debe contener letras.");
                }
                else
                {
                    this.errorProvider.SetError(element, "Obligatorio.");

                }
                return false;
            }
        }

        //valida que el contenido de un input box no este vacio y todos sus caracteres sean digitos
        public bool validInputTextBox_Number(System.Windows.Forms.TextBox element)
        {

            if (element.Text.Trim() != string.Empty && element.Text.All(char.IsNumber))
            {
                this.errorProvider.SetError(element, "");
                return true;
            }
            else
            {
                if (!element.Text.All(char.IsNumber))
                {
                    this.errorProvider.SetError(element, "Solo debe numeros.");
                }
                else
                {
                    this.errorProvider.SetError(element, "Obligatorio.");

                }
                return false;
            }
        }

        //valida el combobox que el elemento seleccionado no este vacio
        public bool validComboBox(System.Windows.Forms.ComboBox element)
        {
            if (element.Text.Trim() != string.Empty)
            {
                this.errorProvider.SetError(element, "");
                return true;
            }
            else
            {
                this.errorProvider.SetError(element, "Obligatorio.");
                return false;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }

        
    }
}
