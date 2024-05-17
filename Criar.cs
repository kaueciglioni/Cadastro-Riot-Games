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
    public partial class Riot : Form
    {
        Cadastro cadastro = new Cadastro(); // Instanciando objeto
        public Riot()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Riot_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão de voltar
            PaginaPrincipal telaPrincipal = new PaginaPrincipal();

            this.Close();
            telaPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Colocando valores nos sets

            cadastro.setNome(nomeBox.Text);
            cadastro.setSobrenome(sobrenomeBox.Text);
            cadastro.setCPf(cpfBox.Text);
            cadastro.setUsername(usernameBox.Text);
            cadastro.setEmail(emailBox.Text);
            cadastro.setSenha(senhaBox.Text);
            cadastro.setConfirmaSenha(confirmaSenhaBox.Text);
            cadastro.setIdade(int.Parse(idadeBox.Text));
            cadastro.setSexo(sexoBox.Text);
            cadastro.setJogoFavorito(jogoFavoritoBox.Text);
            cadastro.setJogaQuantoTempo(int.Parse(jogaQuantoTempoBox.Text));
            cadastro.setCelular(celularBox.Text);
            cadastro.setTelefone(telefoneBox.Text);

            MessageBox.Show("Dados cadastrados com sucesso [OBJETO]", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Banco de dados
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=riot_bd; password=''");
            MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO cadastro(nome, sobrenome, cpf, username, email, senha, idade, sexo, jogoFavorito, jogaQuantoTempo, celular, telefone)" +
                                                $"VALUES('{cadastro.getNome()}', '{cadastro.getSobrenome()}', '{cadastro.getCPf()}', '{cadastro.getUsername()}', '{cadastro.getEmail()}'," +
                                                $"'{cadastro.getSenha()}', {cadastro.getIdade()}, '{cadastro.getSexo()}', '{cadastro.getJogoFavorito()}', {cadastro.getJogaQuantoTempo()}, '{cadastro.getCelular()}', '{cadastro.getTelefone()}');",
                                                      conexao);
            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();
                MessageBox.Show("Dados armazenados com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            PaginaPrincipal telaPrincipal = new PaginaPrincipal(); // Instanciando a tela principal

            // Retorna para inicio
            telaPrincipal.Show();
            this.Close();
        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
