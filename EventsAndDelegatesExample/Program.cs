using System;

namespace EventsAndDelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=jQgwEsJISy0
            var stack = new Stack();
            var stackBuilder = new StackBuilder(stack); //publisher
            var messageService = new MessageService(); //subscriber
            var boomBoomBoomService = new BoomBoomBoomService(); //another subscriber

            //register subscribers
            stackBuilder.StackOverflowed += messageService.OnStackOverflowed;
            stackBuilder.StackOverflowed += boomBoomBoomService.OnStackOverflowed;


            while (!stackBuilder.Stack.Overflow)
            {
                Console.WriteLine("Enter an number:");
                var numberOfItems = 0;

                int.TryParse(Console.ReadLine(), out numberOfItems);

                stackBuilder.AddStackItems(numberOfItems);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
