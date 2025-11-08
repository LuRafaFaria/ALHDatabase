using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALHDatabase
{
    public partial class LogIn : Form
    {
        public static string id, email, nome, password, pais;

        AcessDB objAcessDB = new AcessDB();

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        DataTable dtUtilizadores = new DataTable();


        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string uEmailL = textEmailL.Text;
            string uPasswordL = textPasswordL.Text;

            if (uEmailL.Equals(""))
            {
                MessageBox.Show("O campo Email é para ser preenchido!");
            }

            else if (uPasswordL.Equals(""))
            {
                MessageBox.Show("O campo Password é para ser preenchido!");
            }

            else
            {
                string query = "Select * from Utilizadores Where Email= '" + uEmailL + "' AND Password = '" + uPasswordL + "'";

                //lê em sequencia os dados
                objAcessDB.readDatathroughAdapter(query, dtUtilizadores);

                if (dtUtilizadores.Rows.Count == 1)
                {

                    id = dtUtilizadores.Rows[0]["ID"].ToString();
                    email = dtUtilizadores.Rows[0]["Email"].ToString();
                    nome = dtUtilizadores.Rows[0]["Nome"].ToString();
                    password = dtUtilizadores.Rows[0]["Password"].ToString();
                    pais = dtUtilizadores.Rows[0]["Pais"].ToString();

                    MessageBox.Show("Login com sucesso");

                    objAcessDB.closeConn();

                    this.Hide();
                    PaginaInicial pI = new PaginaInicial();
                    pI.Show();
                }
                else
                {
                    MessageBox.Show("Email ou Password incorretos");
                }
            }
        }

        private void labelCriarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo registo = new Registo();
            registo.Show();
        }
    }
}
