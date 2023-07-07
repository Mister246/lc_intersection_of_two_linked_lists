


public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    static public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        for (ListNode head = headB; headA != null; headA = headA.next)
        // for each node in headA
        {
            while (headB != null)
            // for every other node in headB
            {
                if (headA == headB)
                {
                    return headA;
                }
                headB = headB.next;
            }
            headB = head;
        }

        return null;
    }
}