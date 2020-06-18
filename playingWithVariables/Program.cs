using System;

namespace playingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variable Declarations
            int age;
            string name;
            bool isAlive;
            //Variable initializations//
            age = 44;
            name = "Dan";
            isAlive = true;

            string dogName = "Gebirah";
            int dogAge = 13;

            
            Console.WriteLine($"My dog's name is {dogName}, and she is {dogAge} years old.");

            Console.WriteLine($"{name} {age} is he alive: {isAlive}");

        }
    }
}
