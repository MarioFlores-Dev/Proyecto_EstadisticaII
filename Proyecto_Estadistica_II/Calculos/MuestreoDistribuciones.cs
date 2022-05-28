using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estadistica_II.Calculos
{
    public class MuestreoDistribuciones
    {

        public static double ErrorEstandarInfinitas(double desviacion, double n)
        {
            double resultado = desviacion / Math.Sqrt(n);
            return resultado;

        }


        public static double EstandarizacionMediaMuestra(int opcion, double mediaMuestra, double errorEstandar,double mediaPoblacion, double desviacion, double n )
        {
            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = (mediaMuestra - mediaPoblacion) / errorEstandar;
                    break;
                case 2:
                    resultado = (mediaMuestra - mediaPoblacion) / ErrorEstandarInfinitas(desviacion, n);
                    break;

            }

            return Math.Round(resultado,2);

        }

        public static double MultiplicadorPoblacionFinita(double n, double N)
        {
            double resultado = Math.Sqrt((N - n) / (N - 1));
            return Math.Round(resultado,2);
        }

        public static double ErrorEstandarFinita(double desviacion, double n , double N)
        {
            double resultado = (ErrorEstandarInfinitas(desviacion, n)) * (MultiplicadorPoblacionFinita(n,N));
            return Math.Round(resultado,2);

        }

    }
}
