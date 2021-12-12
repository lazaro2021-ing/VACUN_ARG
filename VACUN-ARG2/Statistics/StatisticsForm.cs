﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VACUN_ARG2.Vaccine;

namespace VACUN_ARG2.Statistics
{
    public partial class StatisticsForm : BaseForm
    {
        private DateTime from_fecha;
        private DateTime to_fecha;
        public StatisticsForm()
        {
            InitializeComponent();
            
        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics plot = panel.CreateGraphics();
            VaccineClass vaccine = new VaccineClass();
            List<PeopleVaccine> vaccine_aplicadas=vaccine.getVaccineAplicadas();
            int index = 0;
            int cantidad_dosis_aplicadas =0;
            Dictionary<int, int> count_vaccine = new Dictionary<int, int>();


            foreach (PeopleVaccine row in vaccine_aplicadas)
            {
                if (DateTime.Compare(row.fecha,this.from_fecha)>=0 && DateTime.Compare(row.fecha, this.to_fecha) <= 0) { 
                    
                     if (count_vaccine.ContainsKey(row.id_vaccine))
                    {
                        count_vaccine[row.id_vaccine]+=1;

                    }
                    else
                    {
                        count_vaccine.Add(row.id_vaccine, 1);
                    }
                    cantidad_dosis_aplicadas++;
                }
            }

            int angle_prev = 0;
            foreach (var row in count_vaccine)
            {
                
                SolidBrush color = new SolidBrush(Color.FromArgb(255, 255, 255 * index / count_vaccine.Count, 255 * index / count_vaccine.Count));
                plot.FillPie(color, 10, 10, 350, 350, angle_prev, 360 * count_vaccine[row.Key] / cantidad_dosis_aplicadas);
                angle_prev += 360 * count_vaccine[row.Key] / cantidad_dosis_aplicadas;
                plot.FillRectangle(color, 450, 10+index*35,30, 20);
                vaccine.getVaccineById(row.Key);
                plot.DrawString($"{vaccine.Name} (Dosis:{count_vaccine[row.Key]}-{100*count_vaccine[row.Key] / cantidad_dosis_aplicadas}%)", new Font("Arial", 12), new SolidBrush(Color.Black), 480, 10+index * 35);
                index++;
            }
            if(cantidad_dosis_aplicadas>0)
            {
                plot.DrawString($"Total de dosis aplicadas:{cantidad_dosis_aplicadas}", new Font("Arial", 12), new SolidBrush(Color.Black), 480, 10 + index * 35);
            }
             


        }

        private void consultar_Click(object sender, EventArgs e)
        {
            this.from_fecha =DateTime.Parse(this.from.Value.ToString("yyyy-MM-dd"));
            this.to_fecha = DateTime.Parse(this.to.Value.ToString("yyyy-MM-dd"));
            Refresh();
        }
    }
}
