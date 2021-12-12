using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VACUN_ARG2
{
    

    public class Departamento
    {
        public string id { get; set; }
        public string nombre { get; set; }
    }

    public class Localidad
    {
        public string id { get; set; }
        public string id_departamento { get; set; }
        public string nombre { get; set; }
    }

    public class Paises
    {
        public string name_en { get; set; }
        public string name_es { get; set; }
        public string dial_code { get; set; }
        public string code { get; set; }
    }

    public class DataGeo
    {
        public Dictionary<string, List<Paises>> paises = new Dictionary<string, List<Paises>>();
        public Dictionary<string, string> provincias;
        public Dictionary<string, List<Departamento>> deptos = new Dictionary<string, List<Departamento>>();
        public Dictionary<string, List<Localidad>> localidades = new Dictionary<string, List<Localidad>>();

        public void loadResources()
        {
            //carga las provincias desde el json en resources
            string provincias_str = @Properties.Resources.provincias_mod.ToString();
            this.provincias = JsonConvert.DeserializeObject<Dictionary<string, string>>(provincias_str);

            //carga los departamentos desde el json en resources
            string deptos_str = @Properties.Resources.departamentos_mod.ToString();

            this.deptos = JsonConvert.DeserializeObject<Dictionary<string, List<Departamento>>>(deptos_str);

            //carga las localidades desde el json en resources
            string localidades_str = @Properties.Resources.localidades_mod.ToString();
            this.localidades = JsonConvert.DeserializeObject<Dictionary<string, List<Localidad>>>(localidades_str);

            //carga las localidades desde el json en resources
            string paises_str = @Properties.Resources.paises.ToString();
            this.paises = JsonConvert.DeserializeObject<Dictionary<string, List<Paises>>>(paises_str);

        }
    }
}
