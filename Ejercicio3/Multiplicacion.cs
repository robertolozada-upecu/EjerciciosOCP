namespace EjerciciosOCP.Ejercicio3
{
    public class Multiplicacion : IOperacionCalculadora
    {
        private readonly double Valor1;
        private readonly double Valor2;

        public Multiplicacion(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public double ObtenerResultado() => Valor1 * Valor2;
    }
}