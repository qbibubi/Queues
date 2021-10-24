using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;

namespace Queues
{
    class Queue
    {
        private string[] Q;     // array in which the queue will be created
        private int qptr;       // index of the element which is the beginning of the queue
        private int qcnt;       // number of elements which queue stores
        private int n;          // number of elements in the array

        public Queue(int new_n)
        {
            Q = new string[new_n];
            n = new_n;
            qptr = qcnt = 0;
        }

        // Check if the queue is empty
        public bool Empty() { return qcnt != 0; }

        // Returns value of the element at the beggining
        // of the queue or special value if the queue is empty
        public string Front()
        {
            if (qcnt != 0) return Q[qptr];
            else return "";
        }

        // Assign new value to the queue if there's space
        // Otherwise the queue is unmutable
        public void Push(string v)
        {
            int i;  // index

            if (qcnt < n)
            {
                i = qptr + qcnt++;
                if (i >= n) i -= n;
                Q[i] = v;
            }
        }

        // Queue is decreased by removal of the first element
        public void Pop()
        {
            if (qcnt != 0)
            {
                qcnt--; qptr++;
                if (qptr == n) qptr = 0;
            }
        }
    }
}
