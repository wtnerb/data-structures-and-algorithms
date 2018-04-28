# Find All Matches
This challenges requires the use of K-ary trees. Below is the description of K-ary Trees from the implementation in the Data Structures directory. The implementation found there is the one used for this challenge. <br>

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

## Challenge
Given a tree and a target value, return a list of all nodes in the tree with a value matching the target value. For example, in the ASCII rendition of a tree above, the value '7' should return a collection of two nodes
```
     7 <-- first returned node in collection
   / | \
  1  7  9

  7 <-- second returned node in the collection
```

## Solution
![Whiteboard](../../../assets.find_matches.jpg)