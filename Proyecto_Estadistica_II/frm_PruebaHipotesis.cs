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
    public partial class frm_PruebaHipotesis : Form
    {
        public int calc = 0;
        public int tabl = 0;
        public frm_PruebaHipotesis()
        {
            InitializeComponent();
        }

        private void btn_ErrorEstMedia_Click(object sender, EventArgs e)
        {
            lbl_tittle.Text = btn_ErrorEstMedia.Text;
            panel1.Visible = true;
            pnl_estandarizacion.Visible = true;
            Limpiar();
            calc = 0;
            lblTItulo.Text = "Error Estándar de la muestra";
            lblvar1.Text = "Desviación Estándar (σ)";
            lblvar2.Text = "Población (n)";
            lblvar3.Text = "";
            lblvar4.Text = "";
            lblRes.Text = "σx =";
            lblVarAb.Text = "√(n)";
            lblVarArr.Text = "σ";
            lbl_resultado.Text = "";
            lblRaiz.Visible = false;
            lblRaiz2.Visible = false;
            txtvar4.Visible = false;
            txtvar3.Visible = false;
            btn_tabla.Visible = false;
        }

        private void frm_PruebaHipotesis_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pnl_estandarizacion.Visible = false;
            calc = 0;
            lblTItulo.Text = "Error Estándar de la muestra";
            lblvar1.Text = "Desviación Estándar (σ)";
            lblvar2.Text = "Población (n)";
            lblvar3.Text = "";
            lblvar4.Text = "";
            lblRes.Text = "σx = ";
            lblVarAb.Text = "√(n)";
            lblVarArr.Text = "σ";
            lbl_resultado.Text = "";
            txtvar4.Visible = false;
            txtvar3.Visible = false;
            btn_tabla.Visible = false;
            Limpiar();

        }
        private void Limpiar()
        {
            txtvar1.Text = "";
            txtvar2.Text = "";
            txtvar3.Text = "";
            txtvar4.Text = "";
        }

        private void btnCantErrEst_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbl_tittle.Text = btnCantErrEst.Text;
            panel1.Visible = true;
            pnl_estandarizacion.Visible = true;
            calc = 1;
            lblTItulo.Text = "Cantidad de Errores Estándar \nde la Muestra";
            lblvar1.Text = "Tamaño de la muestra (x)";
            lblvar2.Text = "Media (μ)";
            lblvar3.Text = "Error Estándar de la Media (σₓ)";
            lblvar4.Text = "";
            lblRes.Text = "z =";
            lblVarAb.Text = "σₓ";
            lblVarArr.Text = "x - μ";
            lbl_resultado.Text = "";
            lblRaiz.Visible = false;
            lblRaiz2.Visible = false;
            txtvar3.Visible = true;
            txtvar4.Visible = false;
            btn_tabla.Visible = true;
            tabl = 0;
        }

        private void btbPhM_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbl_tittle.Text = btbPhM.Text;
            panel1.Visible = true;
            pnl_estandarizacion.Visible = true;
            calc = 2;
            lblTItulo.Text = "Cantidad de Errores Estándar \nde la Muestra";
            lblvar1.Text = "Tamaño de la muestra (x)";
            lblvar2.Text = "Media de la Hipotesis Nula (μHo)";
            lblvar3.Text = "Error Estándar de la Media (σₓ)";
            lblvar4.Text = "";
            lblRes.Text = "z =";
            lblVarAb.Text = "σₓ";
            lblVarArr.Text = "x - μHo";
            lbl_resultado.Text = "";
            txtvar3.Visible = true;
            txtvar4.Visible = false;
            btn_tabla.Visible = true;
            tabl = 0;
        }

        private void btnErrEstProp_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbl_tittle.Text = btnErrEstProp.Text;
            panel1.Visible = true;
            pnl_estandarizacion.Visible = true;
            calc = 3;
            lblTItulo.Text = "Error Estándar de proporción";
            lblvar1.Text = "Probabilidad p de la Hipotesis (pHo)";
            lblvar2.Text = "Probabilidad q de la Hipotesis (qHo)";
            lblvar3.Text = "Población (n)";
            lblvar4.Text = "";
            lblRes.Text = "σp =";
            lblVarAb.Text = "n";
            lblVarArr.Text = "pHo * qHo";
            lbl_resultado.Text = "";
            lblRaiz.Visible = true;
            lblRaiz2.Visible = true;
            txtvar4.Visible = false;
            txtvar3.Visible = true;
            btn_tabla.Visible = false;
        }

        private void btnPropMuesEst_Click(object sender, EventArgs e)
        {
            Limpiar();
            lbl_tittle.Text = btnPropMuesEst.Text;
            panel1.Visible = true;
            pnl_estandarizacion.Visible = true;
            calc = 4;
            lblTItulo.Text = "Proporción de la Muestra \nEstandarizada";
            lblvar1.Text = "Proporción de la Muestra Observada (p)";
            lblvar2.Text = "Proporción Hipotética (pHo)";
            lblvar3.Text = "Error Estándar de la Proporción (σp)";
            lblvar4.Text = "";
            lblRes.Text = "z =";
            lblVarAb.Text = "σp";
            lblVarArr.Text = "p - pHo";
            lbl_resultado.Text = "";
            lblRaiz.Visible = false;
            lblRaiz2.Visible = false;
            txtvar3.Visible = true;
            txtvar4.Visible = false;
            btn_tabla.Visible = true;
            tabl = 0;
        }

        private void btnDistT_Click(object sender, EventArgs e)
        {
            lbl_tittle.Text = btnDistT.Text;
            Limpiar();
            panel1.Visible = true;
            pnl_estandarizacion.Visible = true;
            calc = 5;
            lblTItulo.Text = "Estandarización de la Media \n de la Muestra";
            lblvar1.Text = "Tamaño de la muestra (x)";
            lblvar2.Text = "Media Hipotética (μHo)";
            lblvar3.Text = "Error Estándar estimado (σx)";
            lblvar4.Text = "";
            lblRes.Text = "t =";
            lblVarAb.Text = "σx";
            lblVarArr.Text = "x - μHo";
            lbl_resultado.Text = "";
            lblRaiz.Visible = false;
            lblRaiz2.Visible = false;
            txtvar3.Visible = true;
            txtvar4.Visible = false;
            btn_tabla.Visible = true;
            tabl = 1;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (calc == 0)
            {
                try
                {
                    double desv = Double.Parse(txtvar1.Text);
                    double pobl = Double.Parse(txtvar2.Text);
                    double Respuesta = desv / Math.Sqrt(pobl);
                    double finval = Math.Round(Respuesta, 4);
                    lbl_resultado.Text = finval.ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese números en las casillas");
                }
            }
            if (calc == 1)
            {
                try
                {
                    double x = Double.Parse(txtvar1.Text);
                    double mu = Double.Parse(txtvar2.Text);
                    double errorEst = Double.Parse(txtvar3.Text);
                    double respuesta = (x - mu) / errorEst;
                    double finval = Math.Round(respuesta, 4);
                    lbl_resultado.Text = finval.ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese números en las casillas");
                }
            }

            if (calc == 2)
            {
                try
                {
                    double x = Double.Parse(txtvar1.Text);
                    double muH = Double.Parse(txtvar2.Text);
                    double errorEst = Double.Parse(txtvar3.Text);
                    double respuesta = (x - muH) / errorEst;
                    double finval = Math.Round(respuesta, 4);
                    lbl_resultado.Text = finval.ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese números en las casillas");
                }
            }
            if (calc == 3)
            {
                try
                {
                    double ph = Double.Parse(txtvar1.Text);
                    double qh = Double.Parse(txtvar2.Text);
                    double n = Double.Parse(txtvar3.Text);
                    double respuesta = Math.Sqrt((ph * qh) / n);
                    double finval = Math.Round(respuesta, 4);
                    lbl_resultado.Text = finval.ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese números en las casillas");
                }
            }
            if (calc == 4)
            {
                try
                {
                    double p = Double.Parse(txtvar1.Text);
                    double ph = Double.Parse(txtvar2.Text);
                    double errest = Double.Parse(txtvar3.Text);
                    double respuesta = ((p - ph) / errest);
                    double finval = Math.Round(respuesta, 4);
                    lbl_resultado.Text = finval.ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese números en las casillas");
                }
            }
            if (calc == 5)
            {
                try
                {
                    double x = Double.Parse(txtvar1.Text);
                    double muh = Double.Parse(txtvar2.Text);
                    double errest = Double.Parse(txtvar3.Text);
                    double respuesta = ((x - muh) / errest);
                    double finval = Math.Round(respuesta, 4);
                    lbl_resultado.Text = finval.ToString();
                }
                catch
                {
                    MessageBox.Show("Ingrese números en las casillas");
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_tabla_Click(object sender, EventArgs e)
        {
            if (tabl == 0)
            {
                TablaZ tablaZ = new TablaZ();
                tablaZ.Show();
            }
            if (tabl == 1)
            {
                TablaT tablaT = new TablaT();
                tablaT.Show();
            }
        }
    }
}
