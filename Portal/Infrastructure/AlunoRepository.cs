using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure
{
    // Essa classe vai ter os métodos de adicionar e remover alunos.
    public class AlunoRepository
    {
        // Utilizando o EntityFramework

        private readonly DbConnection _context = new DbConnection();

        public void Add(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public List<Aluno> Get()
        {
            return _context.Alunos.ToList();
        }

        //public bool Add(Aluno aluno)
        //{
        //    // A utilização do using serve para usar o método Dispose de forma automática.
        //    using var conn = new DbConnection();

        //    // Instrução para o banco.
        //    string query = @"INSERT INTO public.alunos(
        //                 nome, curso, idade)
        //                 VALUES (@nome, @curso, @idade);";

        //    // Utilizando o Dapper.
        //    var result = conn.Connection.Execute(sql: query, param: aluno);

        //    return result == 1;

        //}


        //public List<Aluno> Get()
        //{
        //    using var conn = new DbConnection();

        //    string query = @"SELECT * FROM alunos;";

        //    // Fazendo uma consulta.
        //    var alunos = conn.Connection.Query<Aluno>(sql: query);

        //    return alunos.ToList();
        //}
    }
}
