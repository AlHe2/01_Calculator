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
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        public void Run() {
            bool running = true;
            string choice = "";

            do {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice) {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "9": running = false; break;
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

        private void DoActionFor1() {
            throw new NotImplementedException();
        }

        private string GetUserChoice() {
            throw new NotImplementedException();
        }

        private void ShowMenu() {
            throw new NotImplementedException();
        }
    }
}
