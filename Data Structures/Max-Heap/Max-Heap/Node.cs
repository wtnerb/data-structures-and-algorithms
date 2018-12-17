public class Node
{

    public Node()
    {
        Left = null;
        Right = null;
    }
    public Node(int num)
    {
        Left = null;
        Right = null;
        Val = num;
    }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public int Val { get; set; }
}