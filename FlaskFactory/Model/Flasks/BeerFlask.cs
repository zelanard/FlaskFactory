using System.Drawing;

namespace FlaskFactory.Model.Flasks
{
    internal class BeerFlask : Flask
    {
        private Color color = Color.Green;
        public BeerFlask(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return $"this {color} Beer Flask: {ID}";
        }
    }
}