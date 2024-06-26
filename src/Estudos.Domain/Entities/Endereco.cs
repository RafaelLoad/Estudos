﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Estudos.Domain.Entities
{
    public class Endereco 
    {
        public int Id { get; set; }

        public int IdCliente { get;set; }
        public string Tipo { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento {  get; set; }
        public string Cidade {  get; set; }
        public string Estado { get; set; }
        public string Referencia { get; set; }
    }
}
