using Microsoft.EntityFrameworkCore;
using WebApiGerenciadorDeTarefas.Models;

namespace WebApiGerenciadorDeTarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
