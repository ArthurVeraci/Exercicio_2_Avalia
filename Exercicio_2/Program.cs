using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mes, dia, ano, city;
            string Date = null;
            Console.WriteLine("1 - Atibaia \n2 - Bragança Paulista \n3 - Mairiporã \n4 - Nazaré \n5 - Terra Preta \n6 - Extrema \n7 - Vargem \nDigite o codigo referente a cidade que deseja: "); 
            city = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nDigite uma data: \n[Formato: DD/MM/AAAA]");
            var numero1 = Convert.ToDateTime(Console.ReadLine());
            
            mes = numero1.Month;
            dia = numero1.Day;
            ano = numero1.Year;
            
            
            switch (mes)
            {
                case 1:
                    Date = ("Janeiro");
                    break;
                case 2:
                    Date = ("Fevereiro");
                    break;
                case 3:
                    Date = ("Março");
                    break;
                case 4:
                    Date = ("Abril");
                    break;
                case 5:
                    Date = ("Maio");
                    break;
                case 6:
                    Date = ("Junho");
                    break;
                case 7:
                    Date = ("Julho");
                    break;
                case 8:
                    Date = ("Agosto");
                    break;
                case 9:
                    Date = ("Setembro");
                    break;
                case 10:
                    Date = ("Outubro");
                    break;
                case 11:
                    Date = ("Novembro");
                    break;
                case 12:
                    Date = ("Dezembro");
                    break;
            }

            if (city == 1)
            {
                Console.WriteLine("\nAtibaia, " +  dia + " de " + Date + " de " + ano);
            }
            else if (city == 2)
            {
                Console.WriteLine("\nBragança Paulista," + dia + " de " + Date + " de " + ano);
            }

            else if (city == 3)
            {
                Console.WriteLine("\nMairiporã," + dia + " de " + Date + " de " + ano);
            }

            else if (city == 4)
            {
                Console.WriteLine("\nNazaré, " + dia + " de " + Date + " de " + ano);
            }

            else if (city == 5)
            {
                Console.WriteLine("\nTerra preta, " + dia + " de " + Date + " de " + ano);
            }

            else if (city == 6)
            {
                Console.WriteLine("\nExtrema, " + dia + " de " + Date + " de " + ano);
            }

            else if (city == 7)
            {
                Console.WriteLine("\nVargem, "+  dia + " de " + Date + " de " + ano);
            }


            Console.ReadKey();
        }
    }
}
