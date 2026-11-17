using System.Text;
using Parcial2.Models;

namespace Parcial2.Comprobantes
{
    // Producto concreto: comprobante de texto plano.
    public class FormatoEtiqueta : IFormatoComprobante
    {
        private readonly StringBuilder _sg = new StringBuilder();

        public void Encabezado(Pedido pedido)
        {
            
            _sg.AppendLine("LAVADERO LA PERLA");
            _sg.AppendLine($"Pedido #{pedido.Id} - {pedido.Cliente}");
        }

        public void Item(ItemPedido item)
        {
            _sg.AppendLine($"{item.Cantidad,3} x {item.Descripcion,-28}{item.Subtotal,12:C0}");
        }

        public void Totales(decimal subtotal, decimal ajuste, decimal total)
        {
            _sg.AppendLine($"{"TOTAL",-34}{total,12:C0}");
        }

        public string Resultado()
        {
            return _sg.ToString();
        }
    }
}
