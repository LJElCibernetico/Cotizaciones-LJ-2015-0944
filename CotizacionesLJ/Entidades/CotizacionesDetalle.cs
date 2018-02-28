using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CotizacionesLJ.Entidades
{
    public class CotizacionesDetalle
    {
        public int detalleID { get; set; }
        public int cotizacionID { get; set; }
        public int articuloID { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

        public CotizacionesDetalle(int detalleID, int cotizacionID, int articuloID, int cantidad, decimal precio)
        {
            this.detalleID = detalleID;
            this.cotizacionID = cotizacionID;
            this.articuloID = articuloID;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public CotizacionesDetalle()
        {
            detalleID = 0;
            cotizacionID = 0;
            articuloID = 0;
            cantidad = 0;
            precio = 0;
        }
    }
}
