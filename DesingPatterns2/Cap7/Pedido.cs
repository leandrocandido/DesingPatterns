using System;
namespace DesingPatterns2.Cap7
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataFinalizacao { get; set; }
        public Status Status { get; set; }

        public Pedido(string nomeCliente , double valor)
        {
            this.Cliente = nomeCliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            this.Status = Status.Pago;
        }

        public void Finaliza()
        {
            this.Status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }

    }
}
