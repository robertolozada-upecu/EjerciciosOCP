using System;
using System.Collections.Generic;
using System.Drawing;

namespace EjerciciosOCP.Ejercicio2
{
    public class CalculadoraAreas
    {
        private readonly List<IFiguraGeometrica> Figuras;
        
        public CalculadoraAreas(List<IFiguraGeometrica> figuras)
        {
            Figuras = figuras;
        }
        
        public double Calcular()
        {
            double area = 0;
            foreach (var figura in Figuras)
            {
                area += figura.ObtenerArea();

                //Agregar circulo
            }
            return area;
        }
    }
}