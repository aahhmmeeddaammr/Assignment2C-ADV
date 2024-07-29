using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2.FixedList
{
     


    internal class FixedSizeList<T>
    {
        class node
        {
            public T value;
			public node next;
            public node(T val)
            {
                value = val;
				next = null;
            }
        }
		private node head;
		private int size;

        private int capacity;
		

		public int Capacity
		{
			get
			{
				return capacity;
			}
		}

		public int Size
		{
			get { return size; }
		}
		
		public FixedSizeList(int _capacity) 
		{ 
			capacity  = _capacity;
			this.size = 0;
			head = null;
		}

		public void Add(T val)
		{
			if(size == capacity)
			{
				throw new Exception("The List is Full");
			}
			if(head == null)
			{
				head = new node(val);
				size++;
				return;
			}
			node ptr = head;
			while(ptr.next != null) {
				ptr = ptr.next;
			}
			ptr.next = new node(val);
			size++;
		}

		public T Find(int index) {
			if(index < 0 || index >Capacity)
			{
				throw new Exception("Invalid Index");
			}
			if (size == 0)
			{
				throw new Exception("The List is Empty");
			}

			int itr = 0;
			node curr = head;
			while (itr < index) {
				itr++;
				curr = curr.next;
			}
			return curr.value;
		}

		public void print(int index)
		{
            node ptr = head;
            while (ptr.next != null)
            {
                ptr = ptr.next;
                Console.Write($"{ptr.value} ");
            }
            Console.WriteLine("");
        }

		public T this[int index]
		{
			get 
			{ 
				return Find(index);
			}
		}
	}
}
