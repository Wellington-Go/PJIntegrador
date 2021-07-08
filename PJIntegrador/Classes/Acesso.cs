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
        public string Cpf { get; set; }
        public string Senha { get; set; }
       
       
        

        public Acesso()
        {
        }
        public Acesso(string cpf,string senha)
        { 
            Cpf = cpf;
            Senha = senha;
            
           
           
        }
        public Acesso(int id,string senha, string tipo, string cpf, int idUsuario, int idCliente)
        {
            this.ID = id;
            Cpf = cpf;
            Senha = senha;
            
            
            
        }
        public void Logar()
        {

        }
        


    }
}
