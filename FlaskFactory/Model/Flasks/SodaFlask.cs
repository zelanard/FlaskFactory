using System.Drawing;

namespace FlaskFactory.Model.Flasks
{
    /// <summary>
    /// Represents a soda flask which is a specific type of flask.
    /// </summary>
    internal class SodaFlask : Flask
    {
        private Color color = Color.White;

        /// <summary>
        /// Initializes a new instance of the SodaFlask class with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the flask.</param>
        public SodaFlask(int id) : base(id)
        {
        }

        /// <summary>
        /// Returns a string that represents the current SodaFlask object.
        /// </summary>
        /// <returns>A string that represents the current SodaFlask object.</returns>
        public override string ToString()
        {
            return $"this {color} Soda Flask: {ID}";
        }
    }
}
