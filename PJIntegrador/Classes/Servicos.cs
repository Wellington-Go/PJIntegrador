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
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public string Valor { get; set; }
        //=======================================================

        public Servicos() { }

        public Servicos(string descricao, DateTime data, int idCliente, string valor = null)
        {
            Descricao = descricao;
            Data = data;
            this.IdCliente = idCliente;
            Valor = valor;
        }

        public Servicos(int iD, string descricao, DateTime data, int idCliente, string valor = null)
        {
            ID = iD;
            Descricao = descricao;
            Data = data;
            this.IdCliente = idCliente;
            Valor = valor;
        }
        //=====================================================
        public void BuscarPorId(int id)
        {
            string query = "select * from servico where id = " + id;
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr.GetInt32(0);
                Descricao = dr.GetString(1);
                Data = dr.GetDateTime(2);
                IdCliente = dr.GetInt32(3);
                Valor = dr.GetString(4);
            }
        }
        //=======================================================
        public static List<Servicos> ListarTodos() // LISTAR USUARIO - INICIO
        {
            List<Servicos> lista = new List<Servicos>();
            string query = "select * from servico";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Servicos(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetInt32(3),
                    dr.GetString(4)
                ));
            }
            return lista;
        }
        //====================================================================
        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update servico set " +
                "descricao = '" + Descricao + "', " +
                "data = '" + Data + "', " +
                "Cliente_id = '" + IdCliente + "', " +
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
