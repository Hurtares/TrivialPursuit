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
    public partial class Form1 : Form
    {
        int num_jogadores;
        public Form1()
        {
            num_jogadores = LogIn.jogadores;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Pergunta_form novaPergunta = new Pergunta_form(3);
            novaPergunta.Show();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Tabuleiro.desenhaTabuleiro(g);
            for (int i = 0; i < num_jogadores; i++)
            {
                Jogador.desenharJogador(g, i);
                Jogador.desenharEstrela(g, i);
            }
            
            Dado.desenharDado(g,Dado.gerarDado());
            this.pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            tabuleiro.test();
            Jogo.andar(1,0);
        }


    }
}
