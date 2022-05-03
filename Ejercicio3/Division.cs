using System;

namespace EjerciciosOCP.Ejercicio3
{
    public class Division : IOperacionCalculadora
    {
        private readonly double Valor1;
        private readonly double Valor2;

        public Division(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public double ObtenerResultado()
        {
            if (Valor2 != 0)
            {
                return Valor1 / Valor2;
            }
            else
            {
                throw new Exception("¡No se puede dividir para 0!");
            }
        }
    }
}