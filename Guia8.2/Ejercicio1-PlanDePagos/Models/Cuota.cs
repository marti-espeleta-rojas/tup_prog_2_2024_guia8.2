using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PlanDePagos.Models
{
    public class Cuota
    {
        public int Numero { get; private set; }
        public double MontoBase { get; set; }
        public double PorcenVoluntario { get; set; }
        public double MontoVoluntario { get; private set; }
        public DateTime FechaPrimerVencimiento { get; set; }
        public double MontoPrimerVenc { get; private set; }
        public DateTime FechaSegundoVenc { get; private set; }
        public double MontoSegundoVenc { get; private set; }
        public double PorcenSegundoVenc { get; set; }
        public double SobreCargoMontoSegundoVenc { get; private set; }  
        public double MontoSegundoVencConSobre { get; private set; }
        public override string ToString()
        {
            return 
        }
    }
}
