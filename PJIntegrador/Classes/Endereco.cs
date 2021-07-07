using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJIntegrador.Classes
{
    public class Endereco
    {
        private readonly int idCliente;
        public int IdCliente { get { return idCliente; } }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { set; get; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        //=======================================================construtor

        public Endereco() {}

        public Endereco(string cep, string logradouro, string numero, string complemento, string tipo, string cidade, string bairro, string uf = null)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Tipo = tipo;
            Cidade = cidade;
            Bairro = bairro;
            Uf = uf; // nulo
        }

        public Endereco(int idCliente, string cep, string logradouro, string numero, string complemento, string tipo, string cidade, string bairro, string uf)
        {
            this.idCliente = idCliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Tipo = tipo;
            Cidade = cidade;
            Bairro = bairro;
            Uf = uf;
        }

        //=======================================================metodo

        public void Inserir() { }
    }
}
