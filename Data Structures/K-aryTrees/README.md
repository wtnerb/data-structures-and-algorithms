# K-ary Trees
K-ary trees are the generic tree structure. Each node has a list of child nodes it references. If there is a circular reference, it is not a tree but a graph. Each tree has one node from which all others descend - this is called the root. Terminal nodes are called leaves. Here is an ASCII art depiction:
```
        6    <-- the root    
      /   \       
     3      7     
   / | \  / | \  
  5 4  2  1  7  9  <-- a leaf
       |
	   3 <-- another leaf
```
Note: this depiction shows the structure of a tree, but it is worth noting that trees do not inherently have bidirectional references. The root, value '6', must reference both of its children, but (while moderately common in application) it is not required for he children to reference back to their parent (in this case, '3' and '7' don't have to reference back to the root.)

## Details
This implementation of trees has a few important features:
- nodes are generic: this implementation will work regardless of the type of data you want to store
- trees are generic: One type must be chosen for all the nodes in a tree.
- 

#### Traversal
Three tree traversal methods are supported. All three require a delegate of type Method to operate each node as it is traversed.
- PostOrderTraverse: add the children to the stack, then invoke the method provided
- PreOrderTraverse: Invoke the method provided, then add dhildren to the stack
- BreadthFirstTraverse: Invoke the method provided on every node in a level, then move down one level.