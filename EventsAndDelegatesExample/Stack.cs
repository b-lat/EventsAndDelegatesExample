namespace EventsAndDelegatesExample
{
    using System;

    public class Stack
    {
        private int Threshold = 10;
        public bool Overflow { get; set; }

        private int stackItems;

        public Stack()
        {
            this.Overflow = false;
            this.stackItems = 0;
        }

        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        public delegate void StackOverflowedEventHandler(object source, EventArgs args);

        public event StackOverflowedEventHandler StackOverflowed;

        protected internal void AddStackItems(int numberOfItems)
        {
            this.stackItems += numberOfItems;
            Console.WriteLine($"Stack is at {this.stackItems}");
            if (this.stackItems > this.Threshold)
            {
                this.Overflow = true;
                this.OnStackOverflowed();
            }
        }

        protected virtual void OnStackOverflowed()
        {
            if (this.StackOverflowed != null)
            {
                StackOverflowed(this, EventArgs.Empty);
            }
        }
    }
}
