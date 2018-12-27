using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrivialPursuit
{
    public static class Dado
    {

        public static int gerarDado()
        {
            Random rand = new Random();
            int numero = rand.Next(1, 6);
            // randomizar um numero
            return numero;
        }

        public static void desenharDado(Graphics g,int numero)
        {

            switch (numero)
            {
                case 1: desenharBitmap(g,"Dado1.png");
                    break;
                case 2: desenharBitmap(g,"Dado2.png");
                    break;
                case 3: desenharBitmap(g,"Dado3.png");
                    break;
                case 4: desenharBitmap(g,"Dado4.png");
                    break;
                case 5: desenharBitmap(g,"Dado5.png");
                    break;
                case 6: desenharBitmap(g,"Dado6.png");
                    break;
                default: break;

            }
        }
        private static void desenharBitmap(Graphics g,string nome)
        {
            Bitmap jogador = new Bitmap("../../Imagens/" + nome);

            g.DrawImage(jogador, 545,525 );
        }
    }
}
