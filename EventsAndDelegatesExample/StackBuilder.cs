using System;

namespace EventsAndDelegatesExample
{
    public class StackEventArgs : EventArgs
    {
        public Stack Stack { get; set; }
    }

    public class StackBuilder
    {
        public Stack Stack;

        public StackBuilder(Stack stack)
        {
            this.Stack = stack;
        }

        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        public delegate void StackOverflowedEventHandler(object source, StackEventArgs args);

        public event StackOverflowedEventHandler StackOverflowed;

        protected internal void AddStackItems(int numberOfItems)
        {
            var overflowed = this.Stack.AddItem(numberOfItems);
            
            Console.WriteLine($"Stack is at {this.Stack.StackItems}");

            if (overflowed)
            {
                OnStackOverflowed(this.Stack);
            }
        }

        protected virtual void OnStackOverflowed(Stack stack)
        {
            if (this.StackOverflowed != null)
            {
                StackOverflowed(this, new StackEventArgs() { Stack = stack });
            }
        }





        

        
    }
}
