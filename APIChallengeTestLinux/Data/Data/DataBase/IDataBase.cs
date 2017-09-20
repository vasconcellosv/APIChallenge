using APIChallenge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Data
{
    public interface IDataBase
    {
        List<Cliente> obterListaClientes();
        List<Estabelecimento> obterListaEstabelecimentos();
        List<Pagamento> obterListaPagamentos();
        void setListaClientes(List<Cliente> value);
        void setListaPagamentos(List<Pagamento> value);
        void apagarCliente(long id);
        void apagarPagamento(long id);
        void inserirCliente(Cliente cliente);
        void inserirEstabelecimento(Estabelecimento estabelecimento);

        void inserirPagamento(Pagamento pagamento);
        /// <summary>
        /// Método para obter um Cliente por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Cliente obterClientePorId(long id);
        /// <summary>
        /// Método para obter um Estabelecimento por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Estabelecimento obterEstabelecimentoPorId(long id);
        /// <summary>
        /// Método para obter pagamento por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Pagamento obterPagamentoPorId(long id);
    }
}
