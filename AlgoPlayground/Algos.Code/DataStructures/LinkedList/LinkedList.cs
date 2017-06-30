using System;
using System.Collections;
using System.Collections.Generic;

namespace Algos.Code.DataStructures.LinkedList
{
    public class LinkedList<T>: IEnumerable<Node<T>>
    {
        private Node<T> root = new Node<T>();
        private Node<T> current;

		T this[int index]
		{
            get { throw new NotImplementedException(); }
		}

        public void Add(T val)
        {
			current = root;
            while (current.Next != null)
			{
                current = current.Next;
			} 
            current.Next = new Node<T> { Value = val };
		}

		public void Insert(int index, T val)
		{
			throw new NotImplementedException();
		}

		public void Update(int index, T val)
		{
			throw new NotImplementedException();
		}

		public void Delete(int index)
		{
            throw new NotImplementedException();
		}

        public void Clear()
        {
            root.Next = null;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            current = root;
            while(current.Next != null)
            {
                current = current.Next;
                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
