/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> nodes = new Dictionary<Node, Node>();
        var node = head;

        while(node !=null)
        {
            Node copy = new Node(node.val);
            nodes[node] = copy;
            node = node.next;
        }

        node = head;
        while(node!= null)
        {
            var copy = nodes[node];
            copy.next = node.next!=null?nodes[node.next]:null;
            copy.random = node.random!=null?nodes[node.random]:null;
            node = node.next;
            
        }

        return head!=null?nodes[head]:null;

        
    }
}
