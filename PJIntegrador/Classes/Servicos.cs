using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJIntegrador.Classes
{
    public class Servicos
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public DateTime Data { get; set; }

        public int idServico { get; set; }

        public Servicos()
        {
        }

        public Servicos(string descricao, double valor, DateTime data, int idServico)
        {
            Descricao = descricao;
            Valor = valor;
            Data = data;
            this.idServico = idServico;
        }

        public Servicos(int iD, string descricao, double valor, DateTime data, int idServico)
        {
            ID = iD;
            Descricao = descricao;
            Valor = valor;
            Data = data;
            this.idServico = idServico;
        }

    }
}
