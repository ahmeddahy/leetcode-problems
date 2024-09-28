/* problem link : https://leetcode.com/problems/copy-list-with-random-pointer/description/?envType=company&envId=facebook&favoriteSlug=facebook-thirty-days */


//public class Node
//{
//    public int val;
//    public Node next;
//    public Node random;

//    public Node(int _val)
//    {
//        val = _val;
//        next = null;
//        random = null;
//    }
//}

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        var startNode = head;
        while (startNode != null)
        {
            var tmp = startNode.next;
            var newNode = new Node(startNode.val);
            startNode.next = newNode;
            newNode.next = tmp;

            startNode = startNode.next.next;
        }

        startNode = head;
        while (startNode != null)
        {
            if (startNode.random != null)
            {
                startNode.next.random = startNode.random.next;
            }
            startNode = startNode.next.next;
        }

        var result = head?.next;
        var copy = head?.next;
        var original = head;
        while (original != null)
        {
            var tmp = copy.next?.next;
            original.next = original.next.next;
            copy.next = tmp;
            original = original.next;
            copy = copy.next;
        }

        return result;
    }
}