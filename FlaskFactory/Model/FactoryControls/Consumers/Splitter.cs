using FlaskFactory.Model.Flasks;
using FlaskFactory.Utils;
using System;

namespace FlaskFactory.Model.FactoryControls
{
    /// <summary>
    /// Represents a splitter that divides incoming flasks into different buffers based on type.
    /// </summary>
    internal class Splitter : Consumer, IPusher
    {
        Buffer BeerBuffer, SodaBuffer;

        /// <summary>
        /// Initializes a new instance of the Splitter class using a single buffer.
        /// </summary>
        /// <param name="buffer">The buffer from which flasks are to be consumed.</param>
        public Splitter(Buffer buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Splitter class with separate buffers for beer and soda.
        /// </summary>
        /// <param name="beerBuffer">The buffer for storing beer flasks.</param>
        /// <param name="sodaBuffer">The buffer for storing soda flasks.</param>
        /// <param name="productionBuffer">The main production buffer.</param>
        public Splitter(Buffer beerBuffer, Buffer sodaBuffer, Buffer productionBuffer) : base(productionBuffer)
        {
            BeerBuffer = beerBuffer;
            SodaBuffer = sodaBuffer;
        }

        /// <summary>
        /// Distributes a flask based on its type to the appropriate buffer.
        /// </summary>
        /// <param name="flaskType">The type of flask to distribute.</param>
        public void Push(FlaskTypes flaskType)
        {
            switch (CurrentFlask)
            {
                case BeerFlask beerFlask:
                    BeerBuffer.Enqueue(CurrentFlask);
                    break;
                case SodaFlask sodaFlask:
                    SodaBuffer.Enqueue(CurrentFlask);
                    break;
                default:
                    throw new InvalidOperationException("Unknown flask type.");
            }
        }

        public void InitSplitter(object obj)
        {
            while (true)
            {
                if (Buffer.Count > 0 && CurrentFlask == null)
                {
                    Pull();
                }

                if (CurrentFlask != null && Buffer.Count > 0)
                {
                    Push(CurrentFlask.GetFlaskType());
                    CurrentFlask = null;
                }
            }
        }
    }
}
