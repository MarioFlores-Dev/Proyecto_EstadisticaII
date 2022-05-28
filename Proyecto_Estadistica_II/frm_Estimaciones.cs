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
    public partial class frm_Estimaciones : Form
    {
        List<double> data = new List<double>();
        List<double> data2 = new List<double>();
        private int opcion;
        private void SetOpcion(int opc)
        {
            this.opcion = opc;
        }
        private int getOpcion()
        {
            return opcion;
        }
        public frm_Estimaciones()
        {
            InitializeComponent();
        }

        private void frm_Estimaciones_Load(object sender, EventArgs e)
        {
            cargaInicial();
        }
        private void cargaInicial()
        {

            pnl_finita.Visible = false;
            pnl_Edesviacion1.Visible = false;
            pnl_Intervalos.Visible = false;
            pnl_Emp.Visible = false;
            pnl_estimacionErrorPoblacionFinita.Visible = false;
            pnl_mediadispro.Visible = false;
            pnl_errorEstimado.Visible = false;
            pnl_errorEstandar0.Visible = false;
            pnl_mediaMuestra0.Visible = false;
            pnl_mediaMuestra.Visible = false;
            pnl_principal.Visible = false;
            pnl_estandarizacion.Visible = false;
            pnl_erroEstandarProporcion.Visible = false;
            pnl_desviacionEstandar.Visible = false;
            lbl_tittleInterno.Visible = false;
            lbl_n.Visible = false;
            lbl_p.Visible = false;
            lbl_q.Visible = false;
            lbl_r.Visible = false;
            lbl_x.Visible = false;
            txt_mmuestra0.Text = "";
            lbl_resultado.Text = "";
            lbl_resultado.Text = "";
            txt_n.Visible = false;
            txt_n.Text = "";
            txt_p.Visible = false;
            txt_p.Text = "";
            txt_q.Visible = false;
            txt_eError.Enabled = false;
            txt_eError1.Enabled = false;
            txt_errorEstimado.Enabled = false;
            txt_errorEstimadop0.Enabled = true;
            txt_Mmuestra1.Enabled = false;
            txt_Mmuestra.Enabled = false;
            txt_Tz.Enabled = false;
            txt_Tz1.Enabled = false;
            txt_q.Text = "";
            txt_r.Visible = false;
            txt_r.Text = "";
            txt_tabla0.Enabled = false;
            txt_tabla2.Enabled = false;
            txt_opn1.Enabled = false;
            txt_opn2.Enabled = false;
            txt_Mmfinita1.Enabled = false;
            txt_Mmfinita2.Enabled = false;
            txt_ncFinita1.Enabled = false;
            txt_ncFinita2.Enabled = false;
            txt_opn1.Enabled = false;
            txt_opn2.Enabled = false;
            txt_nT.Enabled = false;
            txt_datos.Enabled = false;
            txt_nT.Text = "";
            txt_datos.Text = "";
            listBox_datos.Enabled = false;
            listBox_datos.Items.Clear();
            ckbx_conoceDato.Visible = false;
            btn_calcular.Enabled = false;
            btn_limpiar.Enabled = false;
            txt_mmuestra0.Visible = false;
        }

        private void Limpiar()
        {
            txt_n.Text = "";
            txt_p.Text = "";
            txt_q.Text = "";
            txt_r.Text = "";
            txt_nT.Text = "";
            txt_datos.Text = "";
            lbl_resultado.Text = " - ";
            listBox_datos.Items.Clear();
            txt_mmuestra0.Text = "";

        }

        private void btn_mediaDeLaMuestra_Click(object sender, EventArgs e)
        {
            cargaInicial();
            lbl_tittle.Text = btn_mediaDeLaMuestra.Text;
            pnl_mediaMuestra0.Visible = true;
            pnl_mediaMuestra.Visible = true;
            pnl_estimacionErrorPoblacionFinita.Visible = false;
            btn_calcular.Enabled = true;

            txt_nT.Enabled = true;
            txt_datos.Enabled = true;
            listBox_datos.Enabled = true;
            btn_limpiar.Enabled = true;

            SetOpcion(1);
        }

        private void btn_estimacionEstandarPoblacion_Click(object sender, EventArgs e)
        {
            cargaInicial();
            lbl_tittle.Text = btn_estimacionEstandarPoblacion.Text;
            pnl_mediaMuestra0.Visible = true;
            pnl_mediaMuestra.Visible = true;
            pnl_estimacionErrorPoblacionFinita.Visible = false;
            pnl_Edesviacion1.Visible = true;
            btn_calcular.Enabled = true;
            lbl_x.Visible = true;
            txt_mmuestra0.Visible = true;

            txt_nT.Enabled = true;
            txt_datos.Enabled = true;
            listBox_datos.Enabled = true;
            btn_limpiar.Enabled = true;

            SetOpcion(2);
        }

        private void btn_estimacionErrorEstandardelaMedia_Click(object sender, EventArgs e)
        {
            cargaInicial();

            pnl_Intervalos.Visible = true;
            pnl_principal.Visible = true;
            pnl_estimacionErrorPoblacionFinita.Visible = true;
            lbl_tittle.Text = btn_estimacionErrorEstandardelaMedia.Text;
            lbl_tittleInterno.Visible = true;
            lbl_tittleInterno.Visible = true;

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;


            lbl_n.Visible = true;
            lbl_n.Text = "Desviación estándar de la población ( ô )";
            txt_n.Visible = true;
            txt_q.Enabled = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Tamaño de la muestra (N)";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Tamaño de la población (n)";
            txt_q.Visible = true;

            lbl_r.Visible = true;
            lbl_r.Text = "Nivel de confianza %";
            txt_r.Visible = true;

            SetOpcion(3);
        }

        private void btn_mediaMuestraldelaProporcion_Click(object sender, EventArgs e)
        {
            cargaInicial();
            btn_test.Visible = false;
            btn_calcular.Enabled = true;
            pnl_mediadispro.Visible = true;
            pnl_principal.Visible = true;
            lbl_tittle.Text = btn_mediaMuestraldelaProporcion.Text;
            lbl_tittleInterno.Visible = true;
            lbl_tittleInterno.Visible = true;
            btn_limpiar.Enabled = true;


            lbl_n.Visible = true;
            lbl_n.Text = "n (número de ensayos o intentos)";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "p (probabilidad de exito)";
            txt_p.Visible = true;
            btn_calcular.Enabled = true;
            SetOpcion(4);
        }

        private void btn_errorEstandarProporcion_Click(object sender, EventArgs e)
        {
            cargaInicial();
            pnl_erroEstandarProporcion.Visible = true;
            pnl_principal.Visible = true;
            lbl_tittle.Text = btn_errorEstandarProporcion.Text;
            lbl_tittleInterno.Visible = true;
            btn_test.Visible = false;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;


            lbl_n.Visible = true;
            lbl_n.Text = "Número de ensayos o Intentos (n)";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Probabilidad de éxito (p)";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Probabilidad de falla (q)";
            txt_q.Visible = true;
            txt_q.Enabled = false;
            SetOpcion(5);
        }

        private void btn_errorEstadarEstimadoDeLaProporcion_Click(object sender, EventArgs e)
        {
            cargaInicial();
            txt_ProporcionMF.Enabled = false;
            txt_ProporcionMF0.Enabled = false;
            txt_errorEstimadop0.Enabled = false;
            txt_q.Enabled = false;
            pnl_errorEstimado.Visible = true;
            pnl_errorEstandar0.Visible = true;
            pnl_principal.Visible = true;
            lbl_tittle.Text = btn_errorEstadarEstimadoDeLaProporcion.Text;
            lbl_tittleInterno.Visible = true;
            lbl_tittleInterno.Visible = true;
            btn_test.Visible = true;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;



            lbl_n.Visible = true;
            lbl_n.Text = "Tamaño de la muestra (n)";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Proporción de la muestra a favor (p̂)";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Proporción de la muestra en contra (q^)";
            txt_q.Visible = true;

            lbl_r.Visible = true;
            lbl_r.Text = "Nivel de confianza %";
            txt_r.Visible = true;
            SetOpcion(6);
        }

        private void btn_ErrorEstandarEstimadoDeLaMediaDeUnaPoblacionInfinita_Click(object sender, EventArgs e)
        {
            cargaInicial();
            pnl_Emp.Visible = true;
            pnl_finita.Visible = true;
            pnl_principal.Visible = true;
            lbl_tittle.Text = btn_ErrorEstandarEstimadoDeLaMediaDeUnaPoblacionInfinita.Text;
            lbl_tittleInterno.Visible = true;
            btn_test.Visible = true;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;


            lbl_n.Visible = true;
            lbl_n.Text = "Tamaño de la muestra (n)";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Desviación estandar de la muestra ô = s ";
            txt_p.Visible = true;


            SetOpcion(7);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            switch (getOpcion())
            {
                case 1:
                    int x = data.Count();

                    if (x < Convert.ToDouble(txt_nT.Text))
                    {
                        data.Add(Convert.ToDouble(txt_datos.Text));
                        listBox_datos.Items.Add(txt_datos.Text);
                        txt_datos.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Datos completos");
                    }

                    break;
                case 2:
                    int x2 = data2.Count();

                    if (x2 < Convert.ToDouble(txt_nT.Text))
                    {
                        data2.Add(Math.Pow(Convert.ToDouble(txt_datos.Text), 2));
                        listBox_datos.Items.Add(txt_datos.Text);
                        txt_datos.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Datos completos");
                    }
                    break;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            switch (getOpcion())
            {
                case 1:
                    if (txt_nT.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos( )");
                    }
                    else
                    {
                        double n = Convert.ToDouble(txt_nT.Text);
                        double result1 = Calculos.Estimaciones.MediaMuestra(data, n);
                        double sum = data.Sum();
                        lbl_resultado.Text = result1.ToString();
                        lbl_sumMedia.Text = sum.ToString();
                        lbl_nEnsayos.Text = n.ToString();
                        pnl_Intervalos.Visible = false;

                    }
                    break;
                case 2:
                    if (txt_nT.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos( )");
                    }
                    else
                    {
                        double n1 = Convert.ToDouble(txt_nT.Text);
                        double result0 = Calculos.Estimaciones.MediaMuestra1(data2, n1);
                        double re = Convert.ToDouble(txt_mmuestra0.Text);
                        re = Math.Pow(re, 2);
                        double sum = data.Sum();
                        lbl_Des.Text = re.ToString();
                        lbl_sumxC.Text = result0.ToString();
                        lbl_n11.Text = (n1 - 1).ToString();
                        lbl_n12.Text = (n1 - 1).ToString();
                        lbl_n0.Text = n1.ToString();
                        double rR = (result0 / (n1 - 1)) - (n1 * re) / n1;
                        lbl_resultado.Text = rR.ToString();
                    }


                    break;
                case 3:
                    if (txt_n.Text == "" || txt_p.Text == "" || txt_q.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos(Estimacion de la desviacion estandar de la población σˆ,Tamaño de la muestra (N) y Tamaño de la poblacion (n)");
                    }
                    else
                    {

                        double desviacionEPoblacion = Convert.ToDouble(txt_n.Text);
                        double N = Convert.ToDouble(txt_p.Text);
                        double n = Convert.ToDouble(txt_q.Text);
                        double nConfinza = Convert.ToDouble(txt_r.Text);
                        double result3 = Calculos.Estimaciones.EstimacionoblacionFinita(desviacionEPoblacion, n, N);
                        double NC = Calculos.Estimaciones.Nconfianza(nConfinza);
                        lbl_resultado.Text = result3.ToString();
                        txt_eError.Text = lbl_resultado.Text;
                        txt_eError1.Text = lbl_resultado.Text;
                        txt_Tz.Enabled = true;
                        txt_Mmuestra.Enabled = true;
                        lbl_nC.Text = NC.ToString();
                        lbl_estimacioDesviacionPoblacion.Text = txt_n.Text;
                        lbl_tM1.Text = n.ToString();
                        lbl_tM2.Text = n.ToString();
                        lbl_TP1.Text = N.ToString();
                        lbl_TP2.Text = N.ToString();
                        lbl_TP2.Text = (N - 1).ToString();
                    }
                    break;
                case 4:
                    if (txt_n.Text == "" || txt_p.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos (n) numero de esnsayos (p)probabilidad de éxito");
                    }
                    else
                    {
                        double n = Convert.ToDouble(txt_n.Text);
                        double p = Convert.ToDouble(txt_p.Text);
                        double result4 = Calculos.Estimaciones.MediaMuestralPoblacion(n, p);
                        lbl_resultado.Text = result4.ToString();
                        lbl_nM.Text = n.ToString();
                        lbl_nM1.Text = n.ToString();
                        lbl_pM.Text = p.ToString();
                        lbl_pM2.Text = result4.ToString();
                    }
                    break;
                case 5:
                    if (txt_n.Text == "" || txt_p.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos (n) Tamaño de la muestra (p)probabilidad de éxito (Q) probabilidad de falla");
                    }
                    else
                    {
                        double n = Convert.ToDouble(txt_n.Text);
                        double p = Convert.ToDouble(txt_p.Text);
                        double q = 1 - p;
                        double result5 = Calculos.Estimaciones.ErrorEstandarProporcion(n, p, q);
                        lbl_resultado.Text = result5.ToString();
                        lbl_pErrorp.Text = p.ToString();
                        lbl_qErrorp.Text = txt_q.Text;
                        lbl_nErrorp.Text = n.ToString();
                        txt_q.Text = q.ToString();
                    }
                    break;
                case 6:
                    if (txt_n.Text == "" || txt_p.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos (n) Tamaño de la muestra (p)probabilidad de éxito (Q) probabilidad de falla");
                    }
                    else
                    {
                        double n = Convert.ToDouble(txt_n.Text);
                        double p = Convert.ToDouble(txt_p.Text);
                        double q = 1 - p;
                        double nConfianza = Convert.ToDouble(txt_r.Text);
                        double result6 = Calculos.Estimaciones.ErrorEstandarProporcion(n, p, q);
                        double nC = Calculos.Estimaciones.Nconfianza(nConfianza);
                        lbl_resultado.Text = result6.ToString();
                        lbl_NCErrorE.Text = nC.ToString();
                        txt_q.Text = q.ToString();
                        lbl_Errorp.Text = p.ToString();
                        lbl_Errorq.Text = txt_q.Text;
                        lbl_Errorn.Text = n.ToString();
                        lbl_asento.Visible = false;
                        txt_errorEstimado.Text = lbl_resultado.Text;
                        txt_errorEstimadop0.Text = lbl_resultado.Text;
                        txt_ProporcionMF.Text = txt_p.Text;
                        txt_ProporcionMF0.Text = txt_p.Text;
                        txt_tabla0.Enabled = true;
                        txt_tabla2.Enabled = false;


                    }
                    break;
                case 7:
                    if (txt_n.Text == "" || txt_p.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos (n) Tamaño de la muestra (p)Desviación estandár de la población ");
                    }
                    else
                    {
                        double o = Convert.ToDouble(txt_n.Text);
                        double n = Convert.ToDouble(txt_p.Text);
                        double result7 = Calculos.Estimaciones.ErrorEstandarPoblacionFinita(o, n);
                        lbl_resultado.Text = result7.ToString();
                        lbl_oeEmp.Text = o.ToString();
                        lbl_neEmp.Text = n.ToString();
                        txt_opn1.Text = lbl_resultado.Text;
                        txt_opn2.Text = lbl_resultado.Text;
                        txt_Mmfinita1.Enabled = true;
                        txt_ncFinita1.Enabled = true;
                    }
                    break;
            }
        }

        private void btn_CalcFinita_Click(object sender, EventArgs e)
        {
            double mMuestra = Convert.ToDouble(txt_Mmfinita1.Text);
            double tz = Convert.ToDouble(txt_ncFinita1.Text);
            double eError = Convert.ToDouble(txt_opn1.Text);
            double res1 = Calculos.Estimaciones.LimiteSuperior(mMuestra, tz, eError);
            lbl_Rfinita1.Text = res1.ToString();
            txt_Mmfinita2.Text = txt_Mmfinita1.Text;
            txt_ncFinita2.Text = txt_ncFinita1.Text;
            double mMuestra1 = Convert.ToDouble(txt_Mmfinita2.Text);
            double tZ1 = Convert.ToDouble(txt_ncFinita2.Text);
            double eError1 = Convert.ToDouble(txt_opn2.Text);
            double res2 = Calculos.Estimaciones.LimiteInferior(mMuestra1, tZ1, eError1);
            lbl_Rfinita2.Text = res2.ToString();
        }

        private void btn_Limiteserrorp_Click(object sender, EventArgs e)
        {
            double mMuestra = Convert.ToDouble(txt_ProporcionMF.Text);
            double tz = Convert.ToDouble(txt_tabla0.Text);
            double eError = Convert.ToDouble(txt_errorEstimado.Text);
            double res1 = Calculos.Estimaciones.LimiteSuperior(mMuestra, tz, eError);
            lbl_erroresultado.Text = res1.ToString();
            txt_tabla2.Text = txt_tabla0.Text;
            double mMuestra1 = Convert.ToDouble(txt_ProporcionMF0.Text);
            double tZ1 = Convert.ToDouble(txt_tabla2.Text);
            double eError1 = Convert.ToDouble(txt_errorEstimadop0.Text);
            double res2 = Calculos.Estimaciones.LimiteInferior(mMuestra1, tZ1, eError1);
            lbl_errorresultado0.Text = res2.ToString();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double mMuestra = Convert.ToDouble(txt_Mmuestra.Text);
            double tz = Convert.ToDouble(txt_Tz.Text);
            double eError = Convert.ToDouble(txt_eError.Text);
            double res = Calculos.Estimaciones.LimiteSuperior(mMuestra, tz, eError);
            lbl_result0.Text = res.ToString();

            txt_Mmuestra1.Text = txt_Mmuestra.Text;
            txt_Tz1.Text = txt_Tz.Text;
            double mMuestra1 = Convert.ToDouble(txt_Mmuestra1.Text);
            double tZ1 = Convert.ToDouble(txt_Tz1.Text);
            double eError1 = Convert.ToDouble(txt_eError1.Text);
            double res1 = Calculos.Estimaciones.LimiteInferior(mMuestra1, tZ1, eError1);
            lbl_result1.Text = res1.ToString();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            frm_Tablas tablas = new frm_Tablas();
            tablas.Show();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
