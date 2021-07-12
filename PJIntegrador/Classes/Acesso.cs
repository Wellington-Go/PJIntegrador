using MySql.Data.MySqlClient;

namespace PJIntegrador.classes
{
    public class Acesso
    {   /* paramentros*/

        public int Id { get; set; } 
        public string Cpf { get; set; }
        public string Senha { get; set; }
        /*public int idUsuario { get; set; }
        public int idCliente { get; set; }*/
        

        // criaçao do métodos

        public Acesso(int id,string senha, string cpf)
        {
            this.Id = id;
            Cpf = cpf;
            Senha = senha;
            /*this.idUsuario = idUsuario;
            this.idCliente = idCliente;*/

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
            /*idUsuario = (int)cmd.ExecuteScalar();
            idCliente = (int)cmd.ExecuteScalar();*/




        }



    }
}
