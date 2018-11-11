using System;

public class Max_Heap {
  public Node Root {get; set;}
  public Max_Heap(int[] nums)
  {
      if (nums.Length == 0){
        throw new Exception("empty initializer");
      }
      Root = new Node();
      Root.Val = nums[0];
  }
}