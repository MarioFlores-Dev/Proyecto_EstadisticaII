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
    public partial class TablaZ : Form
    {
        public TablaZ()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaZ_Load(object sender, EventArgs e)
        {
            LlenadoTabla();
        }
        private void LlenadoTabla()
        {
            //Creacion de tabla virtual
            DataTable dt = new DataTable();
            //Creacion de encabezados
            dt.Columns.Add("Z");
            dt.Columns.Add("0.00");
            dt.Columns.Add("0.01");
            dt.Columns.Add("0.02");
            dt.Columns.Add("0.03");
            dt.Columns.Add("0.04");
            dt.Columns.Add("0.05");
            dt.Columns.Add("0.06");
            dt.Columns.Add("0.07");
            dt.Columns.Add("0.08");
            dt.Columns.Add("0.09");
            //Creacion de filas
            DataRow fila0 = dt.NewRow();
            fila0[0] = "0.0";
            fila0[1] = "0.0000";
            fila0[2] = "0.0040";
            fila0[3] = "0.0080";
            fila0[4] = "0.0120";
            fila0[5] = "0.0160";
            fila0[6] = "0.0199";
            fila0[7] = "0.0239";
            fila0[8] = "0.0279";
            fila0[9] = "0.0319";
            fila0[10] = "0.0359";
            dt.Rows.Add(fila0);

            DataRow fila1 = dt.NewRow();
            fila1[0] = "0.1";
            fila1[1] = "0.0398";
            fila1[2] = "0.0438";
            fila1[3] = "0.0478";
            fila1[4] = "0.0517";
            fila1[5] = "0.0557";
            fila1[6] = "0.0596";
            fila1[7] = "0.0636";
            fila1[8] = "0.0675";
            fila1[9] = "0.0714";
            fila1[10] = "0.0753";
            dt.Rows.Add(fila1);

            DataRow fila2 = dt.NewRow();
            fila2[0] = "0.2";
            fila2[1] = "0.0793";
            fila2[2] = "0.0832";
            fila2[3] = "0.0871";
            fila2[4] = "0.0910";
            fila2[5] = "0.0948";
            fila2[6] = "0.0987";
            fila2[7] = "0.1026";
            fila2[8] = "0.1064";
            fila2[9] = "0.1103";
            fila2[10] = "0.1141";
            dt.Rows.Add(fila2);

            DataRow fila3 = dt.NewRow();
            fila3[0] = "0.3";
            fila3[1] = "0.1179";
            fila3[2] = "0.1217";
            fila3[3] = "0.1255";
            fila3[4] = "0.1293";
            fila3[5] = "0.1331";
            fila3[6] = "0.1368";
            fila3[7] = "0.1406";
            fila3[8] = "0.1443";
            fila3[9] = "0.1480";
            fila3[10] = "0.1517";
            dt.Rows.Add(fila3);

            DataRow fila4 = dt.NewRow();
            fila4[0] = "0.4";
            fila4[1] = "0.1554";
            fila4[2] = "0.1591";
            fila4[3] = "0.1628";
            fila4[4] = "0.1664";
            fila4[5] = "0.1700";
            fila4[6] = "0.1736";
            fila4[7] = "0.1772";
            fila4[8] = "0.1808";
            fila4[9] = "0.1844";
            fila4[10] = "0.1879";
            dt.Rows.Add(fila4);

            DataRow fila5 = dt.NewRow();
            fila5[0] = "0.5";
            fila5[1] = "0.1915";
            fila5[2] = "0.1950";
            fila5[3] = "0.1985";
            fila5[4] = "0.2019";
            fila5[5] = "0.2054";
            fila5[6] = "0.2088";
            fila5[7] = "0.2123";
            fila5[8] = "0.2157";
            fila5[9] = "0.2190";
            fila5[10] = "0.2224";
            dt.Rows.Add(fila5);

            DataRow fila6 = dt.NewRow();
            fila6[0] = "0.6";
            fila6[1] = "0.2257";
            fila6[2] = "0.2291";
            fila6[3] = "0.2324";
            fila6[4] = "0.2357";
            fila6[5] = "0.2389";
            fila6[6] = "0.2422";
            fila6[7] = "0.2454";
            fila6[8] = "0.2486";
            fila6[9] = "0.2517";
            fila6[10] = "0.2549";
            dt.Rows.Add(fila6);

            DataRow fila7 = dt.NewRow();
            fila7[0] = "0.7";
            fila7[1] = "0.2580";
            fila7[2] = "0.2611";
            fila7[3] = "0.2642";
            fila7[4] = "0.2673";
            fila7[5] = "0.2604";
            fila7[6] = "0.2734";
            fila7[7] = "0.2764";
            fila7[8] = "0.2794";
            fila7[9] = "0.2823";
            fila7[10] = "0.2852";
            dt.Rows.Add(fila7);

            DataRow fila8 = dt.NewRow();
            fila8[0] = "0.8";
            fila8[1] = "0.2881";
            fila8[2] = "0.2910";
            fila8[3] = "0.2939";
            fila8[4] = "0.2967";
            fila8[5] = "0.2995";
            fila8[6] = "0.3023";
            fila8[7] = "0.3051";
            fila8[8] = "0.3078";
            fila8[9] = "0.3106";
            fila8[10] = "0.3133";
            dt.Rows.Add(fila8);

            DataRow fila9 = dt.NewRow();
            fila9[0] = "0.9";
            fila9[1] = "0.3159";
            fila9[2] = "0.3186";
            fila9[3] = "0.3212";
            fila9[4] = "0.3238";
            fila9[5] = "0.3264";
            fila9[6] = "0.3289";
            fila9[7] = "0.3315";
            fila9[8] = "0.3340";
            fila9[9] = "0.3365";
            fila9[10] = "0.3389";
            dt.Rows.Add(fila9);

            DataRow fila10 = dt.NewRow();
            fila10[0] = "1.0";
            fila10[1] = "0.3413";
            fila10[2] = "0.3438";
            fila10[3] = "0.3461";
            fila10[4] = "0.3485";
            fila10[5] = "0.3508";
            fila10[6] = "0.3531";
            fila10[7] = "0.3554";
            fila10[8] = "0.3577";
            fila10[9] = "0.3599";
            fila10[10] = "0.3621";
            dt.Rows.Add(fila10);

            DataRow fila11 = dt.NewRow();
            fila11[0] = "1.1";
            fila11[1] = "0.3643";
            fila11[2] = "0.3665";
            fila11[3] = "0.3686";
            fila11[4] = "0.3708";
            fila11[5] = "0.3729";
            fila11[6] = "0.3749";
            fila11[7] = "0.3770";
            fila11[8] = "0.3790";
            fila11[9] = "0.3810";
            fila11[10] = "0.3830";
            dt.Rows.Add(fila11);

            DataRow fila12 = dt.NewRow();
            fila12[0] = "1.2";
            fila12[1] = "0.3849";
            fila12[2] = "0.3869";
            fila12[3] = "0.3888";
            fila12[4] = "0.3907";
            fila12[5] = "0.3925";
            fila12[6] = "0.3944";
            fila12[7] = "0.3962";
            fila12[8] = "0.3980";
            fila12[9] = "0.3997";
            fila12[10] = "0.4015";
            dt.Rows.Add(fila12);

            DataRow fila13 = dt.NewRow();
            fila13[0] = "1.3";
            fila13[1] = "0.4032";
            fila13[2] = "0.4049";
            fila13[3] = "0.4066";
            fila13[4] = "0.4082";
            fila13[5] = "0.4099";
            fila13[6] = "0.4115";
            fila13[7] = "0.4131";
            fila13[8] = "0.4147";
            fila13[9] = "0.4162";
            fila13[10] = "0.4177";
            dt.Rows.Add(fila13);

            DataRow fila14 = dt.NewRow();
            fila14[0] = "1.4";
            fila14[1] = "0.4192";
            fila14[2] = "0.4207";
            fila14[3] = "0.4222";
            fila14[4] = "0.4236";
            fila14[5] = "0.4251";
            fila14[6] = "0.4265";
            fila14[7] = "0.4279";
            fila14[8] = "0.4292";
            fila14[9] = "0.4306";
            fila14[10] = "0.4319";
            dt.Rows.Add(fila14);

            DataRow fila15 = dt.NewRow();
            fila15[0] = "1.5";
            fila15[1] = "0.4332";
            fila15[2] = "0.4345";
            fila15[3] = "0.4357";
            fila15[4] = "0.4370";
            fila15[5] = "0.4382";
            fila15[6] = "0.4394";
            fila15[7] = "0.4406";
            fila15[8] = "0.4418";
            fila15[9] = "0.4429";
            fila15[10] = "0.4441";
            dt.Rows.Add(fila15);

            DataRow fila16 = dt.NewRow();
            fila16[0] = "1.6";
            fila16[1] = "0.4452";
            fila16[2] = "0.4463";
            fila16[3] = "0.4474";
            fila16[4] = "0.4484";
            fila16[5] = "0.4495";
            fila16[6] = "0.4505";
            fila16[7] = "0.4515";
            fila16[8] = "0.4525";
            fila16[9] = "0.4535";
            fila16[10] = "0.4545";
            dt.Rows.Add(fila16);

            DataRow fila17 = dt.NewRow();
            fila17[0] = "1.7";
            fila17[1] = "0.4554";
            fila17[2] = "0.4564";
            fila17[3] = "0.4573";
            fila17[4] = "0.4582";
            fila17[5] = "0.4591";
            fila17[6] = "0.4599";
            fila17[7] = "0.4608";
            fila17[8] = "0.4616";
            fila17[9] = "0.4625";
            fila17[10] = "0.4633";
            dt.Rows.Add(fila17);

            DataRow fila18 = dt.NewRow();
            fila18[0] = "1.8";
            fila18[1] = "0.4641";
            fila18[2] = "0.4649";
            fila18[3] = "0.4656";
            fila18[4] = "0.4664";
            fila18[5] = "0.4671";
            fila18[6] = "0.4678";
            fila18[7] = "0.4686";
            fila18[8] = "0.4693";
            fila18[9] = "0.4699";
            fila18[10] = "0.4706";
            dt.Rows.Add(fila18);

            DataRow fila19 = dt.NewRow();
            fila19[0] = "1.9";
            fila19[1] = "0.4713";
            fila19[2] = "0.4719";
            fila19[3] = "0.4726";
            fila19[4] = "0.4732";
            fila19[5] = "0.4738";
            fila19[6] = "0.4744";
            fila19[7] = "0.4750";
            fila19[8] = "0.4756";
            fila19[9] = "0.4761";
            fila19[10] = "0.4767";
            dt.Rows.Add(fila19);

            DataRow fila20 = dt.NewRow();
            fila20[0] = "2.0";
            fila20[1] = "0.4772";
            fila20[2] = "0.4778";
            fila20[3] = "0.4783";
            fila20[4] = "0.4788";
            fila20[5] = "0.4793";
            fila20[6] = "0.4798";
            fila20[7] = "0.4803";
            fila20[8] = "0.4808";
            fila20[9] = "0.4812";
            fila20[10] = "0.4817";
            dt.Rows.Add(fila20);

            DataRow fila21 = dt.NewRow();
            fila21[0] = "2.1";
            fila21[1] = "0.4821";
            fila21[2] = "0.4826";
            fila21[3] = "0.4830";
            fila21[4] = "0.4834";
            fila21[5] = "0.4838";
            fila21[6] = "0.4842";
            fila21[7] = "0.4846";
            fila21[8] = "0.4850";
            fila21[9] = "0.4854";
            fila21[10] = "0.4857";
            dt.Rows.Add(fila21);

            DataRow fila22 = dt.NewRow();
            fila22[0] = "2.2";
            fila22[1] = "0.4861";
            fila22[2] = "0.4864";
            fila22[3] = "0.4868";
            fila22[4] = "0.4871";
            fila22[5] = "0.4875";
            fila22[6] = "0.4878";
            fila22[7] = "0.4881";
            fila22[8] = "0.4884";
            fila22[9] = "0.4887";
            fila22[10] = "0.4890";
            dt.Rows.Add(fila22);

            DataRow fila23 = dt.NewRow();
            fila23[0] = "2.3";
            fila23[1] = "0.4893";
            fila23[2] = "0.4896";
            fila23[3] = "0.4898";
            fila23[4] = "0.4901";
            fila23[5] = "0.4904";
            fila23[6] = "0.4906";
            fila23[7] = "0.4909";
            fila23[8] = "0.4911";
            fila23[9] = "0.4913";
            fila23[10] = "0.4916";
            dt.Rows.Add(fila23);

            DataRow fila24 = dt.NewRow();
            fila24[0] = "2.4";
            fila24[1] = "0.4918";
            fila24[2] = "0.4920";
            fila24[3] = "0.4922";
            fila24[4] = "0.4925";
            fila24[5] = "0.4927";
            fila24[6] = "0.4929";
            fila24[7] = "0.4931";
            fila24[8] = "0.4932";
            fila24[9] = "0.4934";
            fila24[10] = "0.4936";
            dt.Rows.Add(fila24);

            DataRow fila25 = dt.NewRow();
            fila25[0] = "2.5";
            fila25[1] = "0.4938";
            fila25[2] = "0.4940";
            fila25[3] = "0.4941";
            fila25[4] = "0.4943";
            fila25[5] = "0.4945";
            fila25[6] = "0.4946";
            fila25[7] = "0.4948";
            fila25[8] = "0.4949";
            fila25[9] = "0.4951";
            fila25[10] = "0.4952";
            dt.Rows.Add(fila25);

            DataRow fila26 = dt.NewRow();
            fila26[0] = "2.6";
            fila26[1] = "0.4953";
            fila26[2] = "0.4955";
            fila26[3] = "0.4956";
            fila26[4] = "0.4957";
            fila26[5] = "0.4959";
            fila26[6] = "0.4960";
            fila26[7] = "0.4961";
            fila26[8] = "0.4962";
            fila26[9] = "0.4963";
            fila26[10] = "0.4964";
            dt.Rows.Add(fila26);

            DataRow fila27 = dt.NewRow();
            fila27[0] = "2.7";
            fila27[1] = "0.4965";
            fila27[2] = "0.4966";
            fila27[3] = "0.4967";
            fila27[4] = "0.4968";
            fila27[5] = "0.4969";
            fila27[6] = "0.4970";
            fila27[7] = "0.4971";
            fila27[8] = "0.4972";
            fila27[9] = "0.4973";
            fila27[10] = "0.4974";
            dt.Rows.Add(fila27);

            DataRow fila28 = dt.NewRow();
            fila28[0] = "2.8";
            fila28[1] = "0.4974";
            fila28[2] = "0.4975";
            fila28[3] = "0.4976";
            fila28[4] = "0.4977";
            fila28[5] = "0.4977";
            fila28[6] = "0.4978";
            fila28[7] = "0.4979";
            fila28[8] = "0.4979";
            fila28[9] = "0.4980";
            fila28[10] = "0.4981";
            dt.Rows.Add(fila28);

            DataRow fila29 = dt.NewRow();
            fila29[0] = "2.9";
            fila29[1] = "0.4981";
            fila29[2] = "0.4982";
            fila29[3] = "0.4982";
            fila29[4] = "0.4983";
            fila29[5] = "0.4984";
            fila29[6] = "0.4984";
            fila29[7] = "0.4985";
            fila29[8] = "0.4985";
            fila29[9] = "0.4986";
            fila29[10] = "0.4986";
            dt.Rows.Add(fila29);

            DataRow fila30 = dt.NewRow();
            fila30[0] = "3.0";
            fila30[1] = "0.4987";
            fila30[2] = "0.4987";
            fila30[3] = "0.4987";
            fila30[4] = "0.4988";
            fila30[5] = "0.4988";
            fila30[6] = "0.4989";
            fila30[7] = "0.4989";
            fila30[8] = "0.4989";
            fila30[9] = "0.4990";
            fila30[10] = "0.4990";
            dt.Rows.Add(fila30);

            // Carga de datos
            dgv_tablaz.DataSource = dt;
        }
    }
}
