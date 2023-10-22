using System;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = new int[10];
            int firstRoll, secondRoll = 0;
            int preLastRoll, lastRoll = 0;
            int bonusRoll = 0;
            int[] roll = new int[21];
            int counter = 0;
            
            
           for (int i = 0; i < 10; i++)
           {

                if (i + 1 == 10)
                {
                    Console.WriteLine($"Frejm {i + 1}");
                    Console.WriteLine("Bacanje 1 : ");
                    preLastRoll = int.Parse(Console.ReadLine());
                    roll[counter] = preLastRoll;

                    if (preLastRoll == 10)
                    {
                        Console.WriteLine("STRIKE");
                        Console.WriteLine("Bonus bacanje : ");
                        bonusRoll = int.Parse(Console.ReadLine());
                        tabela[i] = 10 + bonusRoll;
                        counter++;
                        roll[counter] = bonusRoll;
                        break;


                    }

                    Console.WriteLine("Bacanje 2 : ");
                    lastRoll = int.Parse(Console.ReadLine());
                    counter++;
                    roll[counter] = lastRoll;

                    if (preLastRoll + lastRoll == 10)
                    {
                        Console.WriteLine("SPARE");
                        Console.WriteLine("Bonus bacanje : ");
                        bonusRoll = int.Parse(Console.ReadLine());
                        tabela[i] = 10 + bonusRoll;
                        counter++;
                        roll[counter] = bonusRoll;
                        break;
                    }

                    tabela[i] = preLastRoll + lastRoll;



                }
                else
                {

                    Console.WriteLine("----------------------");
                    Console.WriteLine($"Frejm {i + 1}");
                    Console.WriteLine("Bacanje 1 : ");
                    firstRoll = int.Parse(Console.ReadLine());
                    roll[counter] = firstRoll;


                    if (firstRoll == 10)
                    {
                        Console.WriteLine("STRIKE");
                        //tabela[i] = 10 + Bonus(i + 1, tabela);
                        roll[counter + 1] = 0;
                        counter += 2;
                        continue;
                    }


                    Console.WriteLine("Bacanje 2 : ");
                    secondRoll = int.Parse(Console.ReadLine());
                    counter++;
                    roll[counter] = secondRoll;
                    counter++;
                    tabela[i] = firstRoll + secondRoll;

                    if (firstRoll + secondRoll == 10)
                    {
                        Console.WriteLine("SPARE");
                        tabela[i] = 10;
                        continue;

                    }

                }
                
           }

            int f = 0;

            for (int i = 0; i < 18; i+=2)
            {
                if (i%2 == 0 && roll[i] == 10)
                {
                    if (i+3 < 21)
                    {
                        tabela[f] = 10 + roll[i + 2] + roll[i + 3];
                        f++;
                    }
                   
                    continue;
                }
                else f++;

            }

            int b = 0;
            for (int i = 0; i<18; i+= 2)
            {
                if (i%2==0 && roll[i+1] > 0 && roll[i] + roll[i + 1] == 10)
                {
                    tabela[b] = 10 + roll[i + 2];
                    b++;
                    continue;
                }
                else b++;

            }


            Console.WriteLine("*******************");
            Console.WriteLine("REZULTAT BACANJA:");
            for (int i = 0; i < 21; i++)
            {
   
                Console.Write(roll[i] + " | ");
            }

            Console.WriteLine("\n*******************");
            Console.WriteLine("REZULTAT FREJMOVA :");
            for (int i = 0; i < 10; i++)
            {
               
                Console.Write(tabela[i] + " | ");
            }

           /* static int Bonus(int nextFrame, int[] tabela)
            {
                int bonus = 0;
                if (nextFrame < 10)
                {
                    bonus = tabela[nextFrame];
                    tabela[nextFrame - 1] = 10 + bonus;
                }
                return bonus;
            } */




        }

       

        
    }
}
