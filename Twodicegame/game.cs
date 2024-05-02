using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twodicegame
{
    public class Game
    {
        protected Die[] dice; // Change access modifier to protected

        public Game()
        {
            dice = new Die[5]; // Default to five dice for Three or More game
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("Generic game play.");
        }

        public int RollDie()
        {
            return new Die().Roll();
        }
    }

    public class SevensOut : Game
    {
        public SevensOut()
        {
            dice = new Die[2]; // Two dice for Sevens Out game
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
    }

    public class ThreeOrMore : Game
    {
        public ThreeOrMore()
        {
            dice = new Die[5]; // Default to five dice for Three or More game
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }// Default constructor
           
                
        }

       
    }

    

}

