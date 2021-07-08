
using MySql.Data.MySqlClient;
using PJIntegrador.classes;

namespace PJIntegrador.Classes
{
    public class Acesso
    {

        public int Id { get; set; } 
        public string Cpf { get; set; }
        public string Senha { get; set; }
       
       
      
       public Acesso(int id,string senha, string cpf)
        {
            this.Id = id;
            Cpf = cpf;
            Senha = senha;

        } 
        public Acesso(string cpf, string senha)
        {
            Cpf = cpf;
            Senha = senha;


        }
        public Acesso()
        {
        }
      
      
        public void Logar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_Logar";
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("select max(id) from cadastro",cmd.Connection);
            Id = (int)cmd.ExecuteScalar();



        }
        


    }
}
