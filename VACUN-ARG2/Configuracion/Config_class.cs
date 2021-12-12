using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using VACUN_ARG2.Center;

namespace VACUN_ARG2.Configuracion
{
   
    public class Config_class
    {
        public int id_center { get; set; }
        public String macAddress;

        public Config_class()
        {
            this.id_center = 0;
        }
        public void getMacAddres()
        {
            this.macAddress =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
        }

        public void getIdCenter()
        {
            CenterVaccine center = new CenterVaccine();
            this.id_center = center.getIdByMacAddress(this.macAddress);
        }

    }
}
