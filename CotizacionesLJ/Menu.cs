using CotizacionesLJ.Consultas;
using CotizacionesLJ.Registros;
using CotizacionesLJ.Detalle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CotizacionesLJ
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void notasDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCotizaciones rc = new rCotizaciones();
            rc.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos ra = new rArticulos();
            ra.Show();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cArticulos ca = new cArticulos();
            ca.Show();
        }

        private void notasDeCreditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCotizaciones cc = new cCotizaciones();
            cc.Show();
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cotizacionesDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dDetalle d = new dDetalle();
            d.Show();
        }
    }
}
