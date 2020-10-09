using System;
using System.Threading;

namespace CNAWeek2Task1 {
    public class Multithreading {
        public static void Function() {
            for (int i = 100; i >= 0; i--) {
                Console.WriteLine("Thread 1: " + i);
                Thread.Sleep(100);
            }
        }
    }

    class main {
        static void Main(string[] args) {
            Thread thread1 = new Thread(Multithreading.Function);
            thread1.Start();

            for (int i = 0; i <= 100; i++) {
                Console.WriteLine("Main: " + i);
                Thread.Sleep(100);
            }
        }
    }
}
