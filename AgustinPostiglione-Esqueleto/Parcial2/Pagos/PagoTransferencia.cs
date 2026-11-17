namespace Parcial2.Pagos
{
    // Estrategia concreta: pago en efectivo al dejar la ropa. 10 % de descuento.
    // Ya está resuelta: usala de MODELO para el TODO 4.
    public class PagoTransferencia : IPagoStrategy
    {
        public const decimal Descuento = 0.03m;

        public string Nombre => "Transferencia";
        public bool PermiteCuotas => false;
        public bool RequiereCuit => false;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            return -subtotal * Descuento;
        }
    }
}
