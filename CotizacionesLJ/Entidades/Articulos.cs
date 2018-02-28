using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CotizacionesLJ.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloID { get; set; }
        public string Descripcion { get; set; }
        public decimal precio { get; set; }

        public Articulos(int articuloID, string descripcion, decimal precio)
        {
            ArticuloID = articuloID;
            Descripcion = descripcion;
            this.precio = precio;
        }

        public Articulos()
        {
            ArticuloID = 0;
            Descripcion = string.Empty;
            precio = 0;
        }
    }
}
