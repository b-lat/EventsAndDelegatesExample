namespace EventsAndDelegatesExample
{
    using System;

    public class MessageService
    {
        public void OnStackOverflowed(object source, EventArgs e)
        {
            Console.WriteLine("Alert! Alert! The stack has overflowed. Run for your lives!!");
        }
    }
}
