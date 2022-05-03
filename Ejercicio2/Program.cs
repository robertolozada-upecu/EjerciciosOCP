using System.Collections.Generic;

namespace EjerciciosOCP.Ejercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var figuras = new List<IFiguraGeometrica>
            {
                new Cuadrado(lado:5),
                new Rectangulo(ancho:2, altura:5),
                new Triangulo(alto:8,ancho:3),
                new Circulo(radio:6)
            };

            var calculadora = new CalculadoraAreas(figuras);

            calculadora.Calcular();
        }
    }
    public class Triangulo : IFiguraGeometrica
    {
        private readonly double alto;
        private readonly double ancho;

        public Triangulo(double alto, double ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }

        public double ObtenerArea()
        {
            return (alto * ancho) / 2; ;
        }
    }
}