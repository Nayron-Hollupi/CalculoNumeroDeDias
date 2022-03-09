using System;

namespace Numero_De_Dias
{
    internal class DateTimeOffset
    {

        static void Main(string[] args)
        {
             
            Console.WriteLine("Digite a primeira data 00/00/0000 :");
            DateTime date1 = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Digite a segunda data 00/00/0000 :");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            if (date1 < date2)
            {

                Console.WriteLine(date2 - date1);
            }
            else
            {
                Console.WriteLine(date1 - date2);
            }
   
        }
        }
    }

