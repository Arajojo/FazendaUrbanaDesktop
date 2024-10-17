using Dapper;
using FazendaUrbanaDesktop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaUrbanaDesktop.Repositories
{ 
    public class FuncionarioRepositorio
    {
        public void Insert(Funcionario funcionario)
        {
            SqlConnection connection = (SqlConnection) new DbConnection().GetConnection();
            connection.Execute("INSERT INTO FUNCIONARIO (NOME, DOCUMENTO, TELEFONE, ENDERECO, DATA_ADM, DATA_NASC) VALUES (@nome, @documento, @telefone, @endereco, @data_adm, @data_nasc);",
                new
                {
                    nome = funcionario.Nome,
                    documento = funcionario.Documento,
                    telefone = funcionario.Telefone,
                    endereco = funcionario.Endereco,
                    data_adm = funcionario.DataAdm,
                    data_nasc = funcionario.DataNasc
                });
        }
        public void Update(Funcionario funcionario)
        {
            SqlConnection connection = (SqlConnection)new DbConnection().GetConnection();
            connection.Execute("UPDATE FUNCIONARIO SET NOME = @nome, DOCUMENTO = @documento, TELEFONE = @telefone, ENDERECO = @endereco, DATA_ADM = @data_adm, DATA_NASC = @data_nasc WHERE ID = @id;",
                new
                {
                    nome = funcionario.Nome,
                    documento = funcionario.Documento,
                    telefone = funcionario.Telefone,
                    endereco = funcionario.Endereco,
                    data_adm = funcionario.DataAdm,
                    data_nasc = funcionario.DataNasc,
                    id = funcionario.ID
                });
        }
        public void Delete(int id)
        {
            SqlConnection connection = (SqlConnection)new DbConnection().GetConnection();
            connection.Execute("DELETE FROM FUNCIONARIO WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Funcionario BuscarFuncPeloId(int id)
        {
            SqlConnection connection = (SqlConnection)new DbConnection().GetConnection();
            return connection.QueryFirstOrDefault<Funcionario>(@"SELECT * FROM FUNCIONARIO WHERE ID = @id",
                new { id });
        }

        public IEnumerable<Funcionario> BuscarTodosFunc()
        {
            SqlConnection connection = (SqlConnection)new DbConnection().GetConnection();
            return connection.Query<Funcionario>(@"SELECT * FROM FUNCIONARIO");
        }
    }
}
