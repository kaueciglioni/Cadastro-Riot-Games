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
    public partial class PaginaPrincipal : Form
    {
        //Instancia dos objetos
        Riot cadastro = new Riot();
        Consutar consulta = new Consutar();
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre o cadastro
            this.Hide();
            cadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abre o consulta
            this.Hide();
            consulta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botão de sair
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
