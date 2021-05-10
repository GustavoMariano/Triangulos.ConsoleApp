using System;

namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        private double ladoA = 0, ladoB = 0, ladoC = 0;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        public string validar()
        {
            if (ladoA + ladoB > ladoC 
                && ladoA + ladoC > ladoB
                && ladoB + ladoC > ladoA)
            {
                if (ladoA == ladoB && ladoA == ladoC)
                {
                    return "Triangulo Equilátero";
                }
                else if(ladoA == ladoB 
                    || ladoA == ladoC
                    || ladoB == ladoC)
                {
                    return "Triangulo isóceles";
                }
                else
                {
                    return "Triangulo escaleno";
                }
            }
            else
            {
                return "Triangulo inválido";
            }
        }
    }
}
