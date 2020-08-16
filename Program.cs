namespace Leetcode
{
    using LeetCode;

    public class Program
    {
        public static void Main()
        {
            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            _ = MergeTwoLists(list1, list2);

        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val <= l2.val)
            {
                return new ListNode(l1.val, MergeTwoLists(l1.next, l2));
            }
            else
            {
                return new ListNode(l2.val, MergeTwoLists(l1, l2.next));
            }
        }
    }
}
