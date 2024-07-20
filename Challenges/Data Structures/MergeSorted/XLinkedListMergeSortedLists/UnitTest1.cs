using Xunit;

public class MergeSortedLinkedListsTests
{
    [Fact]
    public void TestMergeWithOneEmptyList()
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();
        list2.Add(1);
        list2.Add(3);
        list2.Add(5);

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Assert.Equal("1 -> 3 -> 5 -> Null", mergedList.ToString());
    }

    [Fact]
    public void TestMergeWithBothEmptyLists()
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Assert.Null(mergedList.Head);
    }

    [Fact]
    public void TestMergeLists()
    {
        LinkedList list1 = new LinkedList();
        list1.Add(5);
        list1.Add(10);
        list1.Add(15);

        LinkedList list2 = new LinkedList();
        list2.Add(2);
        list2.Add(3);
        list2.Add(20);

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Assert.Equal("2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", mergedList.ToString());
    }
}
