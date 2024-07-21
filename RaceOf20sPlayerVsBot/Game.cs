using System;
using System.Threading;
using Microsoft.VisualBasic;
using System.Text;
using System.Linq;

namespace RaceOf20sInput
{
 class GlobalVariables
 {
  public static string GlobalString { get; set; }
  public static short IntValue { get; set; }
 }
  class Program
    {
      
        static void Main(string[] args)
        {
            int TotalValue = 0;

            bool j1 = false;
            bool j2 = false;

             Console.ForegroundColor = ConsoleColor.Green;

             
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("Inserte un numero para empezar: ");
             Console.WriteLine("El numero solo puede ser entre el 1 y el 2");
             Console.WriteLine("Tu objetivo sera llegar al 20 primero que tu adversario");
             Console.WriteLine("");


            while (TotalValue <20)
            {
             Random random = new Random();
             int numeroAleatorio = random.Next(1, 3);
             if (TotalValue == 19)
             {
              numeroAleatorio = 1;
             }
             else
             {
               numeroAleatorio = random.Next(1, 3);
             }
             Console.ForegroundColor = ConsoleColor.Blue;
             


             Console.Write("Numero J1 ");
             bool esNumero = false;
             
             
             while (!esNumero)
             {
             GlobalVariables.GlobalString = Console.ReadLine();

             foreach (char c in GlobalVariables.GlobalString)
             {
                 if (Char.IsDigit(c))
                 {
                     esNumero = true;
                     break;
                 }
             }
             if (!esNumero)
             {
                 Console.WriteLine("Intruduce un numero.");
                 Console.Write("Numero J1 ");
                 continue;
             }
             if (esNumero == true)
             {
              try
              {
                GlobalVariables.IntValue = Convert.ToInt16(GlobalVariables.GlobalString);
              }
               catch (FormatException)
               {
                Console.WriteLine("Pon un numero entero.");
                Console.Write("Numero J1 ");
                esNumero = false; 
               }
               catch (OverflowException)
               {
                Console.WriteLine("El valor ingresado es muy grande.");
                Console.Write("Numero J1 ");
                esNumero = false; 
               }
             }
             }
             
             j1 = true;
             j2 = false;

             if (TotalValue == 19 && GlobalVariables.IntValue < 2)
             {
             }
             else if (TotalValue == 19 && GlobalVariables.IntValue > 2)
             {
              Console.WriteLine("Vuelva a intentar el maximo es de 20");  
             }
             


              if (GlobalVariables.IntValue < 3 )
              {
                TotalValue += GlobalVariables.IntValue;
                if (TotalValue < 20)
                {
                  TotalValue += numeroAleatorio;
                  Console.ForegroundColor = ConsoleColor.Magenta;
                  Console.WriteLine($"Numero IA {numeroAleatorio}");
                  j1 = false;
                  j2 = true;
                
                }
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"ValorTotal: {TotalValue}");


              }
              else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vuelva a insertar un numero entre el 1 y el 2");
              }
            
             
            } 
            Console.ForegroundColor = ConsoleColor.Green;
            if (j1 == true)
            {
              Console.WriteLine("");
              Console.WriteLine("Ha ganado el Jugador 1");

            }
            else if (j2 == true)
            {
              Console.WriteLine("");
              Console.WriteLine("Ha ganado la IA");

            }


        }
    }
}

