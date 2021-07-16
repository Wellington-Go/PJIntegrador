using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJIntegrador.classes
{
    public class Endereco
    {
        private readonly int idCliente;
        public int IdCliente { get { return idCliente; } }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }

        //==========================================================================
        public Endereco()
        { }

        public Endereco(string cep, string logradouro, string numero, string complemento, string tipo, string cidade, string bairro, string uf)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Tipo = tipo;
            Cidade = cidade;
            Bairro = bairro;
            Uf = uf;
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

        //=======================================================================Metodo
        public static List<Endereco> ListaEnderecos(int id = 0, int inicial = 0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>(); // código buscar os endereços
            string query = "";

            if (id > 0)
            {
                query = "select * from endereco where Cliente_id = " + id;
            }
            else if (limit >= 0 && inicial >= 0)
            {
                query = "select * from endereco limit " + limit + "," + limit;
            }

            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                ));
            }
            return lista;
        }
    }
}
