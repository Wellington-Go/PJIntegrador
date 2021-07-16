using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJIntegrador.classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string Senha { get; set; }

        //=========================================================================
        public Cliente()
        { }

        public Cliente(string nome, string cpf, string email, string telefone, string senha, bool ativo = true, List<Endereco> enderecos = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Ativo = ativo;
            Enderecos = enderecos;
            Senha = senha;
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, string senha, bool ativo = true, List<Endereco> enderecos = null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Ativo = ativo;
            Enderecos = enderecos;
            Senha = senha;
        }
        //===================================================================================Metodo
        public static List<Cliente> ListarTodos() // LISTAR CLIENTE - INICIO
        {
            List<Cliente> lista = new List<Cliente>();
            string query = "select * from cliente";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(6),
                    dr.GetBoolean(5),
                    Endereco.ListaEnderecos(dr.GetInt32(0))
                ));
            }
            return lista;
        }

        //========================================================================== LISTAR CLIENTE - FIM
        public void BuscarPorId(int id) // BUSCAR ID - INICIO
        {
            string query = "select * from cliente where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString(1);
                Cpf = dr.GetString(2);
                Email = dr.GetString(3);
                Telefone = dr.GetString(4);
                Ativo = dr.GetBoolean(5);
                Senha = dr.GetString(6);
                Enderecos = Endereco.ListaEnderecos(id);
            }
        }
    }
}
