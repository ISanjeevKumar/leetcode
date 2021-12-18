/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
         ListNode currentNode = l1;
         ListNode currentNode2 = l2;
         ListNode sumOfTwoNumbers = null;
         ListNode current = null; 
         ListNode prev = null;  
         int carry = 0;
         int sum = 0;
        while (currentNode != null || currentNode2 != null) {
            sum = carry +  (currentNode != null ? currentNode.val : 0)
                  + (currentNode2 != null ? currentNode2.val : 0);
            carry = (sum >= 10) ? 1 : 0;
            sum = sum % 10;
            current = new ListNode(sum);
            if(sumOfTwoNumbers==null)
            {
                sumOfTwoNumbers = current;
                
            } else
            {
                prev.next = current; 
            }
            prev = current;
           Console.WriteLine(sumOfTwoNumbers.val);
              if (currentNode != null) {
                currentNode = currentNode.next;
            }
            if (currentNode2 != null) {
               currentNode2 = currentNode2.next;   
            }
                             
        }
        if (carry > 0) {
            sumOfTwoNumbers.next = new ListNode(carry);
        }
        return sumOfTwoNumbers;
    }

}