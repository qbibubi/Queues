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
        Patient qptr, qcnt;
        private int n;          // number of elements in the array

        public Queue(int new_n)
        {
            n = new_n;
            qptr = qcnt = null;
        }

        // Check if the queue is empty
        public bool Empty() { return qcnt != null; }

        // Returns value of the element at the beggining
        // of the queue or special value if the queue is empty
        public int Front()
        {
            if (qcnt != null) return qptr.GetValue();
            else return 0;     // special value string
        }

        // Assign new value to the queue if there's space
        // Otherwise the queue is unmutable
        public void Push(int n)
        {
            Patient temp = new Patient(n);

            if (qcnt == null)
                qcnt = qptr = null;
            else
            {
                qptr.SetNext(temp);
                qptr = temp;
            }
        }

        // Queue is decreased by removal of the first element
        public void Pop()
        {
            if (qcnt != null)
            {
                if (qcnt.GetNext() == null)
                    qptr = null;

                qcnt = qcnt.GetNext();
            }
            else return;
        }
    }
}
