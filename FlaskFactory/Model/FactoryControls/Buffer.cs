using FlaskFactory.Model.Flasks;
using System.Collections.Generic;

namespace FlaskFactory.Model.FactoryControls
{
    /// <summary>
    /// Represents a buffer that holds a collection of flasks temporarily during production.
    /// </summary>
    public class Buffer
    {
        /// <summary>
        /// The maximum number of flasks that the buffer can hold.
        /// </summary>
        public const int MAX_SIZE = 100;

        /// <summary>
        /// A queue to store the flasks in the order they were added.
        /// </summary>
        public Queue<Flask> buffer;

        /// <summary>
        /// Initializes a new instance of the Buffer class.
        /// </summary>
        public Buffer()
        {
            buffer = new Queue<Flask>();
        }
    }
}
