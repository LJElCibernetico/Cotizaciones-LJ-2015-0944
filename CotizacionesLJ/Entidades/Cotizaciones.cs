using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CotizacionesLJ.Entidades
{
    public class Cotizaciones
    {
        public int cotizacionesID { get; set; }
        public DateTime fecha { get; set; }
        public string comentarios { get; set; }
        public decimal monto { get; set; }

        public Cotizaciones(int cotizacionesID, DateTime fecha, string comentarios, decimal monto)
        {
            this.cotizacionesID = cotizacionesID;
            this.fecha = fecha;
            this.comentarios = comentarios;
            this.monto = monto;
        }

        public Cotizaciones()
        {
            cotizacionesID = 0;
            fecha = DateTime.Now;
            comentarios = string.Empty;
            monto = 0; 
        }
    }
}
