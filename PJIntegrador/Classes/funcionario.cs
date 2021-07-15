using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PJIntegrador.classes;
using PJIntegrador.Formulario;

namespace PJIntegrador.classes
{
    public class Funcionario
    {
        public string msg;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public int IdServico { get; set; }
        public bool Ativo { get; set; }

        //=================================================construtor
        public Funcionario() { }

        public Funcionario(string nome, string email, string telefone, string cpf, string senha, int idServico, bool ativo = true)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            Senha = senha;
            IdServico = idServico;
            Ativo = ativo;
        }

        public Funcionario(int id, string nome, string email, string telefone, string cpf, string senha, int idServico, bool ativo = true)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            CPF = cpf;
            Senha = senha;
            IdServico = idServico;
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
                    "funcionario(nome, email, telefone, cpf, senha, ativo, Servico_id) " +
                    "values('"+Nome+"','"+Email+"','"+Telefone+"','"+CPF+"','"+Senha+"',default,"+IdServico+")";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        //====================================================================Fim Inserir

        public void BuscarFun(string _cpf, string _senha)
        // SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE User='" + txtUser.Text + "' AND Pass ='" + txtPass.Text + "'", con);
        {
            string query = "select * from funcionario where cpf = '" + _cpf + "' and senha = '" + _senha + "' ";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                 
               
                frmServicos app = new frmServicos();
                app.Show();
                Principal login = new Principal();
                login.Close();
            }
            else
            {
                msg = "nao encontrado!";
            }
        }
    }
}
