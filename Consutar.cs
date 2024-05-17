using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riot
{
    public partial class Consutar : Form
    {
        public Consutar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão de voltar
            PaginaPrincipal telaPrincipal = new PaginaPrincipal();

            this.Close();
            telaPrincipal.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exibir
            dataGridView1.Rows.Clear();

            //Database connection

            //Irá fazer o select e exibir por ordem de nome
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=riot_bd; password=''"); // Conexão - Server: porta / DB
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM cadastro ORDER BY nome", conexao); // Instr. SQL

            try
            {
                conexao.Open(); // Abrir Conexão
                MySqlDataReader datReader = sqlQuery.ExecuteReader(); // Executar os dados

                while (datReader.Read())
                {
                    object[] registro = new object[datReader.FieldCount];

                    // Cabeçalho do DataGrid
                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < datReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(datReader.GetName(i), datReader.GetName(i));

                        }
                    }

                    // Traz o registro.
                    for (int i = 0; i < datReader.FieldCount; i++)
                    {
                        registro[i] = datReader.GetValue(i); // monta o registro.                        
                    }
                    dataGridView1.Rows.Add(registro); // Adiciona a linha
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
