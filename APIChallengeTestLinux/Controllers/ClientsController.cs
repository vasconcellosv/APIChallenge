﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionSample.Interfaces;

namespace APIChallenge.Controllers
{
    [Route("[controller]")]
    public class ClientsController : Controller
    {

        private IServicosDeCliente servicosDeClientes;
        public ClientsController(IServicosDeCliente servicosDeClientes)
        {
            this.servicosDeClientes = servicosDeClientes;
        }

        // GET clients
        /// <summary>
        /// Método responsável por listar todos os Clientes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return servicosDeClientes.obterListaClientes();
        }

        // GET clients/5
        /// <summary>
        /// Método responsável por exibir um determinado Cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Cliente Get(long id)
        {
            Cliente cliente = servicosDeClientes.obterClientePorId(id);
            if (cliente == null)
            {
                this.HttpContext.Response.StatusCode = 404;
            }
            return cliente;
        }

        // POST clients
        /// <summary>
        /// Método responsável por cadastrar um Cliente
        /// </summary>
        /// <param name="cliente"></param>
        [HttpPost]
        public void Post([FromBody]Cliente cliente)
        {
            try
            {
                servicosDeClientes.inserirCliente(cliente);
            }
            catch (ArgumentException)
            {
                this.HttpContext.Response.StatusCode = 406;
            }
            catch (Exception)
            {
                this.HttpContext.Response.StatusCode = 400;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody]Cliente cliente)
        {
            //servicosDeClientes.atualizarCliente(id, cliente);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            //servicosDeClientes.apagarCliente(id);
        }
    }
}
