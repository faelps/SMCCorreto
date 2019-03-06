using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Npgsql;
using System.Configuration;

namespace SMC.Repositorio
{
    public class Conexao
    {
       

        //Conexao ao Banco
        public static NpgsqlConnection Conectar() {
            //parametros de conexao ao banco
            string conexString = ConfigurationManager.ConnectionStrings["ConexaoBanco"].ConnectionString;
            //Instanciando nova conexao
            NpgsqlConnection con = new NpgsqlConnection(conexString);
            //Abrindo conexao
            con.Open();
            return con;
        }
        //Comando CRUD pré-definido
        public static void CRUD(NpgsqlCommand cmd) {
            //Abre nova conexao
            NpgsqlConnection con = Conectar();
            cmd.Connection = con;
            //Executa a query
            cmd.ExecuteNonQuery();
            //Fecha conexao
            con.Close();
        }

        //Comando generico de select
        public static NpgsqlDataReader Selecionar(NpgsqlCommand cmd) {
            NpgsqlConnection con = Conectar();
            cmd.Connection = con;
            NpgsqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

    }
}