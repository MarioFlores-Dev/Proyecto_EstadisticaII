using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estadistica_II.Tablas
{
    public partial class Tabla_4b : Form
    {
        public Tabla_4b()
        {
            InitializeComponent();
        }

        private void Tabla_4b_Load(object sender, EventArgs e)
        {
            //CargaInicial();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            CargarTablas();
        }

        private void cbbx_parte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("0.1 - 1.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if ("1.1 - 2.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if ("2.1 - 3.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else if ("3.1 - 4.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage4;
            }
            else if ("4.1 -  5.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage5;
            }
            else if ("5.1 - 6.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage6;
            }
            else if ("6.1 - 7.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage7;
            }
            else if ("7.1 - 8.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage8;
            }
            else if ("8.1 - 9.0" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage9;
            }
            else if ("9.1 - 10" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage10;
            }
            else if ("11 - 20" == cbbx_parte.SelectedItem.ToString())
            {
                tabControl1.SelectedTab = tabPage11;
            }
        }
        private void CargarTablas()
        {
            CargarTabla1();
            CargarTabla2();
            CargarTabla3();
            CargarTabla4();
            CargarTabla5();
            CargarTabla6();
            CargarTabla7();
            CargarTabla8();
            CargarTabla9();
            CargarTabla10();
            CargarTabla11();
        }
        public void CargarTabla1()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("X");
            dt.Columns.Add("0.1");
            dt.Columns.Add("0.2");
            dt.Columns.Add("0.3");
            dt.Columns.Add("0.4");
            dt.Columns.Add("0.5");
            dt.Columns.Add("0.6");
            dt.Columns.Add("0.7");
            dt.Columns.Add("0.8");
            dt.Columns.Add("0.9");
            dt.Columns.Add("1.0");

            DataRow fila1 = dt.NewRow();
            fila1[0] = "0";
            fila1[1] = "0.9048";
            fila1[2] = "0.8187";
            fila1[3] = "0.7408";
            fila1[4] = "0.6703";
            fila1[5] = "0.6065";
            fila1[6] = "0.5488";
            fila1[7] = "0.4966";
            fila1[8] = "0.4493";
            fila1[9] = "0.4066";
            fila1[10] = "0.3679";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "1";
            fila2[1] = "0.0905";
            fila2[2] = "0.1637";
            fila2[3] = "0.2222";
            fila2[4] = "0.2681";
            fila2[5] = "0.3333";
            fila2[6] = "0.3293";
            fila2[7] = "0.3476";
            fila2[8] = "0.3595";
            fila2[9] = "0.3659";
            fila2[10] = "0.3679";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "2";
            fila3[1] = "0.0045";
            fila3[2] = "0.0164";
            fila3[3] = "0.0333";
            fila3[4] = "0.0536";
            fila3[5] = "0.0758";
            fila3[6] = "0.0988";
            fila3[7] = "0.1217";
            fila3[8] = "0.1438";
            fila3[9] = "0.1647";
            fila3[10] = "0.1839";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "3";
            fila4[1] = "0.0002";
            fila4[2] = "0.0011";
            fila4[3] = "0.0033";
            fila4[4] = "0.0072";
            fila4[5] = "0.0126";
            fila4[6] = "0.0198";
            fila4[7] = "0.0284";
            fila4[8] = "0.0383";
            fila4[9] = "0.0494";
            fila4[10] = "0.063";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "4";
            fila5[1] = "0.0000";
            fila5[2] = "0.0001";
            fila5[3] = "0.0003";
            fila5[4] = "0.0007";
            fila5[5] = "0.0016";
            fila5[6] = "0.0030";
            fila5[7] = "0.0050";
            fila5[8] = "0.0077";
            fila5[9] = "0.0111";
            fila5[10] = "0.0153";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "5";
            fila6[1] = "0.0000";
            fila6[2] = "0.0000";
            fila6[3] = "0.0000";
            fila6[4] = "0.0001";
            fila6[5] = "0.0002";
            fila6[6] = "0.0004";
            fila6[7] = "0.0007";
            fila6[8] = "0.0012";
            fila6[9] = "0.0020";
            fila6[10] = "0.0031";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "6";
            fila7[1] = "0.0000";
            fila7[2] = "0.0000";
            fila7[3] = "0.0000";
            fila7[4] = "0.0000";
            fila7[5] = "0.0000";
            fila7[6] = "0.0000";
            fila7[7] = "0.0001";
            fila7[8] = "0.0002";
            fila7[9] = "0.0003";
            fila7[10] = "0.0005";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "7";
            fila8[1] = "0.0000";
            fila8[2] = "0.0000";
            fila8[3] = "0.0000";
            fila8[4] = "0.0000";
            fila8[5] = "0.0000";
            fila8[6] = "0.0000";
            fila8[7] = "0.0000";
            fila8[8] = "0.0000";
            fila8[9] = "0.0000";
            fila8[10] = "0.0001";
            dt.Rows.Add(fila8);
            dgv_t4b1.DataSource = dt;

        }
        public void CargarTabla2()
        {
            DataTable d1 = new DataTable();
            d1.Columns.Add("X");
            d1.Columns.Add("1.1");
            d1.Columns.Add("1.2");
            d1.Columns.Add("1.3");
            d1.Columns.Add("1.4");
            d1.Columns.Add("1.5");
            d1.Columns.Add("1.6");
            d1.Columns.Add("1.7");
            d1.Columns.Add("1.8");
            d1.Columns.Add("1.9");
            d1.Columns.Add("2.0");

            DataRow fila9 = d1.NewRow();
            fila9[0] = "0";
            fila9[1] = "0.3329";
            fila9[2] = "0.3012";
            fila9[3] = "0.2725";
            fila9[4] = "0.2466";
            fila9[5] = "0.2231";
            fila9[6] = "0.2019";
            fila9[7] = "0.1827";
            fila9[8] = "0.1653";
            fila9[9] = "0.1496";
            fila9[10] = "0.1353";
            d1.Rows.Add(fila9);

            DataRow fila10 = d1.NewRow();
            fila10[0] = "1";
            fila10[1] = "0.3662";
            fila10[2] = "0.3614";
            fila10[3] = "0.3543";
            fila10[4] = "0.3452";
            fila10[5] = "0.3347";
            fila10[6] = "0.3230";
            fila10[7] = "0.3106";
            fila10[8] = "0.2975";
            fila10[9] = "0.2842";
            fila10[10] = "0.2707";
            d1.Rows.Add(fila10);

            DataRow fila11 = d1.NewRow();
            fila11[0] = "2";
            fila11[1] = "0.2014";
            fila11[2] = "0.2169";
            fila11[3] = "0.2303";
            fila11[4] = "0.2417";
            fila11[5] = "0.2510";
            fila11[6] = "0.2584";
            fila11[7] = "0.2640";
            fila11[8] = "0.2678";
            fila11[9] = "0.2700";
            fila11[10] = "0.2707";
            d1.Rows.Add(fila11);

            DataRow fila12 = d1.NewRow();
            fila12[0] = "3";
            fila12[1] = "0.0738";
            fila12[2] = "0.0867";
            fila12[3] = "0.0998";
            fila12[4] = "0.1128";
            fila12[5] = "0.1255";
            fila12[6] = "0.1378";
            fila12[7] = "0.1496";
            fila12[8] = "0.1607";
            fila12[9] = "0.1710";
            fila12[10] = "0.1804";
            d1.Rows.Add(fila12);

            DataRow fila13 = d1.NewRow();
            fila13[0] = "4";
            fila13[1] = "0.0203";
            fila13[2] = "0.0260";
            fila13[3] = "0.0324";
            fila13[4] = "0.0395";
            fila13[5] = "0.0471";
            fila13[6] = "0.0551";
            fila13[7] = "0.0636";
            fila13[8] = "0.0723";
            fila13[9] = "0.0812";
            fila13[10] = "0.0902";
            d1.Rows.Add(fila13);

            DataRow fila14 = d1.NewRow();
            fila14[0] = "5";
            fila14[1] = "0.0045";
            fila14[2] = "0.0062";
            fila14[3] = "0.0084";
            fila14[4] = "0.0111";
            fila14[5] = "0.0141";
            fila14[6] = "0.0176";
            fila14[7] = "0.0216";
            fila14[8] = "0.0260";
            fila14[9] = "0.0369";
            fila14[10] = "0.0361";
            d1.Rows.Add(fila14);

            DataRow fila15 = d1.NewRow();
            fila15[0] = "6";
            fila15[1] = "0.0008";
            fila15[2] = "0.0012";
            fila15[3] = "0.0018";
            fila15[4] = "0.0026";
            fila15[5] = "0.0035";
            fila15[6] = "0.0047";
            fila15[7] = "0.0061";
            fila15[8] = "0.0078";
            fila15[9] = "0.0098";
            fila15[10] = "0.0120";
            d1.Rows.Add(fila15);

            DataRow fila16 = d1.NewRow();
            fila16[0] = "7";
            fila16[1] = "0.0001";
            fila16[2] = "0.0002";
            fila16[3] = "0.0003";
            fila16[4] = "0.0005";
            fila16[5] = "0.0008";
            fila16[6] = "0.0011";
            fila16[7] = "0.0015";
            fila16[8] = "0.0020";
            fila16[9] = "0.0027";
            fila16[10] = "0.0034";
            d1.Rows.Add(fila16);

            DataRow fila17 = d1.NewRow();
            fila17[0] = "8";
            fila17[1] = "0.0000";
            fila17[2] = "0.0000";
            fila17[3] = "0.0001";
            fila17[4] = "0.0001";
            fila17[5] = "0.0001";
            fila17[6] = "0.0002";
            fila17[7] = "0.0003";
            fila17[8] = "0.0005";
            fila17[9] = "0.0006";
            fila17[10] = "0.0009";
            d1.Rows.Add(fila17);

            DataRow fila18 = d1.NewRow();
            fila18[0] = "9";
            fila18[1] = "0.0000";
            fila18[2] = "0.0000";
            fila18[3] = "0.0000";
            fila18[4] = "0.0000";
            fila18[5] = "0.0000";
            fila18[6] = "0.0000";
            fila18[7] = "0.0001";
            fila18[8] = "0.0001";
            fila18[9] = "0.0001";
            fila18[10] = "0.0002";
            d1.Rows.Add(fila18);
            dgv_t4b2.DataSource = d1;

        }
        public void CargarTabla3()
        {
            DataTable d2 = new DataTable();
            d2.Columns.Add("X");
            d2.Columns.Add("2.1");
            d2.Columns.Add("2.2");
            d2.Columns.Add("2.3");
            d2.Columns.Add("2.4");
            d2.Columns.Add("2.5");
            d2.Columns.Add("2.6");
            d2.Columns.Add("2.7");
            d2.Columns.Add("2.8");
            d2.Columns.Add("2.9");
            d2.Columns.Add("3.0");

            DataRow fila19 = d2.NewRow();
            fila19[0] = "0";
            fila19[1] = "0.1225";
            fila19[2] = "0.1108";
            fila19[3] = "0.1003";
            fila19[4] = "0.0907";
            fila19[5] = "0.0821";
            fila19[6] = "0.0743";
            fila19[7] = "0.0672";
            fila19[8] = "0.0608";
            fila19[9] = "0.0550";
            fila19[10] = "0.0498";
            d2.Rows.Add(fila19);

            DataRow fila20 = d2.NewRow();
            fila20[0] = "1";
            fila20[1] = "0.2572";
            fila20[2] = "0.2438";
            fila20[3] = "0.2306";
            fila20[4] = "0.2177";
            fila20[5] = "0.2052";
            fila20[6] = "0.1931";
            fila20[7] = "0.1815";
            fila20[8] = "0.1703";
            fila20[9] = "0.1596";
            fila20[10] = "0.1494";
            d2.Rows.Add(fila20);

            DataRow fila21 = d2.NewRow();
            fila21[0] = "2";
            fila21[1] = "0.2700";
            fila21[2] = "0.2681";
            fila21[3] = "0.2652";
            fila21[4] = "0.2613";
            fila21[5] = "0.2565";
            fila21[6] = "0.2510";
            fila21[7] = "0.2450";
            fila21[8] = "0.2384";
            fila21[9] = "0.2314";
            fila21[10] = "0.2240";
            d2.Rows.Add(fila21);

            DataRow fila22 = d2.NewRow();
            fila22[0] = "3";
            fila22[1] = "0.1890";
            fila22[2] = "0.1966";
            fila22[3] = "0.2033";
            fila22[4] = "0.2090";
            fila22[5] = "0.2138";
            fila22[6] = "0.2176";
            fila22[7] = "0.2205";
            fila22[8] = "0.2225";
            fila22[9] = "0.2237";
            fila22[10] = "0.2240";
            d2.Rows.Add(fila22);

            DataRow fila23 = d2.NewRow();
            fila23[0] = "4";
            fila23[1] = "0.0992";
            fila23[2] = "0.1082";
            fila23[3] = "0.1169";
            fila23[4] = "0.1254";
            fila23[5] = "0.1336";
            fila23[6] = "0.1414";
            fila23[7] = "0.1488";
            fila23[8] = "0.1557";
            fila23[9] = "0.1622";
            fila23[10] = "0.1680";
            d2.Rows.Add(fila23);

            DataRow fila24 = d2.NewRow();
            fila24[0] = "5";
            fila24[1] = "0.0417";
            fila24[2] = "0.0476";
            fila24[3] = "0.0538";
            fila24[4] = "0.0602";
            fila24[5] = "0.0668";
            fila24[6] = "0.0735";
            fila24[7] = "0.0804";
            fila24[8] = "0.0872";
            fila24[9] = "0.0940";
            fila24[10] = "0.1008";
            d2.Rows.Add(fila24);

            DataRow fila25 = d2.NewRow();
            fila25[0] = "6";
            fila25[1] = "0.0146";
            fila25[2] = "0.0174";
            fila25[3] = "0.0206";
            fila25[4] = "0.0241";
            fila25[5] = "0.0278";
            fila25[6] = "0.0319";
            fila25[7] = "0.0362";
            fila25[8] = "0.0407";
            fila25[9] = "0.0455";
            fila25[10] = "0.0504";
            d2.Rows.Add(fila25);

            DataRow fila26 = d2.NewRow();
            fila26[0] = "7";
            fila26[1] = "0.0044";
            fila26[2] = "0.0055";
            fila26[3] = "0.0068";
            fila26[4] = "0.0083";
            fila26[5] = "0.0099";
            fila26[6] = "0.0118";
            fila26[7] = "0.0139";
            fila26[8] = "0.0163";
            fila26[9] = "0.0188";
            fila26[10] = "0.0216";
            d2.Rows.Add(fila26);

            DataRow fila27 = d2.NewRow();
            fila27[0] = "8";
            fila27[1] = "0.0011";
            fila27[2] = "0.0015";
            fila27[3] = "0.0019";
            fila27[4] = "0.0025";
            fila27[5] = "0.0031";
            fila27[6] = "0.0038";
            fila27[7] = "0.0047";
            fila27[8] = "0.0057";
            fila27[9] = "0.0068";
            fila27[10] = "0.0081";
            d2.Rows.Add(fila27);

            DataRow fila28 = d2.NewRow();
            fila28[0] = "9";
            fila28[1] = "0.0003";
            fila28[2] = "0.0004";
            fila28[3] = "0.0005";
            fila28[4] = "0.0007";
            fila28[5] = "0.0009";
            fila28[6] = "0.0011";
            fila28[7] = "0.0014";
            fila28[8] = "0.0018";
            fila28[9] = "0.0022";
            fila28[10] = "0.0027";
            d2.Rows.Add(fila28);

            DataRow fila29 = d2.NewRow();
            fila29[0] = "10";
            fila29[1] = "0.0001";
            fila29[2] = "0.0001";
            fila29[3] = "0.0001";
            fila29[4] = "0.0002";
            fila29[5] = "0.0002";
            fila29[6] = "0.0003";
            fila29[7] = "0.0004";
            fila29[8] = "0.0005";
            fila29[9] = "0.0006";
            fila29[10] = "0.0008";
            d2.Rows.Add(fila29);

            DataRow fila30 = d2.NewRow();
            fila30[0] = "11";
            fila30[1] = "0.0000";
            fila30[2] = "0.0000";
            fila30[3] = "0.0000";
            fila30[4] = "0.0000";
            fila30[5] = "0.0000";
            fila30[6] = "0.0001";
            fila30[7] = "0.0001";
            fila30[8] = "0.0001";
            fila30[9] = "0.0002";
            fila30[10] = "0.0002";
            d2.Rows.Add(fila30);

            DataRow fila31 = d2.NewRow();
            fila31[0] = "12";
            fila31[1] = "0.0000";
            fila31[2] = "0.0000";
            fila31[3] = "0.0000";
            fila31[4] = "0.0000";
            fila31[5] = "0.0000";
            fila31[6] = "0.0000";
            fila31[7] = "0.0000";
            fila31[8] = "0.0000";
            fila31[9] = "0.0000";
            fila31[10] = "0.0001";
            d2.Rows.Add(fila31);
            dgv_t4b3.DataSource = d2;
        }
        public void CargarTabla4()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("X");
            dt.Columns.Add("3.1");
            dt.Columns.Add("3.2");
            dt.Columns.Add("3.3");
            dt.Columns.Add("3.4");
            dt.Columns.Add("3.5");
            dt.Columns.Add("3.6");
            dt.Columns.Add("3.7");
            dt.Columns.Add("3.8");
            dt.Columns.Add("3.9");
            dt.Columns.Add("4.0");

            DataRow fila1 = dt.NewRow();
            fila1[0] = "0";
            fila1[1] = "0.0450";
            fila1[2] = "0.0408";
            fila1[3] = "0.0369";
            fila1[4] = "0.0334";
            fila1[5] = "0.0302";
            fila1[6] = "0.0273";
            fila1[7] = "0.0247";
            fila1[8] = "0.0224";
            fila1[9] = "0.0202";
            fila1[10] = "0.0183";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "1";
            fila2[1] = "0.1397";
            fila2[2] = "0.1304";
            fila2[3] = "0.1217";
            fila2[4] = "0.1135";
            fila2[5] = "0.1057";
            fila2[6] = "0.0984";
            fila2[7] = "0.0915";
            fila2[8] = "0.0850";
            fila2[9] = "0.0789";
            fila2[10] = "0.0733";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "2";
            fila3[1] = "0.2165";
            fila3[2] = "0.2087";
            fila3[3] = "0.2008";
            fila3[4] = "0.1929";
            fila3[5] = "0.1850";
            fila3[6] = "0.1771";
            fila3[7] = "0.1692";
            fila3[8] = "0.1615";
            fila3[9] = "0.1539";
            fila3[10] = "0.1465";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "3";
            fila4[1] = "0.2237";
            fila4[2] = "0.2226";
            fila4[3] = "0.2209";
            fila4[4] = "0.2186";
            fila4[5] = "0.2158";
            fila4[6] = "0.2125";
            fila4[7] = "0.2087";
            fila4[8] = "0.2046";
            fila4[9] = "0.2001";
            fila4[10] = "0.1954";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "4";
            fila5[1] = "0.1734";
            fila5[2] = "0.1781";
            fila5[3] = "0.1823";
            fila5[4] = "0.1858";
            fila5[5] = "0.1888";
            fila5[6] = "0.1912";
            fila5[7] = "0.1931";
            fila5[8] = "0.1944";
            fila5[9] = "0.1951";
            fila5[10] = "0.1954";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "5";
            fila6[1] = "0.1075";
            fila6[2] = "0.1140";
            fila6[3] = "0.1203";
            fila6[4] = "0.1264";
            fila6[5] = "0.1322";
            fila6[6] = "0.1377";
            fila6[7] = "0.1429";
            fila6[8] = "0.1477";
            fila6[9] = "0.1522";
            fila6[10] = "0.1563";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "6";
            fila7[1] = "0.0555";
            fila7[2] = "0.0608";
            fila7[3] = "0.0662";
            fila7[4] = "0.0716";
            fila7[5] = "0.0771";
            fila7[6] = "0.0826";
            fila7[7] = "0.0881";
            fila7[8] = "0.0936";
            fila7[9] = "0.0989";
            fila7[10] = "0.1042";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "7";
            fila8[1] = "0.0246";
            fila8[2] = "0.0278";
            fila8[3] = "0.0312";
            fila8[4] = "0.0348";
            fila8[5] = "0.0385";
            fila8[6] = "0.0425";
            fila8[7] = "0.0466";
            fila8[8] = "0.0508";
            fila8[9] = "0.0551";
            fila8[10] = "0.0595";
            dt.Rows.Add(fila8);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "8";
            fila9[1] = "0.0095";
            fila9[2] = "0.0111";
            fila9[3] = "0.0129";
            fila9[4] = "0.0148";
            fila9[5] = "0.0169";
            fila9[6] = "0.0191";
            fila9[7] = "0.0215";
            fila9[8] = "0.0241";
            fila9[9] = "0.0269";
            fila9[10] = "0.0298";
            dt.Rows.Add(fila9);

            DataRow fila99 = dt.NewRow();
            fila99[0] = "9";
            fila99[1] = "0.0033";
            fila99[2] = "0.0040";
            fila99[3] = "0.0047";
            fila99[4] = "0.0056";
            fila99[5] = "0.0066";
            fila99[6] = "0.0076";
            fila99[7] = "0.0089";
            fila99[8] = "0.0102";
            fila99[9] = "0.0116";
            fila99[10] = "0.0132";
            dt.Rows.Add(fila99);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "10";
            fila10[1] = "0.0010";
            fila10[2] = "0.0013";
            fila10[3] = "0.0016";
            fila10[4] = "0.0019";
            fila10[5] = "0.0023";
            fila10[6] = "0.0028";
            fila10[7] = "0.0033";
            fila10[8] = "0.0039";
            fila10[9] = "0.0045";
            fila10[10] = "0.0053";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "11";
            fila11[1] = "0.0003";
            fila11[2] = "0.0004";
            fila11[3] = "0.0005";
            fila11[4] = "0.0006";
            fila11[5] = "0.0007";
            fila11[6] = "0.0009";
            fila11[7] = "0.0011";
            fila11[8] = "0.0013";
            fila11[9] = "0.0016";
            fila11[10] = "0.0019";
            dt.Rows.Add(fila11);


            DataRow fila12 = dt.NewRow();
            fila12[0] = "12";
            fila12[1] = "0.0001";
            fila12[2] = "0.0001";
            fila12[3] = "0.0001";
            fila12[4] = "0.0002";
            fila12[5] = "0.0002";
            fila12[6] = "0.0003";
            fila12[7] = "0.0003";
            fila12[8] = "0.0004";
            fila12[9] = "0.0005";
            fila12[10] = "0.0006";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "13";
            fila13[1] = "0.0000";
            fila13[2] = "0.0000";
            fila13[3] = "0.0000";
            fila13[4] = "0.0000";
            fila13[5] = "0.0001";
            fila13[6] = "0.0001";
            fila13[7] = "0.0001";
            fila13[8] = "0.0001";
            fila13[9] = "0.0002";
            fila13[10] = "0.0002";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "14";
            fila14[1] = "0.0000";
            fila14[2] = "0.0000";
            fila14[3] = "0.0000";
            fila14[4] = "0.0000";
            fila14[5] = "0.0000";
            fila14[6] = "0.0000";
            fila14[7] = "0.0000";
            fila14[8] = "0.0000";
            fila14[9] = "0.0000";
            fila14[10] = "0.0001";
            dt.Rows.Add(fila14);

            dgv_t4b4.DataSource = dt;
        }
        public void CargarTabla5()
        {
            DataTable d1 = new DataTable();
            d1.Columns.Add("X");
            d1.Columns.Add("4.1");
            d1.Columns.Add("4.2");
            d1.Columns.Add("4.3");
            d1.Columns.Add("4.4");
            d1.Columns.Add("4.5");
            d1.Columns.Add("4.6");
            d1.Columns.Add("4.7");
            d1.Columns.Add("4.8");
            d1.Columns.Add("4.9");
            d1.Columns.Add("5.0");

            DataRow fila15 = d1.NewRow();
            fila15[0] = "0";
            fila15[1] = "0.0166";
            fila15[2] = "0.0150";
            fila15[3] = "0.0136";
            fila15[4] = "0.0123";
            fila15[5] = "0.0111";
            fila15[6] = "0.0101";
            fila15[7] = "0.0091";
            fila15[8] = "0.0082";
            fila15[9] = "0.0074";
            fila15[10] = "0.0067";
            d1.Rows.Add(fila15);

            DataRow fila16 = d1.NewRow();
            fila16[0] = "1";
            fila16[1] = "0.0679";
            fila16[2] = "0.0630";
            fila16[3] = "0.0583";
            fila16[4] = "0.0540";
            fila16[5] = "0.0500";
            fila16[6] = "0.0462";
            fila16[7] = "0.0427";
            fila16[8] = "0.0395";
            fila16[9] = "0.0365";
            fila16[10] = "0.0337";
            d1.Rows.Add(fila16);

            DataRow fila17 = d1.NewRow();
            fila17[0] = "2";
            fila17[1] = "0.1393";
            fila17[2] = "0.1323";
            fila17[3] = "0.1254";
            fila17[4] = "0.1188";
            fila17[5] = "0.1125";
            fila17[6] = "0.1063";
            fila17[7] = "0.1005";
            fila17[8] = "0.0948";
            fila17[9] = "0.0894";
            fila17[10] = "0.0842";
            d1.Rows.Add(fila17);

            DataRow fila18 = d1.NewRow();
            fila18[0] = "3";
            fila18[1] = "0.1904";
            fila18[2] = "0.1852";
            fila18[3] = "0.1798";
            fila18[4] = "0.1743";
            fila18[5] = "0.1787";
            fila18[6] = "0.1631";
            fila18[7] = "0.1574";
            fila18[8] = "0.1517";
            fila18[9] = "0.1460";
            fila18[10] = "0.1404";
            d1.Rows.Add(fila18);

            DataRow fila19 = d1.NewRow();
            fila19[0] = "4";
            fila19[1] = "0.1951";
            fila19[2] = "0.1944";
            fila19[3] = "0.1933";
            fila19[4] = "0.1917";
            fila19[5] = "0.1898";
            fila19[6] = "0.1875";
            fila19[7] = "0.1849";
            fila19[8] = "0.1820";
            fila19[9] = "0.1789";
            fila19[10] = "0.1755";
            d1.Rows.Add(fila19);

            DataRow fila20 = d1.NewRow();
            fila20[0] = "5";
            fila20[1] = "0.1600";
            fila20[2] = "0.1633";
            fila20[3] = "0.1662";
            fila20[4] = "0.1687";
            fila20[5] = "0.1708";
            fila20[6] = "0.1725";
            fila20[7] = "0.1738";
            fila20[8] = "0.1747";
            fila20[9] = "0.1753";
            fila20[10] = "0.1755";
            d1.Rows.Add(fila20);

            DataRow fila21 = d1.NewRow();
            fila21[0] = "6";
            fila21[1] = "0.1093";
            fila21[2] = "0.1143";
            fila21[3] = "0.1191";
            fila21[4] = "0.1237";
            fila21[5] = "0.1281";
            fila21[6] = "0.1323";
            fila21[7] = "0.1362";
            fila21[8] = "0.1398";
            fila21[9] = "0.1432";
            fila21[10] = "0.1462";
            d1.Rows.Add(fila21);

            DataRow fila22 = d1.NewRow();
            fila22[0] = "7";
            fila22[1] = "0.0640";
            fila22[2] = "0.0686";
            fila22[3] = "0.0732";
            fila22[4] = "0.0778";
            fila22[5] = "0.0824";
            fila22[6] = "0.0869";
            fila22[7] = "0.0914";
            fila22[8] = "0.0959";
            fila22[9] = "0.1022";
            fila22[10] = "0.1044";
            d1.Rows.Add(fila22);

            DataRow fila24 = d1.NewRow();
            fila24[0] = "8";
            fila24[1] = "0.0328";
            fila24[2] = "0.0360";
            fila24[3] = "0.0393";
            fila24[4] = "0.0428";
            fila24[5] = "0.0463";
            fila24[6] = "0.0500";
            fila24[7] = "0.0737";
            fila24[8] = "0.0575";
            fila24[9] = "0.0614";
            fila24[10] = "0.0653";
            d1.Rows.Add(fila24);

            DataRow fila25 = d1.NewRow();
            fila25[0] = "9";
            fila25[1] = "0.0150";
            fila25[2] = "0.0168";
            fila25[3] = "0.0188";
            fila25[4] = "0.0209";
            fila25[5] = "0.0232";
            fila25[6] = "0.0255";
            fila25[7] = "0.0280";
            fila25[8] = "0.0307";
            fila25[9] = "0.0334";
            fila25[10] = "0.0363";
            d1.Rows.Add(fila25);

            DataRow fila26 = d1.NewRow();
            fila26[0] = "10";
            fila26[1] = "0.0061";
            fila26[2] = "0.0071";
            fila26[3] = "0.0081";
            fila26[4] = "0.0092";
            fila26[5] = "0.0104";
            fila26[6] = "0.0118";
            fila26[7] = "0.0132";
            fila26[8] = "0.0147";
            fila26[9] = "0.0164";
            fila26[10] = "0.0181";
            d1.Rows.Add(fila26);

            DataRow fila27 = d1.NewRow();
            fila27[0] = "11";
            fila27[1] = "0.0023";
            fila27[2] = "0.0027";
            fila27[3] = "0.0032";
            fila27[4] = "0.0037";
            fila27[5] = "0.0043";
            fila27[6] = "0.0049";
            fila27[7] = "0.0056";
            fila27[8] = "0.0064";
            fila27[9] = "0.0073";
            fila27[10] = "0.0082";
            d1.Rows.Add(fila27);

            DataRow fila28 = d1.NewRow();
            fila28[0] = "12";
            fila28[1] = "0.0008";
            fila28[2] = "0.0009";
            fila28[3] = "0.0011";
            fila28[4] = "0.0014";
            fila28[5] = "0.0016";
            fila28[6] = "0.0019";
            fila28[7] = "0.0022";
            fila28[8] = "0.0026";
            fila28[9] = "0.0030";
            fila28[10] = "0.0034";
            d1.Rows.Add(fila28);

            DataRow fila29 = d1.NewRow();
            fila29[0] = "13";
            fila29[1] = "0.0002";
            fila29[2] = "0.0003";
            fila29[3] = "0.0004";
            fila29[4] = "0.0005";
            fila29[5] = "0.0006";
            fila29[6] = "0.0007";
            fila29[7] = "0.0008";
            fila29[8] = "0.0009";
            fila29[9] = "0.0011";
            fila29[10] = "0.0013";
            d1.Rows.Add(fila29);

            DataRow fila30 = d1.NewRow();
            fila30[0] = "14";
            fila30[1] = "0.0001";
            fila30[2] = "0.0001";
            fila30[3] = "0.0001";
            fila30[4] = "0.0001";
            fila30[5] = "0.0002";
            fila30[6] = "0.0002";
            fila30[7] = "0.0003";
            fila30[8] = "0.0003";
            fila30[9] = "0.0004";
            fila30[10] = "0.0005";
            d1.Rows.Add(fila30);

            DataRow fila31 = d1.NewRow();
            fila31[0] = "15";
            fila31[1] = "0.0000";
            fila31[2] = "0.0000";
            fila31[3] = "0.0000";
            fila31[4] = "0.0000";
            fila31[5] = "0.0001";
            fila31[6] = "0.0001";
            fila31[7] = "0.0001";
            fila31[8] = "0.0001";
            fila31[9] = "0.0001";
            fila31[10] = "0.0002";
            d1.Rows.Add(fila31);
            dgv_t4b5.DataSource = d1;
        }
        public void CargarTabla6()
        {
            DataTable d2 = new DataTable();
            d2.Columns.Add("X");
            d2.Columns.Add("5.1");
            d2.Columns.Add("5.2");
            d2.Columns.Add("5.3");
            d2.Columns.Add("5.4");
            d2.Columns.Add("5.5");
            d2.Columns.Add("5.6");
            d2.Columns.Add("5.7");
            d2.Columns.Add("5.8");
            d2.Columns.Add("5.9");
            d2.Columns.Add("6.0");

            DataRow fila32 = d2.NewRow();
            fila32[0] = "0";
            fila32[1] = "0.0061";
            fila32[2] = "0.0055";
            fila32[3] = "0.0050";
            fila32[4] = "0.0045";
            fila32[5] = "0.0041";
            fila32[6] = "0.0037";
            fila32[7] = "0.0033";
            fila32[8] = "0.0030";
            fila32[9] = "0.0027";
            fila32[10] = "0.0025";
            d2.Rows.Add(fila32);

            DataRow fila320 = d2.NewRow();
            fila320[0] = "1";
            fila320[1] = "0.0311";
            fila320[2] = "0.0287";
            fila320[3] = "0.0265";
            fila320[4] = "0.0244";
            fila320[5] = "0.0225";
            fila320[6] = "0.0207";
            fila320[7] = "0.0191";
            fila320[8] = "0.0176";
            fila320[9] = "0.0162";
            fila320[10] = "0.0149";
            d2.Rows.Add(fila320);

            DataRow fila33 = d2.NewRow();
            fila33[0] = "2";
            fila33[1] = "0.0793";
            fila33[2] = "0.0746";
            fila33[3] = "0.0701";
            fila33[4] = "0.0659";
            fila33[5] = "0.0618";
            fila33[6] = "0.0580";
            fila33[7] = "0.0544";
            fila33[8] = "0.0509";
            fila33[9] = "0.0477";
            fila33[10] = "0.0446";
            d2.Rows.Add(fila33);

            DataRow fila34 = d2.NewRow();
            fila34[0] = "3";
            fila34[1] = "0.1348";
            fila34[2] = "0.1293";
            fila34[3] = "0.1239";
            fila34[4] = "0.1185";
            fila34[5] = "0.1133";
            fila34[6] = "0.1082";
            fila34[7] = "0.1033";
            fila34[8] = "0.0985";
            fila34[9] = "0.0938";
            fila34[10] = "0.0892";
            d2.Rows.Add(fila34);

            DataRow fila35 = d2.NewRow();
            fila35[0] = "4";
            fila35[1] = "0.1719";
            fila35[2] = "0.1681";
            fila35[3] = "0.1641";
            fila35[4] = "0.1600";
            fila35[5] = "0.1558";
            fila35[6] = "0.1515";
            fila35[7] = "0.1472";
            fila35[8] = "0.1428";
            fila35[9] = "0.1383";
            fila35[10] = "0.1339";
            d2.Rows.Add(fila35);

            DataRow fila36 = d2.NewRow();
            fila36[0] = "5";
            fila36[1] = "0.1753";
            fila36[2] = "0.1748";
            fila36[3] = "0.1740";
            fila36[4] = "0.1728";
            fila36[5] = "0.1714";
            fila36[6] = "0.1697";
            fila36[7] = "0.1678";
            fila36[8] = "0.1656";
            fila36[9] = "0.1632";
            fila36[10] = "0.1606";
            d2.Rows.Add(fila36);

            DataRow fila37 = d2.NewRow();
            fila37[0] = "6";
            fila37[1] = "0.1490";
            fila37[2] = "0.1515";
            fila37[3] = "0.1537";
            fila37[4] = "0.1555";
            fila37[5] = "0.1571";
            fila37[6] = "0.1584";
            fila37[7] = "0.1594";
            fila37[8] = "0.1601";
            fila37[9] = "0.1605";
            fila37[10] = "0.1606";
            d2.Rows.Add(fila37);

            DataRow fila38 = d2.NewRow();
            fila38[0] = "7";
            fila38[1] = "0.1087";
            fila38[2] = "0.1125";
            fila38[3] = "0.1163";
            fila38[4] = "0.1200";
            fila38[5] = "0.1234";
            fila38[6] = "0.1267";
            fila38[7] = "0.1298";
            fila38[8] = "0.1326";
            fila38[9] = "0.1353";
            fila38[10] = "0.1377";
            d2.Rows.Add(fila38);

            DataRow fila39 = d2.NewRow();
            fila39[0] = "8";
            fila39[1] = "0.0692";
            fila39[2] = "0.0731";
            fila39[3] = "0.0771";
            fila39[4] = "0.0810";
            fila39[5] = "0.0849";
            fila39[6] = "0.0887";
            fila39[7] = "0.0925";
            fila39[8] = "0.0962";
            fila39[9] = "0.0998";
            fila39[10] = "0.1033";
            d2.Rows.Add(fila39);

            DataRow fila40 = d2.NewRow();
            fila40[0] = "9";
            fila40[1] = "0.0392";
            fila40[2] = "0.0423";
            fila40[3] = "0.0454";
            fila40[4] = "0.0486";
            fila40[5] = "0.0519";
            fila40[6] = "0.0552";
            fila40[7] = "0.0586";
            fila40[8] = "0.0620";
            fila40[9] = "0.0654";
            fila40[10] = "0.0688";
            d2.Rows.Add(fila40);

            DataRow fila41 = d2.NewRow();
            fila41[0] = "10";
            fila41[1] = "0.0200";
            fila41[2] = "0.0220";
            fila41[3] = "0.0241";
            fila41[4] = "0.0262";
            fila41[5] = "0.0285";
            fila41[6] = "0.0309";
            fila41[7] = "0.0334";
            fila41[8] = "0.0359";
            fila41[9] = "0.0386";
            fila41[10] = "0.0413";
            d2.Rows.Add(fila41);

            DataRow fila42 = d2.NewRow();
            fila42[0] = "11";
            fila42[1] = "0.0093";
            fila42[2] = "0.0104";
            fila42[3] = "0.0116";
            fila42[4] = "0.0129";
            fila42[5] = "0.0143";
            fila42[6] = "0.0157";
            fila42[7] = "0.0173";
            fila42[8] = "0.0190";
            fila42[9] = "0.0207";
            fila42[10] = "0.0225";
            d2.Rows.Add(fila42);

            DataRow fila43 = d2.NewRow();
            fila43[0] = "12";
            fila43[1] = "0.0039";
            fila43[2] = "0.0045";
            fila43[3] = "0.0051";
            fila43[4] = "0.0058";
            fila43[5] = "0.0065";
            fila43[6] = "0.0073";
            fila43[7] = "0.0082";
            fila43[8] = "0.0092";
            fila43[9] = "0.0102";
            fila43[10] = "0.0113";
            d2.Rows.Add(fila43);

            DataRow fila44 = d2.NewRow();
            fila44[0] = "13";
            fila44[1] = "0.0015";
            fila44[2] = "0.0018";
            fila44[3] = "0.0021";
            fila44[4] = "0.0024";
            fila44[5] = "0.0028";
            fila44[6] = "0.0032";
            fila44[7] = "0.0036";
            fila44[8] = "0.0041";
            fila44[9] = "0.0046";
            fila44[10] = "0.0052";
            d2.Rows.Add(fila44);

            DataRow fila45 = d2.NewRow();
            fila45[0] = "14";
            fila45[1] = "0.0006";
            fila45[2] = "0.0007";
            fila45[3] = "0.0008";
            fila45[4] = "0.0009";
            fila45[5] = "0.0011";
            fila45[6] = "0.0013";
            fila45[7] = "0.0015";
            fila45[8] = "0.0017";
            fila45[9] = "0.0019";
            fila45[10] = "0.0022";
            d2.Rows.Add(fila45);

            DataRow fila46 = d2.NewRow();
            fila46[0] = "15";
            fila46[1] = "0.0002";
            fila46[2] = "0.0002";
            fila46[3] = "0.0003";
            fila46[4] = "0.0003";
            fila46[5] = "0.0004";
            fila46[6] = "0.0005";
            fila46[7] = "0.0006";
            fila46[8] = "0.0007";
            fila46[9] = "0.0008";
            fila46[10] = "0.0009";
            d2.Rows.Add(fila46);

            DataRow fila47 = d2.NewRow();
            fila47[0] = "16";
            fila47[1] = "0.0001";
            fila47[2] = "0.0001";
            fila47[3] = "0.0001";
            fila47[4] = "0.0001";
            fila47[5] = "0.0001";
            fila47[6] = "0.0002";
            fila47[7] = "0.0002";
            fila47[8] = "0.0002";
            fila47[9] = "0.0003";
            fila47[10] = "0.0003";
            d2.Rows.Add(fila47);

            DataRow fila48 = d2.NewRow();
            fila48[0] = "17";
            fila48[1] = "0.0000";
            fila48[2] = "0.0000";
            fila48[3] = "0.0000";
            fila48[4] = "0.0000";
            fila48[5] = "0.0000";
            fila48[6] = "0.0000";
            fila48[7] = "0.0001";
            fila48[8] = "0.0001";
            fila48[9] = "0.0001";
            fila48[10] = "0.0001";
            d2.Rows.Add(fila48);

            dgv_t4b6.DataSource = d2;


        }
        public void CargarTabla7()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("X");
            dt.Columns.Add("6.1");
            dt.Columns.Add("6.2");
            dt.Columns.Add("6.3");
            dt.Columns.Add("6.4");
            dt.Columns.Add("6.5");
            dt.Columns.Add("6.6");
            dt.Columns.Add("6.7");
            dt.Columns.Add("6.8");
            dt.Columns.Add("6.9");
            dt.Columns.Add("7.0");

            DataRow fila1 = dt.NewRow();
            fila1[0] = "0";
            fila1[1] = "0.0022";
            fila1[2] = "0.0220";
            fila1[3] = "0.0018";
            fila1[4] = "0.0017";
            fila1[5] = "0.0015";
            fila1[6] = "0.0014";
            fila1[7] = "0.0012";
            fila1[8] = "0.0011";
            fila1[9] = "0.0010";
            fila1[10] = "0.0009";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "1";
            fila2[1] = "0.0137";
            fila2[2] = "0.0126";
            fila2[3] = "0.0116";
            fila2[4] = "0.0106";
            fila2[5] = "0.0098";
            fila2[6] = "0.0090";
            fila2[7] = "0.0082";
            fila2[8] = "0.0076";
            fila2[9] = "0.0070";
            fila2[10] = "0.0064";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "2";
            fila3[1] = "0.0417";
            fila3[2] = "0.0390";
            fila3[3] = "0.0364";
            fila3[4] = "0.0340";
            fila3[5] = "0.0318";
            fila3[6] = "0.0296";
            fila3[7] = "0.0276";
            fila3[8] = "0.0258";
            fila3[9] = "0.0240";
            fila3[10] = "0.0223";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "3";
            fila4[1] = "0.0848";
            fila4[2] = "0.0806";
            fila4[3] = "0.0765";
            fila4[4] = "0.0726";
            fila4[5] = "0.0688";
            fila4[6] = "0.0652";
            fila4[7] = "0.0617";
            fila4[8] = "0.0584";
            fila4[9] = "0.0552";
            fila4[10] = "0.0521";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "4";
            fila5[1] = "0.1894";
            fila5[2] = "0.1249";
            fila5[3] = "0.1205";
            fila5[4] = "0.1162";
            fila5[5] = "0.1118";
            fila5[6] = "0.1076";
            fila5[7] = "0.1034";
            fila5[8] = "0.0992";
            fila5[9] = "0.0952";
            fila5[10] = "0.0912";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "5";
            fila6[1] = "0.1579";
            fila6[2] = "0.1549";
            fila6[3] = "0.1519";
            fila6[4] = "0.1487";
            fila6[5] = "0.1454";
            fila6[6] = "0.1420";
            fila6[7] = "0.1385";
            fila6[8] = "0.1349";
            fila6[9] = "0.1314";
            fila6[10] = "0.1277";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "6";
            fila7[1] = "0.1605";
            fila7[2] = "0.1601";
            fila7[3] = "0.1595";
            fila7[4] = "0.1583";
            fila7[5] = "0.1575";
            fila7[6] = "0.1562";
            fila7[7] = "0.1546";
            fila7[8] = "0.1529";
            fila7[9] = "0.1511";
            fila7[10] = "0.1490";
            dt.Rows.Add(fila7);

            DataRow fila800 = dt.NewRow();
            fila800[0] = "7";
            fila800[1] = "0.1399";
            fila800[2] = "0.1418";
            fila800[3] = "0.1435";
            fila800[4] = "0.1450";
            fila800[5] = "0.1462";
            fila800[6] = "0.1472";
            fila800[7] = "0.1480";
            fila800[8] = "0.1486";
            fila800[9] = "0.1489";
            fila800[10] = "0.1490";
            dt.Rows.Add(fila800);

            DataRow fila81 = dt.NewRow();
            fila81[0] = "8";
            fila81[1] = "0.1066";
            fila81[2] = "0.1099";
            fila81[3] = "0.1130";
            fila81[4] = "0.1160";
            fila81[5] = "0.1188";
            fila81[6] = "0.1215";
            fila81[7] = "0.1240";
            fila81[8] = "0.1263";
            fila81[9] = "0.1284";
            fila81[10] = "0.1304";
            dt.Rows.Add(fila81);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "9";
            fila9[1] = "0.0723";
            fila9[2] = "0.0757";
            fila9[3] = "0.0791";
            fila9[4] = "0.0825";
            fila9[5] = "0.0858";
            fila9[6] = "0.0891";
            fila9[7] = "0.0923";
            fila9[8] = "0.0954";
            fila9[9] = "0.0985";
            fila9[10] = "0.1014";
            dt.Rows.Add(fila9);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "10";
            fila10[1] = "0.0441";
            fila10[2] = "0.0469";
            fila10[3] = "0.0498";
            fila10[4] = "0.0528";
            fila10[5] = "0.0558";
            fila10[6] = "0.0588";
            fila10[7] = "0.0618";
            fila10[8] = "0.0649";
            fila10[9] = "0.0679";
            fila10[10] = "0.0710";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "11";
            fila11[1] = "0.0245";
            fila11[2] = "0.0265";
            fila11[3] = "0.0285";
            fila11[4] = "0.0307";
            fila11[5] = "0.0330";
            fila11[6] = "0.0353";
            fila11[7] = "0.0377";
            fila11[8] = "0.0401";
            fila11[9] = "0.0426";
            fila11[10] = "0.0452";
            dt.Rows.Add(fila11);


            DataRow fila12 = dt.NewRow();
            fila12[0] = "12";
            fila12[1] = "0.0124";
            fila12[2] = "0.0137";
            fila12[3] = "0.0150";
            fila12[4] = "0.0164";
            fila12[5] = "0.0179";
            fila12[6] = "0.0194";
            fila12[7] = "0.0210";
            fila12[8] = "0.0227";
            fila12[9] = "0.0245";
            fila12[10] = "0.0264";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "13";
            fila13[1] = "0.0058";
            fila13[2] = "0.0065";
            fila13[3] = "0.0073";
            fila13[4] = "0.0081";
            fila13[5] = "0.0089";
            fila13[6] = "0.0098";
            fila13[7] = "0.0108";
            fila13[8] = "0.0119";
            fila13[9] = "0.0130";
            fila13[10] = "0.0142";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "14";
            fila14[1] = "0.0025";
            fila14[2] = "0.0029";
            fila14[3] = "0.0033";
            fila14[4] = "0.0037";
            fila14[5] = "0.0041";
            fila14[6] = "0.0046";
            fila14[7] = "0.0052";
            fila14[8] = "0.0058";
            fila14[9] = "0.0064";
            fila14[10] = "0.0071";
            dt.Rows.Add(fila14);

            DataRow fila15 = dt.NewRow();
            fila15[0] = "15";
            fila15[1] = "0.0010";
            fila15[2] = "0.0012";
            fila15[3] = "0.0014";
            fila15[4] = "0.0016";
            fila15[5] = "0.0018";
            fila15[6] = "0.0020";
            fila15[7] = "0.0023";
            fila15[8] = "0.0026";
            fila15[9] = "0.0029";
            fila15[10] = "0.0033";
            dt.Rows.Add(fila15);

            DataRow fila16 = dt.NewRow();
            fila16[0] = "16";
            fila16[1] = "0.0004";
            fila16[2] = "0.0005";
            fila16[3] = "0.0005";
            fila16[4] = "0.0006";
            fila16[5] = "0.0007";
            fila16[6] = "0.0008";
            fila16[7] = "0.0010";
            fila16[8] = "0.0011";
            fila16[9] = "0.0013";
            fila16[10] = "0.0014";
            dt.Rows.Add(fila16);

            DataRow fila17 = dt.NewRow();
            fila17[0] = "17";
            fila17[1] = "0.0001";
            fila17[2] = "0.0002";
            fila17[3] = "0.0002";
            fila17[4] = "0.0002";
            fila17[5] = "0.0003";
            fila17[6] = "0.0003";
            fila17[7] = "0.0004";
            fila17[8] = "0.0004";
            fila17[9] = "0.0005";
            fila17[10] = "0.0006";
            dt.Rows.Add(fila17);

            DataRow fila18 = dt.NewRow();
            fila18[0] = "18";
            fila18[1] = "0.0000";
            fila18[2] = "0.0001";
            fila18[3] = "0.0001";
            fila18[4] = "0.0001";
            fila18[5] = "0.0001";
            fila18[6] = "0.0001";
            fila18[7] = "0.0001";
            fila18[8] = "0.0002";
            fila18[9] = "0.0002";
            fila18[10] = "0.0002";
            dt.Rows.Add(fila18);

            DataRow fila19 = dt.NewRow();
            fila19[0] = "19";
            fila19[1] = "0.0000";
            fila19[2] = "0.0000";
            fila19[3] = "0.0000";
            fila19[4] = "0.0000";
            fila19[5] = "0.0000";
            fila19[6] = "0.0000";
            fila19[7] = "0.0000";
            fila19[8] = "0.0001";
            fila19[9] = "0.0001";
            fila19[10] = "0.0001";
            dt.Rows.Add(fila19);

            dgv_t4b7.DataSource = dt;


        }
        public void CargarTabla8()
        {
            DataTable d1 = new DataTable();
            d1.Columns.Add("X");
            d1.Columns.Add("7.1");
            d1.Columns.Add("7.2");
            d1.Columns.Add("7.3");
            d1.Columns.Add("7.4");
            d1.Columns.Add("7.5");
            d1.Columns.Add("7.6");
            d1.Columns.Add("7.7");
            d1.Columns.Add("7.8");
            d1.Columns.Add("7.9");
            d1.Columns.Add("8.0");


            DataRow fila20 = d1.NewRow();
            fila20[0] = "0";
            fila20[1] = "0.0008";
            fila20[2] = "0.0007";
            fila20[3] = "0.0007";
            fila20[4] = "0.0006";
            fila20[5] = "0.0006";
            fila20[6] = "0.0005";
            fila20[7] = "0.0005";
            fila20[8] = "0.0004";
            fila20[9] = "0.0004";
            fila20[10] = "0.0003";
            d1.Rows.Add(fila20);

            DataRow fila21 = d1.NewRow();
            fila21[0] = "1";
            fila21[1] = "0.0059";
            fila21[2] = "0.0054";
            fila21[3] = "0.0049";
            fila21[4] = "0.0045";
            fila21[5] = "0.0041";
            fila21[6] = "0.0038";
            fila21[7] = "0.0035";
            fila21[8] = "0.0032";
            fila21[9] = "0.0029";
            fila21[10] = "0.0027";
            d1.Rows.Add(fila21);

            DataRow fila22 = d1.NewRow();
            fila22[0] = "2";
            fila22[1] = "0.0208";
            fila22[2] = "0.0194";
            fila22[3] = "0.0180";
            fila22[4] = "0.0167";
            fila22[5] = "0.0156";
            fila22[6] = "0.0145";
            fila22[7] = "0.0134";
            fila22[8] = "0.0125";
            fila22[9] = "0.0116";
            fila22[10] = "0.0107";
            d1.Rows.Add(fila22);

            DataRow fila24 = d1.NewRow();
            fila24[0] = "3";
            fila24[1] = "0.0492";
            fila24[2] = "0.0464";
            fila24[3] = "0.0438";
            fila24[4] = "0.0413";
            fila24[5] = "0.0389";
            fila24[6] = "0.0366";
            fila24[7] = "0.0345";
            fila24[8] = "0.0324";
            fila24[9] = "0.0305";
            fila24[10] = "0.0286";
            d1.Rows.Add(fila24);

            DataRow fila25 = d1.NewRow();
            fila25[0] = "4";
            fila25[1] = "0.0874";
            fila25[2] = "0.0836";
            fila25[3] = "0.0799";
            fila25[4] = "0.0764";
            fila25[5] = "0.0729";
            fila25[6] = "0.0696";
            fila25[7] = "0.0663";
            fila25[8] = "0.0632";
            fila25[9] = "0.0602";
            fila25[10] = "0.0573";
            d1.Rows.Add(fila25);

            DataRow fila26 = d1.NewRow();
            fila26[0] = "5";
            fila26[1] = "0.1241";
            fila26[2] = "0.1204";
            fila26[3] = "0.1167";
            fila26[4] = "0.1130";
            fila26[5] = "0.1094";
            fila26[6] = "0.1057";
            fila26[7] = "0.1021";
            fila26[8] = "0.0986";
            fila26[9] = "0.0951";
            fila26[10] = "0.0916";
            d1.Rows.Add(fila26);

            DataRow fila27 = d1.NewRow();
            fila27[0] = "6";
            fila27[1] = "0.1468";
            fila27[2] = "0.1445";
            fila27[3] = "0.1420";
            fila27[4] = "0.1394";
            fila27[5] = "0.1367";
            fila27[6] = "0.1339";
            fila27[7] = "0.1311";
            fila27[8] = "0.1282";
            fila27[9] = "0.1252";
            fila27[10] = "0.1221";
            d1.Rows.Add(fila27);

            DataRow fila28 = d1.NewRow();
            fila28[0] = "7";
            fila28[1] = "0.1489";
            fila28[2] = "0.1486";
            fila28[3] = "0.1481";
            fila28[4] = "0.1474";
            fila28[5] = "0.1465";
            fila28[6] = "0.1454";
            fila28[7] = "0.1442";
            fila28[8] = "0.1428";
            fila28[9] = "0.1413";
            fila28[10] = "0.1396";
            d1.Rows.Add(fila28);

            DataRow fila29 = d1.NewRow();
            fila29[0] = "8";
            fila29[1] = "0.1321";
            fila29[2] = "0.1337";
            fila29[3] = "0.1351";
            fila29[4] = "0.1363";
            fila29[5] = "0.1373";
            fila29[6] = "0.1382";
            fila29[7] = "0.1388";
            fila29[8] = "0.1392";
            fila29[9] = "0.1395";
            fila29[10] = "0.1396";
            d1.Rows.Add(fila29);

            DataRow fila30 = d1.NewRow();
            fila30[0] = "9";
            fila30[1] = "0.1042";
            fila30[2] = "0.1070";
            fila30[3] = "0.1096";
            fila30[4] = "0.1121";
            fila30[5] = "0.1144";
            fila30[6] = "0.1167";
            fila30[7] = "0.1187";
            fila30[8] = "0.1207";
            fila30[9] = "0.1224";
            fila30[10] = "0.1241";
            d1.Rows.Add(fila30);

            DataRow fila31 = d1.NewRow();
            fila31[0] = "10";
            fila31[1] = "0.0740";
            fila31[2] = "0.0770";
            fila31[3] = "0.0808";
            fila31[4] = "0.0829";
            fila31[5] = "0.0858";
            fila31[6] = "0.0887";
            fila31[7] = "0.0914";
            fila31[8] = "0.0941";
            fila31[9] = "0.0967";
            fila31[10] = "0.0993";
            d1.Rows.Add(fila31);

            DataRow fila32 = d1.NewRow();
            fila32[0] = "11";
            fila32[1] = "0.0478";
            fila32[2] = "0.0504";
            fila32[3] = "0.0531";
            fila32[4] = "0.0558";
            fila32[5] = "0.0585";
            fila32[6] = "0.0613";
            fila32[7] = "0.0640";
            fila32[8] = "0.0667";
            fila32[9] = "0.0695";
            fila32[10] = "0.0722";
            d1.Rows.Add(fila32);

            DataRow fila320 = d1.NewRow();
            fila320[0] = "12";
            fila320[1] = "0.0283";
            fila320[2] = "0.0303";
            fila320[3] = "0.0323";
            fila320[4] = "0.0344";
            fila320[5] = "0.0366";
            fila320[6] = "0.0388";
            fila320[7] = "0.0411";
            fila320[8] = "0.0434";
            fila320[9] = "0.0457";
            fila320[10] = "0.0481";
            d1.Rows.Add(fila320);

            DataRow fila33 = d1.NewRow();
            fila33[0] = "13";
            fila33[1] = "0.0154";
            fila33[2] = "0.0168";
            fila33[3] = "0.0181";
            fila33[4] = "0.0196";
            fila33[5] = "0.0211";
            fila33[6] = "0.0227";
            fila33[7] = "0.0243";
            fila33[8] = "0.0260";
            fila33[9] = "0.0278";
            fila33[10] = "0.0296";
            d1.Rows.Add(fila33);

            DataRow fila34 = d1.NewRow();
            fila34[0] = "14";
            fila34[1] = "0.0078";
            fila34[2] = "0.0086";
            fila34[3] = "0.0095";
            fila34[4] = "0.0104";
            fila34[5] = "0.0113";
            fila34[6] = "0.0123";
            fila34[7] = "0.0134";
            fila34[8] = "0.0145";
            fila34[9] = "0.0157";
            fila34[10] = "0.0169";
            d1.Rows.Add(fila34);

            DataRow fila35 = d1.NewRow();
            fila35[0] = "15";
            fila35[1] = "0.0037";
            fila35[2] = "0.0041";
            fila35[3] = "0.0046";
            fila35[4] = "0.0051";
            fila35[5] = "0.0057";
            fila35[6] = "0.0062";
            fila35[7] = "0.0069";
            fila35[8] = "0.0075";
            fila35[9] = "0.0083";
            fila35[10] = "0.0090";
            d1.Rows.Add(fila35);

            DataRow fila36 = d1.NewRow();
            fila36[0] = "16";
            fila36[1] = "0.0016";
            fila36[2] = "0.0019";
            fila36[3] = "0.0021";
            fila36[4] = "0.0024";
            fila36[5] = "0.0026";
            fila36[6] = "0.0030";
            fila36[7] = "0.0033";
            fila36[8] = "0.0037";
            fila36[9] = "0.0041";
            fila36[10] = "0.0045";
            d1.Rows.Add(fila36);

            DataRow fila37 = d1.NewRow();
            fila37[0] = "17";
            fila37[1] = "0.0007";
            fila37[2] = "0.0008";
            fila37[3] = "0.0009";
            fila37[4] = "0.0010";
            fila37[5] = "0.0012";
            fila37[6] = "0.0013";
            fila37[7] = "0.0015";
            fila37[8] = "0.0017";
            fila37[9] = "0.0019";
            fila37[10] = "0.0021";
            d1.Rows.Add(fila37);

            DataRow fila38 = d1.NewRow();
            fila38[0] = "18";
            fila38[1] = "0.0003";
            fila38[2] = "0.0003";
            fila38[3] = "0.0004";
            fila38[4] = "0.0004";
            fila38[5] = "0.0005";
            fila38[6] = "0.0006";
            fila38[7] = "0.0006";
            fila38[8] = "0.0007";
            fila38[9] = "0.0008";
            fila38[10] = "0.0009";
            d1.Rows.Add(fila38);

            DataRow fila39 = d1.NewRow();
            fila39[0] = "19";
            fila39[1] = "0.0001";
            fila39[2] = "0.0001";
            fila39[3] = "0.0001";
            fila39[4] = "0.0002";
            fila39[5] = "0.0002";
            fila39[6] = "0.0002";
            fila39[7] = "0.0003";
            fila39[8] = "0.0003";
            fila39[9] = "0.0003";
            fila39[10] = "0.0004";
            d1.Rows.Add(fila39);

            DataRow fila40 = d1.NewRow();
            fila40[0] = "20";
            fila40[1] = "0.0000";
            fila40[2] = "0.0000";
            fila40[3] = "0.0001";
            fila40[4] = "0.0001";
            fila40[5] = "0.0001";
            fila40[6] = "0.0001";
            fila40[7] = "0.0001";
            fila40[8] = "0.0001";
            fila40[9] = "0.0001";
            fila40[10] = "0.0002";
            d1.Rows.Add(fila40);

            DataRow fila41 = d1.NewRow();
            fila41[0] = "21";
            fila41[1] = "0.0000";
            fila41[2] = "0.0000";
            fila41[3] = "0.0000";
            fila41[4] = "0.0000";
            fila41[5] = "0.0000";
            fila41[6] = "0.0000";
            fila41[7] = "0.0000";
            fila41[8] = "0.0000";
            fila41[9] = "0.0001";
            fila41[10] = "0.0001";
            d1.Rows.Add(fila41);


            dgv_t4b8.DataSource = d1;


        }
        public void CargarTabla9()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("X");
            dt.Columns.Add("8.1");
            dt.Columns.Add("8.2");
            dt.Columns.Add("8.3");
            dt.Columns.Add("8.4");
            dt.Columns.Add("8.5");
            dt.Columns.Add("8.6");
            dt.Columns.Add("8.7");
            dt.Columns.Add("8.8");
            dt.Columns.Add("8.9");
            dt.Columns.Add("9.0");

            DataRow fila1 = dt.NewRow();
            fila1[0] = "0";
            fila1[1] = "0.0003";
            fila1[2] = "0.0003";
            fila1[3] = "0.0002";
            fila1[4] = "0.0002";
            fila1[5] = "0.0002";
            fila1[6] = "0.0002";
            fila1[7] = "0.0002";
            fila1[8] = "0.0002";
            fila1[9] = "0.0001";
            fila1[10] = "0.0001";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "1";
            fila2[1] = "0.0025";
            fila2[2] = "0.0023";
            fila2[3] = "0.0021";
            fila2[4] = "0.0019";
            fila2[5] = "0.0017";
            fila2[6] = "0.0016";
            fila2[7] = "0.0014";
            fila2[8] = "0.0013";
            fila2[9] = "0.0012";
            fila2[10] = "0.0011";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "2";
            fila3[1] = "0.0100";
            fila3[2] = "0.0092";
            fila3[3] = "0.0086";
            fila3[4] = "0.0079";
            fila3[5] = "0.0074";
            fila3[6] = "0.0068";
            fila3[7] = "0.0063";
            fila3[8] = "0.0058";
            fila3[9] = "0.0054";
            fila3[10] = "0.0050";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "3";
            fila4[1] = "0.0269";
            fila4[2] = "0.0252";
            fila4[3] = "0.0237";
            fila4[4] = "0.0222";
            fila4[5] = "0.0202";
            fila4[6] = "0.0195";
            fila4[7] = "0.0183";
            fila4[8] = "0.0171";
            fila4[9] = "0.0160";
            fila4[10] = "0.0150";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "4";
            fila5[1] = "0.0544";
            fila5[2] = "0.0517";
            fila5[3] = "0.0491";
            fila5[4] = "0.0466";
            fila5[5] = "0.0443";
            fila5[6] = "0.0420";
            fila5[7] = "0.0398";
            fila5[8] = "0.0377";
            fila5[9] = "0.0357";
            fila5[10] = "0.0337";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "5";
            fila6[1] = "0.0882";
            fila6[2] = "0.0849";
            fila6[3] = "0.0816";
            fila6[4] = "0.0784";
            fila6[5] = "0.0752";
            fila6[6] = "0.0722";
            fila6[7] = "0.0692";
            fila6[8] = "0.0663";
            fila6[9] = "0.0635";
            fila6[10] = "0.0607";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "6";
            fila7[1] = "0.1191";
            fila7[2] = "0.1160";
            fila7[3] = "0.1128";
            fila7[4] = "0.1097";
            fila7[5] = "0.1066";
            fila7[6] = "0.1034";
            fila7[7] = "0.1003";
            fila7[8] = "0.0972";
            fila7[9] = "0.0941";
            fila7[10] = "0.0911";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "7";
            fila8[1] = "0.1378";
            fila8[2] = "0.1358";
            fila8[3] = "0.1338";
            fila8[4] = "0.1317";
            fila8[5] = "0.1294";
            fila8[6] = "0.1271";
            fila8[7] = "0.1247";
            fila8[8] = "0.1222";
            fila8[9] = "0.1197";
            fila8[10] = "0.1171";
            dt.Rows.Add(fila8);

            DataRow fila80 = dt.NewRow();
            fila80[0] = "8";
            fila80[1] = "0.1395";
            fila80[2] = "0.1392";
            fila80[3] = "0.1388";
            fila80[4] = "0.1382";
            fila80[5] = "0.1372";
            fila80[6] = "0.1366";
            fila80[7] = "0.1356";
            fila80[8] = "0.1344";
            fila80[9] = "0.1332";
            fila80[10] = "0.1318";
            dt.Rows.Add(fila80);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "9";
            fila9[1] = "0.1256";
            fila9[2] = "0.1269";
            fila9[3] = "0.1280";
            fila9[4] = "0.1290";
            fila9[5] = "0.1290";
            fila9[6] = "0.1306";
            fila9[7] = "0.1311";
            fila9[8] = "0.1315";
            fila9[9] = "0.1317";
            fila9[10] = "0.1318";
            dt.Rows.Add(fila9);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "10";
            fila10[1] = "0.1017";
            fila10[2] = "0.1040";
            fila10[3] = "0.1063";
            fila10[4] = "0.1084";
            fila10[5] = "0.1104";
            fila10[6] = "0.1123";
            fila10[7] = "0.1140";
            fila10[8] = "0.1157";
            fila10[9] = "0.1172";
            fila10[10] = "0.1186";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "11";
            fila11[1] = "0.0749";
            fila11[2] = "0.0776";
            fila11[3] = "0.0802";
            fila11[4] = "0.0828";
            fila11[5] = "0.0853";
            fila11[6] = "0.0878";
            fila11[7] = "0.0902";
            fila11[8] = "0.0925";
            fila11[9] = "0.0948";
            fila11[10] = "0.0970";
            dt.Rows.Add(fila11);


            DataRow fila12 = dt.NewRow();
            fila12[0] = "12";
            fila12[1] = "0.0505";
            fila12[2] = "0.0530";
            fila12[3] = "0.0555";
            fila12[4] = "0.0579";
            fila12[5] = "0.0604";
            fila12[6] = "0.0629";
            fila12[7] = "0.0654";
            fila12[8] = "0.0679";
            fila12[9] = "0.0703";
            fila12[10] = "0.0728";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "13";
            fila13[1] = "0.0315";
            fila13[2] = "0.0334";
            fila13[3] = "0.0354";
            fila13[4] = "0.0374";
            fila13[5] = "0.0395";
            fila13[6] = "0.0416";
            fila13[7] = "0.0438";
            fila13[8] = "0.0459";
            fila13[9] = "0.0481";
            fila13[10] = "0.0504";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "14";
            fila14[1] = "0.0182";
            fila14[2] = "0.0196";
            fila14[3] = "0.0210";
            fila14[4] = "0.0225";
            fila14[5] = "0.0240";
            fila14[6] = "0.0256";
            fila14[7] = "0.0272";
            fila14[8] = "0.0289";
            fila14[9] = "0.0306";
            fila14[10] = "0.0324";
            dt.Rows.Add(fila14);

            DataRow fila15 = dt.NewRow();
            fila15[0] = "15";
            fila15[1] = "0.0098";
            fila15[2] = "0.0107";
            fila15[3] = "0.0116";
            fila15[4] = "0.0126";
            fila15[5] = "0.0136";
            fila15[6] = "0.0147";
            fila15[7] = "0.0158";
            fila15[8] = "0.0169";
            fila15[9] = "0.0182";
            fila15[10] = "0.0194";
            dt.Rows.Add(fila15);

            DataRow fila16 = dt.NewRow();
            fila16[0] = "16";
            fila16[1] = "0.0050";
            fila16[2] = "0.0055";
            fila16[3] = "0.0060";
            fila16[4] = "0.0066";
            fila16[5] = "0.0072";
            fila16[6] = "0.0079";
            fila16[7] = "0.0086";
            fila16[8] = "0.0093";
            fila16[9] = "0.0101";
            fila16[10] = "0.0109";
            dt.Rows.Add(fila16);

            DataRow fila17 = dt.NewRow();
            fila17[0] = "17";
            fila17[1] = "0.0024";
            fila17[2] = "0.0026";
            fila17[3] = "0.0029";
            fila17[4] = "0.0033";
            fila17[5] = "0.0036";
            fila17[6] = "0.0040";
            fila17[7] = "0.0044";
            fila17[8] = "0.0048";
            fila17[9] = "0.0053";
            fila17[10] = "0.0058";
            dt.Rows.Add(fila17);

            DataRow fila18 = dt.NewRow();
            fila18[0] = "18";
            fila18[1] = "0.0011";
            fila18[2] = "0.0012";
            fila18[3] = "0.0014";
            fila18[4] = "0.0015";
            fila18[5] = "0.0017";
            fila18[6] = "0.0019";
            fila18[7] = "0.0021";
            fila18[8] = "0.0024";
            fila18[9] = "0.0026";
            fila18[10] = "0.0029";
            dt.Rows.Add(fila18);

            DataRow fila19 = dt.NewRow();
            fila19[0] = "19";
            fila19[1] = "0.0005";
            fila19[2] = "0.0005";
            fila19[3] = "0.0006";
            fila19[4] = "0.0007";
            fila19[5] = "0.0008";
            fila19[6] = "0.0009";
            fila19[7] = "0.0010";
            fila19[8] = "0.0011";
            fila19[9] = "0.0012";
            fila19[10] = "0.0014";
            dt.Rows.Add(fila19);

            DataRow fila20 = dt.NewRow();
            fila20[0] = "20";
            fila20[1] = "0.0002";
            fila20[2] = "0.0002";
            fila20[3] = "0.0002";
            fila20[4] = "0.0003";
            fila20[5] = "0.0003";
            fila20[6] = "0.0004";
            fila20[7] = "0.0004";
            fila20[8] = "0.0005";
            fila20[9] = "0.0005";
            fila20[10] = "0.0006";
            dt.Rows.Add(fila20);

            DataRow fila21 = dt.NewRow();
            fila21[0] = "21";
            fila21[1] = "0.0001";
            fila21[2] = "0.0001";
            fila21[3] = "0.0001";
            fila21[4] = "0.0001";
            fila21[5] = "0.0001";
            fila21[6] = "0.0002";
            fila21[7] = "0.0002";
            fila21[8] = "0.0002";
            fila21[9] = "0.0002";
            fila21[10] = "0.0003";
            dt.Rows.Add(fila21);

            DataRow fila22 = dt.NewRow();
            fila22[0] = "22";
            fila22[1] = "0.0000";
            fila22[2] = "0.0000";
            fila22[3] = "0.0000";
            fila22[4] = "0.0000";
            fila22[5] = "0.0001";
            fila22[6] = "0.0001";
            fila22[7] = "0.0001";
            fila22[8] = "0.0001";
            fila22[9] = "0.0001";
            fila22[10] = "0.0001";
            dt.Rows.Add(fila22);

            dgv_t4b9.DataSource = dt;



        }
        public void CargarTabla10()
        {
            DataTable d1 = new DataTable();
            d1.Columns.Add("X");
            d1.Columns.Add("9.1");
            d1.Columns.Add("9.2");
            d1.Columns.Add("9.3");
            d1.Columns.Add("9.4");
            d1.Columns.Add("9.5");
            d1.Columns.Add("9.6");
            d1.Columns.Add("9.7");
            d1.Columns.Add("7.8");
            d1.Columns.Add("9.9");
            d1.Columns.Add("10");

            DataRow fila24 = d1.NewRow();
            fila24[0] = "0";
            fila24[1] = "0.0001";
            fila24[2] = "0.0001";
            fila24[3] = "0.0001";
            fila24[4] = "0.0001";
            fila24[5] = "0.0001";
            fila24[6] = "0.0001";
            fila24[7] = "0.0001";
            fila24[8] = "0.0001";
            fila24[9] = "0.0001";
            fila24[10] = "0.0000";
            d1.Rows.Add(fila24);

            DataRow fila25 = d1.NewRow();
            fila25[0] = "1";
            fila25[1] = "0.0010";
            fila25[2] = "0.0009";
            fila25[3] = "0.0009";
            fila25[4] = "0.0008";
            fila25[5] = "0.0007";
            fila25[6] = "0.0007";
            fila25[7] = "0.0006";
            fila25[8] = "0.0005";
            fila25[9] = "0.0005";
            fila25[10] = "0.0005";
            d1.Rows.Add(fila25);

            DataRow fila26 = d1.NewRow();
            fila26[0] = "2";
            fila26[1] = "0.0046";
            fila26[2] = "0.0043";
            fila26[3] = "0.0040";
            fila26[4] = "0.0037";
            fila26[5] = "0.0034";
            fila26[6] = "0.0031";
            fila26[7] = "0.0029";
            fila26[8] = "0.0027";
            fila26[9] = "0.0025";
            fila26[10] = "0.0023";
            d1.Rows.Add(fila26);

            DataRow fila27 = d1.NewRow();
            fila27[0] = "3";
            fila27[1] = "0.0140";
            fila27[2] = "0.0131";
            fila27[3] = "0.0123";
            fila27[4] = "0.0115";
            fila27[5] = "0.0107";
            fila27[6] = "0.0100";
            fila27[7] = "0.0193";
            fila27[8] = "0.0087";
            fila27[9] = "0.0081";
            fila27[10] = "0.0076";
            d1.Rows.Add(fila27);

            DataRow fila28 = d1.NewRow();
            fila28[0] = "4";
            fila28[1] = "0.0319";
            fila28[2] = "0.0302";
            fila28[3] = "0.0285";
            fila28[4] = "0.0269";
            fila28[5] = "0.0254";
            fila28[6] = "0.0240";
            fila28[7] = "0.0226";
            fila28[8] = "0.0213";
            fila28[9] = "0.0201";
            fila28[10] = "0.0189";
            d1.Rows.Add(fila28);

            DataRow fila29 = d1.NewRow();
            fila29[0] = "5";
            fila29[1] = "0.0581";
            fila29[2] = "0.0555";
            fila29[3] = "0.0530";
            fila29[4] = "0.0506";
            fila29[5] = "0.0483";
            fila29[6] = "0.0460";
            fila29[7] = "0.0439";
            fila29[8] = "0.0418";
            fila29[9] = "0.0398";
            fila29[10] = "0.0378";
            d1.Rows.Add(fila29);

            DataRow fila30 = d1.NewRow();
            fila30[0] = "6";
            fila30[1] = "0.0881";
            fila30[2] = "0.0851";
            fila30[3] = "0.0822";
            fila30[4] = "0.0793";
            fila30[5] = "0.0764";
            fila30[6] = "0.0736";
            fila30[7] = "0.0709";
            fila30[8] = "0.0682";
            fila30[9] = "0.0656";
            fila30[10] = "0.0631";
            d1.Rows.Add(fila30);

            DataRow fila31 = d1.NewRow();
            fila31[0] = "7";
            fila31[1] = "0.1145";
            fila31[2] = "0.1118";
            fila31[3] = "0.1091";
            fila31[4] = "0.1064";
            fila31[5] = "0.1037";
            fila31[6] = "0.1010";
            fila31[7] = "0.0982";
            fila31[8] = "0.0955";
            fila31[9] = "0.0928";
            fila31[10] = "0.0901";
            d1.Rows.Add(fila31);


            DataRow fila32 = d1.NewRow();
            fila32[0] = "8";
            fila32[1] = "0.1302";
            fila32[2] = "0.1286";
            fila32[3] = "0.1269";
            fila32[4] = "0.1251";
            fila32[5] = "0.1232";
            fila32[6] = "0.1212";
            fila32[7] = "0.1191";
            fila32[8] = "0.1170";
            fila32[9] = "0.1148";
            fila32[10] = "0.1126";
            d1.Rows.Add(fila32);

            DataRow fila320 = d1.NewRow();
            fila320[0] = "9";
            fila320[1] = "0.1317";
            fila320[2] = "0.1315";
            fila320[3] = "0.1311";
            fila320[4] = "0.1306";
            fila320[5] = "0.1300";
            fila320[6] = "0.1293";
            fila320[7] = "0.1284";
            fila320[8] = "0.1274";
            fila320[9] = "0.1263";
            fila320[10] = "0.1151";
            d1.Rows.Add(fila320);

            DataRow fila33 = d1.NewRow();
            fila33[0] = "10";
            fila33[1] = "0.1198";
            fila33[2] = "0.1210";
            fila33[3] = "0.1219";
            fila33[4] = "0.1228";
            fila33[5] = "0.1235";
            fila33[6] = "0.1241";
            fila33[7] = "0.1245";
            fila33[8] = "0.1249";
            fila33[9] = "0.1250";
            fila33[10] = "0.1251";
            d1.Rows.Add(fila33);

            DataRow fila34 = d1.NewRow();
            fila34[0] = "11";
            fila34[1] = "0.0991";
            fila34[2] = "0.1012";
            fila34[3] = "0.1031";
            fila34[4] = "0.1049";
            fila34[5] = "0.1067";
            fila34[6] = "0.1083";
            fila34[7] = "0.1098";
            fila34[8] = "0.1112";
            fila34[9] = "0.1125";
            fila34[10] = "0.1137";
            d1.Rows.Add(fila34);

            DataRow fila35 = d1.NewRow();
            fila35[0] = "12";
            fila35[1] = "0.0752";
            fila35[2] = "0.0776";
            fila35[3] = "0.0799";
            fila35[4] = "0.0822";
            fila35[5] = "0.0844";
            fila35[6] = "0.0866";
            fila35[7] = "0.0888";
            fila35[8] = "0.0908";
            fila35[9] = "0.0928";
            fila35[10] = "0.0948";
            d1.Rows.Add(fila35);

            DataRow fila36 = d1.NewRow();
            fila36[0] = "13";
            fila36[1] = "0.0526";
            fila36[2] = "0.0549";
            fila36[3] = "0.0572";
            fila36[4] = "0.0594";
            fila36[5] = "0.0617";
            fila36[6] = "0.0640";
            fila36[7] = "0.0662";
            fila36[8] = "0.0685";
            fila36[9] = "0.0707";
            fila36[10] = "0.0729";
            d1.Rows.Add(fila36);

            DataRow fila37 = d1.NewRow();
            fila37[0] = "14";
            fila37[1] = "0.0342";
            fila37[2] = "0.0361";
            fila37[3] = "0.0380";
            fila37[4] = "0.0399";
            fila37[5] = "0.0419";
            fila37[6] = "0.0439";
            fila37[7] = "0.0459";
            fila37[8] = "0.0479";
            fila37[9] = "0.0500";
            fila37[10] = "0.0521";
            d1.Rows.Add(fila37);

            DataRow fila38 = d1.NewRow();
            fila38[0] = "15";
            fila38[1] = "0.0208";
            fila38[2] = "0.0221";
            fila38[3] = "0.0235";
            fila38[4] = "0.0250";
            fila38[5] = "0.0265";
            fila38[6] = "0.0281";
            fila38[7] = "0.0297";
            fila38[8] = "0.0313";
            fila38[9] = "0.0330";
            fila38[10] = "0.0347";
            d1.Rows.Add(fila38);

            DataRow fila39 = d1.NewRow();
            fila39[0] = "16";
            fila39[1] = "0.0118";
            fila39[2] = "0.0127";
            fila39[3] = "0.0137";
            fila39[4] = "0.0147";
            fila39[5] = "0.0157";
            fila39[6] = "0.0168";
            fila39[7] = "0.0180";
            fila39[8] = "0.0192";
            fila39[9] = "0.0204";
            fila39[10] = "0.0217";
            d1.Rows.Add(fila39);

            DataRow fila40 = d1.NewRow();
            fila40[0] = "17";
            fila40[1] = "0.0063";
            fila40[2] = "0.0069";
            fila40[3] = "0.0075";
            fila40[4] = "0.0081";
            fila40[5] = "0.0088";
            fila40[6] = "0.0095";
            fila40[7] = "0.0103";
            fila40[8] = "0.0111";
            fila40[9] = "0.0119";
            fila40[10] = "0.0128";
            d1.Rows.Add(fila40);

            DataRow fila41 = d1.NewRow();
            fila41[0] = "18";
            fila41[1] = "0.0032";
            fila41[2] = "0.0035";
            fila41[3] = "0.0039";
            fila41[4] = "0.0042";
            fila41[5] = "0.0046";
            fila41[6] = "0.0051";
            fila41[7] = "0.0055";
            fila41[8] = "0.0060";
            fila41[9] = "0.0065";
            fila41[10] = "0.0071";
            d1.Rows.Add(fila41);

            DataRow fila42 = d1.NewRow();
            fila42[0] = "19";
            fila42[1] = "0.0015";
            fila42[2] = "0.0017";
            fila42[3] = "0.0019";
            fila42[4] = "0.0021";
            fila42[5] = "0.0023";
            fila42[6] = "0.0026";
            fila42[7] = "0.0028";
            fila42[8] = "0.0031";
            fila42[9] = "0.0034";
            fila42[10] = "0.0037";
            d1.Rows.Add(fila42);

            DataRow fila43 = d1.NewRow();
            fila43[0] = "20";
            fila43[1] = "0.0007";
            fila43[2] = "0.0008";
            fila43[3] = "0.0009";
            fila43[4] = "0.0010";
            fila43[5] = "0.0011";
            fila43[6] = "0.0012";
            fila43[7] = "0.0014";
            fila43[8] = "0.0015";
            fila43[9] = "0.0017";
            fila41[10] = "0.0019";
            d1.Rows.Add(fila43);

            DataRow fila44 = d1.NewRow();
            fila44[0] = "21";
            fila44[1] = "0.0003";
            fila44[2] = "0.0003";
            fila44[3] = "0.0004";
            fila44[4] = "0.0004";
            fila44[5] = "0.0005";
            fila44[6] = "0.0006";
            fila44[7] = "0.0006";
            fila44[8] = "0.0007";
            fila44[9] = "0.0008";
            fila44[10] = "0.0009";
            d1.Rows.Add(fila44);

            DataRow fila45 = d1.NewRow();
            fila45[0] = "22";
            fila45[1] = "0.0001";
            fila45[2] = "0.0001";
            fila45[3] = "0.0002";
            fila45[4] = "0.0002";
            fila45[5] = "0.0002";
            fila45[6] = "0.0002";
            fila45[7] = "0.0003";
            fila45[8] = "0.0003";
            fila45[9] = "0.0004";
            fila45[10] = "0.0004";
            d1.Rows.Add(fila45);

            DataRow fila46 = d1.NewRow();
            fila46[0] = "23";
            fila46[1] = "0.0000";
            fila46[2] = "0.0001";
            fila46[3] = "0.0001";
            fila46[4] = "0.0001";
            fila46[5] = "0.0001";
            fila46[6] = "0.0001";
            fila46[7] = "0.0001";
            fila46[8] = "0.0001";
            fila46[9] = "0.0002";
            fila46[10] = "0.0002";
            d1.Rows.Add(fila46);

            DataRow fila47 = d1.NewRow();
            fila47[0] = "24";
            fila47[1] = "0.0000";
            fila47[2] = "0.0000";
            fila47[3] = "0.0000";
            fila47[4] = "0.0000";
            fila47[5] = "0.0000";
            fila47[6] = "0.0000";
            fila47[7] = "0.0000";
            fila47[8] = "0.0001";
            fila47[9] = "0.0001";
            fila47[10] = "0.0001";
            d1.Rows.Add(fila47);

            dgv_t4b10.DataSource = d1;
        }
        public void CargarTabla11()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("X");
            dt.Columns.Add("11");
            dt.Columns.Add("12");
            dt.Columns.Add("13");
            dt.Columns.Add("14");
            dt.Columns.Add("15");
            dt.Columns.Add("16");
            dt.Columns.Add("17");
            dt.Columns.Add("18");
            dt.Columns.Add("19");
            dt.Columns.Add("20");

            DataRow fila1 = dt.NewRow();
            fila1[0] = "0";
            fila1[1] = "0.0000";
            fila1[2] = "0.0000";
            fila1[3] = "0.0000";
            fila1[4] = "0.0000";
            fila1[5] = "0.0000";
            fila1[6] = "0.0000";
            fila1[7] = "0.0000";
            fila1[8] = "0.0000";
            fila1[9] = "0.0000";
            fila1[10] = "0.0000";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "1";
            fila2[1] = "0.0002";
            fila2[2] = "0.0001";
            fila2[3] = "0.0000";
            fila2[4] = "0.0000";
            fila2[5] = "0.0000";
            fila2[6] = "0.0000";
            fila2[7] = "0.0000";
            fila2[8] = "0.0000";
            fila2[9] = "0.0000";
            fila2[10] = "0.0000";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "2";
            fila3[1] = "0.0010";
            fila3[2] = "0.0004";
            fila3[3] = "0.0002";
            fila3[4] = "0.0001";
            fila3[5] = "0.0000";
            fila3[6] = "0.0000";
            fila3[7] = "0.0000";
            fila3[8] = "0.0000";
            fila3[9] = "0.0000";
            fila3[10] = "0.0000";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "3";
            fila4[1] = "0.0037";
            fila4[2] = "0.0018";
            fila4[3] = "0.0008";
            fila4[4] = "0.0004";
            fila4[5] = "0.0002";
            fila4[6] = "0.0001";
            fila4[7] = "0.0000";
            fila4[8] = "0.0000";
            fila4[9] = "0.0000";
            fila4[10] = "0.0000";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "4";
            fila5[1] = "0.0102";
            fila5[2] = "0.0053";
            fila5[3] = "0.0027";
            fila5[4] = "0.0013";
            fila5[5] = "0.0006";
            fila5[6] = "0.0003";
            fila5[7] = "0.0001";
            fila5[8] = "0.0001";
            fila5[9] = "0.0000";
            fila5[10] = "0.0000";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "5";
            fila6[1] = "0.0224";
            fila6[2] = "0.0127";
            fila6[3] = "0.0070";
            fila6[4] = "0.0037";
            fila6[5] = "0.0019";
            fila6[6] = "0.0010";
            fila6[7] = "0.0005";
            fila6[8] = "0.0002";
            fila6[9] = "0.0001";
            fila6[10] = "0.0001";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "6";
            fila7[1] = "0.0411";
            fila7[2] = "0.0255";
            fila7[3] = "0.0152";
            fila7[4] = "0.0087";
            fila7[5] = "0.0048";
            fila7[6] = "0.0026";
            fila7[7] = "0.0014";
            fila7[8] = "0.0007";
            fila7[9] = "0.0004";
            fila7[10] = "0.0002";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "7";
            fila8[1] = "0.0646";
            fila8[2] = "0.0437";
            fila8[3] = "0.0281";
            fila8[4] = "0.0174";
            fila8[5] = "0.0104";
            fila8[6] = "0.0060";
            fila8[7] = "0.0034";
            fila8[8] = "0.0018";
            fila8[9] = "0.0010";
            fila8[10] = "0.0005";
            dt.Rows.Add(fila8);

            DataRow fila80 = dt.NewRow();
            fila80[0] = "8";
            fila80[1] = "0.0888";
            fila80[2] = "0.0655";
            fila80[3] = "0.0457";
            fila80[4] = "0.0304";
            fila80[5] = "0.0194";
            fila80[6] = "0.0120";
            fila80[7] = "0.0072";
            fila80[8] = "0.0042";
            fila80[9] = "0.0024";
            fila80[10] = "0.0013";
            dt.Rows.Add(fila80);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "9";
            fila9[1] = "0.1085";
            fila9[2] = "0.0874";
            fila9[3] = "0.0661";
            fila9[4] = "0.0473";
            fila9[5] = "0.0324";
            fila9[6] = "0.0213";
            fila9[7] = "0.0135";
            fila9[8] = "0.0083";
            fila9[9] = "0.0050";
            fila9[10] = "0.0029";
            dt.Rows.Add(fila9);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "10";
            fila10[1] = "0.1194";
            fila10[2] = "0.1048";
            fila10[3] = "0.0859";
            fila10[4] = "0.0663";
            fila10[5] = "0.0486";
            fila10[6] = "0.0341";
            fila10[7] = "0.0230";
            fila10[8] = "0.0150";
            fila10[9] = "0.0095";
            fila10[10] = "0.0058";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "11";
            fila11[1] = "0.1194";
            fila11[2] = "0.1144";
            fila11[3] = "0.1015";
            fila11[4] = "0.0844";
            fila11[5] = "0.0663";
            fila11[6] = "0.0496";
            fila11[7] = "0.0355";
            fila11[8] = "0.0245";
            fila11[9] = "0.0164";
            fila11[10] = "0.0106";
            dt.Rows.Add(fila11);


            DataRow fila12 = dt.NewRow();
            fila12[0] = "12";
            fila12[1] = "0.1094";
            fila12[2] = "0.1144";
            fila12[3] = "0.1099";
            fila12[4] = "0.0984";
            fila12[5] = "0.0829";
            fila12[6] = "0.0661";
            fila12[7] = "0.0504";
            fila12[8] = "0.0368";
            fila12[9] = "0.0259";
            fila12[10] = "0.0176";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "13";
            fila13[1] = "0.0926";
            fila13[2] = "0.1056";
            fila13[3] = "0.1099";
            fila13[4] = "0.1060";
            fila13[5] = "0.0956";
            fila13[6] = "0.0814";
            fila13[7] = "0.0658";
            fila13[8] = "0.0509";
            fila13[9] = "0.0378";
            fila13[10] = "0.0271";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "14";
            fila14[1] = "0.0728";
            fila14[2] = "0.0905";
            fila14[3] = "0.1021";
            fila14[4] = "0.1060";
            fila14[5] = "0.1024";
            fila14[6] = "0.0930";
            fila14[7] = "0.0800";
            fila14[8] = "0.0655";
            fila14[9] = "0.0514";
            fila14[10] = "0.0387";
            dt.Rows.Add(fila14);


            DataRow fila15 = dt.NewRow();
            fila15[0] = "15";
            fila15[1] = "0.0534";
            fila15[2] = "0.0724";
            fila15[3] = "0.0885";
            fila15[4] = "0.0989";
            fila15[5] = "0.1024";
            fila15[6] = "0.0992";
            fila15[7] = "0.0906";
            fila15[8] = "0.0786";
            fila15[9] = "0.0650";
            fila15[10] = "0.0516";
            dt.Rows.Add(fila15);

            DataRow fila16 = dt.NewRow();
            fila16[0] = "16";
            fila16[1] = "0.0367";
            fila16[2] = "0.0543";
            fila16[3] = "0.0719";
            fila16[4] = "0.0866";
            fila16[5] = "0.0960";
            fila16[6] = "0.0992";
            fila16[7] = "0.0963";
            fila16[8] = "0.0884";
            fila16[9] = "0.0772";
            fila16[10] = "0.0646";
            dt.Rows.Add(fila16);

            DataRow fila17 = dt.NewRow();
            fila17[0] = "17";
            fila17[1] = "0.0237";
            fila17[2] = "0.0383";
            fila17[3] = "0.0550";
            fila17[4] = "0.0713";
            fila17[5] = "0.0847";
            fila17[6] = "0.0934";
            fila17[7] = "0.0963";
            fila17[8] = "0.0936";
            fila17[9] = "0.0863";
            fila17[10] = "0.0760";
            dt.Rows.Add(fila17);

            DataRow fila18 = dt.NewRow();
            fila18[0] = "18";
            fila18[1] = "0.0145";
            fila18[2] = "0.0256";
            fila18[3] = "0.0397";
            fila18[4] = "0.0554";
            fila18[5] = "0.0706";
            fila18[6] = "0.0830";
            fila18[7] = "0.0909";
            fila18[8] = "0.0936";
            fila18[9] = "0.0911";
            fila18[10] = "0.0844";
            dt.Rows.Add(fila18);

            DataRow fila19 = dt.NewRow();
            fila19[0] = "19";
            fila19[1] = "0.0084";
            fila19[2] = "0.0161";
            fila19[3] = "0.0272";
            fila19[4] = "0.0409";
            fila19[5] = "0.0557";
            fila19[6] = "0.0699";
            fila19[7] = "0.0814";
            fila19[8] = "0.0887";
            fila19[9] = "0.0911";
            fila19[10] = "0.0888";
            dt.Rows.Add(fila19);

            DataRow fila20 = dt.NewRow();
            fila20[0] = "20";
            fila20[1] = "0.0046";
            fila20[2] = "0.0097";
            fila20[3] = "0.0177";
            fila20[4] = "0.0286";
            fila20[5] = "0.0418";
            fila20[6] = "0.0559";
            fila20[7] = "0.0692";
            fila20[8] = "0.0798";
            fila20[9] = "0.0866";
            fila20[10] = "0.0888";
            dt.Rows.Add(fila20);

            DataRow fila21 = dt.NewRow();
            fila21[0] = "21";
            fila21[1] = "0.0024";
            fila21[2] = "0.0055";
            fila21[3] = "0.0109";
            fila21[4] = "0.0191";
            fila21[5] = "0.0299";
            fila21[6] = "0.0426";
            fila21[7] = "0.0560";
            fila21[8] = "0.0684";
            fila21[9] = "0.0783";
            fila21[10] = "0.0846";
            dt.Rows.Add(fila21);

            DataRow fila22 = dt.NewRow();
            fila22[0] = "22";
            fila22[1] = "0.0012";
            fila22[2] = "0.0030";
            fila22[3] = "0.0065";
            fila22[4] = "0.0121";
            fila22[5] = "0.0204";
            fila22[6] = "0.0310";
            fila22[7] = "0.0433";
            fila22[8] = "0.0560";
            fila22[9] = "0.0676";
            fila22[10] = "0.0769";
            dt.Rows.Add(fila22);

            DataRow fila24 = dt.NewRow();
            fila24[0] = "23";
            fila24[1] = "0.0006";
            fila24[2] = "0.0016";
            fila24[3] = "0.0037";
            fila24[4] = "0.0074";
            fila24[5] = "0.0133";
            fila24[6] = "0.0216";
            fila24[7] = "0.0320";
            fila24[8] = "0.0438";
            fila24[9] = "0.0559";
            fila24[10] = "0.0669";
            dt.Rows.Add(fila24);

            DataRow fila25 = dt.NewRow();
            fila25[0] = "24";
            fila25[1] = "0.0003";
            fila25[2] = "0.0008";
            fila25[3] = "0.0020";
            fila25[4] = "0.0043";
            fila25[5] = "0.0083";
            fila25[6] = "0.0144";
            fila25[7] = "0.0226";
            fila25[8] = "0.0328";
            fila25[9] = "0.0442";
            fila25[10] = "0.0557";
            dt.Rows.Add(fila25);

            DataRow fila26 = dt.NewRow();
            fila26[0] = "25";
            fila26[1] = "0.0001";
            fila26[2] = "0.0004";
            fila26[3] = "0.0010";
            fila26[4] = "0.0024";
            fila26[5] = "0.0050";
            fila26[6] = "0.0092";
            fila26[7] = "0.0154";
            fila26[8] = "0.0237";
            fila26[9] = "0.0336";
            fila26[10] = "0.0446";
            dt.Rows.Add(fila26);

            DataRow fila27 = dt.NewRow();
            fila27[0] = "26";
            fila27[1] = "0.0000";
            fila27[2] = "0.0002";
            fila27[3] = "0.0005";
            fila27[4] = "0.0013";
            fila27[5] = "0.0029";
            fila27[6] = "0.0057";
            fila27[7] = "0.0101";
            fila27[8] = "0.0164";
            fila27[9] = "0.0246";
            fila27[10] = "0.0343";
            dt.Rows.Add(fila27);

            DataRow fila28 = dt.NewRow();
            fila28[0] = "27";
            fila28[1] = "0.0000";
            fila28[2] = "0.0001";
            fila28[3] = "0.0002";
            fila28[4] = "0.0007";
            fila28[5] = "0.0016";
            fila28[6] = "0.0034";
            fila28[7] = "0.0063";
            fila28[8] = "0.0109";
            fila28[9] = "0.0163";
            fila28[10] = "0.0254";
            dt.Rows.Add(fila28);

            DataRow fila29 = dt.NewRow();
            fila29[0] = "28";
            fila29[1] = "0.0000";
            fila29[2] = "0.0000";
            fila29[3] = "0.0001";
            fila29[4] = "0.0003";
            fila29[5] = "0.0009";
            fila29[6] = "0.0019";
            fila29[7] = "0.0038";
            fila29[8] = "0.0070";
            fila29[9] = "0.0117";
            fila29[10] = "0.0181";
            dt.Rows.Add(fila29);

            DataRow fila30 = dt.NewRow();
            fila30[0] = "29";
            fila30[1] = "0.0000";
            fila30[2] = "0.0000";
            fila30[3] = "0.0001";
            fila30[4] = "0.0002";
            fila30[5] = "0.0004";
            fila30[6] = "0.0011";
            fila30[7] = "0.0023";
            fila30[8] = "0.0044";
            fila30[9] = "0.0077";
            fila30[10] = "0.0125";
            dt.Rows.Add(fila30);

            DataRow fila31 = dt.NewRow();
            fila31[0] = "30";
            fila31[1] = "0.0000";
            fila31[2] = "0.0000";
            fila31[3] = "0.0000";
            fila31[4] = "0.0001";
            fila31[5] = "0.0002";
            fila31[6] = "0.0006";
            fila31[7] = "0.0013";
            fila31[8] = "0.0026";
            fila31[9] = "0.0049";
            fila31[10] = "0.0083";
            dt.Rows.Add(fila31);

            DataRow fila32 = dt.NewRow();
            fila32[0] = "31";
            fila32[1] = "0.0000";
            fila32[2] = "0.0000";
            fila32[3] = "0.0000";
            fila32[4] = "0.0000";
            fila32[5] = "0.0001";
            fila32[6] = "0.0003";
            fila32[7] = "0.0007";
            fila32[8] = "0.0015";
            fila32[9] = "0.0030";
            fila32[10] = "0.0054";
            dt.Rows.Add(fila32);

            DataRow fila320 = dt.NewRow();
            fila320[0] = "32";
            fila320[1] = "0.0000";
            fila320[2] = "0.0000";
            fila320[3] = "0.0000";
            fila320[4] = "0.0000";
            fila320[5] = "0.0001";
            fila320[6] = "0.0001";
            fila320[7] = "0.004";
            fila320[8] = "0.0009";
            fila320[9] = "0.0018";
            fila320[10] = "0.0034";
            dt.Rows.Add(fila320);

            DataRow fila33 = dt.NewRow();
            fila33[0] = "33";
            fila33[1] = "0.0000";
            fila33[2] = "0.0000";
            fila33[3] = "0.0000";
            fila33[4] = "0.0000";
            fila33[5] = "0.0000";
            fila33[6] = "0.0001";
            fila33[7] = "0.0002";
            fila33[8] = "0.0005";
            fila33[9] = "0.0010";
            fila33[10] = "0.0020";
            dt.Rows.Add(fila33);

            DataRow fila34 = dt.NewRow();
            fila34[0] = "34";
            fila34[1] = "0.0000";
            fila34[2] = "0.0000";
            fila34[3] = "0.0000";
            fila34[4] = "0.0000";
            fila34[5] = "0.0000";
            fila34[6] = "0.0000";
            fila34[7] = "0.0001";
            fila34[8] = "0.0002";
            fila34[9] = "0.0006";
            fila34[10] = "0.0012";
            dt.Rows.Add(fila34);

            DataRow fila35 = dt.NewRow();
            fila35[0] = "35";
            fila35[1] = "0.0000";
            fila35[2] = "0.0000";
            fila35[3] = "0.0000";
            fila35[4] = "0.0000";
            fila35[5] = "0.0000";
            fila35[6] = "0.0000";
            fila35[7] = "0.0000";
            fila35[8] = "0.0001";
            fila35[9] = "0.0003";
            fila35[10] = "0.0007";
            dt.Rows.Add(fila35);

            DataRow fila36 = dt.NewRow();
            fila36[0] = "36";
            fila36[1] = "0.0000";
            fila36[2] = "0.0000";
            fila36[3] = "0.0000";
            fila36[4] = "0.0000";
            fila36[5] = "0.0000";
            fila36[6] = "0.0000";
            fila36[7] = "0.0000";
            fila36[8] = "0.0001";
            fila36[9] = "0.0002";
            fila36[10] = "0.0004";
            dt.Rows.Add(fila36);

            DataRow fila37 = dt.NewRow();
            fila37[0] = "37";
            fila37[1] = "0.0000";
            fila37[2] = "0.0000";
            fila37[3] = "0.0000";
            fila37[4] = "0.0000";
            fila37[5] = "0.0000";
            fila37[6] = "0.0000";
            fila37[7] = "0.0000";
            fila37[8] = "0.0000";
            fila37[9] = "0.0001";
            fila37[10] = "0.0002";
            dt.Rows.Add(fila37);

            DataRow fila38 = dt.NewRow();
            fila38[0] = "38";
            fila38[1] = "0.0000";
            fila38[2] = "0.0000";
            fila38[3] = "0.0000";
            fila38[4] = "0.0000";
            fila38[5] = "0.0000";
            fila38[6] = "0.0000";
            fila38[7] = "0.0000";
            fila38[8] = "0.0000";
            fila38[9] = "0.0000";
            fila38[10] = "0.0001";
            dt.Rows.Add(fila38);

            DataRow fila39 = dt.NewRow();
            fila39[0] = "39";
            fila39[1] = "0.0000";
            fila39[2] = "0.0000";
            fila39[3] = "0.0000";
            fila39[4] = "0.0000";
            fila39[5] = "0.0000";
            fila39[6] = "0.0000";
            fila39[7] = "0.0000";
            fila39[8] = "0.0000";
            fila39[9] = "0.0000";
            fila39[10] = "0.0001";
            dt.Rows.Add(fila39);


            dgv_t4b11.DataSource = dt;



        }
    }
}
