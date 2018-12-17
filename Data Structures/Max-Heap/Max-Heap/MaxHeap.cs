using System;
using System.Collections.Generic;

public class Max_Heap {
  public Node Root {get; set;}

///Constructor converts from array to heap, assume given array is a max heap (for now)
  public Max_Heap(int[] nums)
  {
    if (nums.Length == 0){
      throw new Exception("empty initializer");
    }
    Queue<Node> q = new Queue<Node>();
    Root = new Node();
    Root.Val = nums[0];
    q.Enqueue(Root);

    for (int i = 1; i < nums.Length -1; i +=2)
    {
      Node current = q.Dequeue();
      current.Left = new Node(nums[i]);
      current.Right = new Node (nums[i+1]);
      q.Enqueue(current.Left);
      q.Enqueue(current.Right);
    }
    if (nums.Length % 2 != 1){
      Node current = q.Dequeue();
      current.Left = new Node (nums[nums.Length - 1]);
    }
  }
///For testing purposes, it can be useful to convert a max heap back into an array
  public int[] ToArray (){
    Queue<Node> q = new Queue<Node>();
    Node current = Root;
    List<int> l = new List<int>();
    while (current != null){
      l.Add(current.Val);
      q.Enqueue(current.Left);
      q.Enqueue(current.Right);
      current = q.Dequeue();
    }
    return l.ToArray();
  }

/// This assumes the root is the only node in violation of the max-heap rule.
/// All subtrees are assumed to comply with max-heap rule. Recursively will
/// check if there is a violation, and if so swap parent with largest child
/// and recurr until their is no violation (because node has no larger children)
/// This is accomplished easiest by swapping values.
  public void MaxHeapify (Node root)
  {
    //Guard clauses
    if (root.Left == null)
    {
      if(root.Right == null)
      {
        //Do nothing to a leaf
        return;
      }
      if (!(root.Left.Val > root.Val))
      {
        //All is as expected
        return;
      }
      else
      {
        //Fix at this level of the heap, recurr down a level
        Swap(root, root.Left);
        MaxHeapify(root.Left);
      }
    }
    if (root.Right == null)
    {
      if (!(root.Right.Val > root.Val))
      {
        // No work needs to be done
        return;
      }
      else
      {
        // Fix this level of the heap, recurr down a level
        Swap(root, root.Right);
        MaxHeapify(root.Right);
      }
    }
    //End of guard clauses
    
    //If in the middle of the heap, and a node is out of order
    //(has a child larger than itself)
    if (root.Val < root.Left.Val || root.Val < root.Right.Val)
    {
      //Swap largest of child values for parent, fixing this level of the heap
      //Recurr down to the next level of the heap
      if(root.Left.Val > root.Right.Val)
      {
        Swap(root, root.Left);
        MaxHeapify(root.Left);
      }
      else
      {
        Swap(root, root.Right);
        MaxHeapify(root.Right);
      }
    }
  }

  private void Swap(Node n1, Node n2)
  {
    int temp = n1.Val;
    n1.Val = n2.Val;
    n2.Val = temp;
  }
}