using System;
using System.Threading;

namespace _3_AsynchronousTimer
{
    public class AsyncTimer
    {      
        private int ticks;
        private int t;

        public AsyncTimer(Action<string> action, int ticks, int t)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.T = t;           
        }

        public Action<string> Action { get; private set; }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }

                this.ticks = value;
            }
        }

        public int T
        {
            get
            {
                return this.t;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }

                this.t = value;
            }       
        }

        public void Run()
        {
            var parallel = new Thread(this.Execute);
            parallel.Start();
        }

        private void Execute()
        {
            for (int i = 0; i < this.ticks; i++)
            {
                Thread.Sleep(this.T * 1000);
                Action("Pesho");
            }
        }
    }
}

