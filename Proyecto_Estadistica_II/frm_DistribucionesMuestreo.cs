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
    public partial class frm_DistribucionesMuestreo : Form
    {

        private int opcion;
        private int stateCkbx;

        private void SetOpcion(int opc)
        {
            this.opcion = opc;
        }
        private int getOpcion()
        {
            return opcion;
        }
        private void setStatusCkbx(int status)
        {
            this.stateCkbx = status;
        }
        private int getstatusCkbx()
        {
            return stateCkbx;
        }

        public frm_DistribucionesMuestreo()
        {
            InitializeComponent();
        }

        private void frm_DistribucionesMuestreo_Load(object sender, EventArgs e)
        {
            cargaInicial();
        }

        private void cargaInicial()
        {
            pnl_errorEstandar.Visible = false;
            pnl_estandarizacion.Visible = false;
            pnl_errorEstandaFinito.Visible = false;
            pnl_multiplicadorPoblacion.Visible = false;
            panel1.Visible = false;

            lbl_tittleInterno.Visible = false;
            lbl_n.Visible = false;
            lbl_p.Visible = false;
            lbl_q.Visible = false;
            lbl_r.Visible = false;
            txt_n.Visible = false;
            txt_n.Text = "";
            txt_p.Visible = false;
            txt_p.Text = "";
            txt_q.Visible = false;
            txt_q.Text = "";
            txt_r.Visible = false;
            txt_r.Text = "";
            ckbx_conoceDato.Visible = false;
            btn_calcular.Enabled = false;
            btn_limpiar.Enabled = false;

            lbl_resultado.Text = "";
        }

        private void btn_ErrorEstandarInfinito_Click(object sender, EventArgs e)
        {
            cargaInicial();
            panel1.Visible = true;
            lbl_tittle.Text = btn_ErrorEstandarInfinito.Text;
            lbl_tittleInterno.Visible = true;

            lbl_n.Visible = true;
            lbl_n.Text = "Desviación estándar de la población ( σ )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Tamaño de la muestra (n)";
            txt_p.Visible = true;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            pnl_errorEstandar.Visible = true;
            SetOpcion(1);
        }

        private void btn_EstandarizacionMedia_Click(object sender, EventArgs e)
        {
            cargaInicial();
            panel1.Visible = true;

            pnl_estandarizacion.Visible = true;
            lbl_tittle.Text = btn_EstandarizacionMedia.Text;
            lbl_tittleInterno.Visible = true;

            lbl_n.Visible = true;
            lbl_n.Text = "Media de muestra ( x̅ )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Media de la poblacion( µ )";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Desviacion estándar de la media( σ )";
            txt_q.Visible = true;

            lbl_r.Visible = true;
            lbl_r.Text = "Tamaño de la muestra (n)";
            txt_r.Visible = true;
            txt_r.Text = 0.ToString();

            ckbx_conoceDato.Visible = true;
            lbl_desv2.Visible = false;
            lbl_desv2_.Visible = false;

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            SetOpcion(2);
        }

        private void ckbx_conoceDato_CheckedChanged(object sender, EventArgs e)
        {
            if (getOpcion() == 2)
            {
                if (ckbx_conoceDato.Checked)
                {
                    lbl_q.Text = "Error estándar de la media( σx̅ )";
                    lbl_r.Visible = false;
                    lbl_r.Text = "";
                    txt_r.Visible = false;
                    lbl_desv3.Visible = false;
                    lbl_desv3_.Visible = false;
                    lbl_sqrt.Visible = false;
                    lbl_n3_.Visible = false;
                    lbl_n3.Visible = false;
                    lbl_desv2.Visible = true;
                    lbl_desv2_.Visible = true;
                    setStatusCkbx(1);
                }
                else
                {
                    lbl_q.Text = "Desviacion estándar de la media( σ )";
                    lbl_r.Visible = true;
                    lbl_r.Text = "Tamaño de la muestra (n)";
                    txt_r.Visible = true;
                    lbl_desv3.Visible = true;
                    lbl_desv3_.Visible = true;
                    lbl_sqrt.Visible = true;
                    lbl_n3_.Visible = true;
                    lbl_n3.Visible = true;
                    lbl_desv2.Visible = false;
                    lbl_desv2_.Visible = false;
                    setStatusCkbx(0);
                }
            }
            else
            {

            }
        }

        private void btn_ErrorEstandarFinito_Click(object sender, EventArgs e)
        {
            cargaInicial();
            panel1.Visible = true;

            pnl_errorEstandaFinito.Visible = true;
            lbl_tittle.Text = btn_ErrorEstandarFinito.Text;
            lbl_tittleInterno.Visible = true;

            lbl_n.Visible = true;
            lbl_n.Text = "Desviación estándar de la población ( σ )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Tamaño de la muestra (N)";
            txt_p.Visible = true;

            lbl_q.Visible = true;
            lbl_q.Text = "Tamaño de la población (n)";
            txt_q.Visible = true;

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;



            SetOpcion(3);

        }

        private void btn_Multiplicador_Click(object sender, EventArgs e)
        {
            cargaInicial();
            panel1.Visible = true;

            pnl_multiplicadorPoblacion.Visible = true;
            lbl_tittle.Text = btn_Multiplicador.Text;
            lbl_tittleInterno.Visible = true;

            lbl_n.Visible = true;
            lbl_n.Text = "Tamaño de la población ( N )";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Tamaño de la muestra ( n )";
            txt_p.Visible = true;

            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;

            SetOpcion(4);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int opc = getOpcion();
            switch (opc)
            {
                case 1:
                    if (txt_n.Text == "" || txt_p.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos(Desviacion y tamaño de muestra)");
                    }
                    else
                    {
                        double desviacion = Convert.ToDouble(txt_n.Text);
                        double tamanioMuestra = Convert.ToDouble(txt_p.Text);

                        double result1 = Math.Round(Calculos.MuestreoDistribuciones.ErrorEstandarInfinitas(desviacion, tamanioMuestra),2);
                        lbl_resultado.Text = result1.ToString();

                        lbl_desv1.Text = desviacion.ToString();
                        lbl_n1.Text = tamanioMuestra.ToString();

                    }
                    break;
                case 2:
                    double result2;
                    if (txt_n.Text == "" || txt_p.Text == "" || txt_q.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos(Media de muestra, Media de la poblacion y Error estandar de la media )");
                    }
                    
                    else
                    {
                        double mediaMuestra = Convert.ToDouble(txt_n.Text);
                        double mediaPoblacion = Convert.ToDouble(txt_p.Text);
                        int opc2 = getstatusCkbx();
                        switch (opc2)
                        {
                            case 0:
                                double desviacion = Convert.ToDouble(txt_q.Text);
                                double tamanioMuestra = Convert.ToDouble(txt_r.Text);
                                result2 = Calculos.MuestreoDistribuciones.EstandarizacionMediaMuestra(2, mediaMuestra, 0, mediaPoblacion, desviacion, tamanioMuestra);
                                lbl_resultado.Text = result2.ToString();
                                lbl_desv3.Text = desviacion.ToString();
                                lbl_n3.Text = tamanioMuestra.ToString();

                                break;
                            case 1:
                                double errorEstandar = Convert.ToDouble(txt_q.Text);
                                result2 = Calculos.MuestreoDistribuciones.EstandarizacionMediaMuestra(1, mediaMuestra, errorEstandar, mediaPoblacion, 0, 0);
                                lbl_resultado.Text = result2.ToString();
                                lbl_desv2.Visible = true;
                                lbl_desv2_.Visible = true;
                                lbl_desv2.Text = errorEstandar.ToString();
                                lbl_desv2_.Visible = false;
                                break;
                        }
                        lbl_x_u.Text = (mediaMuestra - mediaPoblacion).ToString();

                    }
                    break;
                case 3: 
                    if (txt_n.Text == "" || txt_p.Text == "" || txt_q.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos(Media de muestra, Media de la poblacion y Error estandar de la media )");
                    }
                    else
                    {
                        double desviacion = Convert.ToDouble(txt_n.Text);
                        double N = Convert.ToDouble(txt_p.Text);
                        double n = Convert.ToDouble(txt_q.Text);

                        double result3 = Calculos.MuestreoDistribuciones.ErrorEstandarFinita(desviacion, n, N);
                        lbl_resultado.Text = result3.ToString();

                        lbl_desv4.Text = desviacion.ToString();
                        lbl_n4.Text = n.ToString();
                        lbl_N_n.Text = (N - n).ToString();
                        lbl_N_1.Text = (N - 1).ToString();
                    }
                        break;
                case 4:
                    if (txt_n.Text == "" || txt_p.Text == "" )
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos(Tamaño de la poblacion y tamaño de la muestra)");
                    }
                    else
                    {
                        double N1 = Convert.ToDouble(txt_n.Text);
                        double n1 = Convert.ToDouble(txt_p.Text);

                        double result4 = Calculos.MuestreoDistribuciones.MultiplicadorPoblacionFinita(n1, N1);
                        lbl_resultado.Text = result4.ToString();
                        lbl_N_n1.Text = (N1- n1).ToString();
                        lbl_N_11.Text = (N1 - 1).ToString();
                    }

                        break;


            }
        }
        
        private void Limpiar()
        {
            lbl_resultado.Text = "-";
            txt_n.Text = "";
            txt_p.Text = "";
            txt_q.Text = "";
            txt_r.Text = "0";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_tabla_Click(object sender, EventArgs e)
        {
            frm_Tablas tablas = new frm_Tablas();
            tablas.Show();
        }

        private void pnl_errorEstandar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
