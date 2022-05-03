using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosOCP.Ejercicio2
{
    public class Circulo : IFiguraGeometrica
    {
        private const double PI = 3.141592;
        private readonly double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double ObtenerArea()
        {
            return radio * radio * PI;
        }
    }
}
