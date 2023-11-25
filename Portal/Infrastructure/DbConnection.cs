using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure
{
    public class DbConnection : DbContext
    {   
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=portal_do_aluno_;User id=postgres;Password=1234");

        // Utilizando o Dapper e a interface IDisposable para fechar a conexão com o banco.

        //public NpgsqlConnection Connection { get; set; }

        //// Abrindo a conexão com o banco.
        //public DbConnection()
        //{
        //    Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=portal_do_aluno_;User id=postgres;Password=1234");
        //    Connection.Open();
        //}

        //// Esse método serve para encerrar a conexão com o banco.
        //public void Dispose()
        //{
        //    Connection.Dispose();
        //}



    }
}
