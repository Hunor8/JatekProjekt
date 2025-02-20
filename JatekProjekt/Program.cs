using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JatekProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey billentyu, bilo, elagazas;
            string valasztas = "";
            string[] repertoar = { "kard", "balta", "szigony" };
            int HP = 100;
            string aktualFegyver = "";
            int MaxHP = 100;
            int MinHP = 0;
            int utitars = 0;


            do
            {
            intro:
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" A SÁPADT KIRÁLYSÁG ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.Clear();
                Console.WriteLine();
                string beve = "BEVEZETŐ BEVEZETŐ BEVEZETŐ BEVEZETŐ";
                string[] szavakBeve = beve.Split(' ');

                foreach (string szo in szavakBeve)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(300);
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("--------------------------");
                Console.ResetColor();
                Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.WriteLine();
                string allomas = "ÁLLOMÁS ÁLLOMÁS ÁLLOMÁS ÁLLOMÁS";
                string[] szavakAllomas = allomas.Split(' ');

                foreach (string szo in szavakAllomas)
                {
                    Console.Write(szo + " ");
                    Thread.Sleep(300);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("--------------------------");
                Console.ResetColor();
                Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.Clear();


                Console.WriteLine();
                Console.Write("Add meg karaktered keresztnevét: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string Nev = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine();
            valasztas:
                Console.Write($"Válaszz az alábbi fegyverek közül: ");
                Console.WriteLine("Kard +20 sebzés, Balta +15 sebzés +15% gyorsaság, Szigony +10 sebzés +20 gyorsaság, +10 távolság");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{repertoar[0]}, {repertoar[1]}, {repertoar[2]}");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Választásod mely veled marad: ");

                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                valasztas = Console.ReadLine();


                if (valasztas == "kard")
                {
                    aktualFegyver += "kard";
                }
                else if (valasztas == "balta")
                {
                    aktualFegyver += "balta";

                }
                else if (valasztas == "szigony")
                {
                    aktualFegyver += "szigony";
                }

                Console.WriteLine($"A fegyver amit választottál: {aktualFegyver}");
                Console.WriteLine("Nyomj egy billetyűt a folytatáshoz.");
                Console.ResetColor();
                Console.WriteLine();
                if (valasztas == repertoar[0])
                    valasztas = repertoar[0];
                else if (valasztas == repertoar[1])
                {
                    valasztas = repertoar[1];
                }
                else if (valasztas == repertoar[2])
                {
                    valasztas = repertoar[2];
                }
                else
                {
                    goto valasztas;
                }
                billentyu = Console.ReadKey(true).Key;
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine($"Te, {Nev} Verath egy {valasztas} kíséretében és megannyi felszereléssel útnak indulsz...");
                Console.ResetColor();
                Console.WriteLine();


            elso:

                string elsoter = "ELSOTER ELSOTER ELSOTER ELSOTER";
                string[] szavakElsoter = elsoter.Split(' ');

                foreach (string szo in szavakElsoter)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(szo + " ");
                    Thread.Sleep(300);
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Mit teszel? <- ->");
                Console.Write($"{Nev} Verath: ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                elagazas = Console.ReadKey().Key;
                if (elagazas == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("OPCIO1");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Mit teszel? <- ->");
                    Console.Write($"{Nev} Verath: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        if (HP == 0 || HP >= -1)
                        {


                            Console.WriteLine("opc1 KIMENETEL1");
                            //mittudom én vesszen 20 HP
                            HP = HP - 20;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Aktuális életerő: {HP}");
                            Console.ResetColor();
                            bilo = Console.ReadKey(true).Key;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("MEGHALTÁL.");
                            Console.ResetColor();
                            goto intro;
                            Console.Clear();
                        }


                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        if (HP == 0 || HP >= -1)
                        {


                            Console.WriteLine("opc1 KIMENETEL2!");
                            //mittudom én vesszen 50 HP
                            HP = HP - 50;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Aktuális életerő: {HP}");
                            Console.ResetColor();
                            bilo = Console.ReadKey(true).Key;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("MEGHALTÁL.");
                            goto intro;
                            Console.Clear();

                        }
                        else
                        {
                            continue;
                        }


                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        Console.WriteLine();
                        goto elso;
                    }

                }
                else if (elagazas == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("OPCIO2");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Mit teszel? <- ->");
                    Console.Write($"{Nev} Verath: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        if (HP == 0 || HP >= -1)
                        {


                            Console.WriteLine("opc2 KIMENETEL1");
                            //mittudom én vesszen 33 HP
                            HP = HP - 33;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Aktuális életerő: {HP}");
                            Console.ResetColor();
                            bilo = Console.ReadKey(true).Key;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("MEGHALTÁL.");

                            goto intro;
                            Console.Clear();
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        if (HP == 0 || HP >= -1)
                        {



                            Console.WriteLine("opc2 KIMENETEL2!");
                            //mittudom én vesszen 10 HP
                            HP = HP - 10;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Aktuális életerő: {HP}");
                            Console.ResetColor();
                            bilo = Console.ReadKey(true).Key;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("MEGHALTÁL.");

                            goto intro;
                            Console.Clear();
                        }
                        else
                        {
                            continue;
                        }


                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" KEZDJÜK ÚJRA! ");
                        Console.ResetColor();
                        Console.WriteLine();
                        goto elso;
                    }
                }
                else
                {
                    Console.Clear();
                    goto elso;
                }
                Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
                bilo = Console.ReadKey(true).Key;
                Console.Clear();

            masodik:
                Console.WriteLine();
                string masodter = "MASODTER MASODTER MASODTER MASODTER";
                string[] szavakMasodter = masodter.Split(' ');

                foreach (string szo in szavakMasodter)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(szo + " ");
                    Thread.Sleep(300);
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Mit teszel? <- ->");
                Console.Write($"{Nev} Verath: ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                elagazas = Console.ReadKey().Key;
                if (elagazas == ConsoleKey.LeftArrow)
                {
                    //utitárs
                    Console.WriteLine("OPCIO1");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Mit teszel? <- ->");
                    Console.Write($"{Nev} Verath: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    elagazas = Console.ReadKey().Key;
                    if (elagazas == ConsoleKey.LeftArrow)
                    {
                        if (HP == 0 || HP >= -1)
                        {


                            Console.WriteLine("opc1 KIMENETEL1");
                            //mittudom én vesszen 15 HP
                            HP = HP - 15;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Aktuális életerő: {HP}");
                            Console.ResetColor();
                            bilo = Console.ReadKey(true).Key;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("MEGHALTÁL.");
                            goto intro;
                            Console.Clear();


                        }
                        else
                        {
                            continue;
                        }



                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        if (HP == 0 || HP >= -1)
                        {

                            //potencionális utitárs felajánlás
                            Console.WriteLine("opc1 KIMENETEL2!");
                            //mittudom én vesszen 25 HP
                            utitars += 1;
                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            Console.ResetColor();


                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" KEZDJÜK ÚJRA! ");
                            Console.ResetColor();
                            Console.WriteLine();
                            goto masodik;
                        }

                    }

                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("OPCIO2");

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Mit teszel? <- ->");
                        Console.Write($"{Nev} Verath: ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        elagazas = Console.ReadKey().Key;
                        if (elagazas == ConsoleKey.LeftArrow)
                        {
                            if (HP == 0 || HP >= -1)
                            {


                                Console.WriteLine("opc2 KIMENETEL1");
                                //mittudom én szerezzen 30 HP
                                HP = HP + 30;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Aktuális életerő: {HP}");
                                Console.ResetColor();

                                bilo = Console.ReadKey(true).Key;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("MEGHALTÁL.");
                                goto intro;
                                Console.Clear();

                            }
                            else
                            {
                                continue;
                            }



                        }
                        else if (elagazas == ConsoleKey.RightArrow)
                        {
                            if (HP == 0 || HP >= -1)
                            {


                                Console.WriteLine("opc2 KIMENETEL2!");
                                //mittudom én szerezzen 20 HP
                                HP = HP - 20;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Aktuális életerő: {HP}");
                                Console.ResetColor();

                                bilo = Console.ReadKey(true).Key;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("MEGHALTÁL.");
                                goto intro;
                                Console.Clear();


                            }
                            else
                            {
                                continue;
                            }


                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" KEZDJÜK ÚJRA! ");
                            Console.ResetColor();
                            Console.WriteLine();
                            goto masodik;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        goto masodik;
                    }
                    Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
                    bilo = Console.ReadKey(true).Key;
                    Console.Clear();

                harmadikBOSS:
                    //HP FÜGGŐ BOSSFIGHT (if ennyi meg annyi felett vagy alatt így meg úgy alakul)
                    string BOSS = "BOSS BOSS BOSS BOSS";
                    string[] szavakBOSS = BOSS.Split(' ');

                    foreach (string szo in szavakBOSS)
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(szo + " ");
                        Thread.Sleep(300);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Mit teszel? <- ->");
                    Console.Write($"{Nev} Verath: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    elagazas = Console.ReadKey().Key;

                    if (elagazas == ConsoleKey.LeftArrow)
                    {

                        Console.WriteLine("OPCIO1");

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Mit teszel? <- ->");
                        Console.Write($"{Nev} Verath: ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        elagazas = Console.ReadKey().Key;
                        if (elagazas == ConsoleKey.LeftArrow || utitars == 1)
                        {
                            Console.WriteLine("opc1 KIMENETEL1");
                            //mittudom én TÖRTÉNÉS

                        }
                        else if (elagazas == ConsoleKey.RightArrow || utitars == 1)
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
                            Console.WriteLine();
                            goto harmadikBOSS;
                        }
                    }
                    else if (elagazas == ConsoleKey.RightArrow)
                    {
                        Console.WriteLine("OPCIO2");

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Mit teszel? <- ->");
                        Console.Write($"{Nev} Verath: ");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        elagazas = Console.ReadKey().Key;


                        if (elagazas == ConsoleKey.LeftArrow || HP <= 50 || utitars == 1)
                        {
                            Console.WriteLine("opc2 KIMENETEL1");
                            //mittudom én TÖRTÉNÉS

                        }
                        else if (elagazas == ConsoleKey.RightArrow || HP <= 50 || utitars == 1)
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
                            Console.WriteLine();
                            goto harmadikBOSS;
                        }

                        if (elagazas == ConsoleKey.LeftArrow || HP >= 50)
                        {
                            Console.WriteLine("opc2 KIMENETEL1");
                            //mittudom én TÖRTÉNÉS

                        }
                        else if (elagazas == ConsoleKey.RightArrow || HP >= 50)
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
                            Console.WriteLine();
                            goto harmadikBOSS;
                        }

                    }
                    else
                    {
                        Console.Clear();
                        goto harmadikBOSS;
                    }
                    string ending = "VÉGE VÉGE VÉGE VÉGE";
                    string[] szavakEnding = ending.Split(' ');
                    Console.WriteLine();
                    foreach (string szo in szavakEnding)
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(szo + " ");
                        Thread.Sleep(300);
                        Console.ResetColor();
                    }
                    Console.WriteLine();


                    Console.WriteLine("A történetnek itt nincs vége... (újra? enter:igen esc:nem)");
                    billentyu = Console.ReadKey(true).Key;
                    Console.Clear();
                } while (billentyu != ConsoleKey.Escape) ;

            };


 








        }    };
    };

