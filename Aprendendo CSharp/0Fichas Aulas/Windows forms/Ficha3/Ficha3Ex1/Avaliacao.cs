using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha3Ex1 {
    public class Avaliacao {

        static public string avaliacao(int soma) {
            string mensagem = "";

            if (soma < 6)
            {
                mensagem = "Fraco";
            } else if (soma > 5 && soma < 11)
            {
                mensagem = "Insuficiente";
            } else if (soma > 10 && soma < 16)
            {
                mensagem = "Suficiente";
            } else if (soma > 15 && soma < 21)
            {
                mensagem = "Bom";
            } else if (soma > 20 && soma < 26)
            {
                mensagem = "Muito Bom";
            } else if (soma > 25 && soma < 31)
            {
                mensagem = "Excelente";
            }


            return mensagem;
        }

        
    }
}
