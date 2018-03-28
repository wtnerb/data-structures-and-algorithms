# Singly linked list
## overview
This exercise has the fundamentals of a singly linked list. The most common realworld example of such a list would be blockchain. For a real application, much more work would be required, but this has the fundamentals.

## Usage
This app has a singly linked list app. Only integers are acceptable node values. For a list, you can start with one value or an array.
```LinkedList l = new LinkedList(321);```
Will start a list with a node of value 1 and Next of null.

Alternatively, initializing with an array
```LinkedList l = new LinkedList(new int [] { 3, 4, 5});```
Will produce a linked list: head 5 -> 4 -> 3 -> null

Lists also come with the Add and Find method, where Find will return the 'index' at which the value was found or -1 if not found.

## Architeture
Linked lists are comprised of nodes. Each node has a property next of the next node in the array. Each node also has a value property.

Lists are comprised of nodes in sequence. A list has a Head property that is the first node. It ends when a node has Next of null.