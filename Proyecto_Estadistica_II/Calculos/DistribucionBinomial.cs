using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estadistica_II.Calculos{
    public class DistribucionBinomial{

        public static double ProcesoBernoulli_binomial(int n, double p,int r){

            double q = 1 - p;
            int rF = 1, nF = 1;
            int difNRF = 1;
            //Calculamos los factoriales de n, r y la diferencia de n menos r
            for (int i = 1; i<=n; i++){
                nF = nF * i;
            }
            for (int i = 1; i<= r; i++){
                rF = rF * i;
            }
            double difNR = n - r;
            for(int i = 1; i <= difNR; i++){
                difNRF = difNRF * i;
            }
            //Calculamos la division de n! partido r!*(n-r)!* p^r* q^n-r
            double resultado = (nF / (rF * (difNRF)))*Math.Pow(p,r)*Math.Pow(q,difNR);

            return resultado;
        }

        public static double Media(int n,double p){
            double media = n * p;
            return media;
        }

        public static double DesviacionEstandar(int n, double p){
            double q = 1 - p;
            double desviacion = Math.Sqrt((n * p * q));
            return desviacion;
        }

        public static double DistribucionPoisson(int x, double lambda, double e)
        {

            double xFac = 1;
               
            for (int j = 1; j <= x; j++)
            {
                xFac = xFac * j;

            }
            double resultado = (Math.Pow(lambda, x) * Math.Round(Math.Pow(e, -lambda), 5)) / xFac;

            return Math.Round(resultado, 5);
        }

        public static double PoissonAproxBinomial(int x, int n, double p, double e){
           
            double resNP = Media(n, p);
            double xFac = 1;

            for (int i = 1; i <= x; i++){
                xFac = xFac * i;
            }
            double resultadoFinal = Math.Pow(resNP, x) * Math.Pow(e, -resNP) / xFac;

            return Math.Round(resultadoFinal,5);
        }

        public static double EstandarizacionVariableAleatoria(int x, double media, double desviacionEstandar)
        {
            double resultado = (x - media) / desviacionEstandar;
            return resultado;
        }

    }
}
