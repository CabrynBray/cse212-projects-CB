public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }

        else if (value == Data)
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value < Data)
        {
            if (Left is null)
                return false;
            else
                return Left.Contains(value);

        }
        if (value == Data)
        {
            return true;
        }
        if (value > Data)
        {
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int heightLeft = 0;
        int heightRight = 0;

        if (Left is not null)
        {
            heightLeft = Left.GetHeight();
        }
        if (Right is not null)
        {
            heightRight = Right.GetHeight();
        }
        return Math.Max(heightLeft, heightRight) + 1;
    }
}