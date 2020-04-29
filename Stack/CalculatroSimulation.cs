using System;
using System.Collections.Generic;
using System.Text;

namespace StackUsinLinkedList
{
    class CalculatroSimulation
    {
        static void Main(string[] args)
        {
            LinkedListStack list = new LinkedListStack();
            while(true)
            {
                Console.WriteLine("Select an action : push, pop, peek!");
                string input = Console.ReadLine();
                input=input.ToLower();
                if (input=="push")
                {
                    Console.WriteLine("Select integer to push on stack!");
                    double integer = Double.Parse(Console.ReadLine());
                    list.push(integer);
                }
                else if (input=="pop")
                {
                    list.pop();
                }
                else if (input=="peek")
                {
                    list.peek();
                }
                else if(input=="operation")
                {
                    Console.WriteLine("What would you like to do : add, subtract, multiply, divide?");
                    string operation = Console.ReadLine();
                    list.performOperation(operation);
                }
            }
            
         

        }
    }
}
