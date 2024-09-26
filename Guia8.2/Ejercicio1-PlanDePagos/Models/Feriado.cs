using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PlanDePagos.Models
{
    public class Feriado
    {
        public DateTime Fecha;
        public string Descripcion;

        public Feriado(DateTime fecha, string descripcion)
        {
            Fecha = fecha;
            Descripcion = descripcion;
        }
     
    }
}
