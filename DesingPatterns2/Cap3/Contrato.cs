using System;
namespace DesingPatterns2.Cap3
{
    public class Contrato
    {
        public string Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public TipoContrato Tipo { get; private set; }


        public Contrato(DateTime data , string cliente , TipoContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

		public void Avanca()
		{
			if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAndamento;
			else if (Tipo == TipoContrato.EmAndamento) Tipo = TipoContrato.Acertado;
			else if (Tipo == TipoContrato.Acertado) Tipo = TipoContrato.Concluido;
		}

		public Estado SalvaEstado()
		{
			return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
		}

		public void Restaura(Estado estado)
		{
			this.Data = estado.Contrato.Data;
			this.Cliente = estado.Contrato.Cliente;
			this.Tipo = estado.Contrato.Tipo;
		}

	}
}
