

public class Node<T>
{

    public T? Value { get; set; }


    public Node<T>? Next { get; set; } = default;

    public Node(){

    }

    public Node(T value)
    {
        Value = value;

    }


    public Node(T value, Node<T> next)
    {
        Value = value;
        Next!.Next = next;
    }



    public override string ToString()
    {
        return Next == null ? $"Value: {Value}" : $"Value is {Value} and Next is {Next.Value}";
    }


}