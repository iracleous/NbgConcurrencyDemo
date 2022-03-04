using NbgConcurrencyDemo;
using NbgConcurrencyDemo2;

Breakfast breakfast = new();
breakfast.MakeBreakfast();

Console.WriteLine("--------------------");

Console.WriteLine("The async task is about to start");
AsynchronousBreakfast breakfastAsync = new AsynchronousBreakfast();
Task breakfastTask =  breakfastAsync.MakeBreakfastAsync();
Console.WriteLine("the async breakfast is being prepared");

await breakfastTask;
Console.WriteLine("the async breakfast has been prepared");