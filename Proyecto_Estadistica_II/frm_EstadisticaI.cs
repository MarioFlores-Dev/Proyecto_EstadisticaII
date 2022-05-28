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
    public partial class frm_EstadisticaI : Form
    {
        Calculos.Estadistica_1 estadistica = new Calculos.Estadistica_1();

        int opc = 0;
        List<double> data = new List<double>();
        List<double> data2 = new List<double>();

        public frm_EstadisticaI()
        {
            InitializeComponent();
        }

        private void frm_EstadisticaI_Load(object sender, EventArgs e)
        {
            CargaInicial();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

        }

        private void CargaInicial()
        {
            txt_n.Text = "";
            txt_p.Text = "";
            txt_q.Text = "";
            txt_r.Text = "";
            txt_n.Visible = false;
            txt_p.Visible = false;
            txt_q.Visible = false;
            txt_r.Visible = false;
            lbl_n.Visible = false;
            lbl_p.Visible = false;
            lbl_q.Visible = false;
            lbl_r.Visible = false;
            lbl_resultado.Text = "";
            panel1.Visible = false;
            pnl_MMM.Visible = false;
            tabControl1.Visible = false;
            btn_calcular.Enabled = false;
            btn_limpiar.Enabled = false;
        }
        private void Limpiar()
        {
            txt_n.Text = "";
            txt_p.Text = "";
            txt_q.Text = "";
            txt_r.Text = "";
            lbl_resultado.Text = " - ";
        }

        private void btn_media_Click(object sender, EventArgs e)
        {
            CargaInicial();
            tabControl1.Visible = true;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
            opc = 1;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_mediana_Click(object sender, EventArgs e)
        {

        }

        private void btn_rango_Click(object sender, EventArgs e)
        {
            CargaInicial();
            panel1.Visible = true;
            tabControl1.Visible = true;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;
            tabControl1.SelectedTab = tabPage4;
            opc = 4;

            lbl_n.Visible = true;
            lbl_n.Text = "Valor mayor de observacion";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Valor menor de observacion";
            txt_p.Visible = true;
        }

        private void btn_media_Click_1(object sender, EventArgs e)
        {
            CargaInicial();
            lbl_tittle.Text = btn_media.Text;
            pnl_MMM.Visible = true;
            btn_calcular.Visible = false;
            btn_limpiar.Visible = false;
            panel2.Visible = false;
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn_rango_Click_1(object sender, EventArgs e)
        {
            CargaInicial();
            lbl_tittle.Text = btn_rango.Text;
            panel1.Visible = true;
            tabControl1.Visible = true;
            btn_calcular.Enabled = true;
            btn_limpiar.Enabled = true;
            btn_calcular.Visible = true;
            btn_limpiar.Visible = true;
            tabControl1.SelectedTab = tabPage4;
            opc = 4;

            lbl_n.Visible = true;
            lbl_n.Text = "Valor mayor de observacion";
            txt_n.Visible = true;

            lbl_p.Visible = true;
            lbl_p.Text = "Valor menor de observacion";
            txt_p.Visible = true;
        }
        public bool validacion()
        {
            bool noError = true;

            if (cantfor.Text == string.Empty)
            {
                MessageBox.Show("Porfavor dijite una cantidad de nuemeros", "Cantidad de nuemero en blaco");
                //retorna un falso 
                noError = false;

            }
            else
            {
                try
                {
                    estadistica.Cantidad = Convert.ToInt32(cantfor.Text);
                }
                catch
                {
                    MessageBox.Show("Tiene q ingresar un numero", "Error");
                    noError = false;
                }
            }
            return noError;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            double num = 0;
            if (validacion())
            {


                for (int i = 0; i < estadistica.Cantidad; i++)
                {

                    while (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los numeros", "Ingesar"), out num))
                    {
                        MessageBox.Show("Debe ser un numero ", "Error");
                    }
                    while (num <= 0)
                    {
                        MessageBox.Show("Debe ser un numero mayor a cero", "Error");
                        while (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los numeros", "Ingesar"), out num))
                        {
                            MessageBox.Show("Debe ser un numero ", "Error");
                        }
                    }

                    ListaNumero.Items.Add(num);
                    estadistica.Numero = num;
                }

            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Mediatxt.Text = estadistica.Media(estadistica.Numero, estadistica.Cantidad).ToString();

            double mediana = 0;
            //sin uso de vectores
            //mediana
            ListaNumero.Sorted = true;
            int pos = estadistica.Cantidad / 2;
            Console.WriteLine(pos);
            if (estadistica.Cantidad % 2 == 0)
            {
                mediana = (((double)ListaNumero.Items[pos] - 1 + (double)ListaNumero.Items[pos]) / 2.0);
            }
            else
            {
                mediana = (double)ListaNumero.Items[pos];
            }
            Medianatxt.Text = mediana.ToString();
            //sin vectores 
            //moda

            int conAnte = 0;
            int conDesp = 0;

            for (int i = 0; i < estadistica.Cantidad; i++)
            {

                double mPrimero = (double)ListaNumero.Items[i];
                conDesp = 0;
                for (int j = 0; j < estadistica.Cantidad; j++)
                {
                    double msegundo = (double)ListaNumero.Items[j];
                    if (mPrimero == msegundo)
                    {
                        conDesp++;
                    }
                }
                if (conDesp != 1)
                {
                    if (conAnte < conDesp)
                    {
                        conAnte = conDesp;
                        Modatxt.Text = mPrimero.ToString();
                    }
                }
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            cantfor.Clear();
            ListaNumero.Items.Clear();
            Modatxt.Clear();
            Medianatxt.Clear();
            Mediatxt.Clear();
        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            switch (opc)
            {
                case 1:
                    break;

                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    if (txt_n.Text == "")
                    {
                        MessageBox.Show("Debe Ingresar los datos requeridos");
                    }
                    else
                    {
                        double n = Convert.ToDouble(txt_n.Text);
                        double p = Convert.ToDouble(txt_p.Text);
                        double result1 = Calculos.Estadistica_1.Rango(n, p);
                        lbl_respuesta.Text = result1.ToString();

                        lbl_vMaximo.Text = n.ToString();
                        lbl_Vminimo.Text = p.ToString();

                    }

                    break;


            }
        }
    }
}
