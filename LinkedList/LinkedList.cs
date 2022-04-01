﻿namespace LinkedLists
{
    public class LinkedList
    {
        private Node _head;

        private Node _tail;

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

        public LinkedList(int[] values)
        {
            if (values == null)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = new Node(values[0]);
                _tail = _head;
                Node crnt = _head;
                for (int i = 1; i < values.Length; i++)
                {
                    crnt.Next = new Node(values[i]);
                    _tail = crnt;
                }

            }
        }

        public void Add(int value)
        {
            if (_head == null)
            {
                _head = new Node(value);
                _tail = _head;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;

            }
        }

    }
}