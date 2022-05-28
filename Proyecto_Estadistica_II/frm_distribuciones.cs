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
    public partial class frm_distribuciones : Form
    {

        private int opcion;

        private void SetOpcion(int opc)
        {
            this.opcion = opc;
        }
        private int getOpcion()
        {
            return opcion;
        }

        public frm_distribuciones()
        {
            InitializeComponent();
        }

        private void frm_distribuciones_Load(object sender, EventArgs e)
        {
            CargaInicial();
        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            CargaInicial();
            panel1.Visible = true;

            lbl_tittle.Text = btn_calculo.Text;
            lbl_n.Visible = true;
            lbl_n.Text = "Número de intentos ( n )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Probabilidad de éxito ( p )";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Probabilidad de fracaso ( q )";
            txt_q.Visible = true;
            txt_q.Text = "";
            txt_q.Enabled = false;

            lbl_r.Visible = true;
            lbl_r.Text = "Número de éxitos deseados ( r )";
            txt_r.Visible = true;

            pnl_binomial.Visible = true;

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;
            LimpiarTxt();
            SetOpcion(1);
           
        }

        private void btn_medidas_Click(object sender, EventArgs e)
        {
            CargaInicial();
            panel1.Visible = true;

            lbl_tittle.Text = btn_media.Text;

            lbl_n.Visible = true;
            lbl_n.Text = "Número de ensayos ( n )";
            txt_n.Visible = true; 

            lbl_p.Visible = true;
            lbl_p.Text = "Probabilidad de tener éxito ( p )";
            txt_p.Visible = true;
            
            pnl_media.Visible = true;
          
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            LimpiarTxt();
            SetOpcion(2);

        }

        private void btn_desviacion_Click(object sender, EventArgs e)
        {
            CargaInicial();
            panel1.Visible = true;
            lbl_tittle.Text = btn_desviacion.Text;

            lbl_n.Visible = true;
            lbl_n.Text = "Número de ensayos ( n )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Probabilidad de éxito ( p )";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Probabilidad de fracaso (q)";
            txt_q.Visible = true;



            pnl_desviacionEstandar.Visible = true;
            

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            LimpiarTxt();
            SetOpcion(3);
        }

        private void btn_poisson_Click(object sender, EventArgs e)
        {
            CargaInicial();
            panel1.Visible = true;
            lbl_tittle.Text = btn_poisson.Text;

           
            lbl_n.Visible = true;
            lbl_n.Text = "Probabilidad de tener ocurrencias ( X )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Lambda ( λ )";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "e";
            txt_q.Visible = true;
            txt_q.Text = "2.71828";


            pnl_dispoisson1.Visible = true;

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;
            btn_tabla.Visible = true;
            SetOpcion(4);
        }

        private void CargaInicial()
        {
            lbl_n.Visible = false;
            txt_n.Visible = false;
            lbl_p.Visible = false;
            txt_p.Visible = false;
            lbl_q.Visible = false;
            txt_q.Visible = false;
            lbl_r.Visible = false;
            txt_r.Visible = false;
            txt_n.Text = "";
            txt_p.Text = "";
            txt_q.Text = "";
            txt_r.Text = "";

            panel1.Visible = false;
            pnl_binomial.Visible = false;
            pnl_desviacionEstandar.Visible = false;
            pnl_media.Visible = false;
            pnl_dispoisson1.Visible = false;
            pnl_distPoisson2.Visible = false;
            pnl_estandarizacion.Visible = false;
            btn_calcular.Enabled = false;
            btn_limpiar.Enabled = false;
            txt_q.Enabled = false;
            btn_tabla.Visible = true;
            lbl_resultado.Text = "";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int opc = getOpcion();

            switch (opc)
            {
                
                case 1:
                    if (txt_p.Text == "" || txt_n.Text == "" || txt_r.Text == " ") {
                        MessageBox.Show("Debe Ingresar los datos requeridos( )");
                    }
                    else
                    {
                        
                        int n1, r;
                        double lbl_result1, p1;
                        p1 = Convert.ToDouble(txt_p.Text);
                        txt_q.Text = (1 - p1).ToString();
                        n1 = Convert.ToInt32(txt_n.Text);
                        r = Convert.ToInt32(txt_r.Text);
                        lbl_result1 = Calculos.DistribucionBinomial.ProcesoBernoulli_binomial(n1, p1, r);
                        lbl_resultado.Text = lbl_result1.ToString();

                        n.Text = n1.ToString();
                        r1.Text = r.ToString();
                        n2.Text = n1.ToString();
                        r2.Text = r.ToString();
                        p.Text = p1.ToString();
                        r3.Text = r.ToString();
                        q.Text = (1 - p1).ToString();
                        nR.Text = (n1 - r).ToString();


                    }
                    break;
                case 2:
                    if (txt_p.Text == "" || txt_n.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos ( )");
                    }
                    else
                    {

                        int n2;
                        double lbl_result2, p2;
                        n2 = Convert.ToInt32(txt_n.Text);
                        p2 = Convert.ToDouble(txt_p.Text);
                        lbl_result2 = Calculos.DistribucionBinomial.Media(n2, p2);
                        lbl_resultado.Text = lbl_result2.ToString();

                        nm.Text = n2.ToString();
                        pm.Text = p2.ToString();
                    }
                    break;
                case 3:
                    if (txt_p.Text == "" || txt_n.Text == "" )
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos ( )");
                    }
                    else
                    {
                        int n3;
                        double lbl_result3, p3;
                        n3 = Convert.ToInt32(txt_n.Text);
                        p3 = Convert.ToDouble(txt_p.Text);
                        txt_q.Text = (1 - p3).ToString();
                        lbl_result3 = Math.Round(Calculos.DistribucionBinomial.DesviacionEstandar(n3, p3),3);
                        lbl_resultado.Text = lbl_result3.ToString();

                        nd.Text = n3.ToString();
                        pd.Text = p3.ToString();
                        qd.Text = (1 - p3).ToString();

                    }
                    break;
                case 4:
                    if (txt_p.Text == "" || txt_n.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos");
                    }
                    else
                    {
                        int xi;
                        double lambda;
                        double lbl_resultado4;
                        double e1;
                        xi = Convert.ToInt32(txt_n.Text);

                        lambda = Convert.ToDouble(txt_p.Text);
                        e1 = 2.71828;
                        lbl_resultado4 = Calculos.DistribucionBinomial.DistribucionPoisson(xi, lambda, e1);

                        txt_q.Text = "2.71828";
                        lbl_resultado.Text = lbl_resultado4.ToString();


                        xP1.Text = ("(" + xi + ")");
                        xP2.Text = xi.ToString();
                        xP3.Text = xi.ToString();
                        lambda1.Text = lambda.ToString();
                        _lambda.Text = "";
                        e2.Text = Math.Round(Math.Pow(e1,-lambda),5).ToString();
                    }
                    
                    break;

                case 5:
                    if (txt_p.Text == "" || txt_n.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos");
                    }
                    else
                    {
                        int n = Convert.ToInt32(txt_n.Text);
                        int x = Convert.ToInt32(txt_r.Text);
                        txt_q.Text = "2.71828";
                        double p = Convert.ToDouble(txt_p.Text);
                        double e2 = 2.71828;
                        double lbl_resultado5 = Calculos.DistribucionBinomial.PoissonAproxBinomial(x,n,p,e2);
                        lbl_resultado.Text = lbl_resultado5.ToString();

                        xdp.Text = ("(" + x + ")");
                        xdp2.Text = x.ToString();
                        xdp3.Text = x.ToString();
                        edp.Text = Math.Round(Math.Pow(e2, -(n * p)), 5).ToString();
                        _mediadp.Text = "";
                        mediadp.Text = ("(" + n * p + ")");


                    }

                     break;

                case 6:
                    if (txt_p.Text == "" || txt_n.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos");
                    }
                    else
                    {
                        int x = Convert.ToInt32(txt_n.Text);
                        double media = Convert.ToDouble(txt_p.Text);
                        double desviacion = Convert.ToDouble(txt_q.Text);

                        double lbl_resultado6 = Calculos.DistribucionBinomial.EstandarizacionVariableAleatoria(x, media, desviacion);
                        lbl_resultado.Text = lbl_resultado6.ToString();


                        x_media.Text = (x + " - " + media);
                        edesviacion.Text = desviacion.ToString();

                    
                    }
                        break;


            }
          

        }


        private void btn_tabla_Click(object sender, EventArgs e)
        {
            frm_Tablas t4a = new frm_Tablas();
            t4a.Show();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        
        private void LimpiarTxt()
        {
            lbl_resultado.Text = " - ";
            txt_n.Text = "";
            txt_p.Text = "";
            txt_q.Text = "";
            txt_r.Text = "";
        }

        private void btn_poissonAproxBinomial_Click(object sender, EventArgs e)
        {
            CargaInicial();
            panel1.Visible = true;
            lbl_tittle.Text = btn_poissonAproxBinomial.Text;

            lbl_n.Visible = true;
            lbl_n.Text = "Número de ensayos ( n )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Probabilidad de tener éxito ( p ) ";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "e";
            txt_q.Visible = true;
            txt_q.Text = "2.71828";


            lbl_r.Visible = true;
            lbl_r.Text = "Probabilidad de tener ocurrencias ( X )";
            txt_r.Visible = true;
            
            pnl_distPoisson2.Visible = true;
            

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            btn_tabla.Visible = false;
            SetOpcion(5);
        }


        private void btn_Estandarizacion_Click(object sender, EventArgs e){
            CargaInicial();
            panel1.Visible = true;
            lbl_tittle.Text = btn_Estandarizacion.Text;

            lbl_n.Visible = true;
            lbl_n.Text = "Variable aleatoria ( x )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Media de la distribución binomial ( µ )";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Desviación estándar de la distribución ( σ )";
            txt_q.Visible = true;
            txt_q.Enabled = true;
            
            pnl_estandarizacion.Visible = true;

            
            txt_q.Text = "";

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            btn_tabla.Visible = false;
            SetOpcion(6);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            TablaZ tz = new TablaZ();
            tz.Show();
        }

        private void pnl_desviacionEstandar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void edesviacion_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tituloResultado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tittle_Click(object sender, EventArgs e)
        {

        }
    }
}
