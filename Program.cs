using System;

namespace semana3_aula2_funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
          /* */
            System.Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();
           /*
           //FUNÇÃO 
           //sem retorno e sem argumento

            OlaMundo();
            Console.WriteLine("----------------");
            OlaMundo();
            Console.WriteLine("----------------");
        }

        //função
        static void OlaMundo(){
            System.Console.WriteLine("Olá Mundo!");
            System.Console.WriteLine("Tudo bem?");
            System.Console.WriteLine("Como vai você.");
            System.Console.WriteLine("Fim");
        */

        // FUNÇÃO SEM RETORNO E COM argumento

        OlaMundoComArgumento(nome,idade);

       
        }
        
        
        static void OlaMundoComArgumento(string nome, string idade){
            System.Console.WriteLine("Seu nome é: " + nome);
            System.Console.WriteLine("Sua idade é : " + idade );
        }
        
    }
}
