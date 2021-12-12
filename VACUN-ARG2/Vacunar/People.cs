using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using VACUN_ARG2.Vaccine;

namespace VACUN_ARG2.Vacunar
{
    class People:DBConnect
    {
        private int id;
        private string name; 
        private string dni_type;
        private int dni_numero;
        private string nacionalidad;
        private string fecha_nacimiento;
        private string dir_calle;
        private int dir_num;
        private int dir_cp;
        private string provincia;
        private string departamento;
        private string localidad;
        private string tel_personal;
        private string tel_emergencias;
        private string email;
        private List<VaccineClass> vaccine_list=new List<VaccineClass>();
        public List<int> vaccine_dosis = new List<int>();
        public List<string> vaccine_fecha= new List<string>();

        private string db_table = "people";
        private DBConnect connect = new DBConnect();
        public People()
        {
        }
        public People(string _nombre)
        {
            this.name = _nombre;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Dni_type
        {
            get { return this.dni_type; }
            set { this.dni_type = value; }
        }

        public int Dni_numero
        {
            get { return this.dni_numero; }
            set { this.dni_numero = value; }
        }

        public string Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public List<VaccineClass> Vaccine_list
        {
            get { return this.vaccine_list; }
            
        }


        public void setDocumentInfo(  string _dni_type,string _dni_numero,string _nacionalidad,string _fecha_nacimiento)
        {
            this.dni_type= _dni_type;
            this.dni_numero= Int32.Parse(_dni_numero);
            this.nacionalidad= _nacionalidad;
            this.fecha_nacimiento= _fecha_nacimiento;
        }

        public void setAddress(  string _dir_calle,string _dir_num,string _dir_cp)
        {
            this.dir_calle= _dir_calle;
            this.dir_num=Int32.Parse( _dir_num);
            this.dir_cp= Int32.Parse(_dir_cp);
        }

        public void setLocalidad( string _provincia, string _departamento, string _localidad)
        {
            this.provincia= _provincia;
            this.departamento= _departamento;
            this.localidad= _localidad;
        }

        public void setInfo( string _tel_personal,string _tel_emergencias,string _email)
        {
            this.tel_personal =_tel_personal;
            this.tel_emergencias = _tel_emergencias;
            this.email = _email;
        }

        public bool crear()
        {
            string query = $"INSERT INTO {this.db_table} (name,dni_type,dni_numero,nacionalidad,nacimiento,calle,numero,cp,provincia,departamento,localidad,tel_personal,tel_emergencias,email) " +
                            $"VALUES ('{this.name}','{this.dni_type}','{this.dni_numero}','{this.nacionalidad}','{this.fecha_nacimiento}','{this.dir_calle}'," +
                            $"'{this.dir_num}','{this.dir_cp}','{this.provincia}','{this.departamento}','{this.localidad}','{this.tel_personal}','{this.tel_emergencias}','{this.email}');";
            bool status = this.connect.Insert(query);
            return status;
        }

        
        public bool findByDNI(int _dni,string _dni_type)
        {
            string query = $"SELECT  id,name,dni_type,dni_numero,nacionalidad FROM {this.db_table} WHERE  dni_numero='{_dni}' AND dni_TYPE='{_dni_type}';";

            DataTable result = this.connect.Select(query);
            if (result.Rows.Count > 0) { 
                this.id = Int32.Parse(result.Rows[0]["id"].ToString());
                this.name = result.Rows[0]["name"].ToString();
                this.dni_type = result.Rows[0]["dni_type"].ToString();
                this.dni_numero = Int32.Parse(result.Rows[0]["dni_numero"].ToString());
                this.nacionalidad = result.Rows[0]["nacionalidad"].ToString();

                return true;
            }
            else
            {
                MessageBox.Show("Persona no encontrada.");
                return false;
            }

        }

        public void findVaccineAplicadas()
        {
            string query = $"SELECT  id,id_vaccine,dosis,fecha FROM people_vaccine WHERE  id_people='{this.id}';";
            DataTable result = this.connect.Select(query);
            foreach (DataRow row in result.Rows)
            {
                VaccineClass vaccine = new VaccineClass();
                vaccine.getVaccineById(Int32.Parse(row["id_vaccine"].ToString()));
                this.vaccine_list.Add(vaccine);
                this.vaccine_dosis.Add(Int32.Parse(row["dosis"].ToString()));
                this.vaccine_fecha.Add(row["fecha"].ToString());
            }
        }
    }
}
