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
            if (EhTrianguloValido())
            {
                if (ladoA == ladoB && ladoA == ladoC)
                    return "Triangulo equilátero";
                else if (EhTrianguloIsoceles())
                    return "Triangulo isóceles";
                else
                    return "Triangulo escaleno";
            }
            else
                return "Triangulo inválido";
        }

        private bool EhTrianguloIsoceles()
        {
            return ladoA == ladoB || ladoA == ladoC || ladoB == ladoC;
        }

        private bool EhTrianguloValido()
        {
            return ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA;
        }
    }
}