using APIChallenge.Data.Data;
using DependencyInjectionSample.Data;
using DependencyInjectionSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIChallenge
{
    public class EstabelecimentoDados : IEstabelecimentoDados
    {
        IDataBase dataBase;
        public EstabelecimentoDados(IDataBase dataBaseEstabelecimento)
        {
            this.dataBase = dataBaseEstabelecimento;
        }

        public void inserirEstabelecimento(Estabelecimento estabelecimento)
        {
            //Valida se já existe um Estabelecimento com o mesmo id
            if (dataBase.obterEstabelecimentoPorId(estabelecimento.Id) == null)
            {
                dataBase.inserirEstabelecimento(estabelecimento);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Estabelecimento obterEstabelecimentoPorCnpj(string cnpj)
        {
            //Busca um Estabelecimento por seu CNPJ
            foreach (Estabelecimento estabelecimento in dataBase.obterListaEstabelecimentos())
            {
                if (estabelecimento.Cnpj.Replace(".","").Replace("/","").Replace("-","").Equals(cnpj))
                {
                    return estabelecimento;
                }
            }

            return null;
        }

        public Estabelecimento obterEstabelecimentoPorId(long id)
        {
            return dataBase.obterEstabelecimentoPorId(id);
        }

        public List<Estabelecimento> obterListaEstabelecimentos()
        {
            return dataBase.obterListaEstabelecimentos();
        }

        public long obterMaxIdEstabelecimento()
        {
            long maxId = 1;
            foreach (Estabelecimento estabelecimento in dataBase.obterListaEstabelecimentos())
            {
                if (estabelecimento.Id > maxId)
                {
                    maxId = estabelecimento.Id;
                }
            }

            return maxId+1;
        }
    }
}
