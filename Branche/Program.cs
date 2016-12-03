using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branche {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Witaj!");
			Console.ReadLine();
		}
	}


	class MyMath {

		static int Add(int firstNumber, int secondNumber) {
			return firstNumber + secondNumber;
		}

		static int Sub(int firstNumber, int secondNumber) {
			return firstNumber - secondNumber;
		}

		static int Mult(int firstNumber, int secondNumber) {
			return firstNumber * secondNumber;
		}
	}


	class StringOperation {

		static string JoinTexts(string firstText, string secondString) {
			return firstText + secondString;
		}
	}
}
