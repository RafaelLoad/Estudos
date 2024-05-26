﻿using Estudos.Application.Interfaces;
using Estudos.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Estudos.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController
        (
            IClienteService ClienteService
        )
        {
            _clienteService = ClienteService;
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar(Cliente cliente)
            => Ok(await _clienteService.Adicionar(cliente));

        [HttpPut("Atualizar/{id}")]
        public async Task<IActionResult> Atualizar(Cliente cliente, int id)
        {
            return Ok(await _clienteService.Atualizar(cliente, id));
        }

        [HttpGet("BuscarPorId/{id}")]
        public async Task<IActionResult> BuscarPorId(int id, bool getDependencies = false)
        {
            return Ok(await _clienteService.BuscarPorId(id, getDependencies));
        }

        [HttpGet("BuscarTodos")]
        public async Task<IActionResult> BuscarTodos(string? nome, string? cpf, string? email)
        {
            return Ok(await _clienteService.BuscarTodos(nome, cpf, email));
        }

        [HttpGet("Cep/{cep}")]
        public async Task<IActionResult> Cep(string cep)
            => Ok(await _clienteService.ConsultarCep(cep));

        [HttpDelete("Remover/{id}")]
        public async Task<IActionResult> Deletar(int id, int? idEndereco, int? idContato)
        {
            return Ok(await _clienteService.Deletar(id, idEndereco, idContato));
        }

    }
}
