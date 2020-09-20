using System;
using System.Collections.Generic;
using System.Text;

namespace Gerestagio.Domain.Entidades
{
    public class Empresa : EntidadeBase
    {
        public Empresa(string nome, string cnpj, string telefone, string contato)
        {
            Id = Guid.NewGuid();
            CriadoEm = DateTime.Now;
            AtualizadoEm = DateTime.Now;
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
            Contato = contato;
        }

        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public string Telefone { get; private set; }
        public string Contato { get; private set; }

        public void AlterarNome(string nome) => Nome = nome;
        public void AlterarCnpj(string cnpj) => Cnpj = cnpj;
        public void AlterarTelefone(string telefone) => Telefone = telefone;
        public void AlterarContato(string contato) => Contato = contato;
    }
}
