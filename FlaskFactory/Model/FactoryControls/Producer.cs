using FlaskFactory.Model.Flasks;
using FlaskFactory.Utils;
using System;
using System.Linq;
using System.Threading;

namespace FlaskFactory.Model.FactoryControls
{
    /// <summary>
    /// Represents a producer in the factory that handles the creation and queuing of flasks into a buffer.
    /// </summary>
    internal class Producer : IPusher
    {
        int idCounter = 0;

        /// <summary>
        /// Gets or sets the buffer where produced flasks are stored.
        /// </summary>
        public Buffer Buffer { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Producer class with a specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer to store the produced flasks.</param>
        public Producer(Buffer buffer)
        {
            Buffer = buffer;
        }

        /// <summary>
        /// Pushes a new flask of the specified type into the buffer.
        /// </summary>
        /// <param name="flaskType">The type of flask to produce and enqueue.</param>
        public void Push(FlaskTypes flaskType)
        {
            switch (flaskType)
            {
                case FlaskTypes.SodaFlask:
                    Buffer.Enqueue(new SodaFlask(idCounter++));
                    break;
                case FlaskTypes.BeerFlask:
                    Buffer.Enqueue(new BeerFlask(idCounter++));
                    break;
                default:
                    break;
            }
        }

        public void InitPush(object obj)
        {
            int count = 0;
            while (true)
            {
                if (Buffer.Count < Buffer.MAX_SIZE)
                {
                    count++;
                    FlaskTypes[] flaskType = (FlaskTypes[])Enum.GetValues(typeof(FlaskTypes));
                    Push(flaskType[count % flaskType.Length]);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
