namespace LinkedList
{
    public class LinkedList
    {
        private Node _head;

        private Node _tail;

        public LinkedList()
        {
            _head = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _head;
                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }
                return count;
            }
            private set
            {

            }
        }
    }
}