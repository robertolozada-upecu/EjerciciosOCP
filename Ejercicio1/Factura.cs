namespace EjerciciosOCP.Ejercicio1
{
    public class Factura
    {
        public virtual double ObtenerDescuentoFactura(double valorTotal)
        {
            return valorTotal;
            //double valorFinal = valorTotal;
            //if (tipoFactura == TipoFactura.FacturaFinal)
            //    valorFinal -= 100;
            //else if (tipoFactura == TipoFactura.FacturaPropuesta)
            //    valorFinal -= 50;
            //return valorFinal;
        }
        //Queremos agregar un nuevo tipo de factura
    }
    public class FacturaFinal : Factura
    {
        public override double ObtenerDescuentoFactura(double valorTotal)
        {
            return valorTotal-100;
        }
    }
    public class FacturaPropuesta : Factura
    {
        public override double ObtenerDescuentoFactura(double valorTotal)
        {
            return valorTotal -50;
        }
    }
    public class FacturaRecurrente : Factura
    {
        public override double ObtenerDescuentoFactura(double valorTotal)
        {
            return valorTotal - 20;
        }
    }
}