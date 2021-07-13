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
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        //=======================================================

        public Servicos() { }

        public Servicos(string descricao, double valor, DateTime data, int idCliente, int idFuncionario)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
            this.IdCliente = idCliente;
            this.IdFuncionario = idFuncionario;
        }

        public Servicos(int iD, string descricao, double valor, DateTime data, int idCliente, int idFuncionario)
        {
            ID = iD;
            Descricao = descricao;
            Valor = valor;
            Data = data;
            this.IdCliente = idCliente;
            this.IdFuncionario = idFuncionario;
        }
        //=====================================================
        public void BuscarPorId(int id)
        {
            string query = "select * from servicoss where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Valor = dr.GetDouble(2);
                Data = dr.GetDateTime(3);
                IdCliente = dr.GetInt32(4);
                IdFuncionario = dr.GetInt32(5);
            }
        }
        //=======================================================
        public static List<Servicos> ListarTodos() // LISTAR USUARIO - INICIO
        {
            List<Servicos> lista = new List<Servicos>();
            string query = "select * from servicos";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servicos(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    dr.GetInt32(4),
                    dr.GetInt32(5)
                ));
            }
            return lista;
        }
        //====================================================================
        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set " +
                "descricao = '" + Descricao + "', " +
                "valor = '" + Valor + "', " +
                "data = '" + Data + "', " +
                "Cliente_id = '" + IdCliente + "', " +
                "funcionario_id = " + IdFuncionario + ", " +
                "where id = " + ID;
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
