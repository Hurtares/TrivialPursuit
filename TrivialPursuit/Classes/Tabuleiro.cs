using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrivialPursuit
{
    public class Tabuleiro
    {

        public Casa[] casa= new Casa[73];
        #region criar_Tabuleiro
        public Tabuleiro(){
            for (int i = 0; i < 73; i++)
            {
                casa[i] = new Casa();
                casa[i].numero = i ;
            }

            // colorir
            //parte exterior do tabuleiro
            for (int i = 0; i < 42; i++)
            { 
                
                // casas especiais
                if (i % 7 == 0)
                {
                    Casa.Cor aux = Casa.Cor.Verde;
                    casa[i].cor = aux + (i / 7);
                }
                // casas a beira das especiais
                if ((i - 1 ) % 7 == 0)
                {
                    Casa.Cor aux = Casa.Cor.Vermelho;
                    if (aux + ((i - 1) / 7) >= Casa.Cor.Branco)
                    {
                        casa[i].cor = Casa.Cor.Verde + ((i - 21) / 7);
                        casa[i - 2].cor = casa[i].cor;
                    }
                    else
                    {

                        casa[i].cor = aux + ((i - 1) / 7);
                        if (i == 1) { casa[i + 40].cor = aux + ((i - 1) / 7); }
                        else { casa[i - 2].cor = aux + ((i - 1) / 7); }
                    }
                }
                // casas joga outra vez
                if ((i - 2) % 7 == 0)
                {
                    casa[i].cor = Casa.Cor.Branco;
                    casa[i + 3].cor = Casa.Cor.Branco;
                }
                // casas no meio do circulo parte 1
                if ((i - 3) % 7 == 0)
                {
                    Casa.Cor aux = Casa.Cor.Azul;
                    if (aux + ((i - 3) / 7) >= Casa.Cor.Branco)
                    {
                        casa[i].cor = Casa.Cor.Verde + ((i - 31) / 7);
                    }
                    else
                    {
                        casa[i].cor = aux + ((i - 3) / 7);
                    }
                }
                //casas no meio do circulo parte 2
                if ((i - 4) % 7 == 0)
                {
                    Casa.Cor aux = Casa.Cor.Roxo;
                    if (aux + ((i - 3) / 7) >= Casa.Cor.Branco)
                    {
                        casa[i].cor = Casa.Cor.Verde + ((i - 5) / 7);
                    }
                    else
                    {
                        casa[i].cor = aux + ((i - 4) / 7);
                    }
                }
                
            }
            //parte interior do tabuleiro
            colorir(57,0);
            colorir(52,1);
            colorir(62,2);
            colorir(67,3);
            colorir(47,4);

            //casa central
            casa[72].cor = Casa.Cor.AzulEscuro;

            //casas adjacentes
            //parte exterior
            for (int i = 1; i < 42; i++)
            {
                if (i % 7 == 0) casa[i].casaAdjacente = new int[3];
                else { casa[i].casaAdjacente = new int[2]; }
                casa[i].casaAdjacente[0] = casa[i - 1].numero;
                casa[i].casaAdjacente[1] = casa[i + 1].numero;
            }
            casa[41].casaAdjacente[1] = 0;
            //casas especiais
            //casa numero 0
            casa[0].casaAdjacente = new int[3];

            for (int i = 0; i < 6; i++)
            {
                casa[i * 7].casaAdjacente[2] = 42 + (5 * i);
            }
            casa[0].casaAdjacente[0] = 41;
            casa[0].casaAdjacente[1] = 1;
            casa[0].casaAdjacente[2] = 42;
            //casas interiores
            for (int i = 42; i < 72; i++)
            {
                casa[i].casaAdjacente = new int[2];
            }
            casasAdjacentes(42, 0);
            casasAdjacentes(47, 7);
            casasAdjacentes(52, 14);
            casasAdjacentes(57, 21);
            casasAdjacentes(62, 28);
            casasAdjacentes(67, 35);
            
            //casa central
            casa[72].cor = Casa.Cor.AzulEscuro;
            casa[72].casaAdjacente = new int[6];
            for (int i = 0; i < 6; i++)
            {
                casa[72].casaAdjacente[i] = 41 + (5 * (i+1));
            }


            //falta as posicoes de cada casa X,Y
            casa[0].pos_x = 450;
            casa[0].pos_y = 130;
            casa[1].pos_x = 490;
            casa[1].pos_y = 160;
            casa[2].pos_x = 510;
            casa[2].pos_y = 180;
            casa[3].pos_x = 530;
            casa[3].pos_y = 200;
            casa[4].pos_x = 540;
            casa[4].pos_y = 230;
            casa[5].pos_x = 550;
            casa[5].pos_y = 260;
            casa[6].pos_x = 560;
            casa[6].pos_y = 290;
            casa[7].pos_x = 560;
            casa[7].pos_y = 330;
            casa[8].pos_x = 560;
            casa[8].pos_y = 370;
            casa[9].pos_x = 550;
            casa[9].pos_y = 400;
            casa[10].pos_x = 540;
            casa[10].pos_y = 430;
            casa[11].pos_x = 530;
            casa[11].pos_y = 460;
            casa[12].pos_x = 510;
            casa[12].pos_y = 490;
            casa[13].pos_x = 490;
            casa[13].pos_y = 510;
            casa[14].pos_x = 450;
            casa[14].pos_y = 520;
            casa[15].pos_x = 410;
            casa[15].pos_y = 540;
            casa[16].pos_x = 380;
            casa[16].pos_y = 550;
            casa[17].pos_x = 350;
            casa[17].pos_y = 560;
            casa[18].pos_x = 320;
            casa[18].pos_y = 560;
            casa[19].pos_x = 290;
            casa[19].pos_y = 550;
            casa[20].pos_x = 260;
            casa[20].pos_y = 550;
            casa[21].pos_x = 220;
            casa[21].pos_y = 530;
            casa[22].pos_x = 180;
            casa[22].pos_y = 500;
            casa[23].pos_x = 160;
            casa[23].pos_y = 480;
            casa[24].pos_x = 140;
            casa[24].pos_y = 460;
            casa[25].pos_x = 130;
            casa[25].pos_y = 430;
            casa[26].pos_x = 120;
            casa[26].pos_y = 400;
            casa[27].pos_x = 120;
            casa[27].pos_y = 370;
            casa[28].pos_x = 110;
            casa[28].pos_y = 330;
            casa[29].pos_x = 120;
            casa[29].pos_y = 290;
            casa[30].pos_x = 120;
            casa[30].pos_y = 260;
            casa[31].pos_x = 130;
            casa[31].pos_y = 230;
            casa[32].pos_x = 150;
            casa[32].pos_y = 200;
            casa[33].pos_x = 170;
            casa[33].pos_y = 180;
            casa[34].pos_x = 190;
            casa[34].pos_y = 160;
            casa[35].pos_x = 230;
            casa[35].pos_y = 130;
            casa[36].pos_x = 260;
            casa[36].pos_y = 120;
            casa[37].pos_x = 290;
            casa[37].pos_y = 110;
            casa[38].pos_x = 320;
            casa[38].pos_y = 100; 
            casa[39].pos_x = 350;
            casa[39].pos_y = 100;
            casa[40].pos_x = 380;
            casa[40].pos_y = 100;
            casa[41].pos_x = 410;
            casa[41].pos_y = 110;
            casa[42].pos_x = 430;
            casa[42].pos_y = 170;
            casa[43].pos_x = 410;
            casa[43].pos_y = 200;
            casa[44].pos_x = 390;
            casa[44].pos_y = 230;
            casa[45].pos_x = 370;
            casa[45].pos_y = 260;
            casa[46].pos_x = 360;
            casa[46].pos_y = 280;
            casa[47].pos_x = 520;
            casa[47].pos_y = 330;
            casa[48].pos_x = 490;
            casa[48].pos_y = 330;
            casa[49].pos_x = 450;
            casa[49].pos_y = 330;
            casa[50].pos_x = 420;
            casa[50].pos_y = 330;
            casa[51].pos_x = 390;
            casa[51].pos_y = 330;
            casa[52].pos_x = 420;
            casa[52].pos_y = 490;
            casa[53].pos_x = 400;
            casa[53].pos_y = 470;
            casa[54].pos_x = 390;
            casa[54].pos_y = 440;
            casa[55].pos_x = 380;
            casa[55].pos_y = 410;
            casa[56].pos_x = 360;
            casa[56].pos_y = 380;
            casa[57].pos_x = 240;
            casa[57].pos_y = 490;
            casa[58].pos_x = 260;
            casa[58].pos_y = 470;
            casa[59].pos_x = 270;
            casa[59].pos_y = 440;
            casa[60].pos_x = 290;
            casa[60].pos_y = 410;
            casa[61].pos_x = 310;
            casa[61].pos_y = 380;
            casa[62].pos_x = 150;
            casa[62].pos_y = 330;
            casa[63].pos_x = 180;
            casa[63].pos_y = 330;
            casa[64].pos_x = 210;
            casa[64].pos_y = 330;
            casa[65].pos_x = 240;
            casa[65].pos_y = 330;
            casa[66].pos_x = 270;
            casa[66].pos_y = 330;
            casa[67].pos_x = 250;
            casa[67].pos_y = 180;
            casa[68].pos_x = 260;
            casa[68].pos_y = 210;
            casa[69].pos_x = 280;
            casa[69].pos_y = 230;
            casa[70].pos_x = 290;
            casa[70].pos_y = 250;
            casa[71].pos_x = 300;
            casa[71].pos_y = 280;
            casa[72].pos_x = 330;
            casa[72].pos_y = 330; 
        }
        
        private void casasAdjacentes(int inicio, int especial)
        {
            casa[inicio].casaAdjacente[0] = especial;
            casa[inicio].casaAdjacente[1] = inicio + 1;
            for (int i = 1; i < 5; i++)
            {
                casa[i + inicio].casaAdjacente[0] = inicio + i - 1;
                casa[i + inicio].casaAdjacente[1] = inicio + i + 1;
            }
            casa[inicio + 4].casaAdjacente[1] = 72;
        }

        private void colorir(int inicio, int offset)
        {
            int aux = inicio + offset;
            for (int i = 0; i < 6; i++)
            {
                if (aux > 71) aux = 42 + offset;
                casa[aux].cor = Casa.Cor.Verde + i;
                aux = aux + 5;
            }
        }
        #endregion
        public void test()
        {
            for (int i = 0; i < 72; i++)
            {
                Console.Write(casa[i].numero +" ");
                Console.Write(casa[i].cor + " " + casa[i].casaAdjacente[0] + " " + casa[i].casaAdjacente[1]);
                if (i % 7 == 0 && i<42)
                {
                    Console.Write(" " + casa[i].casaAdjacente[2]); 
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write(casa[72].casaAdjacente[i] + " ");
            }
            
        }

        public static void desenhaTabuleiro(Graphics g)
        {
            Bitmap tabuleiro = new Bitmap("../../Imagens/ImagemPrincipal.png");

            g.DrawImage(tabuleiro, 0,0);
        }

    }
}
