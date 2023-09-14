using System;
using System.Linq;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;
using MathNet.Numerics;

namespace TecSim{
    public class Procedimientos{
        List<double> ListaNumerosRamdon;
        double Alfa;
        double media;
        public Procedimientos(List<string> Lista,double Alfa){
            ListaNumerosRamdon = new List<double>();
            this.Alfa = Alfa;
            TransformarStringFloat(Lista);
            PruebaHipotesis();
            PruebaVarianza();
        }
        public void TransformarStringFloat(List<string> Lista){
            double Valor = 0;
            for(var i=0;i<1000;i++){
                Valor = double.Parse(Lista[i]);
                ListaNumerosRamdon.Add(Valor);
            }
        }
        
        public void PruebaHipotesis(){
            Media();
            LimiteInferiorAceptacion();
            LimiteSuperiorAceptacion();
        }

        public void PruebaVarianza(){
            Varianza();
        }
        public void Media(){
            media = ListaNumerosRamdon.Average();
            Console.WriteLine(media);
        }

        public void Varianza(){
            double SumatoriaCuadrados = 0;
            for(var i=0; i<1000; i++){
                SumatoriaCuadrados += Math.Pow((ListaNumerosRamdon[i]-media),2);
            }
            Console.WriteLine("Sumatoria Cuadrados: "+SumatoriaCuadrados);
            double varianzaPoblacional = SumatoriaCuadrados / 1000;

            Console.WriteLine("Varianza Poblacional: "+varianzaPoblacional);

        }

        public void LimiteInferiorAceptacion(){
            double DesviacionEstandar = Normal.InvCDF(0,1,1-Alfa);
            double respuestaLimInfAcep = (0.5)-(DesviacionEstandar*(1/(12*Math.Sqrt(ListaNumerosRamdon.Count()-1))));
            Console.WriteLine("Limite Inferior de aceptación: "+respuestaLimInfAcep);
        }

        public void LimiteSuperiorAceptacion(){
            double DesviacionEstandar = Normal.InvCDF(0,1,1-Alfa);
            double respuestaLimInfAcep = (0.5)+(DesviacionEstandar*(1/(12*Math.Sqrt(ListaNumerosRamdon.Count()-1))));
            Console.WriteLine("Limite Superior de aceptación: "+respuestaLimInfAcep);
        }

        public void DesviacionNormalEstandar(){
            double sumatoriaDiferenciasCuadradas = ListaNumerosRamdon.Sum(x => Math.Pow(x - this.media, 2));
            double varianza = sumatoriaDiferenciasCuadradas / ListaNumerosRamdon.Count;
            double desviacionEstandar = Math.Sqrt(varianza);

            Console.WriteLine(desviacionEstandar);
        }
        public void LimiteSuperior(){
            double CHICUAD = ChiSquared.InvCDF(ListaNumerosRamdon.Count(),Alfa);
            Console.WriteLine("Limite Superior "+CHICUAD);
        }
        public void LimiteInferior(){
            double PedacitoCHICUAD = ChiSquared.InvCDF(ListaNumerosRamdon.Count(),(1-Alfa)/2);
            double ResultadoDeEso = PedacitoCHICUAD/(12*ListaNumerosRamdon.Count()-1);
            Console.WriteLine("Limite Ingerior "+ResultadoDeEso);
        }
    }
}