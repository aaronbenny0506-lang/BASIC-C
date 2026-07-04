// BasicsDemo.cs
// Demonstrates core C# fundamentals: variables & data types, loops,
// conditional statements, and classes & objects.
// This is plain C# (not Unity-specific) — useful for learning syntax
// before applying it inside Unity scripts.

using System;

namespace CSharpLearningPhase1
{
    // --------------------------------------------------------------
    // CLASSES & OBJECTS
    // A class is a blueprint. Here, Player is a simple class with
    // its own variables (fields) and a method (behavior).
    // --------------------------------------------------------------
    class Player
    {
        // VARIABLES & DATA TYPES
        public string name;   // string: holds text
        public int health;    // int: whole numbers
        public float speed;   // float: decimal numbers

        // Constructor: runs when a new Player object is created
        public Player(string name, int health, float speed)
        {
            this.name = name;
            this.health = health;
            this.speed = speed;
        }

        public void TakeDamage(int amount)
        {
            health -= amount;

            // CONDITIONAL STATEMENTS
            if (health <= 0)
            {
                Console.WriteLine($"{name} has been defeated!");
            }
            else
            {
                Console.WriteLine($"{name} took {amount} damage. Health remaining: {health}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an OBJECT (an instance of the Player class)
            Player hero = new Player("Hero", 100, 5.5f);

            Console.WriteLine($"Player created: {hero.name}, Health: {hero.health}, Speed: {hero.speed}");
            Console.WriteLine();

            // LOOPS: for loop
            Console.WriteLine("-- Simulating 3 rounds of combat (for loop) --");
            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine($"Round {round}:");
                hero.TakeDamage(20);
            }

            Console.WriteLine();

            // LOOPS: while loop
            Console.WriteLine("-- Countdown using a while loop --");
            int countdown = 3;
            while (countdown > 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }
            Console.WriteLine("Go!");

            Console.WriteLine();

            // CONDITIONAL STATEMENTS: switch
            Console.WriteLine("-- Checking difficulty level (switch) --");
            int difficulty = 2;
            switch (difficulty)
            {
                case 1:
                    Console.WriteLine("Easy mode selected.");
                    break;
                case 2:
                    Console.WriteLine("Normal mode selected.");
                    break;
                case 3:
                    Console.WriteLine("Hard mode selected.");
                    break;
                default:
                    Console.WriteLine("Unknown difficulty.");
                    break;
            }
        }
    }
}
