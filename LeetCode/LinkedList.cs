namespace LeetCode
{

	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}

	public class LinkedList
	{
		/* Delete Node in a Linked List
		 * Write a function to delete a node in a singly-linked list. You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
		 * It is guaranteed that the node to be deleted is not a tail node in the list.
		 */
		public void DeleteNode(ListNode node)
		{
			ListNode temp = node.next;
			node.val = temp.val;
			node.next = temp.next;

			return;
		}
	}
}
