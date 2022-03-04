using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgConcurrencyDemo
{
    internal class Coffee
    {
        public int Id { get; set; }
    }

    internal class Egg
    {
        public int Id { get; set; }
    }

    internal class Bacon
    {
        public int Id { get; set; }
    }

    internal class Toast
    {
        public int Id { get; set; }
    }
    internal class Juice
    {
        public int Id { get; set; }
    }

    internal class Breakfast
    {

        public void MakeBreakfast()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        private Juice PourOJ()
        {

            return new Juice();
        }

        private void ApplyJam(Toast toast)
        {
            Console.WriteLine("Start applying...");
            Task.Delay(1000).Wait();
            Console.WriteLine("Jam has been applied");
        }

        private void ApplyButter(Toast toast)
        {
            Console.WriteLine("Start applying...");
            Task.Delay(1000).Wait();
            Console.WriteLine("Butter has been applied");
             
        }

        private Toast ToastBread(int v)
        {
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        private Bacon FryBacon(int v)
        {
            return new Bacon();
        }

        private Egg FryEggs(int v)
        {
            return new Egg();
        }

        private Coffee PourCoffee()
        {
            return new Coffee();
        }
    }
}
