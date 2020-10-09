using System;
using System.Threading;

namespace CNAWeek2Task2 {
    public class Multithreading {
        static private int id;

        public Multithreading (int identity) {
            id = identity;
        }

        static public void Function() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Thread " + id);
                Thread.Sleep(100);
            }
        }
    }

    class main {
        static void Main(string[] args) {
            const int threadAmount = 5;

            List<Thread> threads = new List<Thread>();

            for (int i = 0; i <= threadAmount; i++) {
                Multithreading mt = new Multithreading(i);
                threads.Add(new Thread(new ThreadStart(mt.Function)));
                threads[i].Start();
            }
        }
    }
}
