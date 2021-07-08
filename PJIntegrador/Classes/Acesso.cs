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
        public string Cpf { get; set; }
        public Acesso()
        {
        }
        public Acesso(string senha, string cpf)
        {
            Senha = senha;
            Cpf = cpf;
        }
        public Acesso(int id,string senha, string cpf)
        {
            this.ID = id;
            Senha = senha;
            Cpf = cpf;
        }
        public void Inserir()
        {

        }
        public void Consultar(int _id)
        {
            
        }


    }
}
