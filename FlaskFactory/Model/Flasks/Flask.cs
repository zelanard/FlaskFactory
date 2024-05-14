using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskFactory.Model.Flasks
{
    public abstract class Flask
    {
        public int ID { get; private set; }
        
        public Flask(int id)
        {
            ID = 0;
        }

        public abstract string ToString();
    }
}
