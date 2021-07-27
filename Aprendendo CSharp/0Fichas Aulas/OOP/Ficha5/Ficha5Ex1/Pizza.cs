using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha5Ex1 {
    class Pizza {

        private string Tamanho = "";
        private string Massa = "";
        private int Ingredientes = 0;
        private double Preco = 0;
        

        public string Tamanho1 { get => Tamanho; set => Tamanho = value; }
        public string Massa1 { get => Massa; set => Massa = value; }
        public int Ingredientes1 { get => Ingredientes; set => Ingredientes = value; }
        public double Preco1 { get => Preco; set => Preco = value; }


        public double calcPreco() {
            
            if (Massa == "Fina")
            {
                if (Tamanho == "Individual")
                {
                    Preco = 4.90;
                   
                    Preco += (1 * Ingredientes );
                   
                }else if (Tamanho == "Média")
                {
                    Preco = 8.55;
                    
                    Preco += (1.70 * Ingredientes);
                  
                } else if (Tamanho == "Familiar")
                {
                    Preco = 12.40;                    
                    
                    Preco += (2.20 * Ingredientes);
                    
                }
            } else if (Massa == "Pan")
            {
                if (Tamanho == "Individual")
                {
                    Preco = 5.85;
                  
                    Preco += (1 * Ingredientes);
                 
                } else if (Tamanho == "Média")
                {
                    Preco = 9.65;
                    
                    Preco += (1 * Ingredientes);
 
                } else if (Tamanho == "Familiar")
                {
                    Preco = 13.65;
                    
                    Preco += (1 * Ingredientes);
                    
                }
            } else if (Massa == "Rolling")
            {
                if (Tamanho == "Individual")
                {
                    Preco = 15.60;
                    
                    Preco += (1 * Ingredientes);
                    
                } else if (Tamanho == "Média")
                {
                    Preco = 17.35;
                    
                    Preco += (1 * Ingredientes);
                    
                } else if (Tamanho == "Familiar")
                {
                    Preco = 19.45;
                    
                    Preco += (1 * Ingredientes);
                    
                }
            }

            return Preco;
        }


           
    }
}
