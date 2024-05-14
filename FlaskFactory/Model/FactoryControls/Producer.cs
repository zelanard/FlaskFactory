using FlaskFactory.Model.Flasks;
using FlaskFactory.Utils;
using System;

namespace FlaskFactory.Model.FactoryControls
{
    internal class Producer : IPusher
    {
        int idCounter = 0;
        public Buffer Buffer { get; private set; }
        public Producer(Buffer buffer)
        {
            Buffer = buffer;
        }

        public void Push(FlaskTypes flaskType)
        {
            switch (flaskType)
            {
                case FlaskTypes.SodaFlask:
                    {
                        Buffer.buffer.Enqueue(new SodaFlask(idCounter));
                        idCounter++;
                    }
                    break;
                case FlaskTypes.BeerFlask:
                    {
                        Buffer.buffer.Enqueue(new BeerFlask(idCounter));
                        idCounter++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
