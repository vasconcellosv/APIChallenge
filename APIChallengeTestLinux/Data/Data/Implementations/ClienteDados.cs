using APIChallenge.Data.Data;
using DependencyInjectionSample.Data;
using DependencyInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIChallenge
{
    public class ClienteDados : IClienteDados
    {
        IDataBase dataBase;
        public ClienteDados(IDataBase dataBaseClient)
        {
            this.dataBase = dataBaseClient;
        }

        public void inserirCliente(Cliente clienteTemp)
        {
            //Valida se já existe um Cliente com o mesmo id
            Cliente cliente = obterClientePorId(clienteTemp.Id);
            if (cliente == null)
            {
                dataBase.inserirCliente(clienteTemp);
            }
            else
            {
                throw new Exception();
            }
        }

        public Cliente obterClientePorId(long id)
        {
            //Busca um Cliente por seu id
            foreach (Cliente cliente in dataBase.obterListaClientes())
            {
                if (cliente.Id == id)
                {
                    return cliente;
                }
            }

            return null;
        }
        
        public List<Cliente> obterListaClientes()
        {
            return dataBase.obterListaClientes();
        }



        public void apagarCliente(long id)
        {
            if (dataBase.obterClientePorId(id) != null)
            {
                dataBase.apagarCliente(id);
            }
            else
            {
                throw new Exception();
            }
        }

        public void atualizarCliente(Cliente clienteTemp)
        {
            Cliente cliente = obterClientePorId(clienteTemp.Id);
            if (cliente != null)
            {
                dataBase.apagarCliente(clienteTemp.Id);
                dataBase.inserirCliente(clienteTemp);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
