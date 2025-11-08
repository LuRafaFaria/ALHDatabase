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
    public partial class PaginaInicial : Form
    {
        AcessDB objDbAcces = new AcessDB();

        public PaginaInicial()
        {
            InitializeComponent();
        }
        
        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            labelInfoPI.Text = "Conta de: " + LogIn.nome;
            textEmailPI.Text = LogIn.email;
            textNomePI.Text = LogIn.nome;
            textPasswordPI.Text = LogIn.password;
            textPaisPI.Text = LogIn.pais;

        }

        private void buttonAtualizarC_Click(object sender, EventArgs e)
        {
            string novoNomeUtilizador = textNomePI.Text;
            string novoEmailUtilizador = textEmailPI.Text;
            string novoPasswordUtilizador = textPasswordPI.Text;
            string novoPaisUtilizador = textPaisPI.Text;

            if (novoNomeUtilizador.Equals(""))
            {
                MessageBox.Show("Por favor escreva o seu nome.");
            }
            else if (novoEmailUtilizador.Equals(""))
            {
                MessageBox.Show("Por favor escreva o seu email.");
            }
            else if (novoPasswordUtilizador.Equals(""))
            {
                MessageBox.Show("Por favor escreva a sua password.");
            }
            else if (novoPaisUtilizador.Equals(""))
            {
                MessageBox.Show("Por favor escreva o seu país.");
            }
            else
            {
                string query = "Update Utilizadores SET Nome '" + @novoNomeUtilizador + "', Email = '" + @novoEmailUtilizador + "', Password = '" + @novoPasswordUtilizador + "', Pais = '" + @novoPaisUtilizador + "' where ID = '" + LogIn.id + "'";

                SqlCommand comandoUpdate = new SqlCommand(query);

                comandoUpdate.Parameters.AddWithValue("@uEmail", @novoEmailUtilizador);
                comandoUpdate.Parameters.AddWithValue("@uNome", @novoNomeUtilizador);
                comandoUpdate.Parameters.AddWithValue("@uPassword", @novoPasswordUtilizador);
                comandoUpdate.Parameters.AddWithValue("@uPais", @novoPaisUtilizador);

                int linha = objDbAcces.executeQuery(comandoUpdate);

                if (linha == 1)
                {
                    MessageBox.Show("Conta atualizada com sucesso");

                    this.Hide();
                    LogIn login = new LogIn();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("ERRO: Por favor tente novamente");
                }
            }
        }

        private void buttonApagarC_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem a certeza?", "Apagar conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog == DialogResult.Yes)
            {
                string query = "DELETE from Utilizadores Where ID = '" + LogIn.id + "'";

                SqlCommand comandoApagar = new SqlCommand(query);

                int linha = objDbAcces.executeQuery(comandoApagar);

                if (linha == 1)
                {
                    MessageBox.Show("Conta apagada com sucesso");

                    this.Hide();
                    LogIn login = new LogIn();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("ERRO: Por favor tente novamente");
                }
            }
        }
    }
}
