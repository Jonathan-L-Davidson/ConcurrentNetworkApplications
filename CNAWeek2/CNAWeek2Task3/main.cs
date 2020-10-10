using System;
using System.Collections.Generic;
using System.Threading;

namespace CNAWeek2Task2 {
    public class Multithreading {
        private int id;
        private int start;
        private int end;

        public Multithreading(int _identity, int _start = 0, int _end = 10) {
            id       = _identity;
            start    = _start;
            end      = _end;
        }

        public void Function() {
            for (int i = start; i <= end; i++) {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }

            Multithreading mt1 = new Multithreading(0, end, end + 10);
            Multithreading mt2 = new Multithreading(0, end, end + 10);

            Thread thread1 = new Thread(new ThreadStart(mt1.Function));
            Thread thread2 = new Thread(new ThreadStart(mt2.Function));
            thread1.Start();
            thread2.Start();
        }
    }

    class main {
        static void Main(string[] args) {

            Multithreading mt = new Multithreading(1);
            Thread thread = new Thread(new ThreadStart(mt.Function));
            thread.Start();
        }
    }
}
