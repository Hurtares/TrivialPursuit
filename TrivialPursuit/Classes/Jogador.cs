using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrivialPursuit
{
    
    public class Jogador
    {
        public int direcao;
        static string dataPath = "../../Imagens/";
        public int num_jogador;
        public int casa;
        public int respCorretas;//
        public int respDadas;//
        public string nome;
        public int num_categAcertadas;//
        public Casa.Cor[] categAcertadas = new Casa.Cor[6];
        public int desenhoPos_x, desenhoPos_y;

        //construtor
        public Jogador()
        {
            direcao = 1;
            num_categAcertadas = 0;
            casa = 72;
            respCorretas = 0;
            respDadas = 0;
            nome = "Sem Nome";
            for (int i = 0; i < 6; i++)
            {
                categAcertadas[i] = Casa.Cor.Branco;
            }
        }

        public static void desenhaTriangulo(Graphics g,int num_jogador)
        {
            Casa.Cor cor;
            for (int i = 0; i < 6; i++)
            {
                cor = Jogo.jogador[num_jogador].categAcertadas[i];
                switch (cor)
                {
                    case Casa.Cor.Verde: desenhaBitmaps(g, num_jogador, "TrianguloVerde.png", 145, 0);
                        break;
                    case Casa.Cor.Laranja: desenhaBitmaps(g, num_jogador, "TrianguloLaranja.png", 105, 30);
                        break;
                    case Casa.Cor.Azul: desenhaBitmaps(g, num_jogador, "TrianguloAzul.png", 65, 30);
                        break;
                    case Casa.Cor.Vermelho: desenhaBitmaps(g, num_jogador, "TrianguloVermelho.png", 145, 30);
                        break;
                    case Casa.Cor.Amarelo: desenhaBitmaps(g, num_jogador, "TrianguloAmarelo.png", 65, 0);
                        break;
                    case Casa.Cor.Roxo: desenhaBitmaps(g, num_jogador, "TrianguloRoxo.png", 105, 0);
                        break;
                    default: break;
                }
            }


        }

        private static void desenhaBitmaps(Graphics g,int num_jogador,string bitmap,int offset_x,int offset_y)
        {
            Bitmap triangulo = new Bitmap(dataPath + bitmap);
            g.DrawImage(triangulo, Jogo.jogador[num_jogador].desenhoPos_x + offset_x, Jogo.jogador[num_jogador].desenhoPos_y + offset_y);
        }

        public static void desenharJogador(Graphics g, int num_jogador)
        {
            Bitmap jogador = new Bitmap("../../Imagens/Gajo.png");

            g.DrawImage(jogador, Jogo.jogador[num_jogador].desenhoPos_x, Jogo.jogador[num_jogador].desenhoPos_y);
            desenhaTriangulo(g, num_jogador);
            escreveTexto(g, num_jogador);
        }

        public static void desenharEstrela(Graphics g, int num_jogador)
        {
            switch (num_jogador)
            {
                case 0: desenharBitmap(g, num_jogador, "estrela1.png");
                    break;
                case 1: desenharBitmap(g, num_jogador, "estrela2.png");
                    break;
                case 2: desenharBitmap(g, num_jogador, "estrela3.png");
                    break;
                case 3: desenharBitmap(g, num_jogador, "estrela4.png");
                    break;
                default: break;
            }
            desenhaTriangulo(g, num_jogador);
        }

        private static void desenharBitmap(Graphics g, int num_jogador, string bitmap)
        {
            Tabuleiro casas = new Tabuleiro();
            Bitmap jogador = new Bitmap("../../Imagens/" + bitmap);

            g.DrawImage(jogador, casas.casa[Jogo.jogador[num_jogador].casa].pos_x, casas.casa[Jogo.jogador[num_jogador].casa].pos_y);
        }
        private static void escreveTexto(Graphics g,int num_jogador)
        {
            Font font = new Font("Arial",10, FontStyle.Bold);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            SolidBrush pincel = new SolidBrush(Color.White);
            Rectangle area = new Rectangle(
                Jogo.jogador[num_jogador].desenhoPos_x ,Jogo.jogador[num_jogador].desenhoPos_y + 45,
                65,
                30);
            //Desenha o texto recebe uma string uma fonte um pincel uma area e um formato
            g.DrawString(Jogo.jogador[num_jogador].nome, font, pincel, area, formato);
        }
    }
}
