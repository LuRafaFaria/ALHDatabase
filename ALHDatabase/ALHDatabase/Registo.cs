using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ALHDatabase
{
    public partial class Registo : Form
    {
        AcessDB objAcessDB = new AcessDB();

        public Registo()
        {
            InitializeComponent();
        }

        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            //Guardar os dados
            string uEmail = textEmail.Text;
            string uNome = textNome.Text;
            string uPassword = textPassword.Text;
            string uPais = textPais.Text;


            //Verificar que todos os campos foram preenchidos
            if (uEmail.Equals(""))
            {
                MessageBox.Show("O campo EMail é para ser preenchido");
            }

            else if (uNome.Equals(""))
            {
                MessageBox.Show("O campo Nome é para ser preenchido");
            }

            else if(uPassword.Equals(""))
            {
                MessageBox.Show("O campo Password é para ser preenchido");
            }

            else if(uPais.Equals(""))
            {
                MessageBox.Show("O campo Pais é para ser preenchido");
            }

            else
            {
                //Introduz um novo utilizador e envia para a DB de forma segura
                SqlCommand introduzirUtilizador = new SqlCommand("insert into Utilizadores(Email, Nome, Password, Pais) values(@uEmail, @uNome, @uPassword, @uPais)");
                introduzirUtilizador.Parameters.AddWithValue("@uEmail", uEmail);
                introduzirUtilizador.Parameters.AddWithValue("@uNome", uNome);
                introduzirUtilizador.Parameters.AddWithValue("@uPassword", uPassword);
                introduzirUtilizador.Parameters.AddWithValue("@uPais", uPais);

                int linha = objAcessDB.executeQuery(introduzirUtilizador);

                if (linha == 1)
                {
                    MessageBox.Show("Conta criada com sucesso. Por favor faça login agora.");

                    this.Hide();
                    LogIn log = new LogIn();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("ERRO: Por favor tente novamente");
                }
            }
        }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
