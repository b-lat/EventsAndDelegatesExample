namespace EventsAndDelegatesExample
{
    using System;

    public class MessageService
    {
        public void OnStackOverflowed(object source, StackEventArgs e)
        {
            Console.WriteLine($"Alert! Alert! The stack has overflowed at {e.Stack.StackItems}. Run for your lives!!");
        }
    }
}
