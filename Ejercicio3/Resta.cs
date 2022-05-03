﻿namespace EjerciciosOCP.Ejercicio3
{
    public class Resta : IOperacionCalculadora
    {
        private readonly double Valor1;
        private readonly double Valor2;

        public Resta(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public double ObtenerResultado() => Valor1 - Valor2;
    }
}