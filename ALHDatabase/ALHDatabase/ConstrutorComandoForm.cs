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
    public partial class ConstrutorComandoForm : Form
    {
        AcessDB objDbAcess = new AcessDB();
        DataTable dtUtilizadores = new DataTable();

        public ConstrutorComandoForm()
        {
            InitializeComponent();
        }

        private void ConstrutorComandoForm_Load(object sender, EventArgs e)
        {
            string query = "Select * from Utilizadores";

            objDbAcess.readDatathroughAdapter(query, dtUtilizadores);

            dataGridView1.DataSource = dtUtilizadores;

            objDbAcess.closeConn();
        }

        private void realizarOperBtn_Click(object sender, EventArgs e)
        {
            string query = "Select * from Utilizadores";

            int changes = objDbAcess.executeDataAdapter(dtUtilizadores, query);

            MessageBox.Show("count = " + changes);
        }
    }
}
