using System;

namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Subtract(int firstNumber, int secondNumber) {
            return firstNumber - secondNumber;
        }

        public static int Sum(int[] numbers) {
            int result = 0;
            foreach(int x in numbers) {
                result = Add(result, x);
            }
            return result;
        }

        public static int Multiply(int firstNumber, int secondNumber) {
            return firstNumber * secondNumber;
        }

        public static int Multiply(int[] numbers) {
            int result = 1;
            foreach (int x in numbers) {
                result = result * x;
            }
            return result;
        }

        public static int Power(int firstNumber, int secondNumber) {
            int result = 1;
            for (int i = 0; i < secondNumber; i++) {
                result = result * firstNumber;
            }
            return result;
        }

        public static int Factorial(int number) {
            int result = 1; 
            for (int i = number; i > 0; i = i - 1) { //note: i = i - 1; is the same as i--;
                result = result * i;
            }
            return result;
        }
    }
}