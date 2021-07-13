using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PJIntegrador.classes;

namespace PJIntegrador.classes
{
    public class Servicos
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdAcesso { get; set; }
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        //=======================================================

        public Servicos() { }

        public Servicos(string descricao, double valor, DateTime data, int idServico, int idCliente, int idFuncionario)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
            this.IdAcesso = idServico;
            this.IdCliente = idCliente;
            this.IdFuncionario = idFuncionario;
        }

        public Servicos(int iD, string descricao, double valor, DateTime data, int idServico, int idCliente, int idFuncionario)
        {
            ID = iD;
            Descricao = descricao;
            Valor = valor;
            Data = data;
            this.IdAcesso = idServico;
            this.IdCliente = idCliente;
            this.IdFuncionario = idFuncionario;
        }
        //=====================================================
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "";

                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
            }
        }
    }
}
