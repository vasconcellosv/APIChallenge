using APIChallenge.Data.Data;
using DependencyInjectionSample.Data;
using DependencyInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIChallenge
{
    public class PagamentoDados : IPagamentoDados
    {
        IDataBase dataBase;
        public PagamentoDados(IDataBase dataBasePagamento)
        {
            this.dataBase = dataBasePagamento;
        }

        public void cancelarPagamento(long id)
        {
            //Valida se existe um pagamento com o id recebido
            if (dataBase.obterPagamentoPorId(id) != null)
            {
                dataBase.apagarPagamento(id);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void inserirPagamento(Pagamento pagamento)
        {
            //Valida se o Cliente e o Estabelecimento existem e que não exista um Pagamento com o id recebido
            if (dataBase.obterClientePorId(pagamento.IdCliente) != null && dataBase.obterEstabelecimentoPorId(pagamento.IdEstabelecimento) != null && dataBase.obterPagamentoPorId(pagamento.Id) == null)
            {
                dataBase.inserirPagamento(pagamento);
            }
            else
            {
                throw new Exception();
            }
        }

        public List<Pagamento> obterListaPagamentosPorEstabelecimento(long idEstabelecimento)
        {
            List<Pagamento> listaPagamentos = new List<Pagamento>();

            foreach (Pagamento pagamento in dataBase.obterListaPagamentos())
            {
                if (pagamento.IdEstabelecimento == idEstabelecimento)
                {
                    listaPagamentos.Add(pagamento);
                }
            }
            return listaPagamentos;
        }

        public Pagamento obterPagamentoPorId(long id)
        {
            return dataBase.obterPagamentoPorId(id);
        }

        public long obterMaxIdPagamento()
        {
            long maxId = 1;
            foreach (Pagamento pagamento in dataBase.obterListaPagamentos())
            {
                if (pagamento.Id > maxId)
                {
                    maxId = pagamento.Id;
                }
            }

            return maxId + 1;
        }
    }
}
