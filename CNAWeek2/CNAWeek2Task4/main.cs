using System;
using System.Collections.Generic;
using System.Threading;

namespace CNAWeek2Task4 {



    class main {
        static void Main(string[] args) {
            const int threadAmount = 1000;

            for (int i = 0; i <= threadAmount; i++) {
                int num = i;
                new Thread(() => CheckIfPrimeNumber(num)).Start();
            }
        }
        public static void CheckIfPrimeNumber(int number) {
            double numberRoot = Math.Sqrt(number);
            int numberRootInt = (int)numberRoot;

            bool isPrime = true;

            if (numberRoot - numberRootInt != 0) {
                for (int i = 2; i < number; i++) {
                    if (number % i == 0) {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) Console.WriteLine("Prime Number Found: " + number);
            }
        }

    }
}
