using APIChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Models
{
    public interface IClienteDados
    {
        void inserirCliente(Cliente cliente);
        List<Cliente> obterListaClientes();
        void apagarCliente(long id);
        Cliente obterClientePorId(long id);
        void atualizarCliente(Cliente cliente);
    }
}