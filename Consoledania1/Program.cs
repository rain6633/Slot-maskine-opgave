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
            while (true)
            {
                Console.WriteLine("vælg dit spil!");
                Console.WriteLine();
                Console.WriteLine("spil 1: Den enarmede tyveknægt!");
                Console.WriteLine("spil 2: Sten, saks, papir!");
                Console.WriteLine("spil 3: Gæt et Tal!");
                Console.WriteLine();
                Console.WriteLine("tryk 1,2 eller 3 for at starte dit spil. eller q for at aflsutte");
                string spil = Console.ReadLine();

                if (spil == "1")
                {
                    Console.Clear();
                    SlotMaskine();
                }
                else if (spil == "2")
                {
                    Console.Clear();
                    StenSaksPapir();
                }

                else if (spil == "3")
                {
                    Console.Clear();
                    GætEtTal();
                }
                if (spil == "q")
                {
                    break;
                }
            }


        }
        static void SlotMaskine()
        {
            Random tilfaelde = new Random(); //generere et tilfældigt tal
            string[] tegn = { "1", "2", "3", "4", "5", "e", }; //tegn til slot maskinen
            float totalPoint = 100; //de point du har i alt
            float mult = 0; //hvor meget dine point du har bettet skal ganges med
            string raekke = string.Empty; //de udskrevne tegn til slot maskinen
            {
                while (true) // holder spillet kørende
                {
                    //udskriver hvor mange point du har i alt
                    Console.WriteLine($"du har {totalPoint}");
                    Console.WriteLine("bet dine point (væk)!!!!!!!!!!!!!!!");

                    //spørger om hvor mange point du vil bette og laver en ny variabel på det
                    float point;
                    if (!float.TryParse(Console.ReadLine(), out point))
                    {
                        Console.WriteLine("det var ikke et gyldigt input");
                    }

                    Console.WriteLine();

                    //tjekker om du har bettet flere point end du har og ændrer det til dine max point
                    if (point > totalPoint)
                    {
                        Console.WriteLine($"du har ikke {point} point. så du " +
                        $"better alle dine {totalPoint} point");

                        point = totalPoint;

                    }
                    //trækker hvor mange point du satser fra dine total point
                    totalPoint = totalPoint - point;

                    int karakter1 = tilfaelde.Next(0, 6);

                    int karakter2 = tilfaelde.Next(0, 6);

                    int karakter3 = tilfaelde.Next(0, 6);

                    //generere tre tilfældige tegn og udskriver dem
                    for (int i = 0; i < 10; i++)
                    {
                        karakter1 = tilfaelde.Next(0, 6);
                        Console.WriteLine($"{tegn[karakter1]}");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        karakter2 = tilfaelde.Next(0, 6);
                        Console.WriteLine($"{tegn[karakter1]}{tegn[karakter2]}");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        karakter3 = tilfaelde.Next(0, 6);
                        Console.WriteLine($"{tegn[karakter1]}{tegn[karakter2]}{tegn[karakter3]}");
                        System.Threading.Thread.Sleep(250);
                        Console.Clear();
                    }


                    raekke = Convert.ToString((tegn[karakter1] +
                            tegn[karakter2] + tegn[karakter3]));

                    //tjekker om du har fået tre ens tegn og hvor meget dit sats skal ganges med
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
                    point = point * mult; //ganger dine satsede point
                    totalPoint = point + totalPoint; //lægger din gevinst ovenpå dine point
                    Console.WriteLine($"du har nu {totalPoint} point");
                    Console.ReadKey();
                    Console.Clear();

                    //tjekker om du har mistet alle dine point
                    if (totalPoint == 0)
                    {
                        Console.WriteLine("du mistede alle dine point, øv bøv");
                        Console.WriteLine("vil du prøve igen? y/n");
                        string fortsæt = Console.ReadLine().ToUpper();

                        //spørger om du vil bette videre
                        if (fortsæt == "Y")
                        {
                            totalPoint = 125; //giver dig 125 point og starter spillet forfra
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            break; //slutter spillet
                        }
                    }
                }
            }
        }
        static void StenSaksPapir()
        {


            Console.WriteLine("Vælg: 1=Sten, 2=Saks, 3=Papir, q=Afslut");
            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine("Du valgte: " + input);

                Random rnd = new Random();
                int computerChoice = rnd.Next(1, 4); // giver 1, 2 eller 3
                Console.WriteLine("Computeren valgte: " + computerChoice);


                int playerChoice = int.Parse(input);

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Uafgjort");

                }
                else if (playerChoice == 1 && computerChoice == 2)
                {
                    Console.WriteLine("Sten slår saks. Du vinder");

                }
                else if (playerChoice == 3 && computerChoice == 1)
                {
                    Console.WriteLine("Papir slår sten. Du vinder");
                }
                Console.WriteLine("Computeren vinder");
                if (input == "q")
                {
                    break;
                }
            }

        }
        static void GætEtTal()
        {
            {
                Console.WriteLine("Gæt et tal");
                String input = Console.ReadLine();
                Console.WriteLine("Du skrev" + input);
            }
            int forsøg = 3;// 3 forsøg i alt

            Random Random = new Random();// Generer tilfældige tal
            int Hemmeligt = Random.Next(1, 50); // tal fra 1 til 200

            while (true)
            {

                Console.WriteLine("Gæt et tal");// 
                string input = Console.ReadLine();
                Console.WriteLine("Du skrev " + input);
                int gæt = int.Parse(input);

                if ((gæt == Hemmeligt))// tjekker om det er for højt eller lavt
                {

                    Console.WriteLine("Godt gæt. Korrekt");
                }
                else if (gæt > Hemmeligt)
                {
                    Console.WriteLine("For højt");
                    forsøg--;
                }
                else if (gæt < Hemmeligt)
                {
                    Console.WriteLine("For lavt");
                    forsøg--;
                }
                if (forsøg == 0)
                {
                    Console.WriteLine("Spillet er ovre");
                }

                if (forsøg == 0)
                {
                    Console.WriteLine("Alle forsøg opbrugt");
                }
            }


        }
    }
}
