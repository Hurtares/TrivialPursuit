using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrivialPursuit
{
    public class Pergunta
    {
        public int cod_pergun;
        public enum Categoria
        {
            Ciencias_Natureza,
            Desporto_lazer,
            Pessoas_Lugares,
            Artes_Entertenimento,
            Historia,
            Variados
        }
        public Casa.Cor Cor;
        public string Questao;
        public string opc_A;
        public string opc_B;
        public string opc_C;
        public string opc_D;
        public int opcCorreta;
        public int resp;

        public Pergunta() { }
    }
}
