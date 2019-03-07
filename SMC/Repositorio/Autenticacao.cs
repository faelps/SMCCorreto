using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SMC.Repositorio
{
    public class Autenticacao
    {

        public void Inserir() {
        }

        public void Update() {

        }

        public void Deletar() {

        }

        public void BuscarPorLogin() {
        }

        public void BuscarPorId() {

        }

        //Incluindo criptografia MD5 na senha
        public string PegaMD5Hash(string senha) {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] senhaBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(senhaBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++){
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}