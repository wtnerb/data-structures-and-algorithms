using System;
using Xunit;
using PrintLevelOrder;
using K_aryTrees;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void BuildsCorrectString()
        {
            Node<char> root = new Node<char>('A', new char[] { 'B', 'C', 'D', 'E', 'F', 'G' });
            Tree<char> tree = new Tree<char>(root);
            tree.Add('B', 'H');
            tree.Add('B', 'I');
            tree.Add('B', 'J');
            tree.Add('E', 'K');
            tree.Add('E', 'L');
            tree.Add('G', 'M');
            tree.Add('H', 'N');
            tree.Add('H', 'O');
            tree.Add('K', 'P');
            tree.Add('L', 'Q');
            string expect = "A \n B C D E F G \n H I J K L M \n N O P Q \n ";
            Assert.Equal(expect, Program.PrintLevelOrder(tree));
        }
    }
}
