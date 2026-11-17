using System;

namespace Parcial2.Pagos
{
    // Estrategia concreta: pago en efectivo al dejar la ropa. 10 % de descuento.
    // Ya está resuelta: usala de MODELO para el TODO 4.
    public class PagoTarjeta : IPagoStrategy
    {
       
        public string Nombre => "Tarjeta";
        public bool PermiteCuotas => true;
        public bool RequiereCuit => false;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            switch (cuotas)
            {
                case 1: return subtotal;
                case 2: return subtotal * 0.05m;
                case 3: return subtotal * 0.10m;
                default: throw new ArgumentException("Con tarjeta solamente se pueden 1, 2 o 3 cuotas.");

            }
        }
    }
}
