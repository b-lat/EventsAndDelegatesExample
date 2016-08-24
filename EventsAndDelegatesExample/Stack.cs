namespace EventsAndDelegatesExample
{
    public class Stack
    {
        private int threshold = 10;

        private bool overflow;

        public int StackItems { get; set; }

        public bool Overflow
        {
            get
            {
                return overflow;
            }
        }

        public Stack()
        {
            overflow = false;
            StackItems = 0;
        }

        public bool AddItem(int numberOfItems)
        {
            StackItems += numberOfItems;

            if (StackItems > threshold)
            {
                overflow = true;
            }

            return overflow;
        }
    }
}
