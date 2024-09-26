using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PlanDePagos.Models
{
    public class PlanDePago
    {
        public double Monto { get; private set; }
        public int CantidadCuotas { get; private set; }
        public DateTime FechaAlta { get; private set; }
        public double MontoTotalFinanciado { get; private set; }
        public Infractor Destinatario { get; private set; }
        List<Cuota> cuotas = new List<Cuota> { };

        public PlanDePago(double monto, int cantcuotas, DateTime fechaAlta, Infractor destinatario, Calendario calendar)
        {
            Monto = monto;
            CantidadCuotas = cantcuotas;
            FechaAlta = fechaAlta;
            Destinatario = destinatario;
            //me falta el calendar

        }

        public Cuota VerCuota(int idx)
        {
            Cuota c = cuotas[idx];
        }
    }
}
