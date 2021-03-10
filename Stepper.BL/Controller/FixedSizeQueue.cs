using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stepper.BL.Controller
{
    public class FixedSizedQueue<T> : Queue<T>
    {
        private readonly object syncObject = new object();

        public int Size { get; private set; }

        public FixedSizedQueue(int size)
        {
            Size = size;
        }

        public FixedSizedQueue(T[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {

            }
        }
        public new void Enqueue(T obj)
        {
            base.Enqueue(obj);
            lock (syncObject)
            {
                while (base.Count > Size)
                {
                    
                    base.Dequeue();
                }
            }
        }
    }
}
