using System;
using Xunit;
using Stacks_and_Queues;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanMakeStack()
        {
            Stack s = new Stack();
            s.Push(new Node(5));
            s.Push(new Node(8));
            Assert.Equal(8, s.Pop().Value);
        }

        [Fact]
        public void CanPeekStack()
        {
            Stack s = new Stack();
            s.Push(new Node(5));
            s.Push(new Node(8));
            s.Pop();
            Assert.Equal(5, s.Peek().Value);
        }

        [Fact]
        public void CanBuildQueue()
        {
            Queue q = new Queue();
            q.Enqueue(new Node(6));
            q.Enqueue(new Node(5));
            q.Enqueue(new Node(3));
            Assert.Equal(6, q.Peek().Value);
        }

        [Fact]
        public void CanDequeue()
        {
            Queue q = new Queue();
            q.Enqueue(new Node(6));
            q.Enqueue(new Node(5));
            q.Enqueue(new Node(3));
            q.Enqueue(new Node(-3));
            q.Dequeue();
            Assert.Equal(5, q.Peek().Value);
        }

        [Fact]
        public void CanSimulateEnqueue()
        {
            Stack s = new Stack();
            s.Push(new Node(5));
            s.Push(new Node(8));
            s = Program.Enqueue(s, 3);
            Assert.Equal(8, s.Pop().Value);
            Assert.Equal(5, s.Pop().Value);
            Assert.Equal(3, s.Pop().Value);
            Assert.Null(s.Peek());
        }

        [Fact]
        public void CanSimulateDequeue()
        {
            Stack s = new Stack();
            s.Push(new Node(5));
            s.Push(new Node(8));
            int num = Program.Dequeue(s);
            Assert.Equal(8, num);
            Assert.Equal(5, s.Pop().Value);
            Assert.Null(s.Peek());
        }
    }
}
