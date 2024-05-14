using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactory.Model.Flasks
{
    internal class SodaFlask : Flask
    {
        private Color color = Color.White;
        public SodaFlask(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return $"this {color} Soda Flask: {ID}";
        }
    }
}
