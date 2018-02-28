using Microsoft.VisualStudio.TestTools.UnitTesting;
using CotizacionesLJ.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CotizacionesLJ.Entidades;

namespace CotizacionesLJ.BLL.Tests
{
    [TestClass()]
    public class CotizacionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos a = new Articulos();
            a.ArticuloID = 1;
            a.Descripcion = "Este no sirve";
            a.precio = 5000;

            bool paso = CotizacionesBLL.Guardar(a);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}