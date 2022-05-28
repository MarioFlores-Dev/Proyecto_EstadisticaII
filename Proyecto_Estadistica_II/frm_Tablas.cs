using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estadistica_II
{
    public partial class frm_Tablas : Form
    {
        public frm_Tablas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaT tt = new TablaT();
            tt.Show();
        }

        private void btn_tablaZ_Click(object sender, EventArgs e)
        {
            TablaZ tz = new TablaZ();
            tz.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tablas.ProbabilidadBinomial1 pb1 = new Tablas.ProbabilidadBinomial1();
            pb1.Show();
        }

        private void btn_pb2_Click(object sender, EventArgs e)
        {
            Tablas.ProbabilidadBinomial2 pb2 = new Tablas.ProbabilidadBinomial2();
            pb2.Show();
        }

        private void btn_pb3_Click(object sender, EventArgs e)
        {
            Tablas.ProbabilidadBinomial3 pb3 = new Tablas.ProbabilidadBinomial3();
            pb3.Show();
        }

        private void btn_t4a_Click(object sender, EventArgs e)
        {
            Tabla_4a t4a = new Tabla_4a();
            t4a.Show();
        }

        private void btn_t4b_Click(object sender, EventArgs e)
        {
            Tablas.Tabla_4b t4b = new Tablas.Tabla_4b();
            t4b.Show();
        }
    }
}
