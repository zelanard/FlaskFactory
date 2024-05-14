using FlaskFactory.Model.Flasks;
using System.Collections.Generic;

namespace FlaskFactory.Model.FactoryControls
{
    public class Buffer
    {
        public int maxSize;
        public Queue<Flask> buffer;
        public Buffer()
        {
            buffer = new Queue<Flask>();
        }
    }
}
