using System.Drawing;

namespace FlaskFactory.Model.Flasks
{
    /// <summary>
    /// Represents a beer flask which is a specific type of flask designed to hold beer.
    /// </summary>
    internal class BeerFlask : Flask
    {
        private Color color = Color.Green;

        /// <summary>
        /// Initializes a new instance of the BeerFlask class with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the flask.</param>
        public BeerFlask(int id) : base(id)
        {
        }

        /// <summary>
        /// Returns a string that represents the current BeerFlask object.
        /// </summary>
        /// <returns>A string that represents the current BeerFlask object, including its color and ID.</returns>
        public override string ToString()
        {
            return $"this {color} Beer Flask: {ID}";
        }
    }
}
