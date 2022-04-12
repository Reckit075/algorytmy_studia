using System;

namespace lab_7
{

    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }

    class Stack<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public void Push(T value)
        {
            Node<T> newNode = new Node<T> { Value = value, Next = _head };
            _head = newNode;
        }
        public bool isEmpty()
        {
            return _head == null;
        }

        public T Pop()
        {
            if (isEmpty())
            {
                throw new Exception("Stack is empty");
            }
            T result = _head.Value;
            _head = _head.Next;
            return result;
        }

        public void Insert(T value)
        {
            Node<T> node = new Node<T> { Value = value };
            if (isEmpty())
            {
                _head = node;
                _tail = _head;
                return;
            }
            _tail.Next = node;
            _tail = node;
        }
        public T Remove()
        {
            if (isEmpty())
            {
                throw new Exception("Queue is empty");
            }
            T result = _head.Value;
            _head = _head.Next;
            return result;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Node<string> node = new Node<string> { Value = "adam" };
            node.Next = new Node<string> { Value = "ewa" };
            node.Next.Next = new Node<string> { Value = "jacek" };
            Node<string> head = node;
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            Stack<string> stack = new Stack<string>();

            stack.Push("Adam");
            stack.Push("Ewa");
            stack.Push("Karol");

            while (!stack.isEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }





}
