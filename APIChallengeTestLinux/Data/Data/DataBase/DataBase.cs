using DependencyInjectionSample.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace APIChallenge.Data.Data
{
    public class DataBase : IDataBase
    {

        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Estabelecimento> listaEstabelecimentos = new List<Estabelecimento>();
        private List<Pagamento> listaPagamentos = new List<Pagamento>();

        public DataBase()
        {
            listaClientes.Add(new Cliente(1, "Nome1", "123", DateTime.Today, "456"));
            listaClientes.Add(new Cliente(2, "Nome2", "234", DateTime.Today, "567"));
            listaClientes.Add(new Cliente(3, "Nome3", "345", DateTime.Today, "678"));
            listaEstabelecimentos.Add(new Estabelecimento(1, "GLOBO COMUNICACAO E PARTICIPACOES S/A", "27.865.757/0001-02", "205-4 - Sociedade Anônima Fechada", "ATIVA"));
            listaEstabelecimentos.Add(new Estabelecimento(2, "TVSBT CANAL 4 DE SAO PAULO S/A", "45.039.237/0001-14", "205-4 - Sociedade Anônima Fechada", "ATIVA"));
            listaEstabelecimentos.Add(new Estabelecimento(3, "STONE PAGAMENTOS S.A.", "16.501.555/0001-57", "205-4 - Sociedade Anônima Fechada", "ATIVA"));
            listaPagamentos.Add(new Pagamento(1, 123.45f, DateTime.Today, 1, 3));
            listaPagamentos.Add(new Pagamento(2, 234.56f, DateTime.Today, 2, 3));
            listaPagamentos.Add(new Pagamento(3, 345.67f, DateTime.Today, 1, 1));
        }

        public List<Cliente> obterListaClientes()
        {
            /*if (!listaClientes.Any() && false)
            {
                string line;
                string[] campos;
                var tempPath = System.IO.Path.GetTempPath();
                FileStream fileStream;
                try
                {
                    fileStream = new FileStream(tempPath + "cliente.txt", FileMode.Open);
                }
                catch (Exception)
                {
                    return listaClientes;
                }
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        campos = line.Split(';');
                        listaClientes.Add(new Cliente(long.Parse(campos[0]), campos[1], campos[2], DateTime.Parse(campos[3]), campos[4]));
                    }
                }
                fileStream.Dispose();
               
            }*/
            return listaClientes;
        }

        public List<Estabelecimento> obterListaEstabelecimentos()
        {
            /*if (!listaEstabelecimentos.Any())
            {
                string line;
                string[] campos;
                var tempPath = System.IO.Path.GetTempPath();
                FileStream fileStream;
                try
                {
                    fileStream = new FileStream(tempPath + "estabelecimento.txt", FileMode.Open);
                }
                catch (Exception)
                {
                    return listaEstabelecimentos;
                }
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        campos = line.Split(';');
                        listaEstabelecimentos.Add(new Estabelecimento(long.Parse(campos[0]), campos[1], campos[2], campos[3], campos[4]));
                    }
                }
                fileStream.Dispose();

            }*/
            return listaEstabelecimentos;
        }

        public List<Pagamento> obterListaPagamentos()
        {
            /*if (!listaPagamentos.Any())
            {
                string line;
                string[] campos;
                var tempPath = System.IO.Path.GetTempPath();
                FileStream fileStream;
                try
                {
                    fileStream = new FileStream(tempPath + "pagamento.txt", FileMode.Open);
                }
                catch (Exception)
                {
                    return listaPagamentos;
                }
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        campos = line.Split(';');
                        listaPagamentos.Add(new Pagamento(long.Parse(campos[0]), float.Parse(campos[1]), DateTime.Parse(campos[2]), long.Parse(campos[3]), long.Parse(campos[4])));
                    }
                }
                fileStream.Dispose();

            }*/
            return listaPagamentos;
        }

        public void setListaClientes(List<Cliente> value)
        {
            /*var tempPath = System.IO.Path.GetTempPath();
            var clienteFile = System.IO.File.Create(tempPath + "cliente.txt");
            var writer = new System.IO.StreamWriter(clienteFile);

            foreach (Cliente cliente in listaClientes)
            {
                writer.WriteLine("{0};{1};{2};{3};{4}", cliente.Id, cliente.Nome, cliente.Cpf, cliente.DataNascimento, cliente.NumeroCartao);
            }
            writer.Dispose();*/
            this.listaClientes = value;
        }

        public void setListaPagamentos(List<Pagamento> value)
        {
            /*var tempPath = System.IO.Path.GetTempPath();
            var pagamentoFile = System.IO.File.Create(tempPath + "pagamento.txt");
            var writer = new System.IO.StreamWriter(pagamentoFile);

            foreach (Pagamento pagamento in listaPagamentos)
            {
                writer.WriteLine("{0};{1};{2};{3};{4}", pagamento.Id, pagamento.Valor, pagamento.Data, pagamento.IdCliente, pagamento.IdEstabelecimento);
            }
            writer.Dispose();*/
            this.listaPagamentos = value;
        }

        public void apagarCliente(long id)
        {
            //List<Cliente> listaClientes = obterListaClientes();
            foreach (Cliente cliente in this.listaClientes)
            {
                if (cliente.Id == id)
                {
                    this.listaClientes.Remove(cliente);
                    break;
                }
            }
            //setListaClientes(listaClientes);
        }

        public void apagarPagamento(long id)
        {
            //List<Pagamento> listaPagamentos = obterListaPagamentos();
            foreach (Pagamento pagamento in this.listaPagamentos)
            {
                if (pagamento.Id == id)
                {
                    this.listaPagamentos.Remove(pagamento);
                    break;
                }
            }
            //setListaPagamentos(listaPagamentos);
        }

        public void inserirCliente(Cliente cliente)
        {
            /*var tempPath = System.IO.Path.GetTempPath();
            var clienteFile = System.IO.File.AppendText(tempPath + "cliente.txt");
            clienteFile.WriteLine("{0};{1};{2};{3};{4}", cliente.Id, cliente.Nome, cliente.Cpf, cliente.DataNascimento, cliente.NumeroCartao);
            clienteFile.Dispose();*/
            this.listaClientes.Add(cliente);
        }

        public void inserirEstabelecimento(Estabelecimento estabelecimento)
        {
            /*var tempPath = System.IO.Path.GetTempPath();
            var clienteFile = System.IO.File.AppendText(tempPath + "estabelecimento.txt");
            clienteFile.WriteLine("{0};{1};{2};{3};{4}", estabelecimento.Id, estabelecimento.Nome, estabelecimento.Cnpj, estabelecimento.Natureza_Juridica, estabelecimento.Situacao);
            clienteFile.Dispose();*/
            this.listaEstabelecimentos.Add(estabelecimento);
        }

        public void inserirPagamento(Pagamento pagamento)
        {
            /*var tempPath = System.IO.Path.GetTempPath();
            var clienteFile = System.IO.File.AppendText(tempPath + "pagamento.txt");
            clienteFile.WriteLine("{0};{1};{2};{3};{4}", pagamento.Id, pagamento.Valor, pagamento.Data, pagamento.IdCliente, pagamento.IdEstabelecimento);
            clienteFile.Dispose();*/
            this.listaPagamentos.Add(pagamento);
        }

        public Cliente obterClientePorId(long id)
        {
            foreach (Cliente cliente in this.listaClientes)
            {
                if (cliente.Id == id)
                {
                    return cliente;
                }
            }

            return null;
        }

        public Estabelecimento obterEstabelecimentoPorId(long id)
        {
            foreach (Estabelecimento estabelecimento in this.listaEstabelecimentos)
            {
                if (estabelecimento.Id == id)
                {
                    return estabelecimento;
                }
            }

            return null;
        }

        public Pagamento obterPagamentoPorId(long id)
        {
            foreach (Pagamento pagamento in this.listaPagamentos)
            {
                if (pagamento.Id == id)
                {
                    return pagamento;
                }
            }

            return null;
        }
    }
}
