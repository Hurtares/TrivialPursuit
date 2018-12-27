using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrivialPursuit
{
    
    public class Casa
    {
        public enum Cor
        {
            Verde,
            Laranja,
            Azul,
            Vermelho,
            Amarelo,
            Roxo,
            Branco,
            AzulEscuro
        };   
        private string teste = "teste";
        public int numero;
        public int[] casaAdjacente;
        public int pos_x;
        public int pos_y;
        public Cor cor;
        
        public Casa()
        {
            

        }
        public string getTeste()
        {
            return teste;
        }
        

    }
}
