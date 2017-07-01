﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Algos.Code.DataStructures.LinkedList
{
    public class LinkedList<T>: IEnumerable<Node<T>>
    {
        private Node<T> root = new Node<T>();
        private Node<T> current;

        public T this[uint index] => GetByIndex(index).Value;

        public void Add(T val)
        {
			current = root;
            while (current.Next != null)
			{
                current = current.Next;
			} 
            current.Next = new Node<T>(val);
		}

		public void Insert(uint index, T val)
		{
            var item = new Node<T>(val);
			if (index == 0)
			{
                item.Next = root.Next;
                root.Next = item;
				return;
			}

            var previous = GetByIndex(index - 1);
            item.Next = previous.Next;
            previous.Next = item;
        }

		public void Update(uint index, T val)
		{
            var item = GetByIndex(index);
            item.Value = val;
		}

        public void Delete(uint index)
        {
            if (index == 0)
            {
                root.Next = root.Next?.Next != null ? root.Next.Next : null;
                return;
            }

            var previous = GetByIndex(index - 1);
            previous.Next = previous.Next?.Next != null ? previous.Next.Next : null;
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

        private Node<T> GetByIndex(uint index)
        {
            current = root;
            int i = 0;
            while (current.Next != null)
            {
                current = current.Next;
                if (i == index)
                {
                    return current;
                }
                i++;
            }

            throw new IndexOutOfRangeException();
        }
    }
}
