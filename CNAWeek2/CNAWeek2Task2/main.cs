using System;
using System.Collections.Generic;
using System.Threading;

namespace CNAWeek2Task2 {
    public class Multithreading {
        private int id;

        public Multithreading (int identity) {
            id = identity;
        }

        public void Function() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Thread " + id);
                Thread.Sleep(500);
            }
        }
    }

    class main {
        static void Main(string[] args) {
            const int threadAmount = 5;

            List<Thread> threads = new List<Thread>();

            for (int i = 0; i <= threadAmount; i++) {
                threads.Add(new Thread(new ThreadStart(new Multithreading(i).Function)));
                threads[i].Start();
            }
        }
    }
}
