using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsADONet;

namespace DesafioCriptografia
{
    class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }



        public bool inserirUsuario()
        {

            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into usuarioCripto " + " values (@nome, @email, @senha);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@senha", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = email;
            command.Parameters[2].Value = senha;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }

            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }



        }

        public bool verifica(string nome, string senha)
        {
            Banco bd = new Banco();
            string user, pass; 
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select nome, senha from usuarioCripto where nome = @nome and senha = @senha",cn);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@senha", senha);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = reader[0].ToString();
                    pass = reader[1].ToString();
                    if (user == nome && pass == senha)
                    {
                        MessageBox.Show("Login Efetuado com sucesso");
                    }
                }

                else
                {
                    MessageBox.Show("Super Erro");
                }
                

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de Login");

                return false;

            }
            finally
            {
                bd.fecharConexao();
            }
        }


    }
}
