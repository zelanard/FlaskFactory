namespace FlaskFactory.Model.Flasks
{
    /// <summary>
    /// Abstract base class for different types of flasks.
    /// </summary>
    public abstract class Flask
    {
        /// <summary>
        /// Gets the unique identifier for the flask.
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Flask class with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the flask.</param>
        public Flask(int id)
        {
            ID = id;
        }

        /// <summary>
        /// Returns a string that represents the current flask.
        /// </summary>
        /// <returns>A string that represents the current flask.</returns>
        public abstract string ToString();
    }
}
