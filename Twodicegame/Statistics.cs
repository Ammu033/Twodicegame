using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Twodicegame
{  //This class will hold the value of palyer's name, number of roll's and sum of that rolls;


    public class Statictics : SevensOut

    {

        public override void Play()
        {
            // this will print info about game 
            Console.WriteLine("Sevens Out Game");
            Console.Write("please enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write("please write the name of opponent player: ");
            string name2 = Console.ReadLine();

            int total1 = 0;
            int total2 = 0;
            while (total1 != 7 || total2 != 7) // This will continue the loop unit one of total go over 20;
            {
                // value's specified;
                int roll1 = RollDie();
                int roll2 = RollDie();



                // for Player 1's turn;
                Console.Write($"'{name1}' please press 'r' to roll: ");
                string verify = Console.ReadLine();
                if (verify != "r")
                {
                    Console.WriteLine("please enter a valid input");
                }
                if (verify == "r")
                {

                    Console.WriteLine($"Rolled: {roll1}");
                    total1 += roll1;
                    Console.WriteLine($"{name1}'s total score is: {total1}");

                    if (total1 >= 7)
                    {
                        Console.WriteLine($"{name1} reached or exceeded 7. Game Over.");
                        break;
                    }
                }

                //for second player turn
                Console.Write($"'{name2}'please press 'r' to roll: ");
                string confirm = Console.ReadLine();
                if (confirm == "r")
                {
                    Console.WriteLine($"Rolled: {roll2}");
                    total2 += roll2;
                    Console.WriteLine($"{name2}'s total score is: {total2}");

                }
                if (total2 >= 7)
                {
                    Console.WriteLine($"{name2} your total score is over 7 game over");
                }
                    



            }

        }

    }
    public class computer: SevensOut // computer's automatic roll in this class
    {
        public override void Play() //interface usage
        {
            Console.WriteLine("Sevens Out Game");
            Console.Write("please enter your name: ");
            string name1 = Console.ReadLine();

            string name2 = "computer";
            int total1 = 0;
            int total2 = 0;
            while (total1 != 7 || total2 != 7)
            {
                int rol1 = RollDie();
                int rol2 = RollDie();



                // for Player 1's turn
                Console.Write($"'{name1}' please press 'r' to roll: ");
                string verify = Console.ReadLine();
                if (verify != "r")
                {
                    Console.WriteLine("please enter a valid input");
                }
                if (verify == "r")
                {

                    Console.WriteLine($"Rolled: {rol1}");
                    total1 += rol1;
                    Console.WriteLine($"{name1}'s total score is: {total1}");

                    if (total1 >= 7)
                    {
                        Console.WriteLine($"{name1} reached or exceeded 7. Game Over.");
                        break;
                    }
                }
                //for computer' turn


                if (verify == "r")
                {
                    Console.WriteLine($"'{name2}' Rolled: {rol2}");
                    total2 += rol2;
                    Console.WriteLine($"{name2}'s total score is: {total2}");

                }
                if (total2 >= 7)
                {
                    Console.WriteLine("your total score is over 7 game over");
                }






            }
        }
    }
    public class Statistics : ThreeOrMore 
    {
        public override void Play()
        {
            Console.WriteLine("THREE OR MORE");
            Console.Write("please enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write("please write the name of opponent player: ");
            string name2 = Console.ReadLine();

            int total = 0;
            int total2 = 0;
            int roll1 = RollDie();
            int roll2 = RollDie();
            int roll3 = RollDie();
            int roll4 = RollDie();
            int roll5 = RollDie();
            int score1 = 3;
            int score2 = 6;
            int score3 = 12;
            
            while (total != 20 || total2 != 20)// will continue loop untill sum will be over 20;
            {
                Console.Write($"{name1} please press 'r' to roll: ");
                string verify = Console.ReadLine();
                if (verify == "r")
                {
                    Console.WriteLine($"rolled ; {roll1}, {roll2}, {roll3}, {roll4}, {roll5}");
                    if (roll2 == 2)
                    {
                        Console.Write("oh you can roll the dice again 'type 'ok''; ");
                        string input = Console.ReadLine();
                        if (input == "ok")
                        {
                            continue;
                        }

                    }
                    else
                    {
                        total += roll1 + roll2 + roll3 + roll4 + roll5;
                        Console.WriteLine($"{name1}'s total score is: {total}");
                    }
                    if ( roll3 == 3)
                    {
                        total += roll1 + roll2 + score2 + roll4 + roll5;
                        Console.WriteLine($"{name1}'s total score is: {total}");
                    }
                    if (roll5 == 5)
                    {
                        total += roll1 + roll2 + roll3 + roll4 + score3;
                        Console.WriteLine($"as you got 5 at end so you got 12 score in your total score: {total}");
                    }
                    if (total >= 20)
                    {
                        Console.WriteLine("you reached the maximum score over 20 game over ");
                        break;
                    }

                }
                //for player second 
                Console.Write($"'{name2}'please press 'r' to roll: ");
                string confirm = Console.ReadLine();
                if (confirm == "r")
                {
                    Console.WriteLine($"Rolled: {roll2}, {roll1}, {roll3}, {roll4}, {roll5}");

                    if (roll2 == 2)
                    {
                        Console.Write("oh you can roll the dice again 'type 'ok''; ");
                        string input = Console.ReadLine();
                        if (input == "ok")
                        {
                            continue;
                        }

                    }
                    else
                    {
                        total2 += roll1 + roll2 + roll3 + roll4 + roll5;
                    }
                    if (roll3 == 3)
                    {
                        total2 += roll1 + roll2 + score2 + roll4 + roll5;
                    }
                    if (roll5 == 5)
                    {
                        total2 += roll1 + roll2 + roll3 + roll4 + score3;
                        Console.WriteLine($"as you got 5 at end so you got 12 score in your total score: {total}");
                    }
                    if (total2 >= 20)
                    {
                        Console.WriteLine("you reached the maximum score over 20 game over ");
                        break;
                    }

                }
                
                




            }
        }
    }
    public class computer2 : Statistics
    {
        public override void Play()
        {
            Console.WriteLine("THREE OR MORE");
            Console.Write("please enter your name: ");
            string name1 = Console.ReadLine();

            string name2 = "computer";

            int total = 0;
            int total2 = 0;
            int roll1 = RollDie();
            int roll2 = RollDie();
            int roll3 = RollDie();
            int roll4 = RollDie();
            int roll5 = RollDie();
            int score1 = 3;
            int score2 = 6;
            int score3 = 12;

            while (total != 20 || total2 != 20)
            {
                Console.Write($"{name1} please press 'r' to roll: ");
                string verify = Console.ReadLine();
                if (verify == "r")
                {
                    Console.WriteLine($"rolled ; {roll1}, {roll2}, {roll3}, {roll4}, {roll5}");
                    if (roll2 == 2)
                    {
                        Console.Write("oh you can roll the dice again 'press 'r''; ");
                        string input = Console.ReadLine();
                        if (input == "r")
                        {
                            continue;
                        }

                    }
                    else
                    {
                        total += roll1 + roll2 + roll3 + roll4 + roll5;
                        Console.WriteLine($"{name1}'s total score is: {total}");
                    }
                    if (roll3 == 3)
                    {
                        total += roll1 + roll2 + score2 + roll4 + roll5;
                        Console.WriteLine($"{name1}'s total score is: {total}");
                        Console.WriteLine($"{name1}'s got 3 at third position so you got extra 3 as well");
                    }
                    if (roll5 == 5)
                    {
                        total += roll1 + roll2 + roll3 + roll4 + score3;
                        Console.WriteLine($"as you got 5 at end so you got 12 score in your total score: {total}");
                    }
                    if (total >= 20)
                    {
                        Console.WriteLine("you reached the maximum score over 20 game over ");
                        break;
                    }

                }
                // for computer's turn
               
                    Console.WriteLine($"{name2} Rolled: {roll2}, {roll1}, {roll3}, {roll4}, {roll5}");

                    if (roll2 == 2)
                    {
                        Console.Write("oh you can roll the dice again 'press 'r''; ");
                        string input = Console.ReadLine();
                        if (input == "r")
                        {
                            continue;
                        }

                    }
                    else
                    {
                        total2 += roll1 + roll2 + roll3 + roll4 + roll5;
                        Console.WriteLine("{name2}'s total: {total2}");
                    }
                    if (roll3 == 3)
                    {
                        total2 += roll1 + roll2 + score2 + roll4 + roll5;
                        Console.WriteLine("{name2}'s total: { total2}");
                    }
                    if (roll5 == 5)
                    {
                        total2 += roll1 + roll2 + roll3 + roll4 + score3;
                      
                        Console.WriteLine($"{name2} got 5 at end so you got 12 score in your total score: {total2}");
                        Console.WriteLine($"{name2}' total's: {total2}");
                    }
                    if (total2 >= 20)
                    {
                        Console.WriteLine("you reached the maximum score over 20 game over ");
                        break;
                    }

                


            }
        }
    }
}


