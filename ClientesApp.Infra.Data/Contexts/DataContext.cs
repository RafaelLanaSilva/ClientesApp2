using ClientesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contexto para conexão com o banco de dados
    /// através do EntityFramework
    /// </summary>
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Criando conexão com um banco de dados em memória
            optionsBuilder.UseInMemoryDatabase("ClientesBD");
        }

        /// <summary>
        /// Operações com cliente em memória
        /// </summary>
        public DbSet<Cliente> Clientes { get; set; }
    }
}
