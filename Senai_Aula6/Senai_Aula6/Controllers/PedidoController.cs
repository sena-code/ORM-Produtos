using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senai_Aula6.Domains;
using Senai_Aula6.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Senai_Aula6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository _repo;

        public PedidoController()
        {
            _repo = new PedidoRepository();
        }
        // GET: api/<PedidoController>
        [HttpGet]
        public List<Pedido> Get()
        {
            return _repo.Listar();
        }

        // GET api/<PedidoController>/5
        [HttpGet("{id}")]
        public Pedido Get(Guid id)
        {
            return _repo.BuscarPorId(id);
        }

        // POST api/<PedidoController>
        [HttpPost]
        public void Post(Pedido pedido)
        {
            _repo.Adicionar(pedido);
        }

        // PUT api/<PedidoController>/5
        [HttpPut("{id}")]
        public void Put(Pedido pedido)
        {
            _repo.Editar(pedido);
        }

        // DELETE api/<PedidoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repo.Remover(id);
        }
    }
}
