using CriptografiaSimetricaAndAssimetrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsADONet;

namespace DesafioCriptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastroS_Click(object sender, EventArgs e)
        {
            string dadoCripto;
            string msg = txtbox_senha.Text;
            Simetrica s = new Simetrica();

            dadoCripto = s.EncryptData(msg, "atos");
            

            Usuario u = new Usuario();
            u.nome = txtbox_nome.Text;
            u.email = txtbox_email.Text;
            u.senha = dadoCripto;



            bool retorno = u.inserirUsuario();
            if (retorno)
            {
                MessageBox.Show("Dado inserido com sucesso");
            }
            else
            {
                MessageBox.Show("Falhou");
            }

            txtbox_nome.Text = "";
            txtbox_email.Text = "";
            txtbox_senha.Text = "";


        }


        private void btn_cadastroA_Click(object sender, EventArgs e)
        {
            string dadoCripto;
            string msg = txtbox_senha.Text;
            Assimetrica a = new Assimetrica();

            dadoCripto = a.encrypt(msg);


            Usuario u = new Usuario();
            u.nome = txtbox_nome.Text;
            u.email = txtbox_email.Text;
            u.senha = dadoCripto;



            bool retorno = u.inserirUsuario();
            if (retorno)
            {
                MessageBox.Show("Dado inserido com sucesso");
            }
            else
            {
                MessageBox.Show("Falhou");
            }

            txtbox_nome.Text = "";
            txtbox_email.Text = "";
            txtbox_senha.Text = "";


        }


        private void btn_EntrarS_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            Simetrica s = new Simetrica();
            string msgDescripto3;
                        
            msgDescripto3 = s.EncryptData(txB_loginSenha.Text, "atos");
            u.verifica(txB_loginNome.Text, msgDescripto3);



        }



    }
    
}
