using CotizacionesLJ.Consultas;
using CotizacionesLJ.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CotizacionesLJ.Registros
{
    public partial class rArticulos : Form
    {
        public rArticulos()
        {
            InitializeComponent();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Articulos art = new Articulos();
            int.TryParse(IDnumericUpDown.Text, out ID);

            art = BLL.ArticulosBLL.Buscar(ID);

            if (art != null)
            {
                MessageBox.Show("Articulo Encontado");
                DescripciontextBox.Text = art.Descripcion;
                PrecionumericUpDown.Value = Convert.ToDecimal(art.precio);
            }
            else
            {
                MessageBox.Show("Articulo No Encontado");
            }
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDnumericUpDown.Text, out ID);
            Articulos art = BLL.ArticulosBLL.Buscar(ID);
            if (art == null)
            {
                Articulos art1 = LlenarClase();

                if (DescripciontextBox.Text == string.Empty || PrecionumericUpDown.Value == 0) 
                    ValidarerrorProvider.SetError(guardarbutton, "No puede dejar nada vacio");
                else if (BLL.ArticulosBLL.Guardar(art1))
                    MessageBox.Show("Nota de Credito Guardada");
                else if (!BLL.ArticulosBLL.Guardar(art1))
                    MessageBox.Show("Nota de Credito No Guardada");
            }
        }

        private Articulos LlenarClase()
        {
            Articulos art = new Articulos();
            int a;
            int.TryParse(IDnumericUpDown.Text, out a);
            art.ArticuloID = a;
            art.Descripcion = DescripciontextBox.Text;
            art.precio = PrecionumericUpDown.Value;
            return art;
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDnumericUpDown.Text, out ID);

            if (BLL.ArticulosBLL.Eliminar(ID))
                MessageBox.Show("Eliminado");
            else
                ValidarerrorProvider.SetError(eliminarbutton, "No se puede eliminar un articulo que no existe");
        }

        private void consultarbutton_Click(object sender, EventArgs e)
        {
            cArticulos ca = new cArticulos();
            ca.Show();
        }
    }
}
