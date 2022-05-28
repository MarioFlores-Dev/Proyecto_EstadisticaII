using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estadistica_II.Calculos
{
    public class Estimaciones
    {

        public static double MediaMuestra(List<double> datos, double n)
        {

            double sum = datos.Sum();
            double resultado = sum / n;

            return resultado;
        }
        public static double MediaMuestra1(List<double> datos, double n)
        {

            double sum = datos.Sum();
            double resultado = sum;

            return resultado;
        }


        public static double EstimacionPuntualDesviacionEstandar()
        {
            double resultado = 0;
            return resultado;
        }

        public static double EstimacionoblacionFinita(double desviacionEPoblacion, double n, double N)
        {
            double resultado = (desviacionEPoblacion / Math.Sqrt(n)) * (Math.Sqrt((N - n) / (N - 1)));
            return Math.Round(resultado, 2);
        }

        public static double MediaMuestralPoblacion(double n, double p)
        {
            double resultado = (n * p) / n;
            return resultado;
        }

        public static double ErrorEstandarProporcion(double n, double p, double q)
        {
            double resultado = Math.Sqrt((p * q) / n);
            return Math.Round(resultado, 3);
        }
        public static double ErrorEstandarEstimadoProporcion(double n, double p, double q)
        {

            double resultado = Math.Sqrt((q * p) / n);
            return Math.Round(resultado, 3);
        }
        public static double ErrorEstandarPoblacionFinita(double o, double n)
        {

            n = Math.Sqrt(n);
            double resultado = o / n;
            return Math.Round(resultado, 2);
        }

        public static double Nconfianza(double nConfianza)
        {

            double resultado = 0;
            double f = 0;
            double d = 0;
            f = nConfianza / 2;
            d = f * 99 / 100;
            f = f - d;
            resultado = f;
            return Math.Round(resultado, 3);
        }

        public static double LimiteSuperior(double mMuestra, double tZ, double eError)
        {

            double resultado = 0;
            resultado = (mMuestra + ((tZ) * (eError)));
            return Math.Round(resultado, 3);
        }

        public static double LimiteInferior(double mMuestra1, double tZ1, double eError1)
        {

            double resultado = 0;
            resultado = (mMuestra1 - ((tZ1) * (eError1)));
            return Math.Round(resultado, 3);
        }


    }
}
