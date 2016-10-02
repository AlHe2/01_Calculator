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
            do {
                ShowMenu();
                choice = GetUserChoice();
                Console.WriteLine();
                Console.WriteLine();
                switch (choice) {
                    case '1': Console.WriteLine("ADDITION"); AddAction(); break;
                    case '2': Console.WriteLine("SUBTRACTION"); Subtract2Action(); break;
                    case '3': Console.WriteLine("MULTIPLICATION"); MultiplyAction(); break;
                    case '4': Console.WriteLine("POWER"); PowerAction(); break;
                    case '5': Console.WriteLine("FACTORIAL"); FactorialAction(); break;
                    case '9': Console.WriteLine("Bye, bye!"); running = false; break;
                    default:  ShowMenuSelectionError(); break;
                }
                Console.Write("Press a key to continue.....");
                Console.ReadKey();
            } while (running);
        }

        private void ShowMenu() {
            Console.Clear();
            Console.WriteLine("Choose from the following operations : ");
            Console.WriteLine("   1. Add numbers");
            Console.WriteLine("   2. Subtract two numbers");
            Console.WriteLine("   3. Multiply numbers");
            Console.WriteLine("   4. Calculate x to the power of y");
            Console.WriteLine("   5. Calculate factorial(x)");
            Console.WriteLine("   9. Exit");
        }
        private void ShowMenuSelectionError() {
            Console.WriteLine("Whoops - that selection is not valid!!");
        }

        private void FactorialAction() {
            int[] numbers = GetNumbers();
            Console.Write("Factorial of " + numbers[0] + " is : ");
            Console.WriteLine(Calculator.Factorial(numbers[0]));
        }

        private void PowerAction() {
            int[] numbers = GetNumbers();
            Console.Write(numbers[0] + " to the power of " + numbers[1] + " is : ");
            Console.WriteLine(Calculator.Power(numbers[0], numbers[1]));
        }

        private void MultiplyAction() {
            int[] numbers = GetNumbers();
            Console.Write("The numbers ");
            ShowNumbers(numbers);
            Console.Write(" multiplied is : ");
            Console.WriteLine(Calculator.Multiply(numbers));
        }

        private void Subtract2Action() {
            int[] numbers = GetNumbers();
            Console.Write(numbers[0] + " minus " + numbers[1] +" is : ");
            Console.WriteLine(Calculator.Subtract(numbers[0], numbers[1]));
        }

        private void AddAction() {
            int[] numbers = GetNumbers();
            Console.Write("The numbers ");
            ShowNumbers(numbers);
            Console.Write(" added is : ");
            Console.WriteLine(Calculator.Sum(numbers));
        }

        private void ShowNumbers(int[] numbers) {
            foreach (int n in numbers) {
                Console.Write(n + " ");
            }
        }

        private int[] GetNumbers() {
            string input;
            Console.WriteLine("Enter the numbers you want to use seperated by spaces. ");
            Console.WriteLine("Entries not representing a number will be replaced with a 0 (zero)");
            input = Console.ReadLine();
            Console.WriteLine();

            string[] strings = input.Split();
            int[] numbers = new int[strings.Length];

            int index = 0;
            foreach(string s in strings) {
                try {
                    numbers[index] = Int32.Parse(s.Trim());
                } catch {
                    numbers[index] = 0;
                } finally {
                    index++;
                }
            }
            return numbers;
        }

        private char GetUserChoice() {
            Console.Write("Type the number for your selection : ");
            return Console.ReadKey().KeyChar; 
            //ReadKey returns a ConsoleKeyInfo that has a property KeyChar to get the actual char
        }
    }
}
