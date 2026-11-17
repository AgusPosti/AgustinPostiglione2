using System;
namespace Parcial2.Pagos
{
    // Estrategia concreta: pago en efectivo al dejar la ropa. 10 % de descuento.
    // Ya está resuelta: usala de MODELO para el TODO 4.
    public class PagoCuentaEmpresa : IPagoStrategy
    {
        public const decimal Descuento = 0.05m;
        public const decimal Tope = 100000m;
        public const decimal Minimo = 20000m;

        public string Nombre => "Cuenta empresa";
        public bool PermiteCuotas => false;
        public bool RequiereCuit => true;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            if (subtotal >= Tope)
                return -subtotal * 0.08m;
            else if (subtotal < Minimo)
                throw new InvalidOperationException($"La cuenta empresa admite pedidos desde $20.000.");
            return -subtotal * 0.05m;
        }
    }
}
