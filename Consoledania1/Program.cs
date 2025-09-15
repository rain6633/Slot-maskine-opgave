using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basis_prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random tilfaelde = new Random();
            string[] tegn = { "1", "2", "3", "4", "5", "e", };
            float totalPoint = 10;
            float mult = 0;
            string raekke = string.Empty;
            {
                while (true)
                {
                    Console.WriteLine($"du har {totalPoint}");
                    Console.WriteLine("bet dine point (væk)!!!!!!!!!!!!!!!");
                    float point;
                    if (!float.TryParse(Console.ReadLine(), out point))
                    {
                        Console.WriteLine("det var ikke et gyldigt input");
                    }

                        Console.WriteLine();

                    if (point > totalPoint)
                    {
                        Console.WriteLine($"du har ikke {point} point. så du " +
                        $"better alle dine {totalPoint} point, fordi fuck Noah");

                        point = totalPoint;

                    }
                    totalPoint = totalPoint - point;
                    int karakter1 = tilfaelde.Next(0, 6);
                    int karakter2 = tilfaelde.Next(0, 6);
                    int karakter3 = tilfaelde.Next(0, 6);
                    raekke = Convert.ToString((tegn[karakter1] +
                            tegn[karakter2] + tegn[karakter3]));

                    switch (raekke)
                    {
                        case "111":
                            mult = 1.5F;
                            break;

                        case "222":
                            mult = 2;
                            break;

                        case "333":
                            mult = 2.5F;
                            break;

                        case "444":
                            mult = 3;
                            break;

                        case "555":
                            mult = 3.5F;
                            break;

                        case "eee":
                            mult = 5;
                            break;

                    }

                    Console.WriteLine(raekke);

                    Console.WriteLine();
                    point = point * mult;
                    totalPoint = point + totalPoint;
                    Console.WriteLine($"du har nu {totalPoint} point");
                    Console.ReadKey();
                    Console.Clear();

                    if (totalPoint == 0)
                    {
                        Console.WriteLine("du mistede alle dine point, øv bøv");
                        Console.WriteLine("vil du prøve igen? y/n");
                        string fortsæt = Console.ReadLine().ToUpper();
                        
                        if (fortsæt == "Y")
                        {
                            totalPoint = 15;
                            Console.Clear();
                        }
                        else 
                        { 
                            break; 
                        }
                    }
                }
            }
        } 
    }
}
