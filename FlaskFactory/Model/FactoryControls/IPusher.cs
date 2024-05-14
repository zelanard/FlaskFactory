using FlaskFactory.Utils;

namespace FlaskFactory.Model.FactoryControls
{
    /// <summary>
    /// Defines the functionality for an object that can push flasks into a buffer or processing line.
    /// </summary>
    public interface IPusher
    {
        /// <summary>
        /// Pushes a flask of the specified type into the designated buffer or production line.
        /// </summary>
        /// <param name="flaskType">The type of flask to be pushed.</param>
        void Push(FlaskTypes flaskType);
    }
}
