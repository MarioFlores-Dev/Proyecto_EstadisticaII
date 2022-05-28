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
    public partial class TablaT : Form
    {
        public TablaT()
        {
            InitializeComponent();
        }

        private void TablaT_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            //Creacion de tabla virtual
            DataTable dt = new DataTable();
            //Creacion de encabezados
            dt.Columns.Add("Grados de libertad");
            dt.Columns.Add("0.10");
            dt.Columns.Add("0.05");
            dt.Columns.Add("0.02");
            dt.Columns.Add("0.01");

            DataRow fila1 = dt.NewRow();
            fila1[0] = "1";
            fila1[1] = "6.314";
            fila1[2] = "12.706";
            fila1[3] = "31.821";
            fila1[4] = "63.657";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "2";
            fila2[1] = "2.920";
            fila2[2] = "4.303";
            fila2[3] = "6.965";
            fila2[4] = "9.925";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "3";
            fila3[1] = "2.353";
            fila3[2] = "3.182";
            fila3[3] = "4.541";
            fila3[4] = "5.841";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "4";
            fila4[1] = "2.132";
            fila4[2] = "2.776";
            fila4[3] = "3.747";
            fila4[4] = "4.604";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "5";
            fila5[1] = "2.015";
            fila5[2] = "2.571";
            fila5[3] = "3.365";
            fila5[4] = "4.032";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "6";
            fila6[1] = "1.943";
            fila6[2] = "2.447";
            fila6[3] = "3.143";
            fila6[4] = "3.707";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "7";
            fila7[1] = "1.895";
            fila7[2] = "2.365";
            fila7[3] = "2.998";
            fila7[4] = "3.499";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "8";
            fila8[1] = "1.860";
            fila8[2] = "2.306";
            fila8[3] = "2.896";
            fila8[4] = "3.355";
            dt.Rows.Add(fila8);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "9";
            fila9[1] = "1.833";
            fila9[2] = "2.262";
            fila9[3] = "2.821";
            fila9[4] = "3.250";
            dt.Rows.Add(fila9);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "10";
            fila10[1] = "1.812";
            fila10[2] = "2.228";
            fila10[3] = "2.764";
            fila10[4] = "3.169";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "11";
            fila11[1] = "1.796";
            fila11[2] = "2.201";
            fila11[3] = "2.718";
            fila11[4] = "3.106";
            dt.Rows.Add(fila11);

            DataRow fila12 = dt.NewRow();
            fila12[0] = "12";
            fila12[1] = "1.782";
            fila12[2] = "2.179";
            fila12[3] = "2.681";
            fila12[4] = "3.055";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "13";
            fila13[1] = "1.771";
            fila13[2] = "2.160";
            fila13[3] = "2.650";
            fila13[4] = "3.012";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "14";
            fila14[1] = "1.761";
            fila14[2] = "2.145";
            fila14[3] = "2.624";
            fila14[4] = "2.977";
            dt.Rows.Add(fila14);

            DataRow fila15 = dt.NewRow();
            fila15[0] = "15";
            fila15[1] = "1.753";
            fila15[2] = "2.131";
            fila15[3] = "2.602";
            fila15[4] = "2.947";
            dt.Rows.Add(fila15);

            DataRow fila16 = dt.NewRow();
            fila16[0] = "16";
            fila16[1] = "1.746";
            fila16[2] = "2.120";
            fila16[3] = "2.583";
            fila16[4] = "2.921";
            dt.Rows.Add(fila16);

            DataRow fila17 = dt.NewRow();
            fila17[0] = "17";
            fila17[1] = "1.740";
            fila17[2] = "2.110";
            fila17[3] = "2.567";
            fila17[4] = "2.898";
            dt.Rows.Add(fila17);

            DataRow fila18 = dt.NewRow();
            fila18[0] = "18";
            fila18[1] = "1.734";
            fila18[2] = "2.101";
            fila18[3] = "2.552";
            fila18[4] = "2.878";
            dt.Rows.Add(fila18);

            DataRow fila19 = dt.NewRow();
            fila19[0] = "19";
            fila19[1] = "1.729";
            fila19[2] = "2.093";
            fila19[3] = "2.539";
            fila19[4] = "2.861";
            dt.Rows.Add(fila19);

            DataRow fila20 = dt.NewRow();
            fila20[0] = "20";
            fila20[1] = "1.725";
            fila20[2] = "2.086";
            fila20[3] = "2.528";
            fila20[4] = "2.845";
            dt.Rows.Add(fila20);

            DataRow fila21 = dt.NewRow();
            fila21[0] = "21";
            fila21[1] = "1.721";
            fila21[2] = "2.080";
            fila21[3] = "2.518";
            fila21[4] = "2.831";
            dt.Rows.Add(fila21);

            DataRow fila22 = dt.NewRow();
            fila22[0] = "22";
            fila22[1] = "1.717";
            fila22[2] = "2.074";
            fila22[3] = "2.508";
            fila22[4] = "2.819";
            dt.Rows.Add(fila22);

            DataRow fila23 = dt.NewRow();
            fila23[0] = "23";
            fila23[1] = "1.714";
            fila23[2] = "2.069";
            fila23[3] = "2.500";
            fila23[4] = "2.807";
            dt.Rows.Add(fila23);

            DataRow fila24 = dt.NewRow();
            fila24[0] = "24";
            fila24[1] = "1.711";
            fila24[2] = "2.064";
            fila24[3] = "2.492";
            fila24[4] = "2.797";
            dt.Rows.Add(fila24);

            DataRow fila25 = dt.NewRow();
            fila25[0] = "25";
            fila25[1] = "1.708";
            fila25[2] = "2.060";
            fila25[3] = "2.485";
            fila25[4] = "2.787";
            dt.Rows.Add(fila25);

            DataRow fila26 = dt.NewRow();
            fila26[0] = "26";
            fila26[1] = "1.706";
            fila26[2] = "2.056";
            fila26[3] = "2.479";
            fila26[4] = "2.779";
            dt.Rows.Add(fila26);

            DataRow fila27 = dt.NewRow();
            fila27[0] = "27";
            fila27[1] = "1.703";
            fila27[2] = "2.052";
            fila27[3] = "2.473";
            fila27[4] = "2.771";
            dt.Rows.Add(fila27);

            DataRow fila28 = dt.NewRow();
            fila28[0] = "28";
            fila28[1] = "1.701";
            fila28[2] = "2.048";
            fila28[3] = "2.467";
            fila28[4] = "2.763";
            dt.Rows.Add(fila28);

            DataRow fila29 = dt.NewRow();
            fila29[0] = "29";
            fila29[1] = "1.699";
            fila29[2] = "2.045";
            fila29[3] = "2.462";
            fila29[4] = "2.756";
            dt.Rows.Add(fila29);

            DataRow fila30 = dt.NewRow();
            fila30[0] = "30";
            fila30[1] = "1.697";
            fila30[2] = "2.042";
            fila30[3] = "2.457";
            fila30[4] = "2.750";
            dt.Rows.Add(fila30);

            DataRow fila31 = dt.NewRow();
            fila31[0] = "40";
            fila31[1] = "1.684";
            fila31[2] = "2.021";
            fila31[3] = "2.423";
            fila31[4] = "2.704";
            dt.Rows.Add(fila31);

            DataRow fila32 = dt.NewRow();
            fila32[0] = "60";
            fila32[1] = "1.671";
            fila32[2] = "2.000";
            fila32[3] = "2.390";
            fila32[4] = "2.660";
            dt.Rows.Add(fila32);

            DataRow fila33 = dt.NewRow();
            fila33[0] = "120";
            fila33[1] = "1.658";
            fila33[2] = "1.980";
            fila33[3] = "2.358";
            fila33[4] = "2.617";
            dt.Rows.Add(fila33);

            DataRow fila34 = dt.NewRow();
            fila34[0] = "Distribución normal";
            fila34[1] = "1.645";
            fila34[2] = "1.960";
            fila34[3] = "2.326";
            fila34[4] = "2.576";
            dt.Rows.Add(fila34);

            // Carga de datos
            dgv_tablaT.DataSource = dt;
        }
    }
}
