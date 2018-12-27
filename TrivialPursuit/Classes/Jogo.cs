using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrivialPursuit
{
    public class Jogo
    {
        public static Pergunta[] pergunta = new Pergunta[12];
        public static Jogador[] jogador = new Jogador[4];
        public void NovoJogo()
        {

            Tabuleiro tabuleiro = new Tabuleiro();
            tabuleiro.test();
            Form1 Jogo = new Form1();
            Jogo.Show();
        }

        public static void andar(int num_jogador,int decisao)
        {
            Tabuleiro tabul = new Tabuleiro();
            if (tabul.casa[Jogo.jogador[num_jogador].casa-1].cor != Casa.Cor.Branco)
            {
                gerarPerguntas();
                int num = (int)tabul.casa[Jogo.jogador[num_jogador].casa].cor;
                Pergunta_form novaPergunta = new Pergunta_form(num);
                novaPergunta.Show();
            }
            // se estiver numa casa especial
            if (Jogo.jogador[num_jogador].casa == 0 || Jogo.jogador[num_jogador].casa == 7 || Jogo.jogador[num_jogador].casa == 15 || Jogo.jogador[num_jogador].casa == 21 || Jogo.jogador[num_jogador].casa == 28 || Jogo.jogador[num_jogador].casa == 35)
            {
                Jogo.jogador[num_jogador].casa = tabul.casa[Jogo.jogador[num_jogador].casa].casaAdjacente[Jogo.jogador[num_jogador].direcao];
            }
            Jogo.jogador[num_jogador].casa = tabul.casa[Jogo.jogador[num_jogador].casa].casaAdjacente[Jogo.jogador[num_jogador].direcao];
        }

        public static void Casa_Jogador(int num_jogador)
        {
            Tabuleiro dasdsa = new Tabuleiro();
            Console.WriteLine(jogador[num_jogador].nome + " " + jogador[num_jogador].casa + " " + dasdsa.casa[jogador[num_jogador].casa].cor);
         }

        //Converte cor em categoria
        public Pergunta.Categoria Categoria_Cor(Casa.Cor cor)
        {
            Pergunta.Categoria categoria = new Pergunta.Categoria();
            switch (cor)
            {
                case Casa.Cor.Verde: categoria = Pergunta.Categoria.Ciencias_Natureza;
                    break;
                case Casa.Cor.Laranja: categoria = Pergunta.Categoria.Desporto_lazer;
                    break;
                case Casa.Cor.Azul: categoria = Pergunta.Categoria.Pessoas_Lugares;
                    break;
                case Casa.Cor.Vermelho: categoria = Pergunta.Categoria.Artes_Entertenimento;
                    break;
                case Casa.Cor.Amarelo: categoria = Pergunta.Categoria.Historia;
                    break;
                case Casa.Cor.Roxo: categoria = Pergunta.Categoria.Variados;
                    break;
                default: break;
            }
            return categoria;
        }
        // Cria os jogadores nessessarios
        public static void gerarJogadores(int numJogadores)
        {
            for (int i = 0; i < numJogadores; i++)
            {
                jogador[i] = new Jogador();
                jogador[i].num_jogador = i;
                if (i <= 1)
                {
                    jogador[i].desenhoPos_x = 10;
                    jogador[i].desenhoPos_y = 10 + i * 70;
                }
                else
                {
                    jogador[i].desenhoPos_x = 10 + 500;
                    jogador[i].desenhoPos_y = 10 + (i-2) * 70;
                }
            }
            // codigo de teste
            jogador[0].categAcertadas[0] = Casa.Cor.Verde;
            jogador[0].categAcertadas[1] = Casa.Cor.Laranja;
            jogador[1].categAcertadas[0] = Casa.Cor.Vermelho;
            jogador[1].categAcertadas[1] = Casa.Cor.Roxo;
            jogador[1].categAcertadas[2] = Casa.Cor.Verde;
            jogador[1].categAcertadas[3] = Casa.Cor.Azul;
            jogador[1].categAcertadas[4] = Casa.Cor.Laranja;
            jogador[1].categAcertadas[5] = Casa.Cor.Amarelo;
            jogador[2].categAcertadas[0] = Casa.Cor.AzulEscuro;
            jogador[1].casa = 4;
            //codigo de teste
        }

        //Cria todas as perguntas
        public static  void gerarPerguntas()
        {
            for (int i = 0; i < 12; i++)
            {
                pergunta[i] = new Pergunta();
                pergunta[i].cod_pergun = i;
                pergunta[i].Questao = "Isto é uma pergunta";
                pergunta[i].opc_A = "Errado";
                pergunta[i].opc_B = "Errado";
                pergunta[i].opc_C = "Certo";
                pergunta[i].opc_D = "Errado";
                pergunta[i].opcCorreta = 3;
                pergunta[i].Cor = Casa.Cor.Azul;

            }
            pergunta[0].cod_pergun = 0;
            pergunta[0].Questao = "Como se chama a cria de uma mula?";
            pergunta[0].opc_A = "Mulas sao estéreis";
            pergunta[0].opc_B = "Burro";
            pergunta[0].opc_C = "Ponei";
            pergunta[0].opc_D = "Mula";
            pergunta[0].opcCorreta = 1;
            pergunta[0].Cor = Casa.Cor.Verde;


            pergunta[1].cod_pergun = 1;
            pergunta[1].Questao = "Quantas bolas de ouro tem o Cristiano Ronaldo?";
            pergunta[1].opc_A = "3";
            pergunta[1].opc_B = "4";
            pergunta[1].opc_C = "5";
            pergunta[1].opc_D = "Nenhuma";
            pergunta[1].opcCorreta = 2;
            pergunta[1].Cor = Casa.Cor.Laranja;

            pergunta[2].cod_pergun = 2;
            pergunta[2].Questao = "Qual dos paises nao faz parte da uniao europeia?";
            pergunta[2].opc_A = "Suecia";
            pergunta[2].opc_B = "Suiça";
            pergunta[2].opc_C = "França";
            pergunta[2].opc_D = "Portugal";
            pergunta[2].opcCorreta = 2;
            pergunta[2].Cor = Casa.Cor.Azul;


            pergunta[3].cod_pergun = 3;
            pergunta[3].Questao = "Como se chama o ator principal do Titanic?";
            pergunta[3].opc_A = "Johnny Depp";
            pergunta[3].opc_B = "Bruce Lee";
            pergunta[3].opc_C = "Jim Carrey";
            pergunta[3].opc_D = "Leonardo Deicaprio";
            pergunta[3].opcCorreta = 4;
            pergunta[3].Cor = Casa.Cor.Vermelho;


            pergunta[4].cod_pergun = 4;
            pergunta[4].Questao = "Quando é que portugal aderiu a uniao europeia?";
            pergunta[4].opc_A = "2002";
            pergunta[4].opc_B = "1999";
            pergunta[4].opc_C = "2010";
            pergunta[4].opc_D = "2000";
            pergunta[4].opcCorreta = 2;
            pergunta[4].Cor = Casa.Cor.Amarelo;


            pergunta[5].cod_pergun = 5;
            pergunta[5].Questao = "Qual é a Primeira letra do alfabeto?";
            pergunta[5].opc_A = "C";
            pergunta[5].opc_B = "D";
            pergunta[5].opc_C = "A";
            pergunta[5].opc_D = "T";
            pergunta[5].opcCorreta = 3;
            pergunta[5].Cor = Casa.Cor.Roxo;

        }

    }
}
