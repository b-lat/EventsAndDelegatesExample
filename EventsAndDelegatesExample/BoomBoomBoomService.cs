namespace EventsAndDelegatesExample
{
    using System;

    public class BoomBoomBoomService
    {
        public void OnStackOverflowed(object source, StackEventArgs e)
        {
            for (int i = 0; i < e.Stack.StackItems; i++)
            {
                Console.WriteLine("Boom, boom, boom. Let me hear you say wayo. Wayo!!");
            }
        }
    }
}
