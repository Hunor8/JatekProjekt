using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey billentyu, bilo, elagazas;
            string valasztas = "";
            string[] repertoar = { "Kard", "Balta", "Szigony" };
            int HP = 100;
            

            do
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" A SÁPADT KIRÁLYSÁG ");
                Console.ResetColor();
                Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.Clear();

                Console.WriteLine("BEVEZETŐ");
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("--------------------------");
                Console.ResetColor();

                Console.WriteLine("ELSŐ ÁLLOMÁS ISMERTETÉSE");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("--------------------------");
                Console.ResetColor();

                Console.Write("Add meg karaktered keresztnevét: ");
                string Nev = Console.ReadLine();

                Console.WriteLine($"Válaszz az alábbi fegyverek közül: {repertoar[0]}, {repertoar[1]}, {repertoar[2]}");
                valasztas = Console.ReadLine();
                if (valasztas == repertoar[0])
                    valasztas = repertoar[0];
                else if (valasztas == repertoar[1])
                {
                    valasztas = repertoar[1];
                }
                else
                {
                    valasztas = repertoar[2];
                }

                Console.Clear();

                Console.WriteLine($"Te, {Nev} Verath egy {valasztas} kíséretében és megannyi felszereléssel útnak indulsz...");
                

            elso:
                Console.WriteLine("ELSŐ ELÁGAZÁS (<- ->)");
                Console.Write($"{Nev} Verath: ");
                elagazas = Console.ReadKey().Key;
                if (elagazas == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("OPCIO1");
                
                    Console.WriteLine("Mit teszel? (<- ->)");
                    Console.Write($"{Nev} Verath: ");
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("opc1 KIMENETEL1");
                        //mittudom én vesszen 2 HP
                        HP = HP - 2;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();

                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("opc1 KIMENETEL2!");
                        //mittudom én vesszen 5 HP
                        HP = HP - 5;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        goto elso;
                    }
                    
                }
                else if (elagazas == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("OPCIO2");
                
                    Console.WriteLine("Mit teszel? (<- ->)");
                    Console.Write($"{Nev} Verath: ");
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("opc2 KIMENETEL1");
                        //mittudom én vesszen 33 HP
                        HP = HP - 33;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();
                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("opc2 KIMENETEL2!");
                        //mittudom én vesszen 10 HP
                        HP = HP - 10;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        goto elso;
                    }
                }
                
            masodik:
                Console.WriteLine("MÁSODIK ELÁGAZÁS (<- ->)");
                Console.Write($"{Nev} Verath: ");
                elagazas = Console.ReadKey().Key;
                if (elagazas == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("OPCIO1");

                    Console.WriteLine("Mit teszel? (<- ->)");
                    Console.Write($"{Nev} Verath: ");
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("opc1 KIMENETEL1");
                        //mittudom én vesszen 7 HP
                        HP = HP - 7;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();

                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("opc1 KIMENETEL2!");
                        //mittudom én vesszen 25 HP
                        HP = HP - 25;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        goto masodik;
                    }
                    
                }

                else if (elagazas == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("OPCIO2");

                    Console.WriteLine("Mit teszel? (<- ->)");
                    Console.Write($"{Nev} Verath: ");
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("opc2 KIMENETEL1");
                        //mittudom én szerezzen 30 HP
                        HP = HP + 30;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();

                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("opc2 KIMENETEL2!");
                        //mittudom én szerezzen 17 HP
                        HP = HP - 17;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Aktuális életerő: {HP}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        goto masodik;
                    }
                }
                
            harmadikBOSS:
                //HP FÜGGŐ BOSSFIGHT (if ennyi meg annyi felett)
                Console.WriteLine("BOSSFIGHT (<- ->)");
                Console.Write($"{Nev} Verath: ");
                elagazas = Console.ReadKey().Key;
                if (elagazas == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("OPCIO1");

                    Console.WriteLine("Mit teszel? (<- ->)");
                    Console.Write($"{Nev} Verath: ");
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("opc1 KIMENETEL1");
                        //mittudom én TÖRTÉNÉS

                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("opc1 KIMENETEL2!");
                        //mittudom én TÖRTÉNÉS
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        goto harmadikBOSS;
                    }
                }
                else if (elagazas == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("OPCIO2");

                    Console.WriteLine("Mit teszel? (<- ->)");
                    Console.Write($"{Nev} Verath: ");
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("opc2 KIMENETEL1");
                        //mittudom én TÖRTÉNÉS

                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("opc2 KIMENETEL2!");
                        //mittudom én TÖRTÉNÉS
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        goto harmadikBOSS;
                    }
                }
                Console.WriteLine("A történet folytatódik... (újra? enter:igen esc:nem)");
            billentyu = Console.ReadKey(true).Key;
            } while (billentyu != ConsoleKey.Escape);
        }
    }
}
