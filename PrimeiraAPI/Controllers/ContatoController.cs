using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Context;
using PrimeiraAPI.Entities;

namespace PrimeiraAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _agendaContext;
        public ContatoController(AgendaContext agendaContext){
            _agendaContext = agendaContext;
        }

        [HttpPost("CriarContato")]
        public IActionResult Create(Contato contato)
        {
            _agendaContext.Add(contato); //Adicionando o objeto no banco de dados
            _agendaContext.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _agendaContext.Contatos.Find(id);
            if(contato == null){
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _agendaContext.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _agendaContext.Contatos.Find(id);
            if(contatoBanco == null){
                return NotFound();
            }
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Status = contato.Status;
            _agendaContext.Contatos.Update(contatoBanco);
            _agendaContext.SaveChanges();
            return Ok(contatoBanco);
            
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _agendaContext.Contatos.Find(id);
            if(contatoBanco == null){
                return NotFound();
            }
            _agendaContext.Contatos.Remove(contatoBanco);
            _agendaContext.SaveChanges();
            return Ok("Contato Removido!");
        }
    }
}