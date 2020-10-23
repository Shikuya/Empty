using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static int tableWidth = 50;
        static void Main(string[] args)
        {
            ;

            {
            Start:
                Console.Clear();
                PrintLine();
                PrintRow("Code", "Detail");
                PrintLine();
                PrintRow("1", "Find the percentage");
                PrintRow("", "");
                PrintRow("2", "Find the year");
                PrintRow("", "");
                PrintRow("3", "Random Number");
                PrintLine();
                Console.WriteLine();
                Console.Write(">> Input Coice for goto Program : ");
                String inputChoice = Console.ReadLine();
                if (inputChoice == "1")
                {
                start1:
                    Console.Clear();
                    double s3, s4;
                    double Persent;
                Check1:
                    Console.Write("Enter gobbet of Number: ");
                    String s1 = Console.ReadLine();
                    if (double.TryParse(s1, out double Gobbet))
                    {
                        s3 = Convert.ToDouble(s1);
                    }
                    else
                    {
                        Errortex();
                        goto Check1;
                    }
                Check2:
                    Console.Write("Enter Number: ");
                    String s2 = Console.ReadLine();
                    if (double.TryParse(s2, out double Number))
                    {
                        s4 = Convert.ToDouble(s2);
                    }
                    else
                    {
                        Errortex();
                        Console.WriteLine("Enter gobbet of Number: " + s1);
                        goto Check2;
                    }
                    Persent = s3 / s4 * 100;
                    Console.WriteLine("Persent: {0}%", Persent);
                CheckPoint:
                    CheckChoicebacking1();
                    String Check3 = Console.ReadLine();
                    if (Check3 == "y" || Check3 == "Y")
                    {
                        Console.Clear();
                        goto start1;
                    }
                    else if (Check3 == "n" || Check3 == "N")
                    {
                        Console.Write("Enter To Continue");
                        Console.ReadLine();
                    }
                    else if (Check3 == "m" || Check3 == "M")
                    {
                        goto Start;
                    }
                    else
                    {
                        Errortex();
                        Console.Clear();
                        Console.WriteLine("Enter gobbet of Number : " + s1);
                        Console.WriteLine("Enter gobbet of Number : " + s2);
                        Console.WriteLine("Persent: {0}%", Persent);
                        goto CheckPoint;
                    }
                }
                if (inputChoice == "2")
                {
                year:
                    Console.Clear();
                    PrintLine();
                    PrintRow("Find Year", "Code", "Detail");
                    PrintLine();
                    PrintRow("", "1", "AD To Budda");
                    PrintRow("", "", "");
                    PrintRow("", "2", "Find the Budda To AD");
                    PrintLine();
                    Console.Write("Input Choice : ");
                    String Choiceyear = Console.ReadLine();
                    if (Choiceyear == "1")
                    {
                    Budda:
                        Console.Clear();
                        Console.Write("Input A.D. year : ");
                        String ADstg = Console.ReadLine();
                        if (double.TryParse(ADstg, out double ADdouble))
                        {
                            Console.WriteLine(ADdouble + 543);
                        CheckPoint:
                            CheckChoicebacking1();
                            String Check3 = Console.ReadLine();
                            if (Check3 == "y" || Check3 == "Y")
                            {
                                Console.Clear();
                                goto Budda;
                            }
                            else if (Check3 == "n" || Check3 == "N")
                            {
                                Console.Write("Enter To Continue");
                                Console.ReadLine();
                            }
                            else if (Check3 == "m" || Check3 == "M")
                            {
                                goto Start;
                            }
                            else
                            {
                                Errortex();
                                Console.Clear();
                                Console.WriteLine("Input A.D. year: " + ADdouble + "\r\n" +
                                    (ADdouble + 543));
                                goto CheckPoint;
                            }
                        }
                        else
                        {
                            Errortex();
                            goto Budda;
                        }
                    }
                    if (Choiceyear == "2")
                    {
                    AD:
                        Console.Clear();
                        Console.Write("Input Buddhist era : ");
                        String Buddastg = Console.ReadLine();
                        if (double.TryParse(Buddastg, out double Buddadouble))
                        {
                            Console.WriteLine(Buddadouble - 543);
                        CheckPoint:
                            CheckChoicebacking1();
                            String Check3 = Console.ReadLine();
                            if (Check3 == "y" || Check3 == "Y")
                            {
                                Console.Clear();
                                goto AD;
                            }
                            else if (Check3 == "n" || Check3 == "N")
                            {
                                Console.Write("Enter To Continue");
                                Console.ReadLine();
                            }
                            else if (Check3 == "m" || Check3 == "M")
                            {
                                goto Start;
                            }
                            else
                            {
                                Errortex();
                                Console.Clear();
                                Console.WriteLine("Input Buddhist era: " + Buddastg + "\r\n" +
                                    (Buddadouble - 543));
                                goto CheckPoint;
                            }

                        }
                        else
                        {
                            Errortex();
                            goto AD;
                        }
                    }
                    else
                    {
                        Errortex();
                        goto year;
                    }
                }
                else if (inputChoice == "3")
                {
                    Random:
                    Console.Clear();
                    Console.Write(">> Input Num To : ");
                    String Num1 = Console.ReadLine();
                    Console.Write(">> Input To Num : ");
                    String Num2 = Console.ReadLine();
                    if (int.TryParse(Num1, out int NumReal1) && int.TryParse(Num2, out int NumReal2))
                    {
                        Random ran = new Random();
                        int genarate = ran.Next(NumReal1, NumReal2);
                        Console.WriteLine("Genarate Number Is : " + genarate);
                    CheckPoint:
                        CheckChoicebacking1();
                        String Check3 = Console.ReadLine();
                        if (Check3 == "y" || Check3 == "Y")
                        {
                            Console.Clear();
                            goto Random;
                        }
                        else if (Check3 == "n" || Check3 == "N")
                        {
                            Console.Write("Enter To Continue");
                            Console.ReadLine();
                        }
                        else if (Check3 == "m" || Check3 == "M")
                        {
                            goto Start;
                        }
                        else
                        {
                            Errortex();
                            Console.Clear();
                            Console.WriteLine(">> Input Num To : " + NumReal1 + "\r\n" +
                                ">> Input To Num : " + NumReal2 + "\r\n" +
                                "Genarate Number Is : " + genarate);
                            goto CheckPoint;
                        }
                    }
                    else
                    {
                        Errortex();
                        goto Random;
                    }
                }
                else
                {
                    Errortex();
                    goto Start;
                }
                static void PrintLine()
                {
                    Console.WriteLine(new string('-', tableWidth));
                }

                static void PrintRow(params string[] columns)
                {
                    int width = (tableWidth - columns.Length) / columns.Length;
                    string row = "|";

                    foreach (string column in columns)
                    {
                        row += AlignCentre(column, width) + "|";
                    }

                    Console.WriteLine(row);
                }

                static string AlignCentre(string text, int width)
                {
                    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                    if (string.IsNullOrEmpty(text))
                    {
                        return new string(' ', width);
                    }
                    else
                    {
                        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                    }
                }
                static void Errortex()
                {
                    Console.Clear();
                    Console.WriteLine("====ERROR====");
                    Console.Write("Enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                static void CheckChoicebacking1()
                {
                    Console.Write("Input y = Continue | n = Close Program | m = goto Menu : ");
                }
            }
        }
    }
}