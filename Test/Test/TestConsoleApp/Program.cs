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
        if (count == 0 || item == null)
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
        if (count == 0 || item == null)
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



public class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
        singlyLinkedList.PushBack(1);
        singlyLinkedList.PushBack(1);
        singlyLinkedList.PushBack(1);
        singlyLinkedList.PushBack(1);
        singlyLinkedList.PushBack(2);        

        Console.WriteLine(singlyLinkedList.Print());
        
        singlyLinkedList.RemoveAll(2);

        Console.WriteLine(singlyLinkedList.Print());

        Console.ReadLine();
    }
}


