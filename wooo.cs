using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramovaniUvod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*víceřádkový komentář
            //spušštění kódu zkratkou F5
            Console.WriteLine("Hello World!"); //příkaz WriteLine na konci řádku provede enter
            Console.WriteLine("Máme rádi 3D grafiku <33");
            Console.Write("C# je okopírovaná Java"); //příkaz Write neukončí řádek
            Console.Write(", proto se budeme učit C#");

            int cislo = 101; //název proměnné ber diakritiky
            //název proměnné musí dávat smysl
            int v;
            //tabulátor dopisuje zdrojový kód (cw a double-click tab)
            Console.WriteLine(cislo); //výpis obsahu proměnné číslo
            //true/false je bool, pravdivostní typ
            //svítí, nesvítí, ověřený mail (a/n)
            bool svetlo = true;
            Console.WriteLine("Světlo " + svetlo);
            svetlo = false; //aktualizace promenne svetlo
            Console.WriteLine("Světlo " + svetlo);
            //desetinná čísla se používá u datového typu float
            float desetinne_cislo = 4.96f; //na konci musi byt f, misto desetinne carky se pise .
            Console.WriteLine("Desetinné číslo " + desetinne_cislo);
            float druhe_desetinne_cislo = 3.14f;
            float vysledek = desetinne_cislo + druhe_desetinne_cislo;
            Console.WriteLine(desetinne_cislo + " + " + druhe_desetinne_cislo + " = " + vysledek); //pokud nechceme aby se hodnoty secetly sle aby tam bylo viditelne +, dame ho do "
            //jeden znak je char
            char znak = '$'; //uvozovky zkratkou alt + 39, alt + 36 je dollar
            Console.WriteLine("Obsah proměnné znak " + znak);
            //string je řetězec, prostý text, který může obsahovat libovolné znaky
            string veta = "Vašek nebude hrát hry! 666 PEKLO "; 
            Console.WriteLine(veta);*/

            /*Console.WriteLine("Načti celé číslo");
            int a = Convert.ToInt16(Console.ReadLine());//vtvoření proměnné
                                                        //nutná konverze je vhodný datový typ       
                                                        //načtení hodnoty z klávesnice ReadLine()
            Console.WriteLine("Načetl jsem hodnotu " + a);

            Console.WriteLine("Nacti druhe cele cislo");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("vysledek" + " = " + (a + b));//soucet musi byt v zavorkach*/

            /* Sudé/Liché
            Console.WriteLine("Zadej číslo:");
            int a = Convert.ToInt16(Console.ReadLine());
                if (a%2 == 0)
            {
               Console.WriteLine( "číslo je sudé");
                    }
            else
            {
                Console.WriteLine("číslo je liché");  
            }*/

            /*
            //Kalkulačka
            Console.WriteLine("zadej číslo");
            float a = float.Parse(Console.ReadLine()); //pro desetinne cisla nepouzivame convert to int ale float parse
            Console.WriteLine("zadej druhé číslo");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej volbu (1- sčítání, 2- odčítání, 3- násobení, 4- dělení)");
            int volba = Convert.ToInt16(Console.ReadLine());

            if (new int[] { 1, 2, 3, 4 }.Contains(volba)) //nový array s hodnotou pouze celého čísla, hodnoty 1, 2, 3, 4
                { 
                if (volba == 1)
            {
                Console.WriteLine("výsledek:" + (a + b));
            }
                if (volba == 2)
            {
                Console.WriteLine("výsledek:" + (a - b));
            }
                if (volba == 3)
            {
                Console.WriteLine("výsledek:" + (a * b));
            }
                if (volba == 4)
            {
                if (b != 0)
                    {
                        Console.WriteLine("výsledek:" + (a / b));
                    }
                    else
                    {
                        Console.WriteLine("nejde delit 0");
                    }
            }
            }
               else
            {
                Console.WriteLine("zvolte volbu 1-4");
            }
            */



            /*Console.WriteLine("nacti cislo");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("chapes jo, druhe cislo zadej");
            int b = Convert.ToInt16(Console.ReadLine());

            int soucet = a + b;
            int rozdil = a - b;
            int nasobeni = a * b;
            int deleni = a / b;

            Console.WriteLine("Soucet:" + soucet);
            Console.WriteLine("Rozdil:" + rozdil);
            Console.WriteLine("Nasobeni:" + nasobeni);
            Console.WriteLine("Deleni:" + deleni);
            Console.WriteLine("nacti cele nebo desetinne cislo");
            //do kodu piseme tecku a do konzole carku
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("nacti cele nebo desetinne cislo");
            float y = float.Parse(Console.ReadLine());

            float vysledek = x / y;
            Console.WriteLine("Dělení:" + vysledek);*/
            //komentování oznaceneho textu ctrl + ckc, odoznaceni ctrl + cku
            //char znak = Convert.ToChar(Console.ReadLine()); //jedna moznost
            //char znak2 = char.Parse(Console.ReadLine()); //druha moznost
            //Console.WriteLine("Obsah charu: " + znak + ", " + znak2);
            //Console.WriteLine("Obsah charu v ASCI: " + "alt+" + (int)znak + ", " + (int)znak2);

            /*Console.WriteLine("zadej cislo vetsi nez 0");
            int a = Convert.ToInt16(Console.ReadLine());

            if (a >= 0)
            { 
            if (a == 0) //výraz, podmínka se testuje nebo vyhodnocuje

            {
                Console.WriteLine("jsi nula");
            }
            //příkaz
            else
            {
                Console.WriteLine("jsi nula tak i tak, jine cislo nic neznamena :)");
            }
            }
            else
            {
                Console.WriteLine("rekl jsem vetsi");
            }
            
            // = přizazeni, např. do proměnné
            // == pozovnání, např. dvou hodnot*/

            /*Console.WriteLine("Hodnota PI = " + Math.PI);
            Console.WriteLine("Odmocnina = " + Math.Sqrt(10.2));

            Console.WriteLine("Zadejte desetinné číslo pro výpočet odmocniny: ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0) //Podmínka vyhodnotí číslo včetně nuly
            {
                double vysledek = Math.Sqrt(x);
                Console.WriteLine("Odmocnina = " + vysledek);
            }
            else
            {
                Console.WriteLine("Hodnota musí být větší než nula.");
            }
            Console.WriteLine("Mocnina = " + Math.Pow(x, 2)); //Power --> mocnina
            //první parametr je základ čísla a druhý parametr je mocnitel*/

            /*Console.WriteLine("Zadejte základ čísla: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte exponent: ");
            double n = double.Parse(Console.ReadLine());
            double vysledek = Math.Pow(x, n);
            Console.WriteLine("Výsledek = " + vysledek);*/

            /*Console.WriteLine("zadej první číslo: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("zadej druhé číslo: ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("vysledek: " + (a+b));*/
            /*int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Číslo je sudé");
            }
            else 
            {
                Console.WriteLine("Číslo je liché");
            }
            */
            /*
            Console.WriteLine("Hodnota PI = " + Math.PI);
            Console.WriteLine("Odmocnina = " + Math.Sqrt(10.2));

            Console.WriteLine("Zadejte desetinné číslo pro výpočet odmocniny: ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0) //Podmínka vyhodnotí číslo včetně nuly
            {
                double vysledek = Math.Sqrt(x);
                Console.WriteLine("Odmocnina = " + vysledek);
            }
            else
            {
                Console.WriteLine("Hodnota musí být větší než nula.");
            }
            Console.WriteLine("Mocnina = " + Math.Pow(x, 2)); //Power --> mocnina
                                                              //první parametr je základ čísla a druhý parametr je mocnitel

            */
            /*
            Console.WriteLine("Zadejte základ čísla (x): "); // x na y (5 na 2)
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej exponent (y): ");
            double n = double.Parse(Console.ReadLine());
            double vysledek = Math.Pow(x, n);
            Console.WriteLine("Výsledek = " + vysledek);
            */
            /*
            Console.WriteLine("Načt jméno: ");
            string name = (Console.ReadLine());//k načtení textu, není nutná konverze
            Console.WriteLine("Jméno = " + name);
            if (name == "Václav")
            {
              Console.WriteLine("Jsem Václav");
            }
            else if (name == "Franta")//rozšířená podmínka
            {
            Console.WriteLine("Jsem Franta");
            }
            else if (name == "Kuba")
            {
            Console.WriteLine("Jsem Kuba");
            }
            else
            {
            Console.WriteLine("Nejsem Václav ani Franta ani Kuba :(");
            }
            */
            /*
            Console.WriteLine("Jste žena nebo muž?");
            string pohlavi = (Console.ReadLine());
            if (pohlavi == "žena")
            {
               Console.WriteLine("Žena");
            }
            else if (pohlavi == "muž")
            {
                Console.WriteLine("Muž");
            }
            else
            {
                Console.WriteLine("neznámo");
            }
            */

            /*
            Console.WriteLine("Načtěte 1. desetinné číslo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Načtěte 2. desetinné číslo: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Načtěte znak: ");
            char y = Char.Parse(Console.ReadLine());
            if (y == '+')
            {
                float plus = a + b;
                Console.WriteLine("Sčítání = " + plus );
            }
            else if (y == '-')
            {
                float minus = a - b;
                Console.WriteLine("Odčítání = " + minus);
            }
            else if (y == '*')
            {
                float nasobeni = a * b;
                Console.WriteLine("Násobení = " + nasobeni);
            }
            else if (y == '/')
            {

                float deleni = a / b;
                Console.WriteLine("Dělení = " + deleni);

                if (b == 0)
                {
                    Console.WriteLine("Nulou dělit nelze");
                }
            }
            else
            {
                Console.WriteLine("Chyba");
            }
            */
            /*
            string a = Console.ReadLine();

            Console.WriteLine(a);
            */
            /*
           // Console.WriteLine("Načtěte 1.  číslo: ");
            float a = float.Parse(Console.ReadLine());
            char y = Char.Parse(Console.ReadLine());
           // Console.WriteLine("Načtěte 2.  číslo: ");
            float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("Načtěte znak: ");
            */
            /*
            Console.WriteLine("Zadej 10 čísel: ");
            int sude = 0;
            int liche = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt16(Console.ReadLine());
                if (a % 2 == 0)
                {
                    sude += 1;
                }
                else
                {
                    liche += 1;
                }
            }
            Console.WriteLine("Sudé: " + sude + ", " + "Liché: " + liche);
            */
            /*
            Console.WriteLine("Zadej 10 čísel: ");
            int kladne = 0;
            int zaporne = 0;
            int nula = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt16(Console.ReadLine());
                if (a < 0)
                {
                    zaporne += 1;
                }
                else if (a == 0)
                {
                    nula += 1;
                }
                else
                {
                    kladne += 1;
                }
            }
            Console.WriteLine("Kladné: " + kladne + ", " + "Záporné: " + zaporne + ", " + "Nula:" + nula);
            */
            /*
            Console.WriteLine("Zadej 10 čísel: ");
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }
               
            }
            Console.WriteLine("Nejvyšší číslo: " + max);
            */
            /*
            Console.WriteLine("Zadejte první číslo: ");
            double a = Convert.ToInt16(Console.ReadLine);
            Console.WriteLine("Zadejte druhé číslo: ");
            double b = Convert.ToInt16(Console.ReadLine);
            Console.WriteLine("Zadejte volbu: ");
            char znak = char.Parse(Console.ReadLine());

            //víccenaásobné větvení
            switch (znak)  //vstupní parametr pro data
            {
                case 'a': //vyhodnoceni vyrazu
                    Console.WriteLine("vase volba je a"); //zadani
                    break;//povinne ukonceni bloku
                case 'b':
                    Console.WriteLine("vase volba je b");
                    break;
                default: Console.WriteLine("chyba vstupu");
            }
            */
            /*
            Console.WriteLine("Zadejte číslo: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1 = Console.WriteLine("Pondělí");
                    break;
                case 2 = Console.WriteLine("Úterý");
                    break;
                case 3 = Console.WriteLine("Středa");
                    break;
                case 4 = Console.WriteLine("Čtvrtek");
                    break;
                case 5 = Console.WriteLine("Pátek");
                    break;
                case 6 = Console.WriteLine("Sobota");
                    break;
                case 7 = Console.WriteLine("Neděle");
                    break;
                default:
                    Console.WriteLine("není den v týdnu");
                    break;
            }
            */
            Console.WriteLine("Zadejte první číslo: ");
            double a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo: ");
            double b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Zadejte volbu: ");
            char znak = char.Parse(Console.ReadLine());


            switch (znak)
            {
                case '+':
                    Console.WriteLine("Výsledek: " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Výsledek: " + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Výsledek: " + (a * b));
                    break;
                case '/':
                    if (b != 0)
                    {
                        Console.WriteLine("Výsledek: " + (a / b));
                    }
                    break;
                default: Console.WriteLine("Chyba");
                    break;
            }

            // '' - alt + 39
            // && & = ctrl + alt + c, alt + 38, altgr + c
            // || = alt + 124, altgr + w "svislítko"
            // na macu jsou na to klavesy 
            // tabulka pravdivostních hodnot
            Console.ReadKey(); //ukončí se program po -- klavesy
        }
    }
}
