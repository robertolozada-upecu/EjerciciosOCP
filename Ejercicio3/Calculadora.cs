using System;

namespace EjerciciosOCP.Ejercicio3
{
    public class Calculadora
    {
        public double Calcular(IOperacionCalculadora operacionCalculadora)
        {
            return operacionCalculadora.ObtenerResultado();
        }
    }
}