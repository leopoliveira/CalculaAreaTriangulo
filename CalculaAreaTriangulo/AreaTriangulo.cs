using System;

namespace CalculaAreaTriangulo
{
    internal class AreaTriangulo
    {
        public double LadoA = 0;
        public double LadoB = 0;
        public double LadoC = 0;


        public double CalculaAreaTriangulo()
        {
            double variavelAux = (LadoA + LadoB + LadoC) / 2;

            double resultado = 
                Math.Sqrt(variavelAux * (variavelAux - LadoA) * (variavelAux - LadoB) * (variavelAux - LadoC));

            return resultado;
            
        }


    }
}
