using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_150519
{
    class MyUniqueList<T>
    {
        List<T> list = new List<T>();

        public MyUniqueList()
        {

        }

        public bool Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }
            throw new ItemAlreadyExistException("Already Exist");
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }
            throw new ItemNotFoundException("Item not found");
        }

        public T Peek(int index)
        {
            return list[index];
            throw new IndexOutOfRangeException("Out of range");
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
                
            }
            set
            {
                if (list[index].Equals(value))
                {
                    return;
                    
                }
              
                //if (list<T>[index] == value)
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}
