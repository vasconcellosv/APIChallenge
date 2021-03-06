﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIChallenge
{
    public class Pagamento
    {
        private long id;
        private float valor;
        private DateTime data;
        private long idCliente;
        private long idEstabelecimento;

        public long Id { get => id; set => id = value; }
        public float Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long IdEstabelecimento { get => idEstabelecimento; set => idEstabelecimento = value; }

        public Pagamento(long id, float valor, DateTime data, long idCliente, long idEstabelecimento)
        {
            this.id = id;
            this.valor = valor;
            this.data = data;
            this.idCliente = idCliente;
            this.idEstabelecimento = idEstabelecimento;
        }
    }
}
