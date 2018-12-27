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
    public partial class Pergunta_form : Form
    {
        int numPergunta;
        public Pergunta_form(int codigo)
        {
            Jogo conv = new Jogo();
            numPergunta = codigo;
            InitializeComponent();
            categoria.Text = conv.Categoria_Cor(Jogo.pergunta[codigo].Cor).ToString();
            Questao1.Text = Jogo.pergunta[codigo].Questao;
            resp_A.Text = Jogo.pergunta[codigo].opc_A;
            resp_B.Text = Jogo.pergunta[codigo].opc_B;
            resp_C.Text = Jogo.pergunta[codigo].opc_C;
            resp_D.Text = Jogo.pergunta[codigo].opc_D;
            
        }

        private void resp_A_Click(object sender, EventArgs e)
        {
            Jogo.pergunta[numPergunta].resp = 1;
            if (Jogo.pergunta[numPergunta].opcCorreta == 1) Console.WriteLine("Certo");
            else{Console.WriteLine("Errado");}
            this.Close();
        }

        private void resp_B_Click(object sender, EventArgs e)
        {
            Jogo.pergunta[numPergunta].resp = 2;
            if (Jogo.pergunta[numPergunta].opcCorreta == 2) Console.WriteLine("Certo");
            else{Console.WriteLine("Errado");}
            this.Close();
        }

        private void resp_C_Click(object sender, EventArgs e)
        {
            Jogo.pergunta[numPergunta].resp = 3;
            if (Jogo.pergunta[numPergunta].opcCorreta == 3) Console.WriteLine("Certo");
            else{Console.WriteLine("Errado");}
            this.Close();
        }

        private void resp_D_Click(object sender, EventArgs e)
        {
            Jogo.pergunta[numPergunta].resp = 4;
            if (Jogo.pergunta[numPergunta].opcCorreta == 4) Console.WriteLine("Certo");
            else { Console.WriteLine("Errado"); }
            this.Close();
        }
    }
}
