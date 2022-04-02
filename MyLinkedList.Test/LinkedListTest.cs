using LinkedLists;
using NUnit.Framework;
using System.Collections;

namespace MyLinkedList.Test
{
    public class Tests
    {
        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest(int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.Add(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddToStartTestSource))]
        public void AddToStartTest(int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddToStart(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopTestSource))]
        public void PopTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.Pop();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopFromStartTestSource))]
        public void PopFromStartTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.PopFromStart();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopByIndexTestSource))]
        public void PopByIndexTest(int index, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.PopByIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsTestSource))]
        public void PopElemsTest(int count, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.PopElems(count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsFromStartTestSource))]
        public void PopElemsFromStartTest(int count, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.PopElemsFromStart(count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsByIndexTestSource))]
        public void PopElemsByIndexTest(int index, int count, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.PopElemsByIndex(index, count);
            Assert.AreEqual(expectedList, actualList);
        }
    }

    public class AddTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 5, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 3, 4, 5 }) };
            yield return new object[] { 2, new LinkedList(new int[] { 1, 4, 3 }), new LinkedList(new int[] { 1, 4, 3, 2 }) };
        }
    }

    public class AddToStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new LinkedList(new int[] { 3, 4 }), new LinkedList(new int[] { 2, 3, 4 }) };
            yield return new object[] { 5, new LinkedList(new int[] { 1, 4, 3 }), new LinkedList(new int[] { 5, 1, 4, 3 }) };
        }
    }

    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, 4, new LinkedList(new int[] { 1, 2, 3 }), new LinkedList(new int[] { 1, 2, 4, 3 }) };
        }
    }

    public class PopTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] {new LinkedList(new int[] { 2 }), new LinkedList(new int[] { }) };
        }
    }

    public class PopFromStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 2, 3, 4 }) };
        }
    }

    public class PopByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {2, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 4 }) };
            yield return new object[] {0, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 2, 3, 4 }) };
            yield return new object[] {0, new LinkedList(new int[] { 1 }), new LinkedList() };
        }
    }

    public class PopElemsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2 }) };
            yield return new object[] { 0, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 3, 4 }) };
        }
    }

    public class PopElemsFromStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 3, 4 }) };
            yield return new object[] { 0, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 3, 4 }) };
            yield return new object[] { 0, new LinkedList(new int[] { }), new LinkedList(new int[] { }) };
            yield return new object[] { 1, new LinkedList(new int[] { 3 }), new LinkedList(new int[] { }) };
        }
    }

    public class PopElemsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, 2, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 3, 4 }) };
            yield return new object[] { 0, 0, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 3, 4 }) };
            yield return new object[] { 0, 4, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { }) };
            yield return new object[] { 1, 2, new LinkedList(new int[] { 3, 5, 7, 9 }), new LinkedList(new int[] { 3, 9 }) };
        }
    }
}