using System;

namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        internal static int Subtract(int firstNumber, int secondNumber) {
            return firstNumber - secondNumber;
        }

        internal static int Sum(int[] numbers) {
            int result = 0;
            foreach(int x in numbers) {
                result = result + x;
            }
            return result;
        }

        internal static int Multiply(int firstNumber, int secondNumber) {
            return firstNumber * secondNumber;
        }

        internal static int Multiply(int[] numbers) {
            int result = 1;
            foreach (int x in numbers) {
                result = result * x;
            }
            return result;
        }

        internal static int Power(int firstNumber, int secondNumber) {
            int result = 1;
            for (int i = 0; i < secondNumber; i++) {
                result = result * firstNumber;
            }
            return result;
        }

        internal static int Factorial(int number) {
            int result = 1; 
            for (int i = number; i > 0; i = i - 1) { //note: i = i - 1; is the same as i--;
                result = result * i;
            }
            return result;
        }
    }
}