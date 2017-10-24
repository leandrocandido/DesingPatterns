using System;
namespace DesingPatterns2.Cap7
{
    public class PagaPedido : IComando
    {
        public Pedido pedido { get; private set; }

        public void Executa()
        {
            this.pedido.Paga();
        }

        public PagaPedido(Pedido pedido)
        {
            Console.WriteLine("Pagando o pedido do cliente {0}",pedido.Cliente);
            this.pedido = pedido;
        }
    }
}
