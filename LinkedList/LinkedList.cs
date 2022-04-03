namespace LinkedLists
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
            if (values.Length == 0 || values == null)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                _head = new Node(values[0]);
                _tail = _head;
                
                for (int i = 1; i < values.Length; i++)
                {
                    Add(values[i]);
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

        public void AddToStart(int value)   
        {
            if (_head == null)
            {
                _head = new Node(value);
                _tail = _head;
            }
            else
            {
                Node crnt = _head;
                _head = new Node(value);
                _head.Next = crnt;
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentException("index is wrong");
            }
            else if (index == 0)
            {
                AddToStart(value);
            }
            else
            {
                Node prev = GetNodeByIndex(index - 1);
                Node next = GetNodeByIndex(index);
                Node newNode = new Node(value);
                
                newNode.Next = next;
                prev.Next = newNode;
            }
        }

        public void Pop()
        {
            if (Length == 0)
            {
                throw new Exception("List already empty!");
            }
            if (Length == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node prev = GetNodeByIndex(Length - 2);
                prev.Next = null;
                _tail = prev;
            }

        }

        public void PopFromStart()
        {
            if (Length == 0)
            {
                throw new Exception("List already empty!");
            }
            _head = _head.Next;
        }

        public void PopByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new Exception("Index out of range");
            }
            if (index == 0)
            {
                PopFromStart();
            }
            else
            {
                Node prev = GetNodeByIndex(index - 1);
                Node next = GetNodeByIndex(index + 1);

                prev.Next = next;
            }
            
        }

        public void PopElems(int count)
        {
            if (count > Length)
            {
                throw new ArgumentException("count is wrong, count mustn't be higher than Length");
            }
            while (count != 0)
            {
                Pop();
                count--;
            }
        }

        public void PopElemsFromStart(int count)
        {
            if (count > Length)
            {
                throw new ArgumentException("count is wrong, count mustn't be higher than Length");
            }
            while (count != 0)
            {
                PopFromStart();
                count--;
            }
        }

        public void PopElemsByIndex(int index, int count)
        {
            if (count > Length)
            {
                throw new ArgumentException("count is wrong, count mustn't be higher than Length");
            }
            while (count != 0)
            {
                PopByIndex(index);
                count--;
            }
        }

        public int ReturnElementByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new Exception("Index out of range");
            }
            Node crnt = GetNodeByIndex(index);
            return crnt.Value;
        }

        public int FirstIndexByElem(int elem)
        {
            int index = -1;
            Node crnt = _head;
            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value == elem)
                {
                    index = i;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        public void ChangeElemByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new Exception("Index out of range");
            }
            Node crnt = GetNodeByIndex(index);
            crnt.Value = value;
        }

        public void Reverse()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to reverse");
            }

            Node crnt = _head;
            Node tmp;

            while (crnt.Next != null)
            {
                tmp = crnt.Next;
                crnt.Next = tmp.Next;
                tmp.Next = _head;
                _head = tmp;
            }
            _tail = crnt;
        }

        public int GetMaxElem()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _head;
            int max = crnt.Value;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return max;
        }

        public int GetMinElem()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _head;
            int min = crnt.Value;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return min;
        }

        public int GetIndexOfMaxElem()
        {
            if (Length == 0)
            {
                throw new Exception("Empty");
            }

            Node crnt = _head;
            int max = crnt.Value;
            int index = 0;
            int indexOfMax = 0;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    indexOfMax = index;
                }
                index++;
                crnt = crnt.Next;
            }

            return indexOfMax;
        }

        public int GetIndexOfMinElem()
        {
            if (Length == 0)
            {
                throw new Exception("Empty, nthng to find");
            }

            Node crnt = _head;
            int min = crnt.Value;
            int index = 0;
            int indexOfMin = 0;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    indexOfMin = index;
                }
                index++;
                crnt = crnt.Next;
            }

            return indexOfMin;
        }

        public override string ToString()
        {
            string str = "";

            Node crnt = _head;
            while (crnt != null)
            {
                str += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return str;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._head;
            Node listCrnt = list._head;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }

        private Node GetNodeByIndex(int index)
        {
            Node crnt = _head;

            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }

    }
}