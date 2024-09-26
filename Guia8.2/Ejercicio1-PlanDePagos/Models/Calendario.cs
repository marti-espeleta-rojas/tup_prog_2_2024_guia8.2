using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PlanDePagos.Models
{
    public class Calendario
    {
        public int CantidadFeriados
        {
            get
            {
                return feriados.Count;
            }
        }
        ArrayList feriados = new ArrayList();
        public Feriado this[DateTime dia]
        {
            get
            {
                foreach(Feriado f in feriados)
                {
                    //Feriado f = feriados[i] as Feriado;
                    if (dia.Day==f.Fecha.Day && dia.Month==f.Fecha.Month && dia.Year==f.Fecha.Year)
                    {
                        return f; 
                    }
                }
                return null;
                //return feriados[idx] as Feriado;
            }
        }

        public Feriado this[int idx]
        {
            get
            {  
                if(idx > 0 && idx < feriados.Count)
                {
                    if (feriados[idx] is Feriado)
                    {
                        Feriado feriado = feriados[idx] as Feriado;
                        return feriado;
                    }
                }
                return null;
            }
        }

        public Feriado AgregarFeriado(DateTime dia, string descripcion)
        {
            Feriado feriado = new Feriado(dia, descripcion);
            feriados.Add(feriado);
            return feriado;
        }
    }
}
