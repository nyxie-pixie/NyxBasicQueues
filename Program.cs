namespace QueuePractice
{

	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<int> myQueue = new Queue<int>();
			myQueue.Add(8);
			myQueue.Add(44);
			myQueue.Add(71);
			Console.WriteLine(myQueue.ViewCount());
			Console.WriteLine(myQueue.Remove());
			Console.WriteLine(myQueue.Remove());
			Console.ReadLine();
		}
	}
	public class Node<T>
	{
		public T Data { get; set; }
		public Node<T> Next { get; set; }

	}
	public class Queue<T>
	{
		int Count = 0;
		private Node<T> head;
		private Node<T> tail;
		public void Add(T val)
		{
			Node<T> tempNode = new Node<T>();
			tempNode.Data = val;
			if (head == null || tail == null)
			{
				head = tempNode;
				tail = tempNode;
			}
			else if (head == tail)
			{ 
				head.Next = tempNode;
				tail = tempNode;
			}
			else
			{
				tail.Next = tempNode;
				tail = tempNode;
			}
			Count = Count + 1;
		}
		public T Remove()
		{
			if (head == null)
			{
				throw new Exception();
			}
			var tempVal = head.Data;
			head = head.Next;
			return tempVal;
			Count = Count - 1;
		}
		public int ViewCount()
		{
			return Count;
		}
	}
}

/*
namespace stacksPractice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stack<int> myStack = new Stack<int>();
			myStack.Push(5);
			myStack.Push(11);
			myStack.Push(35);
			Console.WriteLine(myStack.Peek());
		}
	}

	public class Node<T>
	{
		public T Data { get; set; }
		public Node<T> Next { get; set; }
	}
	public class Stack<T>
	{
		private Node<T> top;

		public void Push(T val)
		{
			Node<T> tempNode = new Node<T>();
			tempNode.Data = val;
			tempNode.Next = top;
			top = tempNode;
		}

		public T Pop()
		{
			if (top == null) throw new Exception();
			var tempVal = top.Data;
			top = top.Next;
			return tempVal;
		}

		public T Peek()
		{
			if (top == null) throw new Exception();
			return top.Data;
		}
	}
}
*/
