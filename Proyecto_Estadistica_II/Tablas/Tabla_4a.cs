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
    public partial class Tabla_4a : Form
    {
        public Tabla_4a()
        {
            InitializeComponent();
        }

        private void Tabla_4a_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("λ");
            dt.Columns.Add("e - ^λ");
            dt.Columns.Add("λ ");
            dt.Columns.Add("e - ^λ ");
            dt.Columns.Add(" λ ");
            dt.Columns.Add(" e - ^λ ");
            dt.Columns.Add(" λ");
            dt.Columns.Add(" e - ^λ");


            DataRow fila1 = dt.NewRow();
            fila1[0] = "0.1";
            fila1[1] = "0.90484";
            fila1[2] = "2.6";
            fila1[3] = "0.07427";
            fila1[4] = "5.1";
            fila1[5] = "0.00610";
            fila1[6] = "7.6";
            fila1[7] = "0.00050";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "0.2";
            fila2[1] = "0.85873";
            fila2[2] = "2.7";
            fila2[3] = "0.06721";
            fila2[4] = "5.2";
            fila2[5] = "0.00552";
            fila2[6] = "7.7";
            fila2[7] = "0.00045";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "0.3";
            fila3[1] = "0.74082";
            fila3[2] = "2.8";
            fila3[3] = "0.06081";
            fila3[4] = "5.3";
            fila3[5] = "0.00499";
            fila3[6] = "7.8";
            fila3[7] = "0.00041";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "0.4";
            fila4[1] = "0.67032";
            fila4[2] = "2.9";
            fila4[3] = "0.05502";
            fila4[4] = "5.4";
            fila4[5] = "0.00452";
            fila4[6] = "7.9";
            fila4[7] = "0.0037";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "0.5";
            fila5[1] = "0.60653";
            fila5[2] = "3.0";
            fila5[3] = "0.04979";
            fila5[4] = "5.5";
            fila5[5] = "0.00409";
            fila5[6] = "8.0";
            fila5[7] = "0.00034";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "0.6";
            fila6[1] = "0.54811";
            fila6[2] = "3.1";
            fila6[3] = "0.04505";
            fila6[4] = "5.6";
            fila6[5] = "0.00370";
            fila6[6] = "8.1";
            fila6[7] = "0.00030";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "0.7";
            fila7[1] = "0.49659";
            fila7[2] = "3.2";
            fila7[3] = "0.04076";
            fila7[4] = "5.7";
            fila7[5] = "0.00335";
            fila7[6] = "8.2";
            fila7[7] = "0.00027";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "0.8";
            fila8[1] = "0.44933";
            fila8[2] = "3.3";
            fila8[3] = "0.03688";
            fila8[4] = "5.8";
            fila8[5] = "0.00303";
            fila8[6] = "8.3";
            fila8[7] = "0.00025";
            dt.Rows.Add(fila8);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "0.9";
            fila9[1] = "0.40657";
            fila9[2] = "3.4";
            fila9[3] = "0.07337";
            fila9[4] = "5.9";
            fila9[5] = "0.00274";
            fila9[6] = "8.4";
            fila9[7] = "0.00022";
            dt.Rows.Add(fila9);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "1.0";
            fila10[1] = "0.36788";
            fila10[2] = "3.5";
            fila10[3] = "0.03020";
            fila10[4] = "6.0";
            fila10[5] = "0.00248";
            fila10[6] = "8.5";
            fila10[7] = "0.00020";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "1.1";
            fila11[1] = "0.33287";
            fila11[2] = "3.6";
            fila11[3] = "0.02732";
            fila11[4] = "6.1";
            fila11[5] = "0.00224";
            fila11[6] = "8.6";
            fila11[7] = "0.00018";
            dt.Rows.Add(fila11);

            DataRow fila12 = dt.NewRow();
            fila12[0] = "1.2";
            fila12[1] = "0.30119";
            fila12[2] = "3.7";
            fila12[3] = "0.02472";
            fila12[4] = "6.2";
            fila12[5] = "0.0023";
            fila12[6] = "8.7";
            fila12[7] = "0.00017";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "1.3";
            fila13[1] = "0.27253";
            fila13[2] = "3.8";
            fila13[3] = "0.02267";
            fila13[4] = "6.3";
            fila13[5] = "0.00184";
            fila13[6] = "8.4";
            fila13[7] = "0.00015";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "1.4";
            fila14[1] = "0.24660";
            fila14[2] = "3.9";
            fila14[3] = "0.02024";
            fila14[4] = "6.4";
            fila14[5] = "0.00166";
            fila14[6] = "8.9";
            fila14[7] = "0.00014";
            dt.Rows.Add(fila14);

            DataRow fila15 = dt.NewRow();
            fila15[0] = "1.5";
            fila15[1] = "0.23313";
            fila15[2] = "4.0";
            fila15[3] = "0.01832";
            fila15[4] = "6.5";
            fila15[5] = "0.00150";
            fila15[6] = "9.0";
            fila15[7] = "0.00012";
            dt.Rows.Add(fila15);

            DataRow fila16 = dt.NewRow();
            fila16[0] = "1.6";
            fila16[1] = "0.20190";
            fila16[2] = "4.1";
            fila16[3] = "0.01657";
            fila16[4] = "6.6";
            fila16[5] = "0.00136";
            fila16[6] = "9.1";
            fila16[7] = "0.00011";
            dt.Rows.Add(fila16);

            DataRow fila17 = dt.NewRow();
            fila17[0] = "1.7";
            fila17[1] = "0.18268";
            fila17[2] = "4.2";
            fila17[3] = "0.01500";
            fila17[4] = "6.7";
            fila17[5] = "0.00123";
            fila17[6] = "9.2";
            fila17[7] = "0.00010";
            dt.Rows.Add(fila17);

            DataRow fila18 = dt.NewRow();
            fila18[0] = "1.8";
            fila18[1] = "0.16530";
            fila18[2] = "4.3";
            fila18[3] = "0.01357";
            fila18[4] = "6.8";
            fila18[5] = "0.00111";
            fila18[6] = "9.3";
            fila18[7] = "0.00009";
            dt.Rows.Add(fila18);

            DataRow fila19 = dt.NewRow();
            fila19[0] = "1.9";
            fila19[1] = "0.14957";
            fila19[2] = "4.4";
            fila19[3] = "0.01228";
            fila19[4] = "6.9";
            fila19[5] = "0.00101";
            fila19[6] = "9.4";
            fila19[7] = "0.00008";
            dt.Rows.Add(fila19);

            DataRow fila20 = dt.NewRow();
            fila20[0] = "2.0";
            fila20[1] = "0.13534";
            fila20[2] = "4.5";
            fila20[3] = "0.01111";
            fila20[4] = "7.0";
            fila20[5] = "0.00091";
            fila20[6] = "9.5";
            fila20[7] = "0.00007";
            dt.Rows.Add(fila20);

            DataRow fila21 = dt.NewRow();
            fila21[0] = "2.1";
            fila21[1] = "0.12246";
            fila21[2] = "0.4.6";
            fila21[3] = "0.01005";
            fila21[4] = "7.1";
            fila21[5] = "0.00083";
            fila21[6] = "9.6";
            fila21[7] = "0.00007";
            dt.Rows.Add(fila21);

            DataRow fila22 = dt.NewRow();
            fila22[0] = "2.2";
            fila22[1] = "0.11080";
            fila22[2] = "4.7";
            fila22[3] = "0.00910";
            fila22[4] = "7.2";
            fila22[5] = "0.00075";
            fila22[6] = "9.7";
            fila22[7] = "0.00006";
            dt.Rows.Add(fila22);

            DataRow fila23 = dt.NewRow();
            fila23[0] = "2.3";
            fila23[1] = "0.10026";
            fila23[2] = "4.8";
            fila23[3] = "0.00823";
            fila23[4] = "7.3";
            fila23[5] = "0.00068";
            fila23[6] = "9.8";
            fila23[7] = "0.00006";
            dt.Rows.Add(fila23);

            DataRow fila24 = dt.NewRow();
            fila24[0] = "2.4";
            fila24[1] = "0.09072";
            fila24[2] = "4.9";
            fila24[3] = "0.00745";
            fila24[4] = "7.4";
            fila24[5] = "0.00061";
            fila24[6] = "9.9";
            fila24[7] = "0.00005";
            dt.Rows.Add(fila24);

            DataRow fila25 = dt.NewRow();
            fila25[0] = "2.5";
            fila25[1] = "0.08208";
            fila25[2] = "5.0";
            fila25[3] = "0.00674";
            fila25[4] = "7.5";
            fila25[5] = "0.00055";
            fila25[6] = "10.0";
            fila25[7] = "0.00005";
            dt.Rows.Add(fila25);


            dgv_t4a.DataSource = dt;

        }
    }
}
