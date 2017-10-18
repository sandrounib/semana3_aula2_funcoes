using System;

namespace funcoes_com_retorno
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Digite o primeiro valor: ");
           int valora =Convert.ToInt16(Console.ReadLine());

           System.Console.WriteLine("Digite o Segundo valor: ");
           int valorb =Convert.ToInt16(Console.ReadLine());
           
           System.Console.WriteLine("Digite o tipo de operação: ");
           string operação = Console.ReadLine();            

          int resultado = Calculadora(valora, valorb,operação);
          System.Console.WriteLine("O resultado é: " + resultado);


            
            /*
            double valor = ValorPI();
            System.Console.WriteLine("Valor de pi é : " + valor);

        }
        //Função com funcoes_com_retorno
        static double ValorPI(){

            return Math.PI;
         */
        
        /*
        string cpr = GerarCpf();
        System.Console.WriteLine("CPF Gerado: " + GerarCpf());

        }
         static string GerarCpf(){
             string cpf ="08929532845";
             //
             return cpf;
            
         }
          */
        }
        static int Calculadora(int a, int b, string tipo){
            int valor = 0;
            switch(tipo){
                case "+" :
                    valor = a + b;
                    break;
                case "-" :
                    valor = a - b;
                    break;
                case "*" :
                    valor = a * b;
                    break;
                case "/" :
                    valor = a / b;
                    break;                
            }
            return valor;
        }
          
    }
}
