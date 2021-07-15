using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace PJIntegrador.classes
{
    public static class Banco // classse publica
    {
        /// <summary>
        /// abre uma conexão para um banco de dados mysql
        /// </summary>
        /// <returns>objeto de comandos mysql</returns>
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strConn = @"server=127.0.0.1;database=bancopi;user id=root;password=usbw;port=3307";
            MySqlConnection cn = new MySqlConnection(strConn);
            try // tratamento de exceções do C#
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                    cmd.Connection = cn;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return cmd;
            
        }
    }
}
