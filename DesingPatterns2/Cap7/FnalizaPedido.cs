using System;
namespace DesingPatterns2.Cap7
{
    public class FinalizaPedido : IComando
    {
        public Pedido pedido { get; private set; }

        public void Executa()
        {
            pedido.Finaliza();
        }

        public FinalizaPedido(Pedido pedido)
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);
            this.pedido = pedido;
        }
    }
}
