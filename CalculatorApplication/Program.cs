using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args) {
            Program myProgram = new Program();
            myProgram.Run();
        }

        public void Run() {
            bool running = true;
            char choice; //so we can use ReadKey to read selection without hitting "Enter"
            int maxNumbers = 10;
            do {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice) {
                    case '1': AddAction(maxNumbers); break;
                    case '2': DoActionFor2(); break;
                    case '3': DoActionFor3(); break;
                    case '9': running = false; break;
                    default: ShowMenuSelectionError(); break;
                }
            } while (running);
        }

        private void ShowMenuSelectionError() {
            throw new NotImplementedException();
        }

        private void DoActionFor3() {
            throw new NotImplementedException();
        }

        private void DoActionFor2() {
            throw new NotImplementedException();
        }

        private void AddAction(int max) {
            int[] numbers = GetNumbers(2, max);
        }

        private int[] GetNumbers(int min, int max) {
            string input;
            int[] numbers = new int[max];
            Console.WriteLine("Enter the " + min + " - " + max + " numbers you want to use seperated by spaces");
            input = Console.ReadLine();
            string[] strings = input.Split();

        }

        private char GetUserChoice() {
            Console.Write("Type the number for your selection : ");
            return Console.ReadKey().KeyChar; 
            //ReadKey returns a ConsoleKeyInfo that has a property KayChar to get the actual char
        }

        private void ShowMenu() {
            Console.WriteLine("Choose from the following operations : ");
            Console.WriteLine("   1. Add numbers");
            Console.WriteLine("   2. Subtract two numbers");
            Console.WriteLine("   3. Multiply numbers");
            Console.WriteLine("   4. Calculate x to the power of y");
            Console.WriteLine("   5. Calculate factorial(x)");
            Console.WriteLine("   9. Exit");
        }
    }
}
