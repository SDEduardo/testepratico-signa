using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=1234;"))
            {
                var result = connection.Query<Aluno>("SELECT * FROM Alunos");

                return result;
            }


        }

        [HttpPost]
        public void insert(Aluno aluno)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=1234;"))
            {
                var sql = $"insert into Alunos (Nome, Cpf) values ('{aluno.Nome}', '{aluno.Cpf}')";
                var result=connection.Query<Aluno>(sql);

            
            }

           
        }
        [HttpPut]
        public Aluno update(Aluno aluno)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=1234;"))
            {
                var sql = $"update Alunos SET Nome ='{aluno.Nome}' where id = {aluno.Id} ";
                var result = connection.Query<Aluno>(sql);

                var resultSelect = connection.QueryFirst<Aluno>($"SELECT * FROM Alunos where id = {aluno.Id} ");

                return resultSelect;

            }


        }
    }
}
