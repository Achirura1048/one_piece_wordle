using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WAN_PİSU_ISREAL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int num = random.Next(0, chars.karakterler.Length);
            /*int num = 11;*/

            Console.WriteLine("ŞUAN OLAN chars.karakterler: ");
            for (int i = 0; i < chars.karakterler.Length; i++)
            {

                Console.Write(chars.karakterler[i].name + " , ");
            }


            Console.Write("\n\nKarakter İsmi Giriniz: ");

            bool dongu = false;
            while (dongu == false)
            {

                string name = Console.ReadLine();
                name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

                int krt = -1;

                for (int i = 0; i < chars.karakterler.Length; i++)
                {

                    if (name == chars.karakterler[i].name)
                    {
                        krt = i;

                        break;
                    }


                }

                name = chars.karakterler[krt].name;
                Console.WriteLine(chars.karakterler[num].name);
                string gender = chars.karakterler[krt].gender;
                string crew = chars.karakterler[krt].crew;
                string df = chars.karakterler[krt].df;
                string df2 = chars.karakterler[krt].df2;
                string conq_haki = chars.karakterler[krt].conq_haki;
                string arm_haki = chars.karakterler[krt].arm_haki;
                string obv_haki = chars.karakterler[krt].obv_haki;
                uint bounty = chars.karakterler[krt].bounty;
                string origin = chars.karakterler[krt].origin;
                string arc = chars.karakterler[krt].arc;
                
                if (name == chars.karakterler[num].name)
                {
                    Console.Write("Gender = " + chars.karakterler[num].gender);
                    Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Affilation = " + chars.karakterler[num].crew);
                    Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ForegroundColor = ConsoleColor.White;



                    if (chars.karakterler[num].df == "Logia" && chars.karakterler[num].df2 == "Paramecia")
                    {
                        Console.Write("Devil Fruit = " + chars.karakterler[num].df);
                        Console.Write(" [Ok] , ", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(chars.karakterler[num].df2);
                        Console.WriteLine(" [Ok]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.Write("Devil Fruit " + chars.karakterler[num].df);
                        Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (conq_haki == chars.karakterler[num].conq_haki &&
                        arm_haki == chars.karakterler[num].arm_haki &&
                        obv_haki == chars.karakterler[num].obv_haki

                       )
                    {
                        Console.Write("Haki = ");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Conqueror's Haki ");

                        Console.Write(" Armament Haki ");

                        Console.WriteLine(" Observation Haki ");
                        
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write("Bounty = " + chars.karakterler[num].bounty);
                    Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Origin " + chars.karakterler[num].origin);
                    Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Debut Arc " + chars.karakterler[num].arc);
                    Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ForegroundColor = ConsoleColor.White;




                    Console.WriteLine("BİLDİN LAN LES GO");
                    break;



                }


                else if (gender != chars.karakterler[num].name)
                {

                    if (gender == chars.karakterler[num].gender)
                    {
                       
                        Console.Write("Gender = " + chars.karakterler[num].gender);
                        Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.Write("Gender = " + chars.karakterler[krt].gender);
                        Console.WriteLine(" [NO]", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    if (crew == chars.karakterler[num].crew)
                    {
                        Console.Write("Affilation = " + chars.karakterler[num].crew);
                        Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.Write("Affilation = " + chars.karakterler[krt].crew);
                        Console.WriteLine(" [NO]", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("Devil Fruit = ");
                    switch(name == "Black Beard")
                    {
                        case true:

                             if(df != chars.karakterler[num].df && df == chars.karakterler[num].df2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(chars.karakterler[krt].df2);
                                
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (df == chars.karakterler[num].df && df != chars.karakterler[num].df2)
                            {

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(chars.karakterler[krt].df2);

                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else if (chars.karakterler[num].df == "Paramecia")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(chars.karakterler[krt].df2);

                                Console.ForegroundColor = ConsoleColor.White;

                            }

                            else if (chars.karakterler[num].df == "None")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(chars.karakterler[krt].df2);

                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(chars.karakterler[krt].df2);

                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case false:

                            if (df == chars.karakterler[num].df)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;

                            }

                            else if(df == chars.karakterler[num].df2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(chars.karakterler[krt].df + " ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            break;

                    }


                    Console.Write("\nHaki = ");

                    if (conq_haki == chars.karakterler[num].conq_haki)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Conqueror's Haki ");                      
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if(conq_haki == "None")
                    {
                        Console.Write("");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Conqueror's Haki ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (arm_haki == chars.karakterler[num].arm_haki)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Armament Haki ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (arm_haki == "None")
                    {
                        Console.Write("");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" Armament Haki ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (obv_haki == chars.karakterler[num].obv_haki)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" Observetion Haki ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (obv_haki == "None")
                    {
                        Console.Write("");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Observetion Haki ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        


                    if (bounty == chars.karakterler[num].bounty)
                    {
                        Console.Write("Bounty = " + chars.karakterler[num].bounty);
                        Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (bounty < chars.karakterler[num].bounty)
                    {
                        Console.Write("Bounty = " + chars.karakterler[krt].bounty);
                        Console.WriteLine(" <", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (bounty > chars.karakterler[num].bounty)
                    {
                        Console.Write("Bounty = " + chars.karakterler[krt].bounty);
                        Console.WriteLine(" >", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;
                    }



                    if (origin == chars.karakterler[num].origin)
                    {
                        Console.Write("Origin = " + chars.karakterler[num].origin);
                        Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.Write("Origin = " + chars.karakterler[krt].origin);
                        Console.WriteLine(" [NO]", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (arc == chars.karakterler[num].arc)
                    {
                        Console.Write("Debut Arc = " + chars.karakterler[num].arc);
                        Console.WriteLine(" [OK]", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        Console.Write("Debut Arc = " + chars.karakterler[krt].arc);
                        Console.WriteLine(" [No]", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ForegroundColor = ConsoleColor.White;

                    }




                    Console.Write("\nTekrar Deneyin: ");

                }





                
            }
            Console.ReadLine();
        }
    }
}

