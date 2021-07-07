using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJIntegrador.Classes
{
    public class Acesso
    {
        public int ID { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public string Cpf { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }

        public Acesso()
        {
        }
        public Acesso(string senha, string tipo, string cpf, int idUsuario, int idCliente)
        {
            Senha = senha;
            Tipo = tipo;
            Cpf = cpf;
            IdUsuario = idUsuario;
            IdCliente = idCliente;
        }
        public Acesso(int id,string senha, string tipo, string cpf, int idUsuario, int idCliente)
        {
            this.ID = id;
            Senha = senha;
            Tipo = tipo;
            Cpf = cpf;
            IdUsuario = idUsuario;
            IdCliente = idCliente;
        }
        public void Inserir()
        {

        }
        public void Consultar(int _id)
        {
            
        }


    }
}
