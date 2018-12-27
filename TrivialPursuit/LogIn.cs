using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrivialPursuit
{
    public partial class LogIn : Form
    {
        public static int jogadores=0;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[4];
            int i=0;
            if (textBox1.Text != "") jogadores++;
            if (textBox2.Text != "") jogadores++;
            if (textBox3.Text != "") jogadores++;
            if (textBox4.Text != "") jogadores++;

            Jogo.gerarJogadores(jogadores);

            if (textBox1.Text != "") { nomes[i] = textBox1.Text; i++; }
            if (textBox2.Text != "") { nomes[i] = textBox2.Text; i++; }
            if (textBox3.Text != "") { nomes[i] = textBox3.Text; i++; }
            if (textBox4.Text != "") { nomes[i] = textBox4.Text; i++; }

            for (int j = 0; j < jogadores; j++)
            {
                Jogo.jogador[j].nome = nomes[j];
            }
            Form1 Jogo1 = new Form1();
            Jogo1.Show();
            this.Hide();

        }
    }
}
