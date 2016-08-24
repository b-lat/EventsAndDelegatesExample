using System;

namespace EventsAndDelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=jQgwEsJISy0
            var stack = new Stack(); //publisher
            var messageService = new MessageService(); //subscriber
            var boomBoomBoomService = new BoomBoomBoomService(); //another subscriber

            //register subscribers
            stack.StackOverflowed += messageService.OnStackOverflowed;
            stack.StackOverflowed += boomBoomBoomService.OnStackOverflowed;


            while (!stack.Overflow)
            {
                Console.WriteLine("Enter an number:");
                var numberOfItems = 0;

                int.TryParse(Console.ReadLine(), out numberOfItems);

                stack.AddStackItems(numberOfItems);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
