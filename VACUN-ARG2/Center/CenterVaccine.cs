using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using VACUN_ARG2.Vaccine;

namespace VACUN_ARG2.Center
{
   
    class CenterVaccine:DBConnect
    {
        private int id;
        private string nombre;
        private string departamento;
        private string localidad;
        private string provincia;
        private List<int> id_vaccine;
        private DBConnect connect = new DBConnect();
        private string db_table="centers";
        private int dosis_aplicadas = 0;
        private int dosis_disponibles = 0;
        public CenterVaccine()
        {

        }

        public CenterVaccine(string _name, string _provincia, string _departamento, string _localidad)
        {
            this.nombre = _name;
            this.localidad = _localidad;
            this.provincia = _provincia;
            this.departamento = _departamento;
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Departamento
        {
            get { return this.departamento; }
            set { this.departamento = value; }
        }
        public string Localidad
        {
            get { return this.localidad; }
            set { this.localidad = value; }
        }
        public string Provincia
        {
            get { return this.provincia; }
            set { this.provincia = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Aplicadas
        {
            get { return this.dosis_aplicadas; }
            set { this.dosis_aplicadas = value; }
        }

        public int Disponibles
        {
            get { return this.dosis_disponibles; }
            set { this.dosis_disponibles = value; }
        }

        public bool Crear()
        {
            
            string query = $"INSERT INTO {this.db_table} (nombre,provincia,departamento,localidad,aplicadas) VALUES ('{this.nombre}','{this.provincia}','{this.departamento}','{this.localidad}','{this.dosis_aplicadas}');";
            bool status=this.connect.Insert(query);
            return status;
        }

        public bool setMacAddress(int id_center,string mac)
        {
            string query = $"UPDATE {this.db_table} SET macAddress='{mac}' WHERE id='{id_center}' ;";
            bool status=this.connect.Update(query);
            return status;
        }

        public void getNameById(int _id)
        {
            string query = $"SELECT nombre FROM {this.db_table} WHERE id='{_id}' ;";
            DataTable result = this.connect.Select(query);
            this.id = _id;
            this.nombre= result.Rows[0]["nombre"].ToString();
            
        }

        public int getIdByMacAddress(string mac)
        {
            string query = $"SELECT id FROM {this.db_table} WHERE macAddress='{mac}' ;";
            DataTable result = this.connect.Select(query);
            if (result.Rows.Count>0) {
                return Convert.ToInt32(result.Rows[0]["id"]);
            }
            else
            {
                return 0;
            }

        }




        public List<CenterVaccine> getAll()
        {
           
            string query = $"SELECT * FROM {this.db_table};";
            
            DataTable result = this.connect.Select(query);

            List<CenterVaccine> all_centers = new List<CenterVaccine>();
            foreach (DataRow row in result.Rows)
            {
                CenterVaccine center = new CenterVaccine(row["nombre"].ToString(), row["provincia"].ToString(), row["departamento"].ToString(), row["localidad"].ToString());
                center.id = Int32.Parse(row["id"].ToString());
                all_centers.Add(center);
            }

            return all_centers;
        }

        
        public void getCountVaccine()
        {
            string query = $"SELECT dosis,aplicadas FROM center_vaccine WHERE id_center='{this.id}' ;";
            DataTable result = this.connect.Select(query);

            foreach (DataRow row in result.Rows)
            {
                this.dosis_disponibles += Int32.Parse(row["dosis"].ToString())- Int32.Parse(row["aplicadas"].ToString());
                this.dosis_aplicadas+= Int32.Parse(row["aplicadas"].ToString());
            }     
        }

        public List<VaccineClass> getAllAvailableVaccine(int _id)
        {
            string query = $"SELECT * FROM center_vaccine WHERE id_center={_id} ;";
            DataTable result = this.connect.Select(query);

            List<VaccineClass> all_vaccine = new List<VaccineClass>();

            foreach (DataRow row in result.Rows)
            {
                query = $"SELECT * FROM vaccine WHERE  id={row["id_vaccine"]};";

                DataTable result_vaccine = this.connect.Select(query);

                foreach (DataRow row_v in result_vaccine.Rows)
                {
                    VaccineClass vaccine = new VaccineClass(row_v["name"].ToString(), Int32.Parse(row_v["dosis"].ToString()), row_v["pais"].ToString(), Int32.Parse(row_v["temp"].ToString()));
                   
                    vaccine.Id = Int32.Parse(row_v["id"].ToString());
                    vaccine.Aplicadas = Int32.Parse(row["aplicadas"].ToString());
                    vaccine.Dosis = Int32.Parse(row["dosis"].ToString());
                    vaccine.Disponibles = vaccine.Dosis - vaccine.Aplicadas;
                    all_vaccine.Add(vaccine);
                }
            }

            return all_vaccine;


        }

    }
}
