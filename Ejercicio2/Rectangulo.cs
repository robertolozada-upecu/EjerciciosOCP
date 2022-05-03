namespace EjerciciosOCP.Ejercicio2
{
    public class Rectangulo : IFiguraGeometrica
    {
        private readonly double Ancho;
        private readonly double Altura;

        public Rectangulo(double ancho, double altura)
        {
            Ancho = ancho;
            Altura = altura;
        }

        public double ObtenerAncho() => Ancho;
        public double ObtenerAltura() => Altura;
        public double ObtenerArea() => Altura * Ancho;
    }
}