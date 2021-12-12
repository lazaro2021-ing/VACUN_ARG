using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using VACUN_ARG2.Center;

namespace VACUN_ARG2.Vaccine

{
    class VaccineClass:DBConnect
    {
        private int id;
        private string name;
        private int dosis;
        private string pais;
        private int temp;
        private int aplicadas=0;
        private int disponibles;
        private DBConnect connect = new DBConnect();
        private string db_table = "vaccine";
        public VaccineClass()
        {
            
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Dosis
        {
            get { return this.dosis; }
            set { this.dosis = value; }
        }
        public string Pais
        {
            get { return this.pais; }
            set { this.pais = value; }
        }

        public int Aplicadas
        {
            get { return this.aplicadas; }
            set { this.aplicadas = value; }
        }

        public int Temp
        {
            get { return this.temp; }
            set { this.temp = value; }
        }
        public int Disponibles
        {
            get { return this.disponibles; }
            set { this.disponibles = value; }
        }

        public  VaccineClass(string _name, int _dosis, string _pais, int _temp)
        {
            this.name = _name;
            this.dosis = _dosis;
            this.disponibles = _dosis;
            this.pais = _pais;
            this.temp = _temp;

        }

        //crea la vacuna.
        public bool Crear(string _name, int _dosis,string _pais,int _temp)
        {
            this.name = _name;
            this.dosis = _dosis;
            this.disponibles = _dosis;
            this.pais = _pais;
            this.temp = _temp;

            string query = $"INSERT INTO {this.db_table} (name,dosis,disponibles,aplicadas,pais,temp) VALUES ('{this.name}','{this.dosis}','{this.disponibles}','0','{this.pais}','{this.temp}');";
            bool status=this.connect.Insert(query);
            return status;
        }

        //obtiene de la db la vacuna por nombre.
        public void getVaccineByName(string name)
        {
            string query = $"SELECT id,name,dosis,disponibles,aplicadas,pais,temp FROM {this.db_table} WHERE name LIKE '{name}' LIMIT 1;";

            DataTable  result= this.connect.Select(query);
            this.id = Int32.Parse(result.Rows[0]["id"].ToString());
            this.name = result.Rows[0]["name"].ToString();
            this.dosis = Int32.Parse(result.Rows[0]["dosis"].ToString());
            this.disponibles = Int32.Parse(result.Rows[0]["disponibles"].ToString());
            this.aplicadas= Int32.Parse(result.Rows[0]["aplicadas"].ToString());
            this.pais = result.Rows[0]["pais"].ToString();
            this.temp = Int32.Parse(result.Rows[0]["temp"].ToString());
        }

        //obtiene de la db la vacuna por id.
        public void getVaccineById(int _id)
        {
            string query = $"SELECT id,name,dosis,disponibles,aplicadas,pais,temp FROM {this.db_table} WHERE id LIKE '{_id}' LIMIT 1;";

            DataTable result = this.connect.Select(query);
            this.id = Int32.Parse(result.Rows[0]["id"].ToString());
            this.name = result.Rows[0]["name"].ToString();
            this.dosis = Int32.Parse(result.Rows[0]["dosis"].ToString());
            this.disponibles = Int32.Parse(result.Rows[0]["disponibles"].ToString());
            this.aplicadas = Int32.Parse(result.Rows[0]["aplicadas"].ToString());
            this.pais = result.Rows[0]["pais"].ToString();
            this.temp = Int32.Parse(result.Rows[0]["temp"].ToString());
        }

        //al aplicar una vacuna se le resta a las disponibles y se suma a plas aplicadas
        //faltaria que se resten a las disponibles del centro y se sume a las aplicadas por el centro
        public void Vacunar(int _id_people,int _id_center,int _dosis)
        {
            
            string query = $"SELECT id,id_vaccine,id_center,dosis,aplicadas FROM center_vaccine WHERE id_vaccine='{this.id}' AND id_center='{_id_center}' LIMIT 1;";
            DataTable result_table = this.connect.Select(query);

            int dosis = Int32.Parse(result_table.Rows[0]["dosis"].ToString()) ;
            int aplicadas = Int32.Parse(result_table.Rows[0]["aplicadas"].ToString());
            
            if (dosis-aplicadas>0) { 
                //insert en la tabla people_vaccine
                query = $"INSERT INTO people_vaccine (id_people,id_vaccine,id_center_p,dosis,fecha) Values ('{_id_people}','{this.id}','{_id_center}','{_dosis}','{DateTime.Now.ToString("dd-MM-yyyy")}');";
                bool result=this.connect.Insert(query);

                if (result)
                {
                    // update en la tabla de vacunas
                    this.aplicadas += 1;
                    this.disponibles -= 1;
                    query = $"UPDATE {this.db_table} SET aplicadas='{this.aplicadas}',disponibles='{this.disponibles}'  WHERE id='{this.id}';";
                    this.connect.Update(query);

                    //actualizacion en la tabla de center_vaccine
                    query = $"UPDATE center_vaccine SET aplicadas='{aplicadas+1}'  WHERE id_center='{_id_center}' AND  id_vaccine='{this.id}';";
                    this.connect.Update(query);

                    MessageBox.Show("Vacunacion registrada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al  registrar exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("Error al  registrar ,no existe la dosis.Solicite mas dosis.");
            }


        }

        //asignar una cantidad de vacunas a un centro,y se descuentan de las disponibles.
        //falta la parte que se asignan al centro
        public void AssignDosis(int _id_center, int _dosis)
        {
            if (_dosis <= this.disponibles) { 
                string query = $"INSERT INTO center_vaccine (id_vaccine,id_center,dosis,aplicadas) Values ('{this.id}','{_id_center}','{_dosis}','0');";
                this.connect.Insert(query);

                string query1 = $"UPDATE {this.db_table} SET disponibles='{this.disponibles-_dosis}'  WHERE id='{this.id}';";
                bool status = this.connect.Update(query1);
                if (status)
                {
                    MessageBox.Show("Dosis asignadas  exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al asignadas las dosis.");
                }
            }
            else
            {
                MessageBox.Show($"El numero de dosis disponible no alcanza.Solo existen {this.disponibles} dosis. ");
            }
        }

        //agrega dosis a una determinada vacuna
        public void AddDosis(int _dosis)
        {
            this.dosis += _dosis;
            this.disponibles += _dosis;
            string query = $"UPDATE {this.db_table} SET dosis='{this.dosis}',disponibles='{this.disponibles}'  WHERE id='{this.id}';";
            bool status=this.connect.Update(query);
            if (status)
            {
                MessageBox.Show("Dosis añadidas  exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al añadidas las dosis.");
            }


        }

      

        //obtiene toda las filas de la db y crea una lista de todas las vacunas
        public List<VaccineClass> getAll()
        {
            
            string query = $"SELECT * FROM {this.db_table};";

            DataTable result = this.connect.Select(query);

            List<VaccineClass> all_vaccine = new List<VaccineClass>();
            foreach (DataRow row in result.Rows)
            {
                VaccineClass vaccine = new VaccineClass(row["name"].ToString(), Int32.Parse(row["dosis"].ToString()), row["pais"].ToString(), Int32.Parse(row["temp"].ToString()));
                vaccine.id = Int32.Parse(row["id"].ToString());
                vaccine.Aplicadas = Int32.Parse(row["aplicadas"].ToString());
                vaccine.Disponibles = Int32.Parse(row["disponibles"].ToString());
                all_vaccine.Add(vaccine);
            }

            return all_vaccine;
        }

        public List<VaccineClass> getAllInCenter(int _id_center)
        {

            string query  = $"SELECT id_vaccine FROM center_vaccine WHERE  id_center='{_id_center}';";

            DataTable result = this.connect.Select(query);

            List<VaccineClass> all_vaccine = new List<VaccineClass>();
            foreach (DataRow row in result.Rows)
            {
                VaccineClass vaccine = new VaccineClass();
                vaccine.getVaccineById(Int32.Parse(row["id_vaccine"].ToString()));
                all_vaccine.Add(vaccine);
            }

            return all_vaccine;
        }

        public List<PeopleVaccine> getVaccineAplicadas()
        {
            List<PeopleVaccine> people_vaccine_list = new List<PeopleVaccine>();
            string query = $"SELECT * FROM people_vaccine ;";

            DataTable result = this.connect.Select(query);
            foreach (DataRow row in result.Rows)
            {
               
                this.getVaccineById(Int32.Parse(row["id_vaccine"].ToString()));
                PeopleVaccine people_vaccine = new PeopleVaccine
                {
                    id = Int32.Parse(row["id"].ToString()),
                    id_center = Int32.Parse(row["id_center_p"].ToString()),
                    id_people = Int32.Parse(row["id_people"].ToString()),
                    id_vaccine = Int32.Parse(row["id_vaccine"].ToString()),
                    fecha = DateTime.Parse(row["fecha"].ToString()),
                    name_vaccine = this.name,
                };
                people_vaccine_list.Add(people_vaccine);
            }

            return people_vaccine_list;

        }



    }
}
