using System;
using System.Collections.Generic;
using System.Text;

namespace Gerestagio.Domain.Entidades
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
