using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=1234;"))
            {
                var result = connection.Query<Pessoa>("SELECT PESSOA_ID, NOME_FANTASIA, CNPJ_CPF FROM Pessoa");

                return result;
            }


        }

        [HttpPost]
        public void insert(Pessoa pessoa)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=1234;"))
            {
                var sql = $"insert into Pessoa (NOME_FANTASIA, CNPJ_CPF) values ('{pessoa.NOME_FANTASIA}','{pessoa.CNPJ_CPF}')";
                var result = connection.Query<Pessoa>(sql);


            }


        }
        [HttpPut]
        public Pessoa update(Pessoa pessoa)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=1234;"))
            {
                var sql = $"update Pessoa SET NOME_FANTASIA ='{pessoa.NOME_FANTASIA}' where PESSOA_ID = {pessoa.PESSOA_ID} ";
                var result = connection.Query<Pessoa>(sql);

                var resultSelect = connection.QueryFirst<Pessoa>($"SELECT * FROM Pessoa where PESSOA_ID = {pessoa.PESSOA_ID} ");

                return resultSelect;

            }


        }
    }
}

