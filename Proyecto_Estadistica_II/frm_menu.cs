using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estadistica_II
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_distribuciones_Click(object sender, EventArgs e)
        {
            frm_distribuciones dist = new frm_distribuciones();
            dist.Show();
            
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_muestreo_Click(object sender, EventArgs e)
        {
            frm_DistribucionesMuestreo md = new frm_DistribucionesMuestreo();
            md.Show();
            
        }

        private void btn_estimaciones_Click(object sender, EventArgs e)
        {
            frm_Estimaciones t2 = new frm_Estimaciones();
            t2.Show();
        }

        private void btn_Tablas_Click(object sender, EventArgs e)
        {
            frm_Tablas tbls = new frm_Tablas();
            tbls.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_EstadisticaI e1 = new frm_EstadisticaI();
            e1.Show();
        }

        private void btn_Hipotesis_Click(object sender, EventArgs e)
        {
            frm_PruebaHipotesis pH = new frm_PruebaHipotesis();
            pH.Show();
        }

        private void btn_Documentación_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/drive/folders/1gOyaorK3I9l3oTFCPzk-yie0qm72WgO6?usp=sharing");
        }
    }
}
