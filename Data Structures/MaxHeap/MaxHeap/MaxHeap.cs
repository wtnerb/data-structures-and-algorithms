using System;
using System.Collections.Generic;

public class Max_Heap {
  public Node Root {get; set;}


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
}