

//LinkedList Specs

//Main Properties
//Head
//Tail
//Length
//push
//shift
//unshift
//pop
//removeAt(index)
//getAt(index)





public class LinkedList<T>
{

    public Node<T>? Head;


    public Node<T>? Tail;


    public int Length;


    public LinkedList()
    {

    }


    public LinkedList(T value)
    {
        Head = new(value);
        Tail = Head;
        Length++;
    }


    public void Push(T value)
    {

        if (Length == 0)
        {
            Head = new(value);
            Tail = Head;

        }
        else
        {
            Node<T> oldTail = Tail!;
            Tail = new(value);
            oldTail.Next = Tail;

        }

        Length++;
    }


    public T? Pop()
    {


        if (Length == 1)
        {
            T value = Head!.Value!;
            Head = null;
            Tail = null;
            Length--;
            return value;
        }
        else if (Head != null)
        {

            Node<T> currentNode = Head;
            Node<T> newTail = new();
            while (currentNode.Next != null)
            {
                newTail = currentNode;
                currentNode = currentNode.Next;
            }
            newTail.Next = null;
            Console.WriteLine(newTail.Value);
            Length--;
            return currentNode.Value;

        }

        return default;
    }


    public void UnShift(T value)
    {

        //adds a new value to the head

        if (Head == null)
        {

            Push(value);
        }
        else
        {

            Node<T> oldHead = Head;
            Head = new(value)
            {
                Next = oldHead
            };
            Length++;

        }



    }


    public T? Shift()
    {
        if(Length == 0){
            return default;
        }
        else if (Length == 1)
        {
            var oldHead = Head;
            Pop();
            
            return oldHead!.Value;
        }
        else
        {
            Node<T> oldHead = Head!;
            Head = Head!.Next;
            Length --;
            return oldHead!.Value;

        }
    }


    public T? GetAt(int index){
       if(index > Length - 1){
        
         throw new ArgumentOutOfRangeException();
       }
       if(index == 0 && Head != null){
           return Head.Value;
       } else {
         Node<T> currentNode = Head!;
         int count = 0;
         while (currentNode.Next != null && count < index){
           currentNode = currentNode.Next;
           count++;
         }
         return currentNode.Value;
       }
    }

    








}


