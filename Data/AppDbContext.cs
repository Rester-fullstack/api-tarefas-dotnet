using api_tarefas_dotnet.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace api_tarefas_dotnet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
