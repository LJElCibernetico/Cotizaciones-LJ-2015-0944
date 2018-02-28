using CotizacionesLJ.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace CotizacionesLJ.Consultas
{
    public partial class cArticulos : Form
    {
        List<Articulos> lista = new List<Articulos>();
        public cArticulos()
        {
            InitializeComponent();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            decimal precio;
            Expression<Func<Articulos, bool>> all = x => true;

            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                ID = int.Parse(CriteriotextBox.Text);
                lista = BLL.ArticulosBLL.GetList(t => t.ArticuloID == ID);
                all = x => x.ArticuloID == ID;
            }

            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                precio = decimal.Parse(CriteriotextBox.Text);
                lista = BLL.ArticulosBLL.GetList(nc => nc.precio == precio);
                all = x => x.precio == precio;
            }

            if (FiltrarcomboBox.Text == string.Empty || CriteriotextBox.Text == string.Empty)
                lista = BLL.ArticulosBLL.GetList(all);

            NotasDeCreditodataGridView.DataSource = lista;
        }
    }
}
