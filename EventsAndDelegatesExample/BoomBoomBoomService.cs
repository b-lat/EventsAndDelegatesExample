namespace EventsAndDelegatesExample
{
    using System;

    public class BoomBoomBoomService
    {
        public void OnStackOverflowed(object source, EventArgs e)
        {
            Console.WriteLine("Boom, boom, boom! Let me hear you say wayo!");
        }
    }
}
