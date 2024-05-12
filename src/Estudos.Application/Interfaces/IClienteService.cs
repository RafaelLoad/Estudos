﻿using Estudos.Domain.Entities;

namespace Estudos.Application.Interfaces
{
    public interface IClienteService
    {
        Task<bool> Add(Cliente cliente);
        Task<IEnumerable<Cliente>> GetAll(string? nome, string? cpf, string? email);
        Task<Cliente> GetById(int id, bool getDependencies = false);
        Task<Tuple<bool, string>> Update(Cliente cliente, int id);
        Task<Tuple<bool, string>>  Delete(int id);
    }
}
