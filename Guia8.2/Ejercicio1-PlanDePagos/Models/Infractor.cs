using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PlanDePagos.Models
{
    public class Infractor
    {
        public int DNI { get; set; }
        public string ApellidosYNombres { get; set; }
        public override string ToString()
        {
            return $"{ApellidosYNombres} - {DNI}";
        }
    }
}
