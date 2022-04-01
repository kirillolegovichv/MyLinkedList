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
    }

    public class AddTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 0 });
            yield return new object[]  { value, list, expectedList };
        }
    }
}