using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Twodicegame;

public class punjab
{
        
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("1. SEVENSOUT ");
            Console.WriteLine("2. THREEORMORE ");
            Console.Write("please choose your game type'press 1 for 'SEVENSOUT' AND 2 FOR 'THREEORMORE' : ");// This will offer user to choos the type of game he/she want to play
            int choose = int.Parse(Console.ReadLine());
           
           

             if (choose == 1)

             {
                //offer choice with  friend or computer 
                Console.Write("You choose SEVENSOUT ");
                Console.WriteLine("Please choose one option");
                Console.WriteLine("1. Play with friend " +
                    "2. play with computer:  ");
                while (true) //will continue the loop
                {
                    Console.Write("press 1 for friend and 2 for computer");
                    int confirm = int.Parse(Console.ReadLine());
                    

                    if (confirm == 1)
                    {

                        Game sevensOutgame = new Statictics();
                        sevensOutgame.Play();

                    }
                    if (confirm == 2)
                    {
                        Game ammudon = new computer();
                        ammudon.Play();
                    }
                    if (confirm != 1 || confirm == 2)
                    {
                        Console.WriteLine("let's continue");
                        continue;

                    }
                }
             }
             if (choose == 2)
             {
                Console.WriteLine("You choose THREE OR MORE ");
                Console.WriteLine("Please choose one option");
                Console.WriteLine("1. Play with friend " +
                    "2. play with computer");
                while (true)
                {
                    Console.Write("press 1 for friend and 2 for computer");

                    int confirm = int.Parse(Console.ReadLine());
                   

                    if (confirm == 1)
                    {

                        Game sevensOutgame = new Statistics();
                        sevensOutgame.Play();

                    }
                    if (confirm == 2)
                    {
                        Game ammudon = new computer2();
                        ammudon.Play();
                    }
                    if (confirm != 1 || confirm == 2)
                    {
                        Console.WriteLine("invalid input");
                        continue;

                    }
                }



             }

               

                

                


           
            
        }
    }



}


