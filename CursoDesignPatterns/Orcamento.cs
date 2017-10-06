﻿using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public IList<Item> Itens { get; private set; }


        public void AdicionaItens (Item item)
        {
            this.Itens.Add(item);
        }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }
    }
}
