using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace NbgConcurrencyDemo2
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

        internal class AsynchronousBreakfast
        {

           public async Task MakeBreakfastAsync()
            {
            Coffee cup = PourCoffee();
            Console.WriteLine("Coffee is ready");

            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = ToastBreadAsync(2);

            Toast toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("Toast is ready");
            Juice oj = PourOJ();
            Console.WriteLine("Oj is ready");

            Egg eggs = await eggsTask;
            Console.WriteLine("Eggs are ready");
            Bacon bacon = await baconTask;
            Console.WriteLine("Bacon is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        private async Task<Toast> ToastBreadAsync(int v)
        {
            Console.WriteLine("Start toasting... with " + v);
            await Task.Delay(2000);
            return new Toast();
        }

        private async Task<Egg> FryEggsAsync(int v)
        {
            Console.WriteLine("Start frying... with " + v);
            await Task.Delay(2000);
            return new Egg();
        }

        private async Task<Bacon> FryBaconAsync(int v)
        {
            Console.WriteLine("Start frying... with " + v);
            await Task.Delay(2000);
            return new Bacon();
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

 
