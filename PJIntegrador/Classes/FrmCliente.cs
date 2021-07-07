using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJIntegrador.Classes
{
    public class FrmCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public bool Ativo { get; set; }
        //=============================================construtor
        public FrmCliente() { }

        public FrmCliente(string nome, string cPF, string email, string telefone, List<Endereco> enderecos, bool ativo = true)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
            Enderecos = enderecos;
            Ativo = ativo;
        }

        public FrmCliente(int id, string nome, string cPF, string email, string telefone, List<Endereco> enderecos, bool ativo = true)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
            Enderecos = enderecos;
            Ativo = ativo;
        }
        //=============================================metodo
        public void Inserir()
        {

        }
        //=============================================FIM INSERIR

    }
}
