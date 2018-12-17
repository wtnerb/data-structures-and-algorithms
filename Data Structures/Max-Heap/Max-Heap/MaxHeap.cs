using System;
using System.Collections.Generic;

public class Max_Heap
{
    public Node Root { get; set; }

    private List<int> Heap { get; set; }

    ///Constructor converts from array to max heap
    public Max_Heap(int[] nums)
    {
        Heap = new List<int>(nums);

        // loop across parents to enforce max heap property
        int highestParentIndex = (Heap.Count - 1) / 2;
        for (int i = highestParentIndex; i >=0; i--)
        {
            MaxHeapify(i);
        }
    }

    /// For testing purposes, it can be useful to convert a max heap back into an array
    /// Relic from when heaps were actually a binary tree and making an array was work
    public int[] ToArray()
    {
        return Heap.ToArray();
    }

    /// This assumes the value at 'index' is the only value that might be in violation
    /// of the max heap rule. 
    private void MaxHeapify(int index)
    {
        var children = ChildIndexes(index);
        switch (children.Length)
        {
            case 0:
                // When no children exist, the max heap property cannot be violated.
                break;
            case 1:
                // With one child, make simple check for max heap property, swap if needed
                if (Heap[index] < Heap[children[0]])
                {
                    Swap(index, children[0]);
                }
                break;
            default:
                // if left child is bigger than right child and current, swap with current
                if (Heap[index] < Heap[children[0]] && Heap[children[0]] > Heap[children[1]])
                {
                    Swap(index, children[0]);
                    MaxHeapify(Parent(index));
                    break;
                }

                // If right child is larger than current, it must be at least equal to right child
                if (Heap[index] < Heap[children[1]])
                {
                    Swap(index, children[1]);
                    MaxHeapify(Parent(index));
                }

                break;
        }

    }

    /// <summary>
    /// finds the index of the 'parent node' given the index of the 'current node'
    /// </summary>
    /// <param name="index">index of the current 'node'</param>
    /// <returns>index of the parent 'node'</returns>
    private int Parent(int index)
    {
        return (index - 1) / 2;
    }

    /// <summary>
    /// Swaps two values in the underlying List based on index
    /// </summary>
    /// <param name="index">index of first value</param>
    /// <param name="target">index of second value</param>
    private void Swap(int index, int target)
    {
        int temp = Heap[index];
        Heap[index] = Heap[target];
        Heap[target] = temp;
    }

    /// <summary>
    /// Finds indexes of the 'child nodes' of the current node given its index.
    /// </summary>
    /// <param name="index">location of current node in the list</param>
    /// <returns>array of children sized appropriate to number of children</returns>
    private int[] ChildIndexes(int index)
    {
        int doubling = (index + 1) * 2;
        if (doubling > Heap.Count)
        {
            return new int[] { };
        }

        if (doubling == Heap.Count)
        {
            return new int[] { doubling - 1 };
        }

        return new int[] { doubling - 1, doubling };
    }
}