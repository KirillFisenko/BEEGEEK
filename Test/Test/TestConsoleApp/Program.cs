using System;
using System.Reflection;
using System.Xml.Linq;

public class Node
{
    public Node Next;
    public int Value;

    public Node(int value)
    {
        Value = value;
    }
}

public class SinglyLinkedList
{
    public Node Head;
    private int count = 0;

    public int GetCount()
    {
        return count;
    }

    public string Print()
    {
        string result = "";
        Node current = Head;
        while (current != null)
        {
            result += current.Value + " ";
            current = current.Next;
        }

        return result;
    }

    public Node Find(int key)
    {
        if (count == 0)
        {
            return null;
        }

        Node current = Head;
        while (current.Value != key)
        {
            current = current.Next;
            if (current == null)
            {
                return null;
            }
        }

        return current;
    }

    public Node FindByIndex(int index)
    {
        if (index < 0 || index >= count)
            return null;
        int cur = 0;
        Node node = Head;
        while (cur != index)
        {
            node = node.Next;
            cur++;

        }

        return node;
    }

    private Node FindTail()
    {
        if (count == 0)
        {
            return null;
        }

        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        return current;
    }

    public void PushBack(int item)
    {
        Node newNode = new Node(item);
        if (count == 0)
        {
            Head = newNode;
        }
        else
        {
            Node tail = FindTail();
            tail.Next = newNode;
        }

        count++;
    }



    public void PushFront(int item)
    {
        Node newNode = new Node(item);

        if (count != 0)
        {
            newNode.Next = Head;
        }

        Head = newNode;
        count++;
    }
    public void AddBefore(Node node, int item)
    {
        if (node == null)
        {
            return;
        }

        if (node == Head)
        {
            PushFront(item);
        }
        else
        {
            Node newNode = new Node(item);
            Node previous = Head;

            while (previous.Next != null)
            {
                if (previous.Next == node)
                {
                    break;
                }

                previous = previous.Next;
            }

            previous.Next = newNode;
            newNode.Next = node;

            count++;
        }

    }
    public void RemoveNode(Node node)
    {
        if (Head == node)
        {
            Head = node.Next;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next == node)
                {
                    break;
                }

                current = current.Next;
            }

            current.Next = node.Next;
        }

        count--;
    }
    public void RemoveFirst()
    {
        if (count == 0)
        {
            throw new Exception("Список пуст");
        }

        Head = Head.Next;
        count--;
    }


    public bool Remove(int item)
    {
        if (count == 0)
        {
            return false;
        }
        var current = Find(item);
        if (current == null)
        {
            return false;
        }
        else
        {
            RemoveNode(current);
            return true;
        }
    }
    public Node FindLast(int key)
    {
        if (count == 0)
        {
            return null;
        }
        Node lastCurrent = null;
        Node current = Head;
        for (int i = 0; i < count; i++)
        {
            if (current.Value == key)
            {
                lastCurrent = current;
            }
            current = current.Next;
        }
        return lastCurrent;
    }
    public bool RemoveLast(int item)
    {
        if (count == 0)
        {
            return false;
        }
        var current = FindLast(item);
        if (current == null)
        {
            return false;
        }
        else
        {
            RemoveNode(current);
            return true;
        }
    }

    public int RemoveAll(int item)
    {
        int cnt = 0;
        Node current = Head;
        while (current.Next != null)
        {
            if (current.Value == item)
            {
                RemoveNode(current);
                cnt++;
            }
            current = current.Next;
        }
        if (current.Value == item)
        {
            RemoveNode(current);
            cnt++;
        }

        return cnt;
    }
    public void Reverse()
    {
        if (Head == null) return;
        Node prev = null, current = Head, next = null;
        while (current.Next != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        current.Next = prev;
        Head = current;
    }

}

public class SinglyCircularLinkedList
{
    public Node Tail;
    private int count = 0;

    public int GetCount()
    {
        return count;
    }

    public string Print()
    {
        if (count == 0)
        {
            return string.Empty;
        }

        return Print(Tail.Next);
    }

    public string Print(Node node)
    {
        if (count == 0)
        {
            return string.Empty;
        }

        string result = "";
        Node current = node;
        do
        {
            result += current.Value + " ";
            current = current.Next;
        } while (current != node);

        return result;
    }

    public Node Find(int key)
    {
        if (count == 0)
        {
            return null;
        }

        Node current = Tail;
        do
        {
            if (current.Value == key)
            {
                return current;
            }

            current = current.Next;
        }
        while (current != Tail);

        return null;
    }

    public Node FindLast(int key)
    {
        if (count == 0)
        {
            return null;
        }
        Node lastCurrent = null;
        Node current = Tail.Next;
        do
        {
            if (current.Value == key)
            {
                lastCurrent = current;
            }

            current = current.Next;
        }
        while (current != Tail.Next);

        return lastCurrent;
    }

    private void AddAfterInternal(Node node, Node newNode)
    {
        newNode.Next = node.Next;
        node.Next = newNode;
        count++;
    }

    private void InsertNodeToEmptyList(Node node)
    {
        node.Next = node;
        Tail = node;
        count++;
    }

    public void PushBack(int item)
    {
        Node newNode = new Node(item);

        if (count == 0)
        {
            InsertNodeToEmptyList(newNode);
        }
        else
        {
            AddAfterInternal(Tail, newNode);
            Tail = newNode;
        }
    }

    public void PushFront(int item)
    {
        Node newNode = new Node(item);
        if (count == 0)
        {
            InsertNodeToEmptyList(newNode);
        }
        else
        {
            AddAfterInternal(Tail, newNode);
        }
    }

    public void AddAfter(Node node, int item)
    {
        Node newNode = new Node(item);

        AddAfterInternal(node, newNode);
        if (node == Tail)
        {
            Tail = newNode;
        }
    }

    public void AddBefore(Node node, int item)
    {
        if (node == null)
        {
            return;
        }

        if (node == Tail.Next)
        {
            PushFront(item);
        }
        else
        {
            Node newNode = new Node(item);
            Node previous = Tail.Next;

            while (previous.Next != null)
            {
                if (previous.Next == node)
                {
                    break;
                }

                previous = previous.Next;
            }

            previous.Next = newNode;
            newNode.Next = node;

            count++;
        }
    }

    private void RemoveAfterNodeInternal(Node node)
    {
        if (count == 0)
        {
            throw new Exception("Список пуст");
        }

        if (count == 1)
        {
            Tail = null;
        }
        else
        {
            if (node.Next == Tail)
            {
                Tail = node;
            }

            node.Next = node.Next.Next;
        }

        count--;
    }

    public void RemoveFirst()
    {
        RemoveAfterNodeInternal(Tail);
    }

    public void RemoveNode(Node node)
    {
        if (count == 0)
        {
            throw new Exception("Список пуст");
        }

        Node current = node;
        while (current.Next != node)
        {
            current = current.Next;
        }

        RemoveAfterNodeInternal(current);
    }

    public void RemoveLast()
    {
        RemoveNode(Tail);
    }

    public bool Remove(int item)
    {
        if (count == 0)
        {
            return false;
        }
        var current = Find(item);
        if (current == null)
        {
            return false;
        }
        else
        {
            RemoveNode(current);
            return true;
        }
    }

    public bool RemoveLast(int item)
    {
        if (count == 0)
        {
            return false;
        }
        var current = FindLast(item);
        if (current == null)
        {
            return false;
        }
        else
        {
            RemoveNode(current);
            return true;
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {

        SinglyCircularLinkedList singlyCircularLinkedList = new SinglyCircularLinkedList();
        singlyCircularLinkedList.PushBack(6);

        Console.WriteLine(singlyCircularLinkedList.Print());


        Console.ReadLine();
    }
}


