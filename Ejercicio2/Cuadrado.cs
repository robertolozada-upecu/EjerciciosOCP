namespace EjerciciosOCP.Ejercicio2
{
    public class Cuadrado : IFiguraGeometrica
    {
        private readonly double Lado;

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double ObtenerLado() => Lado;
        public double ObtenerArea() => Lado * Lado;
    }
}