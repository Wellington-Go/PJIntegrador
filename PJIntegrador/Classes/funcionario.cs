using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJIntegrador.Classes;

namespace PJIntegrador.Classes
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }


        //=================================================construtor
        public Funcionario() { }

        public Funcionario(string nome, string email, string telefone, string cPF, string senha, bool ativo = true)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cPF;
            Senha = senha;
            Ativo = ativo;
        }

        public Funcionario(int id, string nome, string email, string telefone, string cPF, string senha, bool ativo = true)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cPF;
            Senha = senha;
            Ativo = ativo;
        }
        //=================================================metodo
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert " +
                    "funcionario(nome, email, telefone, cpf, senha, ativo) " +
                    "values ('" + Nome + "','" + Email + "','" + Telefone + "','" + CPF + "','" + Senha + "',default);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        //=================================================Fim Inserir
        public void BuscarPorId()
        {

        }
    }
}
