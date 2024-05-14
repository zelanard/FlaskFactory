using FlaskFactory.Model.Flasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactory.Model.FactoryControls
{
    public abstract class Consumer
    {
        protected Flask CurrentFlask;
        protected Buffer Buffer { get; private set; }
        public Consumer(Buffer buffer)
        {
            Buffer = buffer;
        }

        public void Pull(int id)
        {
            CurrentFlask = Buffer.buffer.Dequeue();
        }
    }
}