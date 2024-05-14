using System.Collections.Generic;
using FlaskFactory.Model.Flasks;

namespace FlaskFactory.Model.FactoryControls
{
    public class Buffer
    {
        public const int MAX_SIZE = 100;
        private Queue<Flask> buffer;
        private readonly object lockObject = new object();

        public Buffer()
        {
            buffer = new Queue<Flask>();
        }

        public void Enqueue(Flask item)
        {
            lock (lockObject)
            {
                if (buffer.Count < MAX_SIZE)
                {
                    buffer.Enqueue(item);
                }
            }
        }

        public Flask Dequeue()
        {
            lock (lockObject)
            {
                return buffer.Count > 0 ? buffer.Dequeue() : null;
            }
        }

        public int Count
        {
            get
            {
                lock (lockObject)
                {
                    return buffer.Count;
                }
            }
        }
    }
}
