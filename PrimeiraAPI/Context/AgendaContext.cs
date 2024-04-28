using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Entities;

namespace PrimeiraAPI.Context
{
    public partial class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) //Vaicomunicar com o banco de dados
        {
        }

        // Definir DbSet para cada entidade que será mapeada para o banco de dados
        public DbSet<Contato> Contatos { get; set; }
    }
}