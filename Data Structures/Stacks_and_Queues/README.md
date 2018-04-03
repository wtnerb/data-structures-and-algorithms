# Stacks and Queues
## overview
This file holds some the elementary basics of what it takes to implement a homebrew stack and queue in C#

## Stack
Imagine a todo bucket just wide enough to fit a sheet of paper. Without doing something like picking up the bucket and turning it over, the ways an office drone can interact with the internal pile of todo paperwork is simple. Remove from the top, add to the top, or peek at the top item without removing it. In code, a stack is the same thing. This is a basic C# implementation of that concept.

## Queue
A queue is like a line at the bank. The first person to arrive is helped immediately. If someone arrives while the first person is being helped, they are added to the back of the queue. Every so often, a teller will finish handling a customer and query the queue to move the farthest forwards person out of the queue and to the counter. A teller can also glance at the next person in line, decide they don't like the cut of his jib and abruptly decide to take a 15 minute break. For computers, queues are similar. You can add an item to the back, remove an item from the front, or peek the item in the back. This is a basic C# implementation of that concept.

## implementaion
``` 
Node n = new Node (5); 
```
This will make a new Node

```
Queue q = new Queue();
Queue.Enqueue(n);
```
That will make a new queue and add the node from the previous example to the queue.

```
Node n2 = q.Peek();
n2.Value += 3;
Node n3 = q.Dequeue();
```
Now, n2 will be a node of value 8 and n3 will be a node with value 5

```
Stack s = new Stack();
s.Push(n2);
s.Push(n3);
```
The stack will now include two nodes. The top node should have a value of 5, the bottom node a value of 8.

```
int val = s.Pop().Value;
Console.WriteLine(val) // should print 5 to the console.
```
