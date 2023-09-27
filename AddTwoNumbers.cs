using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    //l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9] Nodos de ejemplos
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int rest = 0;
        ListNode newNode = recursive(l1, l2, ref rest);

        return newNode;
    }
    public ListNode recursive(ListNode l1, ListNode l2, ref int rest)
    {
        int val1 = 0;
        int val2 = 0;
        int suma = 0;
        ListNode newl1 = null;
        ListNode newl2 = null;

        if (l1 == null && l2 == null)
        {
            if (rest > 0)
            {
                l1 = new ListNode(rest, null);
                rest = 0;
            }
            else
            {
                return null;
            }
        }
        if (l1 != null)
        {
            val1 = l1.val;
            newl1 = l1.next;
        }
        if (l2 != null)
        {
            val2 = l2.val;
            newl2 = l2.next;
        }
        suma = val1 + val2 + rest;
        if (suma > 9)
        {
            suma = (suma == 10) ? 0 : suma - 10;
            rest = 1;
        }
        else
        {
            rest = 0;
        }

        ListNode newNode = new ListNode(suma, recursive(newl1, newl2, ref rest));

        return newNode;
    }
}
